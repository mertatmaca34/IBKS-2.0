using IBKS_2._0.Forms.Pages;
using IBKS_2._0.Utils;

namespace IBKS_2._0.Forms
{
    public partial class Main : Form
    {
        HomePage _homePage;
        SimulationPage _simulationPage;

        public Main()
        {
            _homePage = new HomePage();
            _simulationPage = new SimulationPage();

            InitializeComponent();
        }

        private void ButtonHomePage_Click(object sender, EventArgs e)
        {
            PageChange.Change(this, _homePage);
        }

        private void ButtonSimulationPage_Click(object sender, EventArgs e)
        {
            PageChange.Change(this, _homePage);
        }

        private void ButtonCalibrationPage_Click(object sender, EventArgs e)
        {
            PageChange.Change(this, new CalibrationPage());
        }

        private void ButtonMailPage_Click(object sender, EventArgs e)
        {
            PageChange.Change(this, new MailPage());
        }

        private void ButtonReportingPage_Click(object sender, EventArgs e)
        {
            PageChange.Change(this, new ReportingPage());
        }
    }
}
