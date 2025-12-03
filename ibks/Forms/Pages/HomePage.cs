using AutoMapper;
using Business.Abstract;
using Business.Helpers;
using Core.Utilities.TempLogs;
using Entities.Concrete;
using Entities.Concrete.API;
using ibks.Services.Mail.Abstract;
using ibks.Utils;
using PLC;
using PLC.Sharp7.Helpers;
using PLC.Sharp7.Services;
using Serilog;
using Serilog.Events;
using System.ComponentModel;
using WebAPI.Abstract;
using WebAPI.Infrastructure.RemoteApi;

namespace ibks.Forms.Pages
{
    public partial class HomePage : Form
    {
        bool isBusy = false;

        private readonly Sharp7Service _sharp7Service = Sharp7Service.Instance;

        private readonly IMapper _mapper;
        private readonly IStationService _stationManager;
        private readonly ISendDataService _sendDataManager;
        private readonly ICalibrationService _calibrationManager;
        private readonly ICheckStatements _checkStatements;
        private readonly IGetMissingDatesController _getMissingDatesController;
        private readonly IRemoteApiClient _remoteApiClient;

        public HomePage(IStationService stationManager, ISendDataService sendDataManager,
            ICalibrationService calibrationManager, 
            ICheckStatements checkStatements, IGetMissingDatesController getMissingDatesController,
            IRemoteApiClient remoteApiClient, IMapper mapper)
        {
            InitializeComponent();

            _mapper = mapper;
            _remoteApiClient = remoteApiClient;
            _stationManager = stationManager;
            _sendDataManager = sendDataManager;
            _calibrationManager = calibrationManager;
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
                AssignSystemStatement();
                SendDataAndAssignStationInfoControl();
            }; bgw.RunWorkerAsync();

            GC.Collect();

            await _checkStatements.Check();
        }

        private async void SendDataAndAssignStationInfoControl()
        {
            var data = DataProcessingHelper.MergedSendData(_stationManager);

            if (data.Success)
            {
                if (SendDataHelper.IsItTime(data.Data.Readtime).Success)
                {
                    var res = await _remoteApiClient.SendData(data.Data);

                    if (res.message == "Bu saatin datası daha önce kayıt edilmiştir.")
                    {
                        data.Data.IsSent = true;
                    }
                    else
                    {
                        data.Data.IsSent = res.result;
                    }

                    StaticInstantData.Assign(res.objects);

                    AssignStationInfoControl(res);

                    Log.Write(LogEventLevel.Information,$"{data.Data.Readtime}: {res.message}");

                    _sendDataManager.Add(data.Data);
                }
            }
        }

        private void AssignAnalogSensors()
        {
            ChannelAkm.InstantData = _sharp7Service.S71200.DB41.Akm + " mg/l";
            ChannelCozunmusOksijen.InstantData = _sharp7Service.S71200.DB41.CozunmusOksijen + " mg/l";
            ChannelSicaklik.InstantData = _sharp7Service.S71200.DB41.KabinSicaklik + "°C";
            ChannelPh.InstantData = _sharp7Service.S71200.DB41.Ph.ToString();
            ChannelIletkenlik.InstantData = _sharp7Service.S71200.DB41.Iletkenlik + " µS/cm";
            ChannelKoi.InstantData = _sharp7Service.S71200.DB41.Koi + " mg/l";
            ChannelAkisHizi.InstantData = _sharp7Service.S71200.DB41.NumuneHiz + " m³/d";
            ChannelDebi.InstantData = _sharp7Service.S71200.DB41.TesisDebi + " m/s";
        }

        private void AssignAnalogSensorStatements()
        {
            ChannelAkm.ChannelStatement = ColorExtensions.FromDouble(_sharp7Service.S71200.DB41.Akm);
            ChannelCozunmusOksijen.ChannelStatement = ColorExtensions.FromDouble(_sharp7Service.S71200.DB41.CozunmusOksijen);
            ChannelSicaklik.ChannelStatement = ColorExtensions.FromDouble(_sharp7Service.S71200.DB41.KabinSicaklik);
            ChannelPh.ChannelStatement = ColorExtensions.FromDouble(_sharp7Service.S71200.DB41.Ph);
            ChannelIletkenlik.ChannelStatement = ColorExtensions.FromDouble(_sharp7Service.S71200.DB41.Iletkenlik);
            ChannelKoi.ChannelStatement = ColorExtensions.FromDouble(_sharp7Service.S71200.DB41.Koi);
            ChannelAkisHizi.ChannelStatement = ColorExtensions.FromDouble(_sharp7Service.S71200.DB41.NumuneHiz);
            ChannelDebi.ChannelStatement = ColorExtensions.FromDouble(_sharp7Service.S71200.DB41.TesisDebi);
        }

