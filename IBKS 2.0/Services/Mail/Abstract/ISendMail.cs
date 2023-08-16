namespace IBKS_2._0.Services.Mail.Abstract
{
    public interface ISendMail
    {
        public bool MailSend(string mailName, string subject, string body);
    }
}
