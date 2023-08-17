using Business.Abstract;
using Business.Constants;
using Entities.Concrete;
using IBKS_2._0.Components;

namespace IBKS_2._0.Forms.Pages.Settings
{
    public partial class CalibrationSettingsPage : Form
    {
        readonly ICalibrationLimitService _calibrationLimitManager;

        public CalibrationSettingsPage(ICalibrationLimitService calibrationLimitManager)
        {
            InitializeComponent();

            _calibrationLimitManager = calibrationLimitManager;
        }

        private void CalibrationSettingsPage_Load(object sender, EventArgs e)
        {
            AssignComboBoxes(CalibrationSettingsBarAkm, CalibrationSettingsBarIletkenlik, CalibrationSettingsBarKoi, CalibrationSettingsBarPh);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control control in TableLayoutPanelMain.Controls)
                {
                    if (control is CalibrationSettingsBar calibrationBar)
                    {
                        CalibrationLimit calibrationLimit = new()
                        {
                            Parameter = calibrationBar.Parameter,
                            SpanRef = Convert.ToInt16(calibrationBar.SpanRef),
                            SpanTimeStamp = Convert.ToInt16(calibrationBar.SpanTime),
                            ZeroRef = Convert.ToInt16(calibrationBar.ZeroRef),
                            ZeroTimeStamp = Convert.ToInt16(calibrationBar.ZeroTime),
                        };

                        var res = _calibrationLimitManager.Add(calibrationLimit);

                        MessageBox.Show($"{calibrationBar.Parameter}: {res.Message}");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Messages.CalibrationLimitIncompleteInfo);
            }
        }

        private void AssignComboBoxes(params CalibrationSettingsBar[] calibrationSettingBars)
        {
            foreach (var item in calibrationSettingBars)
            {
                var calibrationResult = _calibrationLimitManager.Get(c => c.Parameter == item.Parameter);

                if (calibrationResult.Data != null)
                {
                    item.Parameter = calibrationResult.Data.Parameter;
                    item.ZeroRef = calibrationResult.Data.ZeroRef.ToString();
                    item.ZeroTime = calibrationResult.Data.ZeroTimeStamp.ToString();
                    item.SpanRef = calibrationResult.Data.SpanRef.ToString();
                    item.SpanTime = calibrationResult.Data.SpanTimeStamp.ToString();
                }
            }
        }
    }
}
