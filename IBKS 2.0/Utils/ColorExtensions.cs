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
    }
}
