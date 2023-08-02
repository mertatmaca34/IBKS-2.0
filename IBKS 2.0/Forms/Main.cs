using Business.Abstract;
using IBKS_2._0.Forms.Pages;
using IBKS_2._0.Utils;

namespace IBKS_2._0.Forms
{
    public partial class Main : Form
    {
        readonly HomePage _homePage;
        readonly SimulationPage _simulationPage;
        readonly ReportingPage _reportingPage;

        readonly IStationService _stationManager;
        readonly IApiService _apiManager;
        readonly ISendDataService _sendDataManager;
        readonly ICalibrationService _calibrationManager;
        readonly ICalibrationLimitService _calibrationLimitManager;
        readonly IPlcService _plcManager;

        public Main(IStationService stationManager, IApiService apiManager, ISendDataService sendDataManager, ICalibrationService calibrationManager, ICalibrationLimitService calibrationLimitManager, IPlcService plcManager)
        {
            InitializeComponent();

            _apiManager = apiManager;

            _stationManager = stationManager;
            _plcManager = plcManager;
            _sendDataManager = sendDataManager;
            _calibrationManager = calibrationManager;
            _calibrationLimitManager = calibrationLimitManager;

            _homePage = new HomePage(_stationManager, _sendDataManager, _calibrationManager, _apiManager);
            _simulationPage = new SimulationPage();
            _reportingPage = new ReportingPage(_sendDataManager, _calibrationManager);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, _homePage);
            RoundedCorners.MakeRounded(ButtonHomePage, ButtonSimulationPage, ButtonCalibrationPage, ButtonMailPage, ButtonReportingPage, ButtonSettingPage, ButtonNightMode);
        }

        private void ButtonHomePage_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, _homePage);
            ButtonImageExtensions.Replace(TableLayoutPanelLeftBar, ButtonHomePage);
        }

        private void ButtonSimulationPage_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, _simulationPage);
            ButtonImageExtensions.Replace(TableLayoutPanelLeftBar, ButtonSimulationPage);
        }

        private void ButtonCalibrationPage_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new CalibrationPage(_calibrationManager));
            ButtonImageExtensions.Replace(TableLayoutPanelLeftBar, ButtonCalibrationPage);
        }

        private void ButtonMailPage_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new MailPage());
            ButtonImageExtensions.Replace(TableLayoutPanelLeftBar, ButtonMailPage);
        }

        private void ButtonReportingPage_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, _reportingPage);
            ButtonImageExtensions.Replace(TableLayoutPanelLeftBar, ButtonReportingPage);
        }

        private void ButtonSettingPage_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new SettingsPage(_calibrationLimitManager, _apiManager, _stationManager, _plcManager));
            ButtonImageExtensions.Replace(TableLayoutPanelLeftBar, ButtonSettingPage);
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            foreach (Form activeForm in PanelContent.Controls)
            {
                activeForm.Size = PanelContent.Size;
            }
        }
    }
}
