using Core.Entities;

namespace Entities.Concrete
{
    public class MBTags : IEntity
    {
        public int Id { get; set; }
        public DateTime ReadTime { get; set; }
        public bool YikamaVarMi { get; set; }
        public bool HaftalikYikamaVarMi { get; set; }
        public bool ModAutoMu { get; set; }
        public bool ModBakimMi { get; set; }
        public bool ModKalibrasyonMu { get; set; }
        public bool AkmTetik { get; set; }
        public bool KoiTetik { get; set; }
        public bool PhTetik { get; set; }
    }
}
