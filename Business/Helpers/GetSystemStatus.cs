using PLC.Sharp7;

namespace Business.Helpers
{
    public static class GetSystemStatus
    {
        readonly static Sharp7Service _sharp7Service = Sharp7Service.Instance;

        public static int GetStatus()
        {
            return _sharp7Service.S71200.MBTags.YikamaVarMi ? 23
            : _sharp7Service.S71200.MBTags.HaftalikYikamaVarMi ? 24
            : _sharp7Service.S71200.MBTags.ModAutoMu ? 1
            : _sharp7Service.S71200.MBTags.ModBakimMi ? 25
            : _sharp7Service.S71200.MBTags.ModKalibrasyonMu ? 9
            : 0;
        }
    }
}
