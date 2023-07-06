using Core.Entities;

namespace Entities.Concrete
{
    public class Api : IEntity
    {
        public int Id { get; set; }
        public  string ApiAdress { get; set; }
        public  string UserName { get; set; }
        public  string Password { get; set; }
    }
}
