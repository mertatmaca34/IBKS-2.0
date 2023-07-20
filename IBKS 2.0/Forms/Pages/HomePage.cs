using API.Abstract;
using API.Models;
using Business.Abstract;
using Business.Helpers;
using Core.Utilities.Results;
using IBKS_2._0.Properties;
using IBKS_2._0.Utils;
using Newtonsoft.Json;
using PLC;
using PLC.Sharp7;

namespace IBKS_2._0.Forms.Pages
{
    public partial class HomePage : Form
    {
        readonly Sharp7Service _sharp7Service = Sharp7Service.Instance;

        readonly IStationService _stationManager;
        readonly IApiConnection _apiConnection;
        readonly ISendDataService _sendDataManager;

        public HomePage(IStationService stationManager, IApiConnection apiConnection, ISendDataService sendDataManager)
        {
            _stationManager = stationManager;
            _apiConnection = apiConnection;
            _sendDataManager = sendDataManager;

            _apiConnection.Login("istanbul_pasakoy", "1q2w3e");

            InitializeComponent();
        }

        private void TimerPlcRead_Tick(object sender, EventArgs e)
        {
            AssignAnalogSensors();
            AssignDigitalSensors();
            AssignStatusBar();
            AssignAnalogSensorStatements();
            AssignAverageOfLast60Minutes();
            AssignStationInfoControl(SendDataHelper.SendData(_sendDataManager,_stationManager, _apiConnection));
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

            ChannelAkm.AvgDataOf60Min = data.Akm.ToString();
            ChannelCozunmusOksijen.AvgDataOf60Min = data.CozunmusOksijen.ToString();
            ChannelSicaklik.AvgDataOf60Min = data.KabinSicaklik.ToString();
            ChannelPh.AvgDataOf60Min = data.Ph.ToString();
            ChannelIletkenlik.AvgDataOf60Min = data.Iletkenlik.ToString();
            ChannelKoi.AvgDataOf60Min = data.Koi.ToString();
            ChannelAkisHizi.AvgDataOf60Min = data.NumuneHiz.ToString();
            ChannelDebi.AvgDataOf60Min = data.TesisDebi.ToString();
        }

        private void AssignStationInfoControl(IDataResult<DeserializeResult> deserializeResult)
        {
            if(deserializeResult.Success)
            {
                if(deserializeResult.Data.AKM_N_Status == 1)
                {
                    StationInfoControl.LastWashAkmImage = Resources.Checkmark_12px;
                }
                else if(deserializeResult.Data.AKM_N_Status == 201)
                {
                    StationInfoControl.LastWashAkmImage = Resources.cancel;
                }
            }
        }
    }
}