using Business.Abstract;
using Entities.Concrete;
using ibks.Services.Mail.Abstract;
using PLC.Sharp7.Services;
using System.ComponentModel;

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

        public bool IsMailSent = false;

        public CheckStatements(IUserService userManager, IUserMailStatementService userMailStatementManager, IMailStatementService mailStatementManager, ISendMail sendMail)
        {
            _sendMail = sendMail;
            _userManager = userManager;
            _userMailStatementManager = userMailStatementManager;
            _mailStatementManager = mailStatementManager;

            defaultMailStatements = new List<MailStatement>(_mailStatementManager.GetAll().Data);
            mailStatements = new List<MailStatement>(_mailStatementManager.GetAll().Data);

            userMailStatements = _userMailStatementManager.GetAll().Data.ToList();

            foreach (var item in mailStatements)
            {
                item.CoolDown = new TimeSpan(0, 0, 5);
            }
        }

        public async Task Check()
        {
            CoolDownCountdown();

            if (_sharp7Service.S71200.MBTags != null && _sharp7Service.S71200.MBTags.ModAutoMu == true)
            {
                foreach (var mailStatement in mailStatements)
                {
                    if (mailStatement.CoolDown == new TimeSpan(0, 0, 0))
                    {
                        foreach (var userMailStatement in userMailStatements)
                        {
                            if (userMailStatement.MailStatementId == mailStatement.Id)
                            {
                                var user = _userManager.Get(x => x.Id == userMailStatement.UserId).Data;

                                string mailBody = MailBodyGenerate(mailStatement);

                                if (mailBody != "-1")
                                {
                                    mailStatement.CoolDown = defaultMailStatements.Where(x => x.Id == mailStatement.Id).FirstOrDefault()!.CoolDown;

                                    var res = await _sendMail.MailSend(user.Email, mailStatement.StatementName, mailBody);
                                }
                            }
                        }
                    }
                }
            }
        }

        /*public void Check()
        {
            if (!_checkStatementsWorker.IsBusy)
            {
                CoolDownCountdown();

                _checkStatementsWorker.DoWork += delegate
                {
                    //MemoryByte'lar PLC'den geldi mi?
                    if (_sharp7Service.S71200.MBTags != null && _sharp7Service.S71200.MBTags.ModAutoMu == true)
                    {
                        //Mail Durumları döngüsü
                        for (int i = 0; i < mailStatements.Count; i++)
                        {
                            //Seçili mail durumunun soğuma süresi 0 mı?
                            if (mailStatements[i].CoolDown == new TimeSpan(0, 0, 0))
                            {
                                //Seçili mail durumunun kullanıcı durumlarında tanımlı olup olmadığının karşılaştırılma döngüsü
                                for (int ii = 0; ii < userMailStatements.Count; ii++) //foreach (var userMailStatements in userMailStatementsDTOs)
                                {
                                    //Seçili mail durumu kullanıcı durumunda tanımlı mı?
                                    if (mailStatements[i].Id == userMailStatements[ii].MailStatementId)
                                    {
                                        //Tanımlı ise ilgili kullanıcının bilgilerini getir
                                        var user = _userManager.Get(x => x.Id == userMailStatements[ii].UserId).Data;
                                        
                                        //Eğer mail durumu varsa (şartlar sağlanıyorsa) mail durumunun içeriğini oluştur ve gönder
                                        if (MailBodyGenerate(mailStatements[i]) != "-1")
                                        {
                                            //var res = await _sendMail.MailSend(user.Email, mailStatements[i].StatementName, MailBodyGenerate(mailStatements[i]));
                                        
                                            RefreshCooldowns(mailStatements[i].Id);
                                        }
                                        else
                                        {
                                            //TODO
                                        }
                                    }
                                }
                            }
                        }
                    }
                };
                _checkStatementsWorker.RunWorkerAsync();
            }
        }*/

        public void CoolDownCountdown()
        {
            foreach (var item in mailStatements)
            {
                if (item.CoolDown > new TimeSpan(0, 0, 0))
                    item.CoolDown = item.CoolDown.Add(new TimeSpan(0, 0, -1));
            }
        }

        public string MailBodyGenerate(MailStatement mailStatement)
        {
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

                return $"{mailStatement.Parameter} Limit Aşımı! Değer belirlenen aralıklarda değil: {mailStatement.LowerLimit} - {mailStatement.UpperLimit}\n Değer: {value}";
            }

            object tagsDTO = null;

            if (_sharp7Service.S71200.MBTags.GetType().GetProperty(mailStatement.Parameter) != null)
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
                return $"{mailStatement.Parameter} {mailStatement.Statement.Remove(mailStatement.Statement.Length - 2)}!";
            }

            return "-1";
        }
    }
}
