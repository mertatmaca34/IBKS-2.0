using PLC.Sharp7.Helpers;
using PLC.Sharp7.Services;

namespace IBKS_2._0.Utils
{
    public static class ColorExtensions
    {
        readonly static Sharp7Service _sharp7Service = Sharp7Service.Instance;

        private readonly static Color _simGreen = Color.FromArgb(19,162,97);
        private readonly static Color _simRed = Color.FromArgb(235,85,101);

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
    }
}
