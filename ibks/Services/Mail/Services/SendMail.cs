using Business.Abstract;
using Core.Utilities.TempLogs;
using ibks.Services.Mail.Abstract;
using Serilog;
using Serilog.Events;
using System.Net;
using System.Net.Mail;

namespace ibks.Services.Mail.Services
{
    public class SendMail : ISendMail
    {
        private readonly IMailServerService _mailServerService;
        private readonly IStationService _stationManager;

        public SendMail(IMailServerService mailServerService, IStationService stationManager)
        {
            _mailServerService = mailServerService;
            _stationManager = stationManager;
        }

        public async Task<bool> MailSend(string mailName, string subject, string body)
        {
            var settings = _mailServerService.Get().Data;

            var stationName = _stationManager.Get().Data.StationName;

            if (settings?.Host == null) return false;

            SmtpClient smtpClient = new()
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
                Subject = $"{stationName} - {subject}",
                Body = body,
                IsBodyHtml = true
            };

            mailMessage.To.Add(mailName);

            try
            {
                await smtpClient.SendMailAsync(mailMessage);

                return true;
            }
            catch (Exception ex)
            {
                Log.Write(LogEventLevel.Error, DateTime.Now + ": Mail Gönderilemedi Detay: " + ex.Message);

                return false;
            }
        }
    }
}
