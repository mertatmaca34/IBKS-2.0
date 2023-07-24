using Business.Abstract;
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
            foreach (var item in TableLayoutPanelMain.Controls)
            {
                if (item is CalibrationSettingsBar bar)
                {
                    _calibrationLimitManager.Add(new CalibrationLimit
                    {
                        Parameter = bar.Parameter,
                        ZeroRef = Convert.ToInt16(bar.ZeroRef),
                        ZeroTimeStamp = Convert.ToInt16(bar.ZeroTime),
                        SpanRef = Convert.ToInt16(bar.SpanRef),
                        SpanTimeStamp = Convert.ToInt16(bar.SpanTime)
                    });
                }
            }
        }
    }
}
