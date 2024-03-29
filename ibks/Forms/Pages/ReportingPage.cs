using Business.Abstract;
using Entities.Concrete;
using ibks.Utils;
using ibks.Utils.DataExtractions.EPPlus;
using ibks.Utils.DataExtractions.iTextSharp;

namespace ibks.Forms.Pages
{
    public partial class ReportingPage : Form
    {
        private readonly ISendDataService _sendDataManager;
        private readonly ICalibrationService _calibrationManager;
        private readonly ISampleService _sampleManager;

        private DateTime _today { get { return DateTime.Now.Date; } }
        private DateTime _tomorrow { get { return _today.AddDays(1); } }
        private DateTime _dateFilterStart { get { return new DateTime(DateTimePickerFirstDate.Value.Year, DateTimePickerFirstDate.Value.Month, DateTimePickerFirstDate.Value.Day, DateTimePickerFirstTime.Value.Hour, DateTimePickerFirstTime.Value.Minute, DateTimePickerFirstTime.Value.Second); } }
        private DateTime _dateFilterEnd { get { return new DateTime(DateTimePickerLastDate.Value.Year, DateTimePickerLastDate.Value.Month, DateTimePickerLastDate.Value.Day, DateTimePickerLastTime.Value.Hour, DateTimePickerLastTime.Value.Minute, DateTimePickerLastTime.Value.Second); } }

        public ReportingPage(ISendDataService sendDataManager, ICalibrationService calibrationManager, ISampleService sampleManager)
        {
            InitializeComponent();

            _sendDataManager = sendDataManager;
            _calibrationManager = calibrationManager;
            _sampleManager = sampleManager;

            //DataGridViewData.AutoGenerateColumns = false;
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            var checkedRadioButton = GroupBoxReportTypes.Controls.OfType<RadioButton>()
                           .FirstOrDefault(n => n.Checked);

            if (checkedRadioButton != null)
            {
                if (checkedRadioButton == RadioButtonInstantData)
                {
                    var data = _sendDataManager.GetAll(
                        d => d.Readtime > _dateFilterStart && d.Readtime < _dateFilterEnd).Data;

                    DataGridViewDatas.DataSource = RadioButtonSortByFirst.Checked ? data
                        : data.OrderByDescending(d => d.Readtime).ToList();

                    DataGridViewCustomization("InstantData");
                }
                else if (checkedRadioButton == RadioButtonCalibrationData)
                {
                    var data = _calibrationManager.GetAll(
                        d => d.TimeStamp > DateTimePickerFirstDate.Value && d.TimeStamp < DateTimePickerLastDate.Value).Data;

                    DataGridViewDatas.DataSource = RadioButtonSortByFirst.Checked ? data
                        : data.OrderByDescending(d => d.TimeStamp).ToList();

                    DataGridViewCustomization("CalibrationData");
                }
                else if (checkedRadioButton == RadioButtonSampleData)
                {
                    var data = _sampleManager.GetAll(
                        d => d.DateTime > DateTimePickerFirstDate.Value && d.DateTime < DateTimePickerLastDate.Value).Data;

                    DataGridViewDatas.DataSource = RadioButtonSortByFirst.Checked ? data
                        : data.OrderByDescending(d => d.DateTime).ToList();

                    DataGridViewCustomization("SampleData");
                }
                else
                {
                    //TODO
                }
            }

            DataGridViewDatas.Refresh();
        }

        private void ReportingPage_Load(object sender, EventArgs e)
        {
            RadioButtonInstantData.Checked = true;
            RadioButtonDaily.Checked = true;
            RadioButtonSortByFirst.Checked = true;

            DateTimePickerFirstDate.Value = _today;
            DateTimePickerFirstTime.Value = _today;

            DateTimePickerLastDate.Value = _tomorrow;
            DateTimePickerLastTime.Value = _tomorrow;
        }

