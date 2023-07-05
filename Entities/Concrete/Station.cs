using Core.Entities;

namespace Entities.Concrete
{
    public class Station : IEntity
    {
        public int Id { get; set; }
        public required string StationName { get; set; }
        public Guid StationId { get; set; }
    }
}
