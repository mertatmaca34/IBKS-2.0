using API.Abstract;
using Business.Abstract;
using IBKS_2._0.Forms.Pages;
using IBKS_2._0.Utils;

namespace IBKS_2._0.Forms
{
    public partial class Main : Form
    {
        readonly HomePage _homePage;
        readonly SimulationPage _simulationPage;

        readonly IDB41Service _dB41Manager;
        readonly IStationService _stationManager;
        readonly IApiService _apiManager;
        readonly IApiConnection _apiConnection;

        public Main(IDB41Service dB41Manager, IStationService stationManager, IApiService apiManager, IApiConnection apiConnection)
        {
            _dB41Manager = dB41Manager;
            _stationManager = stationManager;
            _apiManager = apiManager;
            _apiConnection = apiConnection;

            _homePage = new HomePage(_dB41Manager, _stationManager, _apiManager, _apiConnection);

            _simulationPage = new SimulationPage();

            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, _homePage);
        }

        private void ButtonHomePage_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, _homePage);
        }

        private void ButtonSimulationPage_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, _simulationPage);
        }

        private void ButtonCalibrationPage_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new CalibrationPage());
        }

        private void ButtonMailPage_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new MailPage());
        }

        private void ButtonReportingPage_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new ReportingPage());
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
