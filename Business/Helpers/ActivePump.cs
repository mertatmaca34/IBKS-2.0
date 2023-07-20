using PLC.Sharp7;

namespace Business.Helpers
{
    public static class ActivePump
    {
        private static readonly Sharp7Service _sharp7Service = Sharp7Service.Instance;

        public static string Frekans
        {
            get
            {
                if(_sharp7Service.S71200.DB41.Pompa1Hz > 0)
                {
                    return $"{_sharp7Service.S71200.DB41.Pompa1Hz} Hz";
                }
                else if (_sharp7Service.S71200.DB41.Pompa2Hz > 0)
                {
                    return $"{_sharp7Service.S71200.DB41.Pompa2Hz} Hz";
                }
                else
                {
                    return "-";
                }
            }
        }
        public static string Pump
        {
            get
            {
                if(_sharp7Service.S71200.DB41.Pompa1Hz > 0)
                {
                    return "POMPA 1";
                }
                else if (_sharp7Service.S71200.DB41.Pompa2Hz > 0)
                {
                    return "POMPA 2";
                }
                else
                {
                    return "YOK";
                }
            }
        }
    }
}
