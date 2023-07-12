namespace IBKS_2._0.Utils
{
    public static class ColorExtensions
    {
        public static Color FromBoolean(bool value)
        {
            return value ? Color.Red : Color.PaleGreen;
        }
        public static Color FromDouble(double value)
        {
            return value > 0 ? Color.PaleGreen : Color.Red;
        }
        public static Color FromDouble(double value, double limit)
        {
            return (value > 0 && value < limit) ? Color.PaleGreen : Color.Red;
        }
        public static Color FromDouble(double value, double lowerLimit, double upperLimit)
        {
            return (value > lowerLimit && value < upperLimit) ? Color.PaleGreen : Color.Red;
        }
    }
}
