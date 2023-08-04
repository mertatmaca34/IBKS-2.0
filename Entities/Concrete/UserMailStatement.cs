using Core.Entities;

namespace Entities.Concrete
{
    public class UserMailStatement : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MailStatementId { get; set; }
    }
}
