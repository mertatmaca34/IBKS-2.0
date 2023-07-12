using Core.Entities;

namespace Entities.Concrete
{
    public class DB4 : IEntity
    {
        public int Id { get; set; }
        public DateTime SystemTime { get; set; }
    }
}

