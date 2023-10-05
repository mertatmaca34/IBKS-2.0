namespace ibks.Services.Mail.Abstract
{
    public interface ISendMail
    {
        public Task<bool> MailSend(string mailName, string subject, string body);
    }
}
