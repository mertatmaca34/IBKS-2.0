using Core.Entities;

namespace Entities.Concrete
{
    public class Plc : IEntity
    {
        public int Id { get; set; }
        public required string IpAdress { get; set; }
    }
}
