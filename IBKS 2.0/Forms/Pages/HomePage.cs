using PLC.Sharp7.Concrete;

namespace IBKS_2._0.Forms.Pages
{
    public partial class HomePage : Form
    {
        readonly Sharp7Service _sharp7Service = Sharp7Service.Instance;

        public HomePage()
        {
            InitializeComponent();
        }

        private void TimerPlcRead_Tick(object sender, EventArgs e)
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
    }
}