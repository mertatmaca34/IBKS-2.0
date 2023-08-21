using Business.Abstract;
using Business.Concrete;
using ibks.Services.Mail.Abstract;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;

namespace ibks.Services.Mail.Services
{
    public class SendMail : ISendMail
    {
        readonly IMailServerService _mailServerService;
        readonly IStationService _stationManager;

        public SendMail(IMailServerService mailServerService, IStationService stationManager)
        {
            _mailServerService = mailServerService;
            _stationManager = stationManager;
        }
        public bool MailSend(string mailName, string subject, string body)
        {
            var settings = _mailServerService.Get().Data;

            if (settings != null)
            {
                var backgroundWorker = new BackgroundWorker();
                backgroundWorker.DoWork += delegate
                {
                    try
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

                        var stationName = _stationManager.Get().Data.StationName;

                        MailMessage mailMessage = new()
                        {
                            From = new MailAddress(settings.UserName),
                            Subject = $"{stationName} - {subject}",
                            Body = body,
                            IsBodyHtml = true
                        };

                        mailMessage.To.Add(mailName);

                        smtpClient.Send(mailMessage);
                    }
                    catch (Exception)
                    {
                        //TODO
                    }
                    
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