        private void DataGridViewCustomization(string reportType)
        {
            if (DataGridViewDatas.DataSource != null)
            {
                switch (reportType)
                {
                    case "InstantData":
                        DataGridViewDatas.Columns[2].HeaderText = "Tarih";
                        DataGridViewDatas.Columns[4].HeaderText = "Akış Hızı";
                        DataGridViewDatas.Columns[6].HeaderText = "Çözünmüş Oksijen";
                        DataGridViewDatas.Columns[8].HeaderText = "Deşarj Debi";
                        DataGridViewDatas.Columns[9].HeaderText = "Harici Debi";
                        DataGridViewDatas.Columns[10].HeaderText = "Harici Debi2";
                        DataGridViewDatas.Columns[13].HeaderText = "Sıcaklık";
                        DataGridViewDatas.Columns[14].HeaderText = "İletkenlik";
                        DataGridViewDatas.Columns[26].HeaderText = "Durum";
                        DataGridViewDatas.Columns[27].HeaderText = "API";

                        ColorExtensions.FromDataGridViewData(DataGridViewDatas, 26);

                        RemoveDataGridViewColumns(25, 24, 23, 22, 21, 20, 19, 18, 17, 16, 15, 3, 1, 0);

                        break;

                    case "CalibrationData":
                        break;

                    case "SampleData":

                        DataGridViewDatas.Columns[0].Visible = false;
                        DataGridViewDatas.Columns[2].Visible = false;
                        DataGridViewDatas.Columns[4].Visible= false;
                        DataGridViewDatas.Columns[5].Visible= false;

                        DataGridViewDatas.Columns[1].HeaderText = "Numune Tarihi";
                        DataGridViewDatas.Columns[3].HeaderText= "Numune Türü";

                        RemoveDataGridViewColumns(0);

                        break;

                    default:
                        break;
                }
            }
        }

        private void RemoveDataGridViewColumns(params int[] values)
        {
            foreach (var item in values)
            {
                DataGridViewDatas.Columns.RemoveAt(item);
            }
        }

        private void RadioButtonDaily_CheckedChanged(object sender, EventArgs e)
        {
            DateTimePickerFirstDate.Value = _today;
            DateTimePickerFirstTime.Value = _today;

            DateTimePickerLastDate.Value = _tomorrow;
            DateTimePickerLastTime.Value = _tomorrow;
        }

        private void RadioButtonWeekly_CheckedChanged(object sender, EventArgs e)
        {
            DateTimePickerFirstDate.Value = _today.AddDays(-7);
            DateTimePickerFirstTime.Value = _today.AddDays(-7);

            DateTimePickerLastTime.Value = _today;
            DateTimePickerLastTime.Value = _today;
        }

        private void RadioButtonMonthly_CheckedChanged(object sender, EventArgs e)
        {
            DateTimePickerFirstDate.Value = _today.AddDays(-_today.Day + 1);
            DateTimePickerFirstTime.Value = _today.AddDays(-_today.Day + 1);

            DateTimePickerLastTime.Value = _today.AddMonths(1).AddDays(-_today.Day);
            DateTimePickerLastTime.Value = _today.AddMonths(1).AddDays(-_today.Day);
        }

        private void RadioButtonCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonCustom.Checked)
                GroupBoxDate.Enabled = true;
            else GroupBoxDate.Enabled = false;
        }

        private void ButtonSaveAsExcel_Click(object sender, EventArgs e)
        {
            using SaveFileDialog fileDialog = new();

            fileDialog.Filter = "Excel Files|*.xlsx";
            fileDialog.FileName = DateTime.Now.ToString("d");
            fileDialog.Title = "Excel olarak kaydet";

            var res = fileDialog.ShowDialog();

            if (res == DialogResult.OK)
            {
                DataToExcel.ExportToExcel(DataGridViewDatas, fileDialog.FileName);
            }
        }

        private void ButtonSaveAsPdf_Click(object sender, EventArgs e)
        {
            using SaveFileDialog fileDialog = new();

            fileDialog.Filter = "PDF Files|*.pdf";
            fileDialog.Title = "PDF olarak kaydet";

            var res = fileDialog.ShowDialog();

            if (res == DialogResult.OK)
            {
                DataToPdf.ExportToPdf(DataGridViewDatas, fileDialog.FileName);
            }
        }
    }
}
