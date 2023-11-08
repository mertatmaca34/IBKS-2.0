using Business.Abstract;
using Business.Constants;
using Entities.Concrete;
using PLC.Sharp7.Services;

namespace ibks.Forms.Pages.Settings
{
    public partial class PlcSettingsPage : Form
    {
        readonly IPlcService _plcManager;

        Sharp7Service _sharp7Service = Sharp7Service.Instance;

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

                MessageBox.Show(res.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                _sharp7Service.AssignPlcIp();
            }
            catch (Exception)
            {
                MessageBox.Show(Messages.CalibrationLimitIncompleteInfo, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