        private void AssignDigitalSensors()
        {
            DigitalSensorKapi.SensorStatement = ColorExtensions.FromBoolean(_sharp7Service.S71200.DB42.Kabin_KapiAcildi);
            DigitalSensorDuman.SensorStatement = ColorExtensions.FromBoolean(_sharp7Service.S71200.DB42.Kabin_Duman);
            DigitalSensorSuBaskini.SensorStatement = ColorExtensions.FromBoolean(_sharp7Service.S71200.DB42.Kabin_SuBaskini);
            DigitalSensorAcilStop.SensorStatement = ColorExtensions.FromBoolean(_sharp7Service.S71200.DB42.Kabin_AcilStopBasili);
            DigitalSensorPompa1Termik.SensorStatement = ColorExtensions.FromBoolean(_sharp7Service.S71200.DB42.Pompa1Termik);
            DigitalSensorPompa2Termik.SensorStatement = ColorExtensions.FromBoolean(_sharp7Service.S71200.DB42.Pompa2Termik);
            DigitalSensorTSuPompaTermik.SensorStatement = ColorExtensions.FromBoolean(_sharp7Service.S71200.DB42.Pompa3Termik);
            DigitalSensorYikamaTanki.SensorStatement = ColorExtensions.FromBoolean(_sharp7Service.S71200.DB42.TankDolu);
            DigitalSensorEnerji.SensorStatement = ColorExtensions.FromBoolean(_sharp7Service.S71200.DB42.Kabin_EnerjiYok);
        }

        private void AssignStatusBar()
        {
            StatusBarControl.ConnectionStatement = "Bağlantı Durumu: " + RealTimeCalculations.ConnectionStatus();
            StatusBarControl.ConnectionTime = "Bağlantı Zamanı: " + _sharp7Service.ConnectionTime;
            StatusBarControl.GunlukYikamaKalan = $"Günlük Yıkamaya Kalan: {_sharp7Service.DailyWashRemaining}";
            StatusBarControl.HaftalikYikamaKalan = $"Haftalık Yıkamaya Kalan: {_sharp7Service.WeeklyWashRemaining}";
            StatusBarControl.SistemSaati = "Sistem Saati: " + _sharp7Service.S71200.DB43.SystemTime;
        }

        private void AssignAverageOfLast60Minutes()
        {
            var data = ValueAvarages.Last60MinAvg(_sendDataManager);

            if (data != null && data.Data != null)
            {
                ChannelAkm.AvgDataOf60Min = data.Data.Akm.ToString();
                ChannelCozunmusOksijen.AvgDataOf60Min = data.Data.CozunmusOksijen.ToString();
                ChannelSicaklik.AvgDataOf60Min = data.Data.KabinSicaklik.ToString();
                ChannelPh.AvgDataOf60Min = data.Data.Ph.ToString();
                ChannelIletkenlik.AvgDataOf60Min = data.Data.Iletkenlik.ToString();
                ChannelKoi.AvgDataOf60Min = data.Data.Koi.ToString();
                ChannelAkisHizi.AvgDataOf60Min = data.Data.NumuneHiz.ToString();
                ChannelDebi.AvgDataOf60Min = data.Data.TesisDebi.ToString();
            }
        }

        private void AssignStationInfoControl(ResultStatus<SendDataResult> deserializedResult)
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
                ResendMissingDates();
            }
            catch (Exception ex)
            {
                Log.Write(LogEventLevel.Information, $"{DateTime.Now}: [TimerGetMissingDates_Tick] {ex}");
            }
        }

        private async void ResendMissingDates(CancellationToken ct = default)
        {
            if (isBusy) return;

            isBusy = true;

            var stationResult = _stationManager.Get();

            if (!stationResult.Success)
            {
                isBusy = false;
                return;
            }

            var missingDatesResult = await _getMissingDatesController.GetMissingDates(stationResult.Data.StationId);

            if (!missingDatesResult.Success || missingDatesResult.Data?.objects == null)
            {
                return;
            }

            if (missingDatesResult?.Data.objects.MissingDates == null || missingDatesResult?.Data.objects.MissingDates.Count == 0)
            {
                return;
            }

            var allMissingDates = missingDatesResult?.Data.objects.MissingDates;

            var dtStart = allMissingDates!.Min();
            var dtMax = allMissingDates!.Max();

            var unsentDataRange = _sendDataManager
            .GetAll(x => x.Readtime > dtStart && x.Readtime < dtMax)
            .Data;

            var lookup = unsentDataRange
                .GroupBy(x => new DateTime(
                    x.Readtime.Year,
                    x.Readtime.Month,
                    x.Readtime.Day,
                    x.Readtime.Hour,
                    x.Readtime.Minute,
                    0))
                .ToDictionary(g => g.Key, g => g.First());

            foreach (var missingDate in allMissingDates)
            {
                var key = new DateTime(
                    missingDate.Year,
                    missingDate.Month,
                    missingDate.Day,
                    missingDate.Hour,
                    missingDate.Minute,
                    0);

                if (lookup.TryGetValue(key, out var sendData))
                {
                    var res = await _remoteApiClient.SendData(sendData, ct);

                    if (res != null && res.result)
                    {
                        var mappedRes = _mapper.Map<SendData>(res.objects);

                        mappedRes.IsSent = res.result;

                        _sendDataManager.Update(mappedRes);

                        Log.Write(LogEventLevel.Information, $"{sendData.Readtime} {res.message}");
                    }
                    else
                    {
                        Log.Write(LogEventLevel.Information, $"{sendData.Readtime} gönderilemedi: {res?.message}");
                    }
                }
            }

            isBusy = false;
        }
    }
}