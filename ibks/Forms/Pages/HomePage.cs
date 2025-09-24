using Business.Abstract;
using Business.Helpers;
using Core.Utilities.Results;
using Entities.Concrete.API;
using ibks.Services.Mail.Abstract;
using ibks.Utils;
using System;
using Newtonsoft.Json;
using PLC;
using PLC.Sharp7.Helpers;
using PLC.Sharp7.Services;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Abstract;
using Core.Utilities.TempLogs;

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
                AssignSystemStatement();
                SendDataAndAssignStationInfoControl();
            }; bgw.RunWorkerAsync();

            GC.Collect();

            await _checkStatements.Check();
        }

        private async void SendDataAndAssignStationInfoControl()
        {
            try
            {
                var data = DataProcessingHelper.MergedSendData(_stationManager);

                if (data.Success)
                {
                    if (SendDataHelper.IsItTime(data.Data.Readtime).Success)
                    {
                        var res = await _sendDataController.SendData(data.Data);

                        if (res.Success && res.Data != null && res.Data.objects != null)
                        {
                            if (res.Message == "zaten kayıtlı")
                            {
                                data.Data.IsSent = true;
                            }
                            data.Data.IsSent = true;

                            StaticInstantData.Assign(res.Data.objects);

                            AssignStationInfoControl(res);
                        }
                        else
                        {
                            data.Data!.IsSent = false;
                        }

                        _sendDataManager.Add(data.Data);
                    }
                }
            }
            catch (Exception ex)
            {
                TempLog.Write($"{DateTime.Now}: [SendDataAndAssignStationInfoControl] {ex}");
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

        private async void TimerGetMissingDates_Tick(object sender, EventArgs e)
        {
            try
            {
                await ResendMissingDatesAsync();
                await ResendUnsentDataAsync();
            }
            catch (Exception ex)
            {
                TempLog.Write($"{DateTime.Now}: [TimerGetMissingDates_Tick] {ex}");
            }
        }

        private async Task ResendMissingDatesAsync()
        {
            var stationResult = _stationManager.Get();

            if (stationResult?.Data == null)
            {
                return;
            }

            var missingDatesResult = await _getMissingDatesController.GetMissingDates(stationResult.Data.StationId);

            if (!missingDatesResult.Success || missingDatesResult.Data?.objects == null)
            {
                return;
            }

            var serializedObject = JsonConvert.SerializeObject(missingDatesResult.Data.objects);
            var missingDatePayload = JsonConvert.DeserializeObject<MissingDate>(serializedObject);

            if (missingDatePayload?.MissingDates == null || !missingDatePayload.MissingDates.Any())
            {
                return;
            }

            foreach (var missingDate in missingDatePayload.MissingDates)
            {
                var storedData = _sendDataManager
                    .GetAll(x => x.Stationid == stationResult.Data.StationId && x.Readtime == missingDate)
                    .Data?
                    .OrderByDescending(x => x.Id)
                    .FirstOrDefault();

                if (storedData == null)
                {
                    continue;
                }

                var response = await _sendDataController.SendData(storedData);

                storedData.IsSent = response.Success;

                _sendDataManager.Add(storedData);
            }
        }

        private async Task ResendUnsentDataAsync()
        {
            var missedData = _sendDataManager.GetAll(x => x.IsSent == false);

            if (missedData?.Data == null || !missedData.Data.Any())
            {
                return;
            }

            foreach (var item in missedData.Data)
            {
                var res = await _sendDataController.SendData(item);

                item.IsSent = res.Success;

                _sendDataManager.Add(item);
            }
        }

        private void ChannelAkm_Load(object sender, EventArgs e)
        {

        }
    }
}