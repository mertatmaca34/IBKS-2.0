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
            _calibrationLimitManager = calibrationLimitManager;

            InitializeComponent();
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
    }
}
