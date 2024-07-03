using PLC.Sharp7.Services;

namespace PLC
{
    public static class RealTimeCalculations
    {
        readonly static Sharp7Service _sharp7Service = Sharp7Service.Instance;

        public static string ConnectionStatus()
        {
            if (_sharp7Service.client?.Connected == true)
            {
                return "Bağlı";
            }
            else
            {
                return "Bağlı Değil";
            }
        }
    }
}
