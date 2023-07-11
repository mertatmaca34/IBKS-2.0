using IBKS_2._0.Forms.Pages;
using IBKS_2._0.Utils;

namespace IBKS_2._0.Forms
{
    public partial class Main : Form
    {
        HomePage _homePage;
        public Main(HomePage homePage)
        {
            _homePage = homePage;

            InitializeComponent();
        }

        private void ButtonHomePage_Click(object sender, EventArgs e)
        {
            PageChange.Change(this,_homePage);
            /*HomePage homePage = new HomePage();
            homePage.MdiParent = this;
            homePage.Show();*/
        }

        private void ButtonSimulationPage_Click(object sender, EventArgs e)
        {
            /*SimulationPage simulationPage = new SimulationPage();
            simulationPage.MdiParent = this;
            simulationPage.Show();*/
        }

        private void ButtonCalibrationPage_Click(object sender, EventArgs e)
        {
            CalibrationPage calibrationPage = new CalibrationPage();
            calibrationPage.MdiParent = this;
            calibrationPage.Show();
        }

        private void ButtonMailPage_Click(object sender, EventArgs e)
        {
            MailPage mailPage = new MailPage();
            mailPage.MdiParent = this;
            mailPage.Show();
        }

        private void ButtonReportingPage_Click(object sender, EventArgs e)
        {
            /*ReportingPage calibrationPage = new CalibrationPage();
            calibrationPage.MdiParent = this;
            calibrationPage.Show();*/
        }
    }
}
