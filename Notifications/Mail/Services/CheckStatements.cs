using Business.Abstract;
using Entities.Concrete;
using Notifications.Mail.Abstract;
using Notifications.Services.Abstract;
using PLC.Sharp7.Services;
using System.Collections.Concurrent;
using System.ComponentModel;

namespace Notifications.Mail.Services
{
    public class CheckStatements : ICheckStatements
    {
        readonly IUserMailStatementService _userMailStatementManager;
        readonly IUserService _userManager;
        readonly IMailStatementService _mailStatementManager;
        readonly ISendMail _sendMail;

        readonly Sharp7Service _sharp7Service = Sharp7Service.Instance;

        readonly List<UserMailStatement> userMailStatements;
        public ConcurrentBag<MailStatement> mailStatements;

        public bool IsMailSent = false;

        public CheckStatements(IUserService userManager, IUserMailStatementService userMailStatementManager, IMailStatementService mailStatementManager, ISendMail sendMail)
        {
            _sendMail = sendMail;
            _userManager = userManager;
            _userMailStatementManager = userMailStatementManager;
            _mailStatementManager = mailStatementManager;

            mailStatements = new ConcurrentBag<MailStatement>(_mailStatementManager.GetAll().Data);
            userMailStatements = _userMailStatementManager.GetAll().Data.ToList();

            foreach (var item in mailStatements)
            {
                item.CoolDown = new TimeSpan(0, 0, 15);
            }
        }

        public void Check()
        {
            var bgw = new BackgroundWorker();
            bgw.DoWork += delegate
            {
                CoolDownCountdown();

                //MemoryByte'lar PLC'den geldi mi?
                if (_sharp7Service.S71200.MBTags != null)
                {
                    //Tesis Otomatik Modda mı?
                    if (_sharp7Service.S71200.MBTags.ModAutoMu == true)
                    {
                        //Mail Durumları döngüsü
                        for (int i = 0; i < mailStatements.Count; i++) //foreach (var mailStatementDTO in mailStatementDTOs)
                        {
                            var array = mailStatements.OrderBy(x => x.Id).ToArray();
                            //Seçili mail durumunun soğuma süresi 0 mı?
                            if (array[i].CoolDown == new TimeSpan(0, 0, 0))
                            {
                                //Seçili mail durumunun kullanıcı durumlarında tanımlı olup olmadığının karşılaştırılma döngüsü
                                for (int ii = 0; ii < userMailStatements.Count; ii++) //foreach (var userMailStatements in userMailStatementsDTOs)
                                {
                                    //Seçili mail durumu kullanıcı durumunda tanımlı mı?
                                    if (array[i].Id == userMailStatements[ii].MailStatementId)
                                    {
                                        //Tanımlı ise ilgili kullanıcının bilgilerini getir
                                        var user = _userManager.Get(x => x.Id == userMailStatements[ii].UserId).Data;

                                        //Eğer mail durumu varsa (şartlar sağlanıyorsa) mail durumunun içeriğini oluştur ve gönder
                                        if (MailBodyGenerate(array[i]) != "-1")
                                        {
                                            IsMailSent = _sendMail.MailSend(user.Email, array[i].StatementName, MailBodyGenerate(array[i]));
                                        }
                                        else
                                        {
                                            IsMailSent = false;
                                        }
                                    }
                                }

                                //İşlemi bitmiş olan mail durumu eğer varsa ve gönderildiyse bekleme süresini tekrar ata
                                if (IsMailSent == true)
                                {
                                    RefreshCooldowns(i);
                                    //MessageBox.Show("ismail sent true oluyo");
                                }
                            }
                        }
                    }
                }
            };
            bgw.RunWorkerAsync();
        }

        public void CoolDownCountdown()
        {
            var bgw = new BackgroundWorker();
            bgw.DoWork += delegate
            {
                var array = mailStatements.OrderBy(x => x.Id).ToArray();

                for (int i = 0; i < mailStatements.Count; i++)
                {
                    if (array[i].CoolDown > new TimeSpan(0, 0, 0))
                    {
                        array[i].CoolDown = array[i].CoolDown.Add(new TimeSpan(0, 0, -1));
                    }
                }
            };
            bgw.RunWorkerAsync();
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

        public void RefreshCooldowns(int? indeks = null)
        {
            if (indeks != null)
            {
                var resetedCooldowns = _mailStatementManager.Get(x => x.Id == Convert.ToInt16(indeks) + 1).Data;

                var array = mailStatements.OrderBy(x => x.Id).ToArray();

                array[(int)indeks].CoolDown = new TimeSpan(resetedCooldowns.CoolDown.Hours, resetedCooldowns.CoolDown.Minutes, resetedCooldowns.CoolDown.Seconds);

                mailStatements = new ConcurrentBag<MailStatement>(array);
            }
            else
            {
                mailStatements = new ConcurrentBag<MailStatement>(_mailStatementManager.GetAll().Data);
            }
        }
    }
}
