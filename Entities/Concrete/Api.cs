using Core.Entities;

namespace Entities.Concrete
{
    public class Api : IEntity
    {
        public int Id { get; set; }
        public required string ApiAdress { get; set; }
        public required string UserName { get; set; }
        public required string Password { get; set; }
    }
}
