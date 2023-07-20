using API.Abstract;
using Business.Abstract;
using Business.Concrete;
using IBKS_2._0.Utils;
using PLC;
using PLC.Sharp7;

namespace IBKS_2._0.Forms.Pages
{
    public partial class HomePage : Form
    {
        readonly Sharp7Service _sharp7Service = Sharp7Service.Instance;

        private DateTime _lastMinute = new();

        readonly IDB41Service _dB41Manager;
        readonly IStationService _stationManager;
        readonly IApiService _apiManager;
        readonly IApiConnection _apiConnection;
        readonly ISendDataService _sendDataManager;

        public HomePage(IDB41Service dB41Manager, IStationService stationManager, IApiService apiManager, IApiConnection apiConnection, ISendDataService sendDataManager)
        {
            _dB41Manager = dB41Manager;
            _stationManager = stationManager;
            _apiManager = apiManager;
            _apiConnection = apiConnection;
            _sendDataManager = sendDataManager;

            _apiConnection.Login("istanbul_pasakoy", "1q2w3e");

            InitializeComponent();
        }

        private void TimerPlcRead_Tick(object sender, EventArgs e)
        {
            if (_lastMinute.Minute != DateTime.Now.Minute)
            {
                _lastMinute = DateTime.Now;

                _dB41Manager.Add(_sharp7Service.S71200.DB41);

                var mergedData = DataProcessingService.MergedSendData(_stationManager);

                var res = _apiConnection.SendData(mergedData);

                _sendDataManager.Add(mergedData);
            }

            AssignAnalogSensors();
            AssignDigitalSensors();
            AssignStatusBar();
            AssignAnalogSensorStatements();
            AssignAverageOfLast60Minutes();
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
            var data = _sendDataManager.GetLast60Minutes();

            ChannelAkm.AvgDataOf60Min = data.Data.Average(d => d.AKM).ToString();
            ChannelCozunmusOksijen.AvgDataOf60Min = data.Data.Average(d => d.CozunmusOksijen).ToString();
            ChannelSicaklik.AvgDataOf60Min = data.Data.Average(d => d.Sicaklik).ToString();
            ChannelPh.AvgDataOf60Min = data.Data.Average(d => d.pH).ToString();
            ChannelIletkenlik.AvgDataOf60Min = data.Data.Average(d => d.Iletkenlik).ToString();
            ChannelKoi.AvgDataOf60Min = data.Data.Average(d => d.KOi).ToString();
            ChannelAkisHizi.AvgDataOf60Min = data.Data.Average(d => d.AkisHizi).ToString();
            ChannelDebi.AvgDataOf60Min = data.Data.Average(d => d.Debi).ToString();
        }
    }
}