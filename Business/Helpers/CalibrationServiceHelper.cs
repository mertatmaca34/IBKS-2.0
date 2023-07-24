namespace Business.Helpers
{
    public static class CalibrationServiceHelper
    {
        public static double CalculateStd(List<double> measurementValues)
        {
            double sum = 0;
            double mean;
            double stdDev = 0;

            if (measurementValues.Count > 1)
            {
                // verilerin ortalaması hesaplanır
                for (int i = 0; i < measurementValues.Count; i++)
                {
                    sum += measurementValues[i];
                }
                mean = sum / measurementValues.Count;

                // standart sapma hesaplanır
                for (int i = 0; i < measurementValues.Count; i++)
                {
                    stdDev += Math.Pow(measurementValues[i] - mean, 2);
                }
                stdDev = Math.Sqrt(stdDev / (measurementValues.Count - 1));

                return stdDev;
            }
            else
            {
                return stdDev;
            }
        }
    }
}