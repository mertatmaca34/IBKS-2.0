using Core.Entities;

namespace Entities.Concrete
{
    public class DB12 : IEntity
    {
        public int Id { get; set; }
        public byte HaftaGunu { get; set; }
        public byte HaftaGunuSaat { get; set; }
        public byte HaftaGunuDakika { get; set; }
        public byte GunlukYikamaSaat { get; set; }
        public byte GunlukYikamaDakika { get; set; }
    }
}
