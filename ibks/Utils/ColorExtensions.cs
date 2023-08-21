using Business.Constants;
using PLC.Sharp7.Helpers;
using PLC.Sharp7.Services;

namespace ibks.Utils
{
    public static class ColorExtensions
    {
        readonly static Sharp7Service _sharp7Service = Sharp7Service.Instance;

        private readonly static Color _simGreen = Color.FromArgb(19, 162, 97);
        private readonly static Color _simRed = Color.FromArgb(235, 85, 101);

        public static Color FromBoolean(bool value)
        {
            return IsPlcConnected() ? (value ? _simRed : _simGreen) : Color.Gray;
        }

        public static Color FromDouble(double value)
        {
            return IsPlcConnected() ? (value > 0 ? _simGreen : _simRed) : Color.Gray;
        }

        public static Color FromDouble(double value, double limit)
        {
            return IsPlcConnected() ? ((value > 0 && value < limit) ? _simGreen : _simRed) : Color.Gray;
        }

        public static Color FromDouble(double value, double lowerLimit, double upperLimit)
        {
            return IsPlcConnected() ? ((value > lowerLimit && value < upperLimit) ? _simGreen : _simRed) : Color.Gray;
        }

        public static bool IsPlcConnected()
        {
            return _sharp7Service.client?.Connected == true;
        }

        public static Color FromStatus() => GetSystemStatus.GetStatus() == 1 ? _simGreen
                 : GetSystemStatus.GetStatus() == 23 ? _simGreen
                 : GetSystemStatus.GetStatus() == 24 ? _simGreen
                 : GetSystemStatus.GetStatus() == 25 ? _simRed
                 : GetSystemStatus.GetStatus() == 9 ? _simRed
                 : GetSystemStatus.GetStatus() == 0 ? _simRed
                 : _simRed;

        public static Color FromStatusText() => GetSystemStatus.GetStatus() == 1 ? Color.White
                 : GetSystemStatus.GetStatus() == 23 ? Color.White
                 : GetSystemStatus.GetStatus() == 24 ? Color.White
                 : GetSystemStatus.GetStatus() == 25 ? Color.White
                 : GetSystemStatus.GetStatus() == 9 ? Color.White
                 : GetSystemStatus.GetStatus() == 0 ? Color.White
                 : Color.White;

        public static void FromDataGridViewData(DataGridView dataGridView, int index)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataGridViewCell statusCell = row.Cells[index];

                string status = (string)statusCell.Value;

                row.DefaultCellStyle.BackColor = status switch
                {
                    "1" => Color.White,
                    "4" => SimRed(row),
                    "9" => SimRed(row),
                    "23" => SimGreen(row),
                    "24" => SimGreen(row),
                    _ => Color.White
                };

                string valueToAssign = status switch
                {
                    "1" => "Geçerli",
                    "4" => "Geçersiz",
                    "9" => "Kalibrasyon",
                    "23" => "Yıkama",
                    "24" => "H. Yıkama",
                    _ => "Geçerli"
                };

                row.Cells[index].Value = valueToAssign;
            }
        }

        private static Color SimGreen(DataGridViewRow row)
        {
            row.DefaultCellStyle.ForeColor = Color.White;
            return Color.FromArgb(19, 162, 97);
        }
        private static Color SimRed(DataGridViewRow row)
        {
            row.DefaultCellStyle.ForeColor = Color.White;
            return Color.FromArgb(237, 85, 101);
        }
        public static void ChangeTheme(Control.ControlCollection container)
        {
            foreach (Control component in container)
            {
                if (component is Panel)
                {
                    ChangeTheme(component.Controls);
                    component.BackColor = ColorScheme.PanelBgDark;
                    component.ForeColor = ColorScheme.PanelFgDark;
                }
                else if (component is Button)
                {
                    component.BackColor = ColorScheme.ButtonBgDark;
                    component.ForeColor = ColorScheme.ButtonFgDark;
                }
                else if (component is TextBox)
                {
                    //component.BackColor = ColorScheme.TextBoxBG;
                    //component.ForeColor = ColorScheme.TextBoxFG;
                }
            }
        }
    }
}
