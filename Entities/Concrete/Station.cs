using Core.Entities;

namespace Entities.Concrete
{
    public class Station : IEntity
    {
        public int Id { get; set; }
        public string StationName { get; set; }
        public Guid StationId { get; set; }
    }
}
