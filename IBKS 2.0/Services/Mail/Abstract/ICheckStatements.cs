using Entities.Concrete;

namespace IBKS_2._0.Services.Mail.Abstract
{
    public interface ICheckStatements
    {
        public void RefreshCooldowns(int? indeks = null);
        public void Check();
        public void CoolDownCountdown();
        public string MailBodyGenerate(MailStatement mailStatement);
    }
}
