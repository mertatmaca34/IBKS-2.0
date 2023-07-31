using Business.Abstract;
using Business.Helpers;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Concrete.API;
using IBKS_2._0.Utils;
using Newtonsoft.Json;
using PLC;
using PLC.Sharp7;
using System.ComponentModel;
using WebAPI.Controllers;

namespace IBKS_2._0.Forms.Pages
{
    public partial class HomePage : Form
    {
        readonly Sharp7Service _sharp7Service = Sharp7Service.Instance;

        readonly IStationService _stationManager;
        //readonly IApiConnection _apiConnection;
        readonly ISendDataService _sendDataManager;
        readonly ICalibrationService _calibrationManager;

        Task<ResultStatus<LoginResult>> _loginTask;
        public HomePage(IStationService stationManager, /*IApiConnection apiConnection,*/ ISendDataService sendDataManager, ICalibrationService calibrationManager)
        {
            _stationManager = stationManager;
            //_apiConnection = apiConnection;
            _sendDataManager = sendDataManager;
            _calibrationManager = calibrationManager;

            //_apiConnection.Login("istanbul_pasakoy", "1q2w3e");

            _loginTask = new LoginController().Login("istanbul_pasakoy", "1q2w3e");

            InitializeComponent();
        }

        private void TimerPlcRead_Tick(object sender, EventArgs e)
        {
            var bgw = new BackgroundWorker();
            bgw.DoWork += delegate
            {
                if (_loginTask.IsCompleted)
                {
                    MessageBox.Show(_loginTask.Result.objects.TicketId.ToString());
                    //MessageBox.Show(_loginTask.Result.message);

                    /*Guid? ticketId = _loginTask.Result.TicketId;
                    MessageBox.Show(ticketId.ToString());*/
                }
                
                AssignAnalogSensors();
                AssignDigitalSensors();
                AssignStatusBar();
                AssignAnalogSensorStatements();
                AssignAverageOfLast60Minutes();
                AssignSystemStatement();
                AssignStationInfoControl(SendDataHelper.SendData(_sendDataManager, _stationManager));

            }; bgw.RunWorkerAsync();
        }

        private void AssignAnalogSensors()
        {
            ChannelAkm.InstantData = _sharp7Service.S71200.DB41.Akm + " mg/l";
            ChannelCozunmusOksijen.InstantData = _sharp7Service.S71200.DB41.CozunmusOksijen + " mg/l";
            ChannelSicaklik.InstantData = _sharp7Service.S71200.DB41.KabinSicaklik + "°C";
            ChannelPh.InstantData = _sharp7Service.S71200.DB41.Ph.ToString();
            ChannelIletkenlik.InstantData = _sharp7Service.S71200.DB41.Iletkenlik + " mS/cm";
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
            DigitalSensorKapi.SensorStatement = ColorExtensions.FromBoolean(_sharp7Service.S71200.InputTags.Kapi);
            DigitalSensorDuman.SensorStatement = ColorExtensions.FromBoolean(_sharp7Service.S71200.InputTags.Duman);
            DigitalSensorSuBaskini.SensorStatement = ColorExtensions.FromBoolean(_sharp7Service.S71200.InputTags.SuBaskini);
            DigitalSensorAcilStop.SensorStatement = ColorExtensions.FromBoolean(_sharp7Service.S71200.InputTags.AcilStop);
            DigitalSensorPompa1Termik.SensorStatement = ColorExtensions.FromBoolean(_sharp7Service.S71200.InputTags.Pompa1Termik);
            DigitalSensorPompa2Termik.SensorStatement = ColorExtensions.FromBoolean(_sharp7Service.S71200.InputTags.Pompa2Termik);
            DigitalSensorTSuPompaTermik.SensorStatement = ColorExtensions.FromBoolean(_sharp7Service.S71200.InputTags.TemizSuTermik);
            DigitalSensorYikamaTanki.SensorStatement = ColorExtensions.FromBoolean(_sharp7Service.S71200.InputTags.YikamaTanki);
            DigitalSensorEnerji.SensorStatement = ColorExtensions.FromBoolean(_sharp7Service.S71200.InputTags.Enerji);
        }

        private void AssignStatusBar()
        {
            StatusBarControl.ConnectionStatement = "Bağlantı Durumu: " + RealTimeCalculations.ConnectionStatus();
            StatusBarControl.ConnectionTime = "Bağlantı Zamanı: " + _sharp7Service.ConnectionTime.ToString();
            StatusBarControl.GunlukYikamaKalan = "Günlük Yıkamaya Kalan: " + RealTimeCalculations.GunlukYikamayaKalan();
            StatusBarControl.HaftalikYikamaKalan = "Haftalık Yıkamaya Kalan: " + RealTimeCalculations.HaftalikYikamayaKalan();
            StatusBarControl.SistemSaati = "Sistem Saati: " + _sharp7Service.S71200.DB4.SystemTime.ToString();
        }

        private void AssignAverageOfLast60Minutes()
        {
            var data = ValueAvarages.Last60MinAvg(_sendDataManager);

            if (data != null)
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

        private void AssignStationInfoControl(IDataResult<DeserializeResult> deserializedResult)
        {
            StationInfoStatements.AssignLastWashStatements(deserializedResult, _sendDataManager, StationInfoControl);
            StationInfoStatements.AssignLastWashWeekStatements(deserializedResult, _sendDataManager, StationInfoControl);
            StationInfoControl.PhCalibration = StationInfoStatements.AssignCalibrationStatements(_calibrationManager, "Ph");
            StationInfoControl.IletkenlikCalibration = StationInfoStatements.AssignCalibrationStatements(_calibrationManager, "Iletkenlik");
            StationInfoStatements.AssignCalibrationImage(deserializedResult, StationInfoControl);
        }

        private void AssignSystemStatement()
        {
            DigitalSensorBar.SystemStatementColor = ColorExtensions.FromStatus();
            DigitalSensorBar.SystemStatementDescriptionTextColor = ColorExtensions.FromStatusText();
            DigitalSensorBar.SystemStatementTitleTextColor = ColorExtensions.FromStatusText();
            DigitalSensorBar.SystemStatementText = TextExtensions.FromStatus();
        }
    }
}