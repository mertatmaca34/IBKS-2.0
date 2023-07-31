using Business.Abstract;
using Business.Concrete;
using Business.Constants;
using Entities.Concrete;

namespace IBKS_2._0.Forms.Pages.Settings
{
    public partial class PlcSettingsPage : Form
    {
        readonly IPlcService _plcManager;

        public PlcSettingsPage(IPlcService plcManager)
        {
            InitializeComponent();

            _plcManager = plcManager;
        }

        private void PlcSettingsPage_Load(object sender, EventArgs e)
        {
            var result = _plcManager.Get();

            if (result.Success)
            {
                PlcSettingsControlIp.AyarDegeri = result.Data.IpAdress;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Plc plc = new()
                {
                    IpAdress = PlcSettingsControlIp.AyarDegeri
                };

                var res = _plcManager.Add(plc);

                MessageBox.Show(res.Message);
            }
            catch (Exception)
            {
                MessageBox.Show(Messages.CalibrationLimitIncompleteInfo);
            }
        }
    }
}
