using Business.Helpers;
using PLC.Sharp7;

namespace IBKS_2._0.Utils
{
    public static class ColorExtensions
    {
        readonly static Sharp7Service _sharp7Service = Sharp7Service.Instance;

        public static Color FromBoolean(bool value)
        {
            return IsPlcConnected() ? (value ? Color.Red : Color.PaleGreen) : Color.Gray;
        }

        public static Color FromDouble(double value)
        {
            return IsPlcConnected() ? (value > 0 ? Color.PaleGreen : Color.Red) : Color.Gray;
        }

        public static Color FromDouble(double value, double limit)
        {
            return IsPlcConnected() ? ((value > 0 && value < limit) ? Color.PaleGreen : Color.Red) : Color.Gray;
        }

        public static Color FromDouble(double value, double lowerLimit, double upperLimit)
        {
            return IsPlcConnected() ? ((value > lowerLimit && value < upperLimit) ? Color.PaleGreen : Color.Red) : Color.Gray;
        }

        public static bool IsPlcConnected()
        {
            return _sharp7Service.client?.Connected == true;
        }

        public static Color FromStatus()
        {
            return GetSystemStatus.GetStatus() == 1 ? Color.PaleGreen
                 : GetSystemStatus.GetStatus() == 23 ? Color.PaleGreen
                 : GetSystemStatus.GetStatus() == 24 ? Color.PaleGreen
                 : GetSystemStatus.GetStatus() == 25 ? Color.Red
                 : GetSystemStatus.GetStatus() == 9 ? Color.Red
                 : GetSystemStatus.GetStatus() == 0 ? Color.Red
                 : Color.Red;
        }

        public static Color FromStatusText()
        {
            return GetSystemStatus.GetStatus() == 1 ? Color.Black
                 : GetSystemStatus.GetStatus() == 23 ? Color.Black
                 : GetSystemStatus.GetStatus() == 24 ? Color.Black
                 : GetSystemStatus.GetStatus() == 25 ? Color.White
                 : GetSystemStatus.GetStatus() == 9 ? Color.White
                 : GetSystemStatus.GetStatus() == 0 ? Color.White
                 : Color.White;
        }
    }
}
