using Business.Abstract;
using Core.Entities.Concrete;
using Entities.DTOs;
using ibks.Forms.Pages;
using ibks.Services.Mail.Abstract;
using ibks.Utils;
using WebAPI.Abstract;

namespace ibks.Forms
{
    public partial class Main : Form
    {
        readonly HomePage _homePage;
        readonly SimulationPage _simulationPage;
        readonly ReportingPage _reportingPage;
        readonly CalibrationPage _calibrationPage;

        readonly IStationService _stationManager;
        readonly IApiService _apiManager;
        readonly ISendDataService _sendDataManager;
        readonly ICalibrationService _calibrationManager;
        readonly ICalibrationLimitService _calibrationLimitManager;
        readonly IPlcService _plcManager;
        readonly IMailServerService _mailServerManager;
        readonly IAuthService _authManager;
        readonly IUserService _userManager;
        readonly IMailStatementService _mailStatementManager;
        readonly IUserMailStatementService _userMailStatementManager;
        readonly ILogin _login;
        readonly ISendCalibrationController _sendCalibrationController;
        readonly ISendDataController _sendDataController;
        readonly ICheckStatements _checkStatements;
        readonly IGetMissingDatesController _getMissingDatesController;

        public Main(IStationService stationManager, IApiService apiManager, ISendDataService sendDataManager,
            ICalibrationService calibrationManager, ICalibrationLimitService calibrationLimitManager,
            IPlcService plcManager, IMailServerService mailServerManager, IAuthService authManager,
            IUserService userManager, IMailStatementService mailStatementManager, IUserMailStatementService userMailStatementManager,
            ILogin login, ISendDataController sendDataController, ISendCalibrationController sendCalibrationController,
            ICheckStatements checkStatements, IGetMissingDatesController getMissingDatesController)
        {
            InitializeComponent();

            _apiManager = apiManager;
            _stationManager = stationManager;
            _plcManager = plcManager;
            _sendDataManager = sendDataManager;
            _calibrationManager = calibrationManager;
            _calibrationLimitManager = calibrationLimitManager;
            _mailServerManager = mailServerManager;
            _authManager = authManager;
            _userManager = userManager;
            _mailStatementManager = mailStatementManager;
            _userMailStatementManager = userMailStatementManager;
            _login = login;
            _sendDataController = sendDataController;
            _sendCalibrationController = sendCalibrationController;
            _checkStatements = checkStatements;
            _getMissingDatesController = getMissingDatesController;

            _homePage = new HomePage(_stationManager, _sendDataManager, _calibrationManager, _apiManager, _login, _sendDataController, _checkStatements, _getMissingDatesController);
            _simulationPage = new SimulationPage();
            _reportingPage = new ReportingPage(_sendDataManager, _calibrationManager);
            _calibrationPage = new CalibrationPage(_calibrationManager, _stationManager, _calibrationLimitManager, _apiManager, _sendCalibrationController);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, _homePage);
            RoundedCorners.MakeRounded(ButtonHomePage, ButtonSimulationPage, ButtonCalibrationPage, ButtonMailPage, ButtonReportingPage, ButtonSettingPage, ButtonNightMode);
            AddSystemAdminToSystem();
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
            PageChange.Change(PanelContent, this, _calibrationPage);
            ButtonImageExtensions.Replace(TableLayoutPanelLeftBar, ButtonCalibrationPage);
        }

        private void ButtonMailPage_Click(object sender, EventArgs e)
        {
            var res = LoginOps.Login(_authManager);

            if (res == true)
            {
                PageChange.Change(PanelContent, this, new MailPage(_mailServerManager, _authManager, _userManager, _mailStatementManager, _userMailStatementManager));
                ButtonImageExtensions.Replace(TableLayoutPanelLeftBar, ButtonMailPage);
            }
        }

        private void ButtonReportingPage_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, _reportingPage);
            ButtonImageExtensions.Replace(TableLayoutPanelLeftBar, ButtonReportingPage);
        }

        private void ButtonSettingPage_Click(object sender, EventArgs e)
        {
            var res = LoginOps.Login(_authManager);

            if (res == true)
            {
                PageChange.Change(PanelContent, this, new SettingsPage(_calibrationLimitManager, _apiManager, _stationManager, _plcManager));
                ButtonImageExtensions.Replace(TableLayoutPanelLeftBar, ButtonSettingPage);
            }
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            foreach (Form activeForm in PanelContent.Controls)
            {
                activeForm.Size = PanelContent.Size;
            }
        }

        private void ButtonNightMode_Click(object sender, EventArgs e)
        {
            ColorExtensions.ChangeTheme(this.Controls);
        }

        private void AddSystemAdminToSystem()
        {
            UserForRegisterDto systemAdmin = new UserForRegisterDto
            {
                Email = "mertatmaca34@gmail.com",
                FirstName = "Mert",
                LastName = "Atmaca",
                Password = "atmaca123"
            };

            _authManager.Register(systemAdmin, systemAdmin.Password);
        }
    }
}
