using Entities.Concrete;

namespace ibks.Services.Mail.Abstract
{
    public interface ICheckStatements
    {
        public void RefreshCooldowns(int? indeks = null);
        public void Check();
        public void CoolDownCountdown();
        public string MailBodyGenerate(MailStatement mailStatement);
    }
}
