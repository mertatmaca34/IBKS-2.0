using Core.Entities;

namespace Entities.Concrete
{
    public class MailServer : IEntity
    {
        public int Id { get; set; }
        public bool UseSSL { get; set; }
        public  string Host { get; set; }
        public int Port { get; set; }
        public  string UserName { get; set; }
        public  string Password { get; set; }
        public bool UseDefaultCredentials { get; set; }
    }
}
