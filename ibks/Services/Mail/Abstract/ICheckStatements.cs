using Entities.Concrete;

namespace ibks.Services.Mail.Abstract
{
    public interface ICheckStatements
    {
        public Task Check();
        public string MailBodyGenerate(MailStatement mailStatement);
    }
}
