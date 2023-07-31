using Business.Abstract;

namespace IBKS_2._0.Forms.Pages
{
    public partial class ReportingPage : Form
    {
        readonly ISendDataService _sendDataManager;
        readonly ICalibrationService _calibrationManager;

        public ReportingPage(ISendDataService sendDataManager, ICalibrationService calibrationManager)
        {
            InitializeComponent();

            _sendDataManager = sendDataManager;
            _calibrationManager = calibrationManager;
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            DataGridViewDatas.DataSource = _sendDataManager.GetAll(
                d => d.Readtime > DateTimePickerFirstDate.Value && d.Readtime < DateTimePickerLastDate.Value).Data;

            DataGridViewDatas.Refresh();
        }

        private void ReportingPage_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            RadioButtonInstantData.Checked = true;
            RadioButtonDaily.Checked = true;
            RadioButtonSortByFirst.Checked = true;

            DateTime today = new(now.Year, now.Month, now.Day, 0, 0, 0);
            DateTimePickerFirstDate.Value = today;
            DateTimePickerFirstTime.Value = today;

            DateTime tomorrow = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0).AddDays(1);
            DateTimePickerLastDate.Value = tomorrow;
            DateTimePickerLastTime.Value = tomorrow;
        }
    }
}
