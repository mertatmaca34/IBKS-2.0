using Business.Abstract;
using Business.Helpers;
using Core.Utilities.Results;
using Core.Utilities.TempLogs;
using Entities.Concrete;
using Entities.Concrete.API;
using ibks.Services.Mail.Abstract;
using ibks.Utils;
using PLC;
using PLC.Sharp7.Helpers;
using PLC.Sharp7.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ibks.Forms.Pages
{
    public partial class HomePage : Form
    {
        private readonly Sharp7Service _sharp7Service = Sharp7Service.Instance;

        private readonly IStationService _stationManager;
        private readonly ISendDataService _sendDataManager;
        private readonly ICalibrationService _calibrationManager;
        private readonly ISendDataController _sendDataController;
        private readonly ICheckStatements _checkStatements;
        private readonly IGetMissingDatesController _getMissingDatesController;

        private readonly CancellationTokenSource _backgroundWorkCts = new();
        private readonly object _backgroundWorkSync = new();
        private Task _missingDateResendTask = Task.CompletedTask;
        private Task _unsentDataResendTask = Task.CompletedTask;

        private const int SendDataBatchSize = 500;
        private const int MissingDateQueryBatchSize = 250;
        private const int UnsentDataQueryBatchSize = 2000;
        private static readonly TimeSpan SendDataBatchPause = TimeSpan.FromMilliseconds(200);

        public HomePage(IStationService stationManager, ISendDataService sendDataManager,
            ICalibrationService calibrationManager, ISendDataController sendDataController,
            ICheckStatements checkStatements, IGetMissingDatesController getMissingDatesController)
        {
            InitializeComponent();

            _stationManager = stationManager;
            _sendDataManager = sendDataManager;
            _calibrationManager = calibrationManager;
            _sendDataController = sendDataController;
            _checkStatements = checkStatements;
            _getMissingDatesController = getMissingDatesController;
        }

        private async void TimerAssignUI_Tick(object sender, EventArgs e)
        {
            var bgw = new BackgroundWorker();
            bgw.DoWork += delegate
            {
                AssignAnalogSensors();
                AssignDigitalSensors();
                AssignStatusBar();
                AssignAnalogSensorStatements();
                AssignAverageOfLast60Minutes();
@@ -180,200 +180,282 @@ namespace ibks.Forms.Pages
            }
        }

        private void AssignStationInfoControl(IDataResult<ResultStatus<SendDataResult>> deserializedResult)
        {
            StationInfoStatements.AssignLastWashStatements(deserializedResult, _sendDataManager, StationInfoControl);
            StationInfoStatements.AssignCalibrationImage(deserializedResult, StationInfoControl);
            StationInfoStatements.AssignLastWashWeekStatements(deserializedResult, _sendDataManager, StationInfoControl);

            StationInfoControl.PhCalibration = StationInfoStatements.AssignCalibrationStatements(_calibrationManager, "Ph");
            StationInfoControl.IletkenlikCalibration = StationInfoStatements.AssignCalibrationStatements(_calibrationManager, "Iletkenlik");
        }

        private void AssignSystemStatement()
        {
            DigitalSensorBar.SystemStatementColor = ColorExtensions.FromStatus();
            DigitalSensorBar.SystemStatementDescriptionTextColor = ColorExtensions.FromStatusText();
            DigitalSensorBar.SystemStatementTitleTextColor = ColorExtensions.FromStatusText();
            DigitalSensorBar.SystemStatementText = TextExtensions.FromStatus();
        }

        private void TimerGetMissingDates_Tick(object sender, EventArgs e)
        {
            try
            {
                ScheduleBackgroundWork(ref _missingDateResendTask, ResendMissingDatesAsync, nameof(ResendMissingDatesAsync));
                ScheduleBackgroundWork(ref _unsentDataResendTask, ResendUnsentDataAsync, nameof(ResendUnsentDataAsync));
            }
            catch (Exception ex)
            {
                TempLog.Write($"{DateTime.Now}: [TimerGetMissingDates_Tick] {ex}");
            }
        }

        private async Task ResendMissingDatesAsync(CancellationToken cancellationToken)
        {
            var stationResult = _stationManager.Get();

            if (stationResult?.Data == null)
            {
                return;
            }

            var missingDatesResult = await _getMissingDatesController.GetMissingDates(stationResult.Data.StationId);

            if (!missingDatesResult.Success || missingDatesResult.Data?.objects?.MissingDates == null ||
                missingDatesResult.Data.objects.MissingDates.Count == 0)
            {
                return;
            }

            var orderedMissingDates = missingDatesResult.Data.objects.MissingDates
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            foreach (var chunk in Chunk(orderedMissingDates, MissingDateQueryBatchSize))
            {
                cancellationToken.ThrowIfCancellationRequested();

                if (chunk.Count == 0)
                {
                    continue;
                }

                List<SendData> latestRecords;

                try
                {
                    latestRecords = LoadLatestRecordsForReadTimes(stationResult.Data.StationId, chunk);
                }
                catch (Exception ex)
                {
                    TempLog.Write($"{DateTime.Now}: [ResendMissingDatesAsync] {ex}");
                    break;
                }

                if (latestRecords.Count == 0)
                {
                    continue;
                }

                await ProcessSendDataAsync(latestRecords, cancellationToken);
            }
        }

        private async Task ResendUnsentDataAsync(CancellationToken cancellationToken)
        {
            var lastProcessedId = 0;

            while (true)
            {
                cancellationToken.ThrowIfCancellationRequested();

                List<SendData> unsentBatch;

                try
                {
                    unsentBatch = _sendDataManager.GetUnsentBatch(UnsentDataQueryBatchSize, lastProcessedId);
                }
                catch (Exception ex)
                {
                    TempLog.Write($"{DateTime.Now}: [ResendUnsentDataAsync] {ex}");
                    break;
                }

                if (unsentBatch == null || unsentBatch.Count == 0)
                {
                    break;
                }

                var orderedBatch = unsentBatch
                    .OrderBy(x => x.Readtime)
                    .ToList();

                await ProcessSendDataAsync(orderedBatch, cancellationToken);

                lastProcessedId = Math.Max(lastProcessedId, unsentBatch.Max(x => x.Id));
            }
        }

        private List<SendData> LoadLatestRecordsForReadTimes(Guid stationId, IReadOnlyCollection<DateTime> readTimes)
        {
            if (readTimes == null || readTimes.Count == 0)
            {
                return new List<SendData>();
            }

            var minReadTime = readTimes.Min();
            var maxReadTime = readTimes.Max();

            var storedDataResult = _sendDataManager.GetAll(x =>
                x.Stationid == stationId && x.Readtime >= minReadTime && x.Readtime <= maxReadTime);

            if (storedDataResult?.Data == null || storedDataResult.Data.Count == 0)
            {
                return new List<SendData>();
            }

            var readTimeSet = new HashSet<DateTime>(readTimes);

            return storedDataResult.Data
                .Where(x => readTimeSet.Contains(x.Readtime))
                .GroupBy(x => x.Readtime)
                .Select(group => group.OrderByDescending(x => x.Id).First())
                .OrderBy(x => x.Readtime)
                .ToList();
        }

        private async Task ProcessSendDataAsync(IEnumerable<SendData> dataToSend, CancellationToken cancellationToken)
        {
            if (dataToSend == null)
            {
                return;
            }

            var batch = new List<SendData>(SendDataBatchSize);

            foreach (var item in dataToSend)
            {
                cancellationToken.ThrowIfCancellationRequested();

                if (item == null)
                {
                    continue;
                }

                batch.Add(item);

                if (batch.Count >= SendDataBatchSize)
                {
                    await SendBatchAsync(batch, cancellationToken);
                    batch.Clear();

                    if (SendDataBatchPause > TimeSpan.Zero)
                    {
                        await Task.Delay(SendDataBatchPause, cancellationToken);
                    }
                }
            }

            if (batch.Count > 0)
            {
                await SendBatchAsync(batch, cancellationToken);
            }
        }

        private async Task SendBatchAsync(List<SendData> batch, CancellationToken cancellationToken)
        {
            foreach (var sendData in batch)
            {
                cancellationToken.ThrowIfCancellationRequested();

                try
                {
                    var response = await _sendDataController.SendData(sendData);
                    sendData.IsSent = response.Success;

                    if (!response.Success)
                    {
                        TempLog.Write($"{DateTime.Now}: [SendBatchAsync] Veri gönderimi başarısız: {sendData.Readtime}");
                    }
                }
                catch (Exception ex)
                {
                    sendData.IsSent = false;
                    TempLog.Write($"{DateTime.Now}: [SendBatchAsync] {ex}");
                }
                finally
                {
                    _sendDataManager.Update(sendData);
                }
            }
        }

        private static IEnumerable<List<T>> Chunk<T>(IEnumerable<T> source, int size)
        {
            if (source == null || size <= 0)
            {
                yield break;
            }

            var buffer = new List<T>(size);

            foreach (var item in source)
            {
                buffer.Add(item);

                if (buffer.Count == size)
                {
                    yield return buffer;
                    buffer = new List<T>(size);
                }
            }

            if (buffer.Count > 0)
            {
                yield return buffer;
            }
        }

        private void ScheduleBackgroundWork(ref Task backgroundTask, Func<CancellationToken, Task> work, string context)
        {
            lock (_backgroundWorkSync)
            {
                if (!backgroundTask.IsCompleted)
                {
                    return;
                }

                var cancellationToken = _backgroundWorkCts.Token;

                backgroundTask = Task.Run(async () =>
                {
                    try
                    {
                        await work(cancellationToken);
                    }
                    catch (OperationCanceledException)
                    {
                    }
                    catch (Exception ex)
                    {
                        TempLog.Write($"{DateTime.Now}: [{context}] {ex}");
                    }
                }, cancellationToken);
            }
        }

        private void ChannelAkm_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _backgroundWorkCts.Cancel();

            base.OnFormClosing(e);
        }
    }
}