using IBKS_2._0.Utils;
using PLC.Sharp7;

namespace IBKS_2._0.Forms.Pages
{
    public partial class HomePage : Form
    {
        readonly Sharp7Service _sharp7Service = Sharp7Service.Instance;

        private DateTime _lastMinute = new();

        public HomePage()
        {
            InitializeComponent();
        }

        private void TimerPlcRead_Tick(object sender, EventArgs e)
        {
            if (_lastMinute.Minute != DateTime.Now.Minute)
            {
                _lastMinute = DateTime.Now;

                //TODO
            }

            AssignAnalogSensors();
            AssignDigitalSensors();

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
    }
}