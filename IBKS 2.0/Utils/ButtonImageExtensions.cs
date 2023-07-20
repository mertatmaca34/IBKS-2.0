using IBKS_2._0.Properties;

namespace IBKS_2._0.Utils
{
    public static class ButtonImageExtensions
    {
        private static readonly Bitmap _homePage = Resources.home_24px;
        private static readonly Bitmap _homePageFilled = Resources.filled_home_24px;
        private static readonly Bitmap _simulationPage = Resources.monitor_24px;
        private static readonly Bitmap _simulationPageFilled = Resources.filled_monitor_24px;
        private static readonly Bitmap _calibrationPage = Resources.azimuth_24px;
        private static readonly Bitmap _calibrationPageFilled = Resources.filled_azimuth_24px;
        private static readonly Bitmap _mailPage = Resources.alarm_24px;
        private static readonly Bitmap _mailPageFilled = Resources.filled_alarm_24px;
        private static readonly Bitmap _reportingPage = Resources.save_24px;
        private static readonly Bitmap _reportingPageFilled = Resources.filled_save_24px;
        private static readonly Bitmap _settingsPage = Resources.settings_24px;
        private static readonly Bitmap _settingsPageFilled = Resources.filled_settings_24px;

        public static void Replace(TableLayoutPanel tableLayoutPanel, Button button)
        {
            foreach (var item in tableLayoutPanel.Controls)
            {
                if (item is Button)
                {
                    if (((Button)item)!.Name != button.Name)
                    {
                        switch (((Button)item)!.Name)
                        {
                            case "ButtonHomePage":
                                ((Button)item).Image = _homePage;
                                break;
                            case "ButtonSimulationPage":
                                ((Button)item).Image = _simulationPage;
                                break;
                            case "ButtonCalibrationPage":
                                ((Button)item).Image = _calibrationPage;
                                break;
                            case "ButtonMailPage":
                                ((Button)item).Image = _mailPage;
                                break;
                            case "ButtonReportingPage":
                                ((Button)item).Image = _reportingPage;
                                break;
                            case "ButtonSettingPage":
                                ((Button)item).Image = _settingsPage;
                                break;
                        }
                    }
                    else
                    {
                        switch (((Button)item)!.Name)
                        {
                            case "ButtonHomePage":
                                ((Button)item).Image = _homePageFilled;
                                break;
                            case "ButtonSimulationPage":
                                ((Button)item).Image = _simulationPageFilled;
                                break;
                            case "ButtonCalibrationPage":
                                ((Button)item).Image = _calibrationPageFilled;
                                break;
                            case "ButtonMailPage":
                                ((Button)item).Image = _mailPageFilled;
                                break;
                            case "ButtonReportingPage":
                                ((Button)item).Image = _reportingPageFilled;
                                break;
                            case "ButtonSettingPage":
                                ((Button)item).Image = _settingsPageFilled;
                                break;
                        }
                    }
                }
            }
        }
    }
}
