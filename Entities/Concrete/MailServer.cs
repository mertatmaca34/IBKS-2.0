using Core.Entities;

namespace Entities.Concrete
{
    public class MailServer : IEntity
    {
        public int Id { get; set; }
        public bool UseSSL { get; set; }
        public required string Host { get; set; }
        public int Port { get; set; }
        public required string UserName { get; set; }
        public required string Password { get; set; }
        public bool UseDefaultCredentials { get; set; }
    }
}
