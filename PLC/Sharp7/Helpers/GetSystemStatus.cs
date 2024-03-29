using PLC.Sharp7.Services;

namespace PLC.Sharp7.Helpers
{
    public static class GetSystemStatus
    {
        readonly static Sharp7Service _sharp7Service = Sharp7Service.Instance;

        public static int GetStatus()
        {
            return _sharp7Service.S71200.DB42.Kabin_SaatlikYikamada ? 23
            : _sharp7Service.S71200.DB42.Kabin_HaftalikYikamada ? 24
            : _sharp7Service.S71200.DB42.Kabin_Oto ? 1
            : _sharp7Service.S71200.DB42.Kabin_Bakim ? 25
            : _sharp7Service.S71200.DB42.Kabin_Kalibrasyon ? 9
            : 0;
        }
    }
}
