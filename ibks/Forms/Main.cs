using Business.Abstract;
using Entities.DTOs;
using ibks.Forms.Pages;
using ibks.Services.Mail.Abstract;
using ibks.Utils;
using Microsoft.Win32;
using WebAPI.Abstract;
using System.Diagnostics;

namespace ibks.Forms
{
    public partial class Main : Form
    {
        private readonly HomePage _homePage;
        private readonly SimulationPage _simulationPage;
        private readonly ReportingPage _reportingPage;
        private readonly CalibrationPage _calibrationPage;

        private readonly IStationService _stationManager;
        private readonly IApiService _apiManager;
        private readonly ICalibrationLimitService _calibrationLimitManager;
        private readonly IPlcService _plcManager;
        private readonly IMailServerService _mailServerManager;
        private readonly IAuthService _authManager;
        private readonly IUserService _userManager;
        private readonly IMailStatementService _mailStatementManager;
        private readonly IUserMailStatementService _userMailStatementManager;

        public Main(IStationService stationManager, IApiService apiManager, ISendDataService sendDataManager,
            ICalibrationService calibrationManager, ICalibrationLimitService calibrationLimitManager,
            IPlcService plcManager, IMailServerService mailServerManager, IAuthService authManager,
            IUserService userManager, IMailStatementService mailStatementManager, IUserMailStatementService userMailStatementManager,
            ISendDataController sendDataController, ISendCalibrationController sendCalibrationController,
            ICheckStatements checkStatements, ISampleService sampleManager)
        {
            InitializeComponent();

            _apiManager = apiManager;
            _stationManager = stationManager;
            _plcManager = plcManager;
            _calibrationLimitManager = calibrationLimitManager;
            _mailServerManager = mailServerManager;
            _authManager = authManager;
            _userManager = userManager;
            _mailStatementManager = mailStatementManager;
            _userMailStatementManager = userMailStatementManager;

            _homePage = new HomePage(_stationManager, sendDataManager, calibrationManager, sendDataController, checkStatements);
            _simulationPage = new SimulationPage();
            _reportingPage = new ReportingPage(sendDataManager, calibrationManager, sampleManager);
            _calibrationPage = new CalibrationPage(calibrationManager, _stationManager, _calibrationLimitManager, _apiManager, sendCalibrationController);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            AddToStartup();
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
            var loginSuccessful = LoginOps.Login(_authManager);

            if (loginSuccessful)
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

            if (res != true) return;
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

        private void ButtonNightMode_Click(object sender, EventArgs e)
        {
            ColorExtensions.ChangeTheme(this.Controls);
        }

        private void AddSystemAdminToSystem()
        {
            var isSystemAdminExist = _userManager.GetByMail("iskiadmin");

            if (isSystemAdminExist == null)
            {
                UserForRegisterDto systemAdmin = new()
                {
                    Email = "iskiadmin",
                    FirstName = "iski",
                    LastName = "admin",
                    Password = "iskiibks"
                };

                _authManager.Register(systemAdmin, systemAdmin.Password);
            }
        }

        private void AddToStartup()
        {
            string taskName = "IBKS_AutoLaunch"; // Task İsmi
            string exePath = Application.ExecutablePath; // EXE'nin tam yolu

            // Task Scheduler'a ekleme komutu
            string cmd = $"schtasks /create /tn \"{taskName}\" /tr \"\\\"{exePath}\\\"\" /sc onlogon /rl lowest /f";

            // Komutu çalıştır
            Process.Start(new ProcessStartInfo("cmd.exe", "/c " + cmd) { CreateNoWindow = true, UseShellExecute = false });
        }
    }
}
