namespace Notifications.Mail.Abstract
{
    public interface ISendMail
    {
        public bool MailSend(string mailName, string subject, string body);
    }
}
