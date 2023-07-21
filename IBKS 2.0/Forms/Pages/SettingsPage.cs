using IBKS_2._0.Forms.Pages.Settings;
using IBKS_2._0.Utils;

namespace IBKS_2._0.Forms.Pages
{
    public partial class SettingsPage : Form
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void ButtonCalibrationSettings_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new CalibrationSettingsPage());
        }
    }
}
