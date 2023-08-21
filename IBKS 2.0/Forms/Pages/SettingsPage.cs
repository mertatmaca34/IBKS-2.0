using Business.Abstract;
using ibks.Forms.Pages.Settings;
using ibks.Utils;

namespace ibks.Forms.Pages
{
    public partial class SettingsPage : Form
    {
        readonly ICalibrationLimitService _calibrationLimitManager;
        readonly IApiService _apiManager;
        readonly IStationService _stationManager;
        readonly IPlcService _plcManager;

        private ToolStripMenuItem? _selectedMenuItem;

        public SettingsPage(ICalibrationLimitService calibrationLimitManager, IApiService apiManager, IStationService stationManager, IPlcService plcManager)
        {
            InitializeComponent();

            _apiManager = apiManager;
            _calibrationLimitManager = calibrationLimitManager;
            _stationManager = stationManager;
            _plcManager = plcManager;

            InitializeMenuItems();
        }

        private void ButtonCalibrationSettings_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new CalibrationSettingsPage(_calibrationLimitManager));
        }

        private void ButtonStationSettings_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new StationSettingsPage(_stationManager));
        }

        private void ButtonApiSettings_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new ApiSettingsPage(_apiManager));
        }

        private void ButtonPlcSettings_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new PlcSettingsPage(_plcManager));
        }

        private void InitializeMenuItems()
        {
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.Click += MenuItem_Click!;
            }
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            Color hoverBlue = Color.FromArgb(179, 215, 243);

            if (_selectedMenuItem != null)
            {
                _selectedMenuItem.BackColor = Color.White;
            }

            _selectedMenuItem = (ToolStripMenuItem)sender;
            _selectedMenuItem.BackColor = hoverBlue;
            _selectedMenuItem.ForeColor = Color.Black;
        }
    }
}
