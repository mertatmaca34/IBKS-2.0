using Business.Abstract;
using IBKS_2._0.Forms.Pages.Settings;
using IBKS_2._0.Utils;

namespace IBKS_2._0.Forms.Pages
{
    public partial class SettingsPage : Form
    {
        readonly ICalibrationLimitService _calibrationLimitManager;
        readonly IApiService _apiManager;
        readonly IStationService _stationManager;

        public SettingsPage(ICalibrationLimitService calibrationLimitManager, IApiService apiManager, IStationService stationManager)
        {
            InitializeComponent();

            _apiManager = apiManager;
            _calibrationLimitManager = calibrationLimitManager;
            _stationManager = stationManager;
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
            PageChange.Change(PanelContent, this, new PlcSettingsPage());
        }
    }
}
