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

        public HomePage(IDB41Service dB41Manager, IStationService stationManager, IApiService apiManager, IApiConnection apiConnection)
        {
            _dB41Manager = dB41Manager;
            _stationManager = stationManager;
            _apiManager = apiManager;
            _apiConnection = apiConnection;

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

                MessageBox.Show(res.message);
            }

            AssignAnalogSensors();
            AssignDigitalSensors();
            AssignStatusBar();

            AssignAnalogSensorStatements();
        }

        private void AssignAnalogSensors()
        {
            ChannelAkm.InstantData = _sharp7Service.S71200.DB41.Akm.ToString();
            ChannelCozunmusOksijen.InstantData = _sharp7Service.S71200.DB41.CozunmusOksijen.ToString();
            ChannelSicaklik.InstantData = _sharp7Service.S71200.DB41.KabinSicaklik.ToString();
            ChannelPh.InstantData = _sharp7Service.S71200.DB41.Ph.ToString();
            ChannelIletkenlik.InstantData = _sharp7Service.S71200.DB41.Iletkenlik.ToString();
            ChannelKoi.InstantData = _sharp7Service.S71200.DB41.Koi.ToString();
            ChannelAkisHizi.InstantData = _sharp7Service.S71200.DB41.NumuneHiz.ToString();
            ChannelDebi.InstantData = _sharp7Service.S71200.DB41.TesisDebi.ToString();
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
    }
}