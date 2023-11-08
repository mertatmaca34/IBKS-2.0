using Business.Abstract;
using Business.Helpers.Mail;
using Entities.Concrete;

namespace ibks.Forms.Pages.Mail
{
    public partial class MailStatementsEditPage : Form
    {
        List<CooldownItem> _comboBoxCooldownItems;
        List<ParameterItem> _comboBoxParameterItems;

        TimeSpan _coolDown;
        string? _parameter;

        readonly IMailStatementService _mailStatementManager;
        readonly IUserMailStatementService _userMailStatementManager;

        public MailStatementsEditPage(IMailStatementService mailStatementManager, IUserMailStatementService userMailStatementManager)
        {
            InitializeComponent();

            _mailStatementManager = mailStatementManager;
            _userMailStatementManager = userMailStatementManager;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            MailStatement mailStatement = new()
            {
                Parameter = _parameter!,
                Statement = ComboBoxStatement.Text,
                StatementName = TextBoxMailSubject.Text,
                CoolDown = _coolDown,
                Content = TextBoxMailContent.Text,
            };

            if (TableLayoutPanelLimits.Enabled)
            {
                mailStatement.LowerLimit = Convert.ToDouble(TextBoxLowerLimit.Text);
                mailStatement.UpperLimit = Convert.ToDouble(TextBoxUpperLimit.Text);

                var res = _mailStatementManager.Add(mailStatement);

                MessageBox.Show(res.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var res = _mailStatementManager.Add(mailStatement);

                MessageBox.Show(res.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            AssignDataGridView();
        }

        private void ComboBoxStatement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxStatement.Text == "Limit Aşımı")
                TableLayoutPanelLimits.Enabled = true;
            else
                TableLayoutPanelLimits.Enabled = false;
        }

        private void MailStatementsEditPage_Load(object sender, EventArgs e)
        {
            AssignCooldownComboBoxItems();
            AssignParameterComboBoxItems();

            AssignDataGridView();

            if (DataGridViewStatements.Rows.Count < 1)
                SetDefaultStatements();
        }

        private void AssignDataGridView()
        {
            var data = _mailStatementManager.GetAll();

            if (data.Data.Count > 0)
            {
                DataGridViewStatements.DataSource = data.Data;

                DataGridViewStatements.Columns[0].Visible = false;

                DataGridViewStatements.Columns[1].HeaderText = "Konu Başlığı";
                DataGridViewStatements.Columns[2].HeaderText = "Parametre";
                DataGridViewStatements.Columns[3].HeaderText = "Durum";
                DataGridViewStatements.Columns[4].HeaderText = "Alt Limit";
                DataGridViewStatements.Columns[5].HeaderText = "Üst Limit";
                DataGridViewStatements.Columns[6].HeaderText = "Soğuma Süresi";
                DataGridViewStatements.Columns[7].HeaderText = "Mail İçeriği";
            }

            DataGridViewStatements.Refresh();
        }


        private void AssignCooldownComboBoxItems()
        {
            _comboBoxCooldownItems = new List<CooldownItem>
            {
                new CooldownItem { DisplayText = "1 Dakika", RealValue = new TimeSpan(0,1,0) },
                new CooldownItem { DisplayText = "10 Dakika", RealValue = new TimeSpan(0,10,0) },
                new CooldownItem { DisplayText = "30 Dakika", RealValue = new TimeSpan(0,30,0) },
                new CooldownItem { DisplayText = "1 Saat", RealValue = new TimeSpan(1,0,0) },
                new CooldownItem { DisplayText = "3 Saat", RealValue = new TimeSpan(3,0,0) },
            };

            foreach (var item in _comboBoxCooldownItems)
            {
                ComboBoxCoolDown.Items.Add(item.DisplayText);
            }
        }

        private void AssignParameterComboBoxItems()
        {
            _comboBoxParameterItems = new List<ParameterItem>
            {
                new ParameterItem { DisplayText = "Tesis Debi", RealValue = "TesisDebi"},
                new ParameterItem { DisplayText = "Tesis Günlük Debi", RealValue = "TesisGünlükDebi"},
                new ParameterItem { DisplayText = "Deşarj Debi", RealValue = "DesarjDebi"},
                new ParameterItem { DisplayText = "Harici Debi", RealValue = "HariciDebi"},
                new ParameterItem { DisplayText = "Harici Debi 2", RealValue = "HariciDebi2"},
                new ParameterItem { DisplayText = "Numune Hız", RealValue = "NumuneHiz"},
                new ParameterItem { DisplayText = "Numune Debi", RealValue = "NumuneDebi"},
                new ParameterItem { DisplayText = "pH", RealValue = "Ph"},
                new ParameterItem { DisplayText = "İletkenlik", RealValue = "Iletkenlik"},
                new ParameterItem { DisplayText = "Çözünmüş Oksijen", RealValue = "CozunmusOksijen"},
                new ParameterItem { DisplayText = "Numune Sıcaklık", RealValue = "NumuneSicaklik"},
                new ParameterItem { DisplayText = "Koi", RealValue = "Koi"},
                new ParameterItem { DisplayText = "Akm", RealValue = "Akm"},
                new ParameterItem { DisplayText = "Kabin Nem", RealValue = "KabinNem"},
                new ParameterItem { DisplayText = "Kabin Sıcaklık", RealValue = "KabinSicaklik"},
                new ParameterItem { DisplayText = "Pompa 1 Hz", RealValue = "Pompa1Hz"},
                new ParameterItem { DisplayText = "Pompa 2 Hz", RealValue = "Pompa2Hz"},
                new ParameterItem { DisplayText = "Kapı", RealValue = "Kapi"},
                new ParameterItem { DisplayText = "Günlük Yıkama", RealValue = "YikamaVarmi"},
                new ParameterItem { DisplayText = "Haftalık Yıkama", RealValue = "HaftalikYikamaVarMi"},
                new ParameterItem { DisplayText = "Mod Auto Mu", RealValue = "ModAutoMu"},
                new ParameterItem { DisplayText = "Mod Bakım Mı", RealValue = "ModBakimMi"},
                new ParameterItem { DisplayText = "Mod Kalibrasyon Mu", RealValue = "ModKalibrasyonMu"},
                new ParameterItem { DisplayText = "Numune Tetik Akm", RealValue = "AkmTetik"},
                new ParameterItem { DisplayText = "Numune Tetik Koi", RealValue = "KoiTetik"},
                new ParameterItem { DisplayText = "Numune Tetik Ph", RealValue = "PhTetik"},
                new ParameterItem { DisplayText = "Duman", RealValue = "Duman"},
                new ParameterItem { DisplayText = "Su Baskını", RealValue = "SuBaskini"},
                new ParameterItem { DisplayText = "Acil Stop", RealValue = "AcilStop"},
                new ParameterItem { DisplayText = "Pompa 1 Termik", RealValue = "Pompa1Termik"},
                new ParameterItem { DisplayText = "Pompa 2 Termik", RealValue = "Pompa2Termik"},
                new ParameterItem { DisplayText = "Temiz Su Pompası Termik", RealValue = "TemizSuTermik"},
                new ParameterItem { DisplayText = "Yıkama Tankı", RealValue = "YikamaTanki"},
                new ParameterItem { DisplayText = "Enerji", RealValue = "Enerji"},
                new ParameterItem { DisplayText = "Pompa 1 Çalışıyor Mu", RealValue = "Pompa1CalisiyorMu"},
                new ParameterItem { DisplayText = "Pompa 2 Çalışıyor Mu", RealValue = "Pompa2CalisiyorMu"},
            };

            foreach (var item in _comboBoxParameterItems)
            {
                ComboBoxParameter.Items.Add(item.DisplayText);
            }
        }

        private void ComboBoxCoolDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ComboBoxCoolDown.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < _comboBoxCooldownItems?.Count)
            {
                _coolDown = _comboBoxCooldownItems[selectedIndex].RealValue;
            }
        }

        private void ComboBoxParameter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _parameter = _comboBoxParameterItems!.Where(x => x.DisplayText == ComboBoxParameter.Text).FirstOrDefault()!.RealValue;
        }

        private void DuzenleToolStipMenuItem_Click(object sender, EventArgs e)
        {
            if (DataGridViewStatements.SelectedRows.Count > 0)
            {
                var row = DataGridViewStatements.SelectedRows[0];

                TextBoxMailSubject.Text = row.Cells[1].Value.ToString();
                ComboBoxParameter.Text = _comboBoxParameterItems.Where(x => x.RealValue == row.Cells[2].Value.ToString()).FirstOrDefault()!.DisplayText;
                ComboBoxStatement.Text = row.Cells[3].Value.ToString();
                ComboBoxCoolDown.Text = _comboBoxCooldownItems.Where(x => x.RealValue == (TimeSpan)row.Cells[6].Value).FirstOrDefault()!.DisplayText;
                TextBoxMailContent.Text = row.Cells[7].Value.ToString();

                if (row.Cells[3].Value.ToString() == "Limit Aşımı")
                {
                    TextBoxLowerLimit.Text = row.Cells[4].Value.ToString();
                    TextBoxUpperLimit.Text = row.Cells[5].Value.ToString();
                }
                else
                {
                    TextBoxLowerLimit.Text = "Alt Limit";
                    TextBoxUpperLimit.Text = "Üst Limit";
                }
            }
        }

        private void SilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataGridViewStatements.SelectedRows.Count > 0)
            {
                var row = DataGridViewStatements.SelectedRows[0];

                _userMailStatementManager.Delete(new UserMailStatement { MailStatementId = Convert.ToInt16(row.Cells[0].Value) });

                MailStatement mailStatement = new()
                {
                    Id = Convert.ToInt16(row.Cells[0].Value),
                    StatementName = row.Cells[1].Value.ToString()!,
                    Parameter = row.Cells[2].Value.ToString()!,
                    Statement = row.Cells[3].Value.ToString()!,
                    LowerLimit = Convert.ToInt16(row.Cells[4].Value),
                    UpperLimit = Convert.ToInt16(row.Cells[5].Value),
                    CoolDown = (TimeSpan)row.Cells[6].Value,
                    Content = row.Cells[7].Value.ToString()!,
                };

                var res = _mailStatementManager.Delete(mailStatement);

                MessageBox.Show(res.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AssignDataGridView();
            }
        }

        private void SetDefaultStatements()
        {
            TimeSpan timeSpan10Minute = new(0, 0, 600);

            List<MailStatement>? mailStatements = new()
            {
                new MailStatement { StatementName = "Akm Limit Aşımı", Parameter = "Akm", Statement = "Limit Aşımı", LowerLimit = 0, UpperLimit = 350, CoolDown = timeSpan10Minute, Content = "AKM'de anlık olarak limit değer aşıldı. Anlık Değer: " },
                new MailStatement { StatementName = "Koi Limit Aşımı", Parameter = "Koi", Statement = "Limit Aşımı", LowerLimit = 0, UpperLimit = 400, CoolDown = timeSpan10Minute, Content = "KOi'de anlık olarak limit değer aşıldı. Anlık Değer: " },
                new MailStatement { StatementName = "Çözünmüş Oksijen Limit Aşımı", Parameter = "CozunmusOksijen", Statement = "Limit Aşımı", LowerLimit = 0.5, UpperLimit = 100, CoolDown = timeSpan10Minute, Content = "Çözünmüş Oksijende'de anlık olarak limit değer aşıldı. Anlık Değer: " },
                new MailStatement { StatementName = "İletkenlik Limit Aşımı", Parameter = "Iletkenlik", Statement = "Limit Aşımı", LowerLimit = 0, UpperLimit = 9000, CoolDown = timeSpan10Minute, Content = "İletkenlik'de anlık olarak limit değer aşıldı. Anlık Değer: " },
                new MailStatement { StatementName = "Duman Alarmı", Parameter = "Duman", Statement = "Varsa", CoolDown = timeSpan10Minute, Content = "Duman Alarmı!" },
                new MailStatement { StatementName = "Su Baskını Alarmı", Parameter = "SuBaskini", Statement = "Varsa", CoolDown = timeSpan10Minute, Content = "Su Baskını Alarmı!" },
                new MailStatement { StatementName = "Acil Stop Alarmı", Parameter = "AcilStop", Statement = "Varsa", CoolDown = timeSpan10Minute, Content = "Acil Stop Alarmı!" },
                new MailStatement { StatementName = "Pompa 1 Termik Alarmı", Parameter = "Pompa1Termik", Statement = "Varsa", CoolDown = timeSpan10Minute , Content = "Pompa1 Termik Attı!"},
                new MailStatement { StatementName = "Pompa 2 Termik Alarmı", Parameter = "Pompa2Termik", Statement = "Varsa", CoolDown = timeSpan10Minute , Content = "Pompa2 Termik Attı!"},
                new MailStatement { StatementName = "Temiz Su Pompası Termik Alarmı", Parameter = "TemizSuTermik", Statement = "Varsa", CoolDown = timeSpan10Minute , Content = "Temiz Su Pompası Termik Attı!"},
                new MailStatement { StatementName = "Yıkama Tankı Alarmı", Parameter = "YikamaTanki", Statement = "Varsa", CoolDown = timeSpan10Minute , Content = "Yıkama tankında su kalmadı!"},
                new MailStatement { StatementName = "Enerji Alarmı", Parameter = "Enerji", Statement = "Varsa", CoolDown = timeSpan10Minute , Content = "Kabin enerjisi gitti!"},
                new MailStatement { StatementName = "Pompa 1 Çalışıyor Mu Alarmı", Parameter = "Pompa1CalisiyorMu", Statement = "Varsa", CoolDown = timeSpan10Minute , Content = "Pompa1 çalışıyor"},
                new MailStatement { StatementName = "Pompa 2 Çalışıyor Mu Alarmı", Parameter = "Pompa2CalisiyorMu", Statement = "Varsa", CoolDown = timeSpan10Minute , Content = "Pompa2 çalışıyor"},
                new MailStatement { StatementName = "Mod Auto Mu Alarmı", Parameter = "ModAutoMu", Statement = "Varsa", CoolDown = timeSpan10Minute , Content = "Kabin otomatik modda çalışıyor"},
                new MailStatement { StatementName = "Mod Bakım Mı Alarmı", Parameter = "ModBakimMi", Statement = "Varsa", CoolDown = timeSpan10Minute , Content = "Kabin anlık olarak bakımda"},
                new MailStatement { StatementName = "Mod Kalibrasyon Mu Alarmı", Parameter = "ModKalibrasyonMu", Statement = "Varsa", CoolDown = timeSpan10Minute , Content = "Kabinde kalibrasyon yapılıyor"},
                new MailStatement { StatementName = "Numune Tetik Akm Alarmı", Parameter = "AkmTetik", Statement = "Varsa", CoolDown = timeSpan10Minute , Content = "Akm'den numune alınıyor"},
                new MailStatement { StatementName = "Numune Tetik Koi Alarmı", Parameter = "KoiTetik", Statement = "Varsa", CoolDown = timeSpan10Minute , Content = "Koi'den numune alınıyor"},
                new MailStatement { StatementName = "Numune Tetik Ph Alarmı", Parameter = "PhTetik", Statement = "Varsa", CoolDown = timeSpan10Minute , Content = "Ph'dan numune alınıyor"},
                new MailStatement { StatementName = "Veri Geçerliliği Alarmı", Parameter = "Veri Geçerliliği", Statement = "Varsa", CoolDown = timeSpan10Minute , Content = "Veri geçerliliği: "}
            };

            foreach (var item in mailStatements)
            {
                _mailStatementManager.Add(item);
            }

            DataGridViewStatements.DataSource = mailStatements;

            DataGridViewStatements.Refresh();
        }
    }
}