using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using Entities.Concrete;
using ibks.Services.Mail.Abstract;
using ibks.Utils;
using PLC.Sharp7.Services;

namespace ibks.Services.Mail.Services
{
    public class CheckStatements : ICheckStatements
    {
        readonly IUserMailStatementService _userMailStatementManager;
        readonly IUserService _userManager;
        readonly IMailStatementService _mailStatementManager;
        readonly ISendMail _sendMail;

        readonly Sharp7Service _sharp7Service = Sharp7Service.Instance;

        readonly List<UserMailStatement> userMailStatements;

        public List<MailStatement> defaultMailStatements;
        public List<MailStatement> mailStatements;

        private readonly Dictionary<int, DateTime> lastSentTimes = new Dictionary<int, DateTime>();

        public CheckStatements(IUserService userManager, IUserMailStatementService userMailStatementManager, IMailStatementService mailStatementManager, ISendMail sendMail)
        {
            _sendMail = sendMail;
            _userManager = userManager;
            _userMailStatementManager = userMailStatementManager;
            _mailStatementManager = mailStatementManager;

            defaultMailStatements = new List<MailStatement>(_mailStatementManager.GetAll().Data);
            mailStatements = new List<MailStatement>(_mailStatementManager.GetAll().Data);

            userMailStatements = _userMailStatementManager.GetAll().Data.ToList();
        }

        public async Task Check()
        {
            if (_sharp7Service.S71200.DB42 != null && _sharp7Service.S71200.DB42.Kabin_Oto == true)
            {
                foreach (var mailStatement in mailStatements)
                {
                    if (CanSendMail(mailStatement.Id))
                    {
                        foreach (var userMailStatement in userMailStatements)
                        {
                            if (userMailStatement.MailStatementId == mailStatement.Id)
                            {
                                var user = _userManager.Get(x => x.Id == userMailStatement.UserId).Data;

                                string mailBody = MailBodyGenerate(mailStatement);

                                if (mailBody != "-1")
                                {
                                    mailStatement.CoolDown = defaultMailStatements.FirstOrDefault(x => x.Id == mailStatement.Id)?.CoolDown ?? TimeSpan.Zero;
                                    lastSentTimes[mailStatement.Id] = DateTime.Now;


                                    TempLog.Write(DateTime.Now + ": Mail Durumu Oluştu.");

                                    var res = await _sendMail.MailSend(user.Email, mailStatement.StatementName, mailBody);

                                    if(res)
                                        TempLog.Write(DateTime.Now + ": Mail Gönderildi");
                                }
                            }
                        }
                    }
                }
            }
        }

        private bool CanSendMail(int mailStatementId)
        {
            if (!lastSentTimes.ContainsKey(mailStatementId))
            {
                lastSentTimes.Add(mailStatementId, DateTime.MinValue);
                return true;
            }

            var lastSentTime = lastSentTimes[mailStatementId];
            var cooldownTime = defaultMailStatements.FirstOrDefault(x => x.Id == mailStatementId)?.CoolDown ?? TimeSpan.Zero;

            bool isItFirst = DateTime.Now - lastSentTime > new TimeSpan(0, 19, 0);
            bool canSend = DateTime.Now - lastSentTime > cooldownTime;


            if (isItFirst && canSend)
            {
                return false;
            }
            else if (!isItFirst && canSend)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public string MailBodyGenerate(MailStatement mailStatement)
        {
            if (mailStatement.Parameter == "VeriGecerliligi")
            {
                if (DateTime.Now - StaticInstantData.ReadTime < new TimeSpan(0, 2, 0, 0))
                {
                    string message = StaticInstantData.AKM_N_Status switch
                    {
                        200 => mailStatement.Content + $" Eksik veya Geçersiz Yıkama bilgisi.",
                        201 => mailStatement.Content + $" Eksik veya Geçersiz Haftalık Yıkama bilgisi.",
                        202 => mailStatement.Content + $" Eksik veya Geçersiz Aylık Kalibrasyon bilgisi.",
                        203 => mailStatement.Content + $" Geçersiz Akış Hızı değeri.",
                        204 => mailStatement.Content + $" Geçersiz Debi Değeri.",
                        205 => mailStatement.Content + $" Ard ardına tekrar eden mükerrer veri.",
                        206 => mailStatement.Content + $" Uygun olmayan birim ile ölçüm yapılamaz.",
                        _ => "-1",
                    };
                    return message;
                }
            }

            if (mailStatement.Statement == "Limit Aşımı")
            {
                var propertyInfo = _sharp7Service.S71200.DB41.GetType().GetProperty(mailStatement.Parameter);
                if (propertyInfo == null)
                {
                    return "-1";
                }

                var value = Convert.ToDouble(propertyInfo.GetValue(_sharp7Service.S71200.DB41));
                if (value > mailStatement.LowerLimit && value < mailStatement.UpperLimit)
                {
                    return "-1";
                }

                return mailStatement.Content;

            }

            object tagsDTO = null;

            /*if (_sharp7Service.S71200.MBTags.GetType().GetProperty(mailStatement.Parameter) != null)
            {
                tagsDTO = _sharp7Service.S71200.MBTags;
            }
            else if (_sharp7Service.S71200.InputTags.GetType().GetProperty(mailStatement.Parameter) != null)
            {
                tagsDTO = _sharp7Service.S71200.InputTags;
            }

            var propertyInfo2 = tagsDTO?.GetType().GetProperty(mailStatement.Parameter);
            if (propertyInfo2 == null)
            {
                return "-1";
            }

            var value2 = Convert.ToBoolean(propertyInfo2.GetValue(tagsDTO));
            if (mailStatement.Statement == "Varsa" && value2 || mailStatement.Statement == "Yoksa" && !value2)
            {
                return mailStatement.Content;
            }*/

            
            return "-1";
        }
    }
}
