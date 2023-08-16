using Business.Abstract;
using IBKS_2._0.Services.Mail.Abstract;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;

namespace IBKS_2._0.Services.Mail.Services
{
    public class SendMail : ISendMail
    {
        readonly IMailServerService _mailServerService;

        public SendMail(IMailServerService mailServerService)
        {
            _mailServerService = mailServerService;
        }
        public bool MailSend(string mailName, string subject, string body)
        {
            var settings = _mailServerService.Get().Data;

            if (settings != null)
            {
                var backgroundWorker = new BackgroundWorker();
                backgroundWorker.DoWork += delegate
                {
                    SmtpClient smtpClient = new SmtpClient
                    {
                        EnableSsl = settings.UseSSL,
                        Port = Convert.ToInt16(settings.Port),
                        Host = settings.Host,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = settings.UseDefaultCredentials,
                        Credentials = new NetworkCredential(settings.UserName, settings.Password)
                    };
                    MailMessage mailMessage = new()
                    {
                        From = new MailAddress(settings.UserName),
                        Subject = subject,
                        Body = body,
                        IsBodyHtml = true
                    };

                    mailMessage.To.Add(mailName);

                    smtpClient.Send(mailMessage);
                };
                backgroundWorker.RunWorkerAsync();

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
