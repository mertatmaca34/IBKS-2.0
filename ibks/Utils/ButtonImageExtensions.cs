using ibks.Properties;

namespace ibks.Utils
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
                if (item is Button _button)
                {
                    if (_button!.Name != button.Name)
                    {
                        switch (_button!.Name)
                        {
                            case "ButtonHomePage":
                                _button.Image = _homePage;
                                _button.BackColor = Color.White;
                                break;
                            case "ButtonSimulationPage":
                                _button.Image = _simulationPage;
                                _button.BackColor = Color.White;
                                break;
                            case "ButtonCalibrationPage":
                                _button.Image = _calibrationPage;
                                _button.BackColor = Color.White;
                                break;
                            case "ButtonMailPage":
                                _button.Image = _mailPage;
                                _button.BackColor = Color.White;
                                break;
                            case "ButtonReportingPage":
                                _button.Image = _reportingPage;
                                _button.BackColor = Color.White;
                                break;
                            case "ButtonSettingPage":
                                _button.Image = _settingsPage;
                                _button.BackColor = Color.White;
                                break;
                        }
                    }
                    else
                    {
                        switch (_button!.Name)
                        {
                            case "ButtonHomePage":
                                _button.Image = _homePageFilled;
                                _button.BackColor = Color.FromArgb(230, 230, 230);
                                break;
                            case "ButtonSimulationPage":
                                _button.Image = _simulationPageFilled;
                                _button.BackColor = Color.FromArgb(230, 230, 230);
                                break;
                            case "ButtonCalibrationPage":
                                _button.Image = _calibrationPageFilled;
                                _button.BackColor = Color.FromArgb(230, 230, 230);
                                break;
                            case "ButtonMailPage":
                                _button.Image = _mailPageFilled;
                                _button.BackColor = Color.FromArgb(230, 230, 230);
                                break;
                            case "ButtonReportingPage":
                                _button.Image = _reportingPageFilled;
                                _button.BackColor = Color.FromArgb(230, 230, 230);
                                break;
                            case "ButtonSettingPage":
                                _button.Image = _settingsPageFilled;
                                _button.BackColor = Color.FromArgb(230, 230, 230);
                                break;
                        }
                    }
                }
            }
        }
    }
}