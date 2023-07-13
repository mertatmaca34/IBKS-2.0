using PLC.Sharp7;

namespace PLC
{
    public static class RealTimeCalculations
    {
        readonly static Sharp7Service _sharp7Service = Sharp7Service.Instance;

        public static string ConnectionStatus()
        {
            if (_sharp7Service.client.Connected)
            {
                return "Bağlı";
            }
            else
            {
                return "Bağlı Değil";
            }
        }

        public static TimeSpan GunlukYikamayaKalan()
        {
            if (_sharp7Service.client.Connected)
            {
                var SystemTime = _sharp7Service.S71200.DB4.SystemTime;

                var systemHour = SystemTime.Hour % 6;
                var systemMinute = _sharp7Service.S71200.DB4.SystemTime.Minute;
                var systemSecond = _sharp7Service.S71200.DB4.SystemTime.Second;

                TimeSpan gunlukYikamayaKalan = new TimeSpan(systemHour, systemMinute, systemSecond);
                TimeSpan yikamaZamani = new TimeSpan(6, 0, 0);

                return yikamaZamani - gunlukYikamayaKalan;
            }
            else
            {
                return TimeSpan.Zero;
            }
        }

        public static TimeSpan HaftalikYikamayaKalan()
        {
            if (_sharp7Service.client.Connected)
            {
                var SystemTime = _sharp7Service.S71200.DB4.SystemTime;

                var day = _sharp7Service.S71200.DB12.HaftaGunu;
                var hour = _sharp7Service.S71200.DB12.HaftaGunuSaat;
                var minute = _sharp7Service.S71200.DB12.HaftaGunuDakika;

                TimeSpan haftalikYikamaZamani = new TimeSpan(-(int)day + (int)DayOfWeek.Monday, hour, minute, 0);
                TimeSpan systemTime = new TimeSpan(SystemTime.Day, SystemTime.Hour, SystemTime.Minute, SystemTime.Second);
                TimeSpan timeRemain = haftalikYikamaZamani - systemTime;

                if (timeRemain < new TimeSpan(0, 0, 0, 0))
                {
                    do
                    {
                        timeRemain = timeRemain.Add(new TimeSpan(7, 0, 0, 0));
                    } while (timeRemain < new TimeSpan(0, 0, 0, 0));

                    return timeRemain;
                }
                else
                {
                    return timeRemain;
                }
            }
            return TimeSpan.Zero;
        }
    }
}
