using Business.Abstract;
using IBKS_2._0.Forms.Pages.Settings;
using IBKS_2._0.Utils;

namespace IBKS_2._0.Forms.Pages
{
    public partial class SettingsPage : Form
    {
        readonly ICalibrationLimitService _calibrationLimitManager;

        public SettingsPage(ICalibrationLimitService calibrationLimitManager)
        {
            _calibrationLimitManager = calibrationLimitManager;

            InitializeComponent();
        }

        private void ButtonCalibrationSettings_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new CalibrationSettingsPage(_calibrationLimitManager));
        }

        private void ButtonStationSettings_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new StationSettingsPage());
        }

        private void ButtonApiSettings_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new ApiSettingsPage());
        }

        private void ButtonPlcSettings_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new PlcSettingsPage());
        }
    }
}
