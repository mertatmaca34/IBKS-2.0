using Business.Abstract;
using IBKS_2._0.Utils;

namespace IBKS_2._0.Forms.Pages
{
    public partial class CalibrationPage : Form
    {
        ICalibrationService _calibrationManager;

        public CalibrationPage(ICalibrationService calibrationManager)
        {
            _calibrationManager = calibrationManager;

            InitializeComponent();
        }

        private void CalibrationPage_Load(object sender, EventArgs e)
        {
            AssignLastCalibrations();
        }

        private void AssignLastCalibrations()
        {
            LabelPhLastCalibration.Text = StationInfoStatements.AssignCalibrationStatements(_calibrationManager, "Ph");
            LabelIletkenlikLastCalibration.Text = StationInfoStatements.AssignCalibrationStatements(_calibrationManager, "Iletkenlik");
        }
    }
}
