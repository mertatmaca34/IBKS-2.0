using PLC.Sharp7.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBKS_2._0.Forms.Pages
{
    public partial class HomePage : Form
    {
        PlcService _plcService = PlcService.Instance;
        public HomePage()
        {
            InitializeComponent();
        }

        private void TimerPlcRead_Tick(object sender, EventArgs e)
        {
            ChannelAkm.InstantData = _plcService.DB41.Akm.ToString();
            ChannelCozunmusOksijen.InstantData = _plcService.DB41.CozunmusOksijen.ToString();
            ChannelSicaklik.InstantData = _plcService.DB41.KabinSicaklik.ToString();
            ChannelPh.InstantData = _plcService.DB41.Ph.ToString();
            ChannelIletkenlik.InstantData = _plcService.DB41.Iletkenlik.ToString();
            ChannelKoi.InstantData = _plcService.DB41.Koi.ToString();
            ChannelAkisHizi.InstantData = _plcService.DB41.NumuneHiz.ToString();
            ChannelDebi.InstantData = _plcService.DB41.TesisDebi.ToString();
        }
    }
}
