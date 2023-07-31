using PLC.Sharp7.Helpers;

namespace IBKS_2._0.Utils
{
    public static class TextExtensions
    {
        public static string FromStatus() => GetSystemStatus.GetStatus() == 1 ? "Otomatik Mod"
                 : GetSystemStatus.GetStatus() == 23 ? "Yıkama"
                 : GetSystemStatus.GetStatus() == 24 ? "Haftalık Yıkama"
                 : GetSystemStatus.GetStatus() == 25 ? "Sistem Bakım"
                 : GetSystemStatus.GetStatus() == 9 ? "Sistem Kalibrasyon"
                 : GetSystemStatus.GetStatus() == 0 ? "Veri Göndermiyor"
                 : "Sistem çalışmıyor";
    }
}