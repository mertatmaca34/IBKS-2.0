using Business.Abstract;
using System.Collections.Generic;
using Entities.Concrete;
using ibks.Utils;
using ibks.Utils.DataExtractions.EPPlus;
using ibks.Utils.DataExtractions.iTextSharp;
using System.Data;
using System.Globalization;
using System.Linq;

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

        private class DailyValiditySummary
        {
            public DateTime Day { get; set; }
            public int TotalRecords { get; set; }
            public int ValidDailyBlockCount { get; set; }
            public bool DailyWashValid { get; set; }
            public bool WeeklyWashValid { get; set; }
            public int? WeeklyWashDuration { get; set; }
            public bool IsValid { get; set; }
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            var selectedReportType = ComboBoxReportType.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(selectedReportType))
            {
                return;
            }

            if (selectedReportType == "Ölçüm")
            {
                var data = _sendDataManager.GetAll(
                    d => d.Readtime > _dateFilterStart && d.Readtime < _dateFilterEnd).Data;

                DataGridViewDatas.DataSource = RadioButtonSortByFirst.Checked ? data
                    : data.OrderByDescending(d => d.Readtime).ToList();

                DataGridViewCustomization("InstantData");
            }
            else if (selectedReportType == "Kalibrasyon")
            {
                var data = _calibrationManager.GetAll(
                    d => d.TimeStamp > DateTimePickerFirstDate.Value && d.TimeStamp < DateTimePickerLastDate.Value).Data;

                DataGridViewDatas.DataSource = RadioButtonSortByFirst.Checked ? data
                    : data.OrderByDescending(d => d.TimeStamp).ToList();

                DataGridViewCustomization("CalibrationData");
            }
            else if (selectedReportType == "Numune")
            {
                var data = _sampleManager.GetAll(
                    d => d.DateTime > DateTimePickerFirstDate.Value && d.DateTime < DateTimePickerLastDate.Value).Data;

                DataGridViewDatas.DataSource = RadioButtonSortByFirst.Checked ? data
                    : data.OrderByDescending(d => d.DateTime).ToList();

                DataGridViewCustomization("SampleData");
            }
            else if (selectedReportType == "Veri Geçerlilik Durumu")
            {
                GenerateDataValidityReport();

                DataGridViewCustomization("DataValidity");
            }
            else
            {
                DataGridViewDatas.DataSource = null;
            }

            DataGridViewDatas.Refresh();
        }

        private void GenerateDataValidityReport()
        {
            const int expectedDailyRecordCount = 1440;
            const double validRatio = 0.8d;
            var minimumValidRecordCount = (int)Math.Ceiling(expectedDailyRecordCount * validRatio);

            var queryStart = _dateFilterStart.AddDays(-7);
            var sendData = _sendDataManager.GetAll(
                d => d.Readtime >= queryStart && d.Readtime < _dateFilterEnd).Data
                .OrderBy(d => d.Readtime)
                .ToList();

            var dataTable = CreateDataValidityTable();

            if (_dateFilterEnd <= _dateFilterStart)
            {
                DataGridViewDatas.DataSource = dataTable;
                return;
            }

            var startDay = _dateFilterStart.Date;
            var finalDay = _dateFilterEnd.AddTicks(-1).Date;

            var dailySummaries = new List<DailyValiditySummary>();

            for (var day = startDay; day <= finalDay; day = day.AddDays(1))
            {
                var dayStart = day;
                var dayEnd = day.AddDays(1);

                var dailyRecords = sendData
                    .Where(d => d.Readtime >= dayStart && d.Readtime < dayEnd)
                    .ToList();

                var validDailySequences = GetConsecutiveSequences(dailyRecords, 23)
                    .Where(seq => seq.Count >= 4 && seq.Count <= 6)
                    .ToList();

                var intervals = new List<(DateTime Start, DateTime End)>
                {
                    (dayStart, dayStart.AddHours(6)),
                    (dayStart.AddHours(6), dayStart.AddHours(12)),
                    (dayStart.AddHours(12), dayStart.AddHours(18)),
                    (dayStart.AddHours(18), dayEnd)
                };

                var validBlockCount = intervals.Count(interval =>
                    validDailySequences.Any(seq =>
                    {
                        var sequenceStart = seq.First().Readtime;
                        return sequenceStart >= interval.Start && sequenceStart < interval.End;
                    }));

                var dailyWashValid = validBlockCount == intervals.Count;

                var weeklyWindowStart = day.AddDays(-6);
                var weeklyWindowEnd = dayEnd;

                var weeklyWindowRecords = sendData
                    .Where(d => d.Readtime >= weeklyWindowStart && d.Readtime < weeklyWindowEnd)
                    .ToList();

                var validWeeklySequence = GetConsecutiveSequences(weeklyWindowRecords, 24)
                    .Where(seq => seq.Count >= 16 && seq.Count <= 30)
                    .OrderByDescending(seq => seq.Count)
                    .FirstOrDefault();

                var weeklyWashValid = validWeeklySequence != null;

                var totalDailyRecords = dailyRecords.Count;
                var countedRecords = Math.Min(totalDailyRecords, expectedDailyRecordCount);
                var dailyPercentage = expectedDailyRecordCount == 0
                    ? 0
                    : countedRecords * 100d / expectedDailyRecordCount;

                var hasEnoughRecords = totalDailyRecords >= minimumValidRecordCount;

                var summary = new DailyValiditySummary
                {
                    Day = day,
                    TotalRecords = totalDailyRecords,
                    ValidDailyBlockCount = validBlockCount,
                    DailyWashValid = dailyWashValid,
                    WeeklyWashValid = weeklyWashValid,
                    WeeklyWashDuration = validWeeklySequence?.Count,
                    IsValid = hasEnoughRecords && dailyWashValid && weeklyWashValid
                };

                dailySummaries.Add(summary);

                var row = dataTable.NewRow();
                row["Tür"] = "Günlük";
                row["Tarih"] = day.ToString("dd.MM.yyyy");
                row["Yıkama Verisi"] = FormatDailyWashText(validBlockCount, intervals.Count, dailyWashValid);
                row["Haftalık Yıkama Verisi"] = FormatWeeklyWashText(weeklyWashValid, validWeeklySequence?.Count);
                row["Veri Detayı"] = FormatDataDetail(expectedDailyRecordCount, totalDailyRecords, dailyPercentage, "geçerli veri");
                row["Minimum Gereksinim"] = $"Min {minimumValidRecordCount} veri";
                row["Durum"] = summary.IsValid ? "Geçerli" : "Geçersiz";
                dataTable.Rows.Add(row);
            }

            if (dailySummaries.Any())
            {
                AddOverallSummaryRow(dataTable, dailySummaries, expectedDailyRecordCount, minimumValidRecordCount);
                AddMonthlySummaryRows(dataTable, dailySummaries);
            }

            DataGridViewDatas.DataSource = dataTable;
        }

        private static DataTable CreateDataValidityTable()
        {
            var table = new DataTable();
            table.Columns.Add("Tür");
            table.Columns.Add("Tarih");
            table.Columns.Add("Yıkama Verisi");
            table.Columns.Add("Haftalık Yıkama Verisi");
            table.Columns.Add("Veri Detayı");
            table.Columns.Add("Minimum Gereksinim");
            table.Columns.Add("Durum");
            return table;
        }

        private static string FormatDailyWashText(int validBlockCount, int totalBlocks, bool isValid)
        {
            var statusText = isValid ? "Geçerli" : "Geçersiz";
            return $"{statusText} ({validBlockCount}/{totalBlocks} blok)";
        }

        private static string FormatWeeklyWashText(bool isValid, int? duration)
        {
            if (!isValid)
            {
                return "Geçersiz";
            }

            return duration.HasValue
                ? $"Geçerli ({duration.Value} dk)"
                : "Geçerli";
        }

        private static string FormatDataDetail(int expected, int actual, double percentage, string unit = "")
        {
            if (expected <= 0)
            {
                return "0/0 (%0)";
            }

            var ratio = $"{expected}/{actual}";

            if (!string.IsNullOrWhiteSpace(unit))
            {
                ratio += $" {unit}";
            }

            return $"{ratio} (%{percentage:0.##})";
        }

        private void AddOverallSummaryRow(DataTable dataTable, List<DailyValiditySummary> dailySummaries, int expectedDailyRecordCount, int minimumValidRecordCount)
        {
            var totalDays = dailySummaries.Count;
            var totalExpectedRecords = expectedDailyRecordCount * totalDays;
            var totalActualRecords = dailySummaries.Sum(s => s.TotalRecords);
            var countedRecords = Math.Min(totalActualRecords, totalExpectedRecords);
            var percentage = totalExpectedRecords == 0
                ? 0
                : countedRecords * 100d / totalExpectedRecords;

            var validDayCount = dailySummaries.Count(s => s.IsValid);
            var requiredValidDays = (int)Math.Ceiling(totalDays * 0.8d);

            var row = dataTable.NewRow();
            row["Tür"] = "Genel Özet";
            row["Tarih"] = $"{_dateFilterStart:dd.MM.yyyy} - {_dateFilterEnd.AddTicks(-1):dd.MM.yyyy}";
            row["Yıkama Verisi"] = $"{dailySummaries.Count(s => s.DailyWashValid)}/{totalDays} geçerli";
            row["Haftalık Yıkama Verisi"] = $"{dailySummaries.Count(s => s.WeeklyWashValid)}/{totalDays} geçerli";
            row["Veri Detayı"] = FormatDataDetail(totalExpectedRecords, totalActualRecords, percentage, "geçerli veri");
            row["Minimum Gereksinim"] = $"Min {minimumValidRecordCount} veri - Min {requiredValidDays} gün";
            row["Durum"] = validDayCount >= requiredValidDays ? "Geçerli" : "Geçersiz";
            dataTable.Rows.Add(row);
        }

        private void AddMonthlySummaryRows(DataTable dataTable, List<DailyValiditySummary> dailySummaries)
        {
            var culture = CultureInfo.GetCultureInfo("tr-TR");

            foreach (var monthGroup in dailySummaries
                         .GroupBy(s => new { s.Day.Year, s.Day.Month })
                         .OrderBy(g => g.Key.Year)
                         .ThenBy(g => g.Key.Month))
            {
                var totalDays = monthGroup.Count();
                var validDays = monthGroup.Count(s => s.IsValid);
                var requiredValidDays = (int)Math.Ceiling(totalDays * 0.8d);
                var percentage = totalDays == 0 ? 0 : validDays * 100d / totalDays;

                var monthLabel = new DateTime(monthGroup.Key.Year, monthGroup.Key.Month, 1)
                    .ToString("MMMM yyyy", culture);

                var row = dataTable.NewRow();
                row["Tür"] = "Aylık";
                row["Tarih"] = monthLabel;
                row["Yıkama Verisi"] = "-";
                row["Haftalık Yıkama Verisi"] = "-";
                row["Veri Detayı"] = FormatDataDetail(totalDays, validDays, percentage, "geçerli gün");
                row["Minimum Gereksinim"] = $"Min {requiredValidDays} gün";
                row["Durum"] = validDays >= requiredValidDays ? "Geçerli" : "Geçersiz";
                dataTable.Rows.Add(row);
            }
        }

        private static List<List<SendData>> GetConsecutiveSequences(List<SendData> data, int debiStatus)
        {
            var sequences = new List<List<SendData>>();
            List<SendData> currentSequence = null;
            DateTime? lastTimestamp = null;

            foreach (var record in data.OrderBy(d => d.Readtime))
            {
                if (record.Debi_Status != debiStatus)
                {
                    currentSequence = null;
                    lastTimestamp = null;
                    continue;
                }

                else if(currentSequence != null)
                {
                    currentSequence.Add(record);
                    lastTimestamp = record.Readtime;
                }
                else if (currentSequence == null)
                {
                    currentSequence = new List<SendData>();
                    currentSequence.Add(record);
                    lastTimestamp = record.Readtime;
                }


                sequences.Add(currentSequence);
            }

            return sequences;
        }

        private void ReportingPage_Load(object sender, EventArgs e)
        {
            ComboBoxReportType.SelectedIndex = ComboBoxReportType.Items.Count > 0 ? 0 : -1;
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
                DataGridViewDatas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                switch (reportType)
                {
                    case "InstantData":
                        RemoveDataGridViewColumns(26,25,24,23,22,21,20,19,18,17,15,10,9,8,3,1,0);
                        DataGridViewDatas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        DataGridViewDatas.Columns[0].HeaderText = "Tarih";
                        DataGridViewDatas.Columns[0].MinimumWidth = 100;
                        DataGridViewDatas.Columns[1].HeaderText = "Akış Hızı";
                        DataGridViewDatas.Columns[2].HeaderText = "Akm";
                        DataGridViewDatas.Columns[3].HeaderText = "Çözünmüş Oksijen";
                        DataGridViewDatas.Columns[4].HeaderText = "Debi";
                        DataGridViewDatas.Columns[5].HeaderText = "Koi";
                        DataGridViewDatas.Columns[6].HeaderText = "Ph";
                        DataGridViewDatas.Columns[7].HeaderText = "Sıcaklık";
                        DataGridViewDatas.Columns[8].HeaderText = "İletkenlik";
                        DataGridViewDatas.Columns[9].HeaderText = "Durum Kodu";
                        DataGridViewDatas.Columns[10].HeaderText = "Gönderim";

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

                    case "DataValidity":
                        DataGridViewDatas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        DataGridViewDatas.Columns[0].HeaderText = "Tür";
                        DataGridViewDatas.Columns[1].HeaderText = "Tarih";
                        DataGridViewDatas.Columns[2].HeaderText = "Yıkama Verisi";
                        DataGridViewDatas.Columns[3].HeaderText = "Haftalık Yıkama";
                        DataGridViewDatas.Columns[4].HeaderText = "Veri Durumu";
                        DataGridViewDatas.Columns[5].HeaderText = "Minimum Gereksinim";
                        DataGridViewDatas.Columns[6].HeaderText = "Durum";

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
