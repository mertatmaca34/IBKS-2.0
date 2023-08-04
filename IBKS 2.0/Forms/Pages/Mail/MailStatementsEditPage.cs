using Business.Abstract;
using Business.Constants;
using Business.Helpers.Mail;
using Entities.Concrete;

namespace IBKS_2._0.Forms.Pages.Mail
{
    public partial class MailStatementsEditPage : Form
    {
        List<CooldownItem> _comboBoxCooldownItems;
        List<ParameterItem> _comboBoxParameterItems;

        TimeSpan _coolDown;
        string _parameter;

        IMailStatementService _mailStatementManager;

        public MailStatementsEditPage(IMailStatementService mailStatementManager)
        {
            InitializeComponent();

            _mailStatementManager = mailStatementManager;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                MailStatement mailStatement = new MailStatement
                {
                    Parameter = ComboBoxParameter.Text,
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

                    MessageBox.Show(res.Message);
                }
                else
                {
                    var res = _mailStatementManager.Add(mailStatement);

                    MessageBox.Show(res.Message);
                }

                AssignDataGridView();
            }
            catch (Exception)
            {
                MessageBox.Show(Messages.MailStatementCantBeAdded);
            }
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

                DataGridViewStatements.Refresh();
            }
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
                new ParameterItem { DisplayText = "Günlük Yıkama", RealValue = "YikamaVarmi"},
                new ParameterItem { DisplayText = "Haftalık Yıkama", RealValue = "HaftalikYikamaVarMi"},
                new ParameterItem { DisplayText = "Mod Auto Mu", RealValue = "ModAutoMu"},
                new ParameterItem { DisplayText = "Mod Bakım Mı", RealValue = "ModBakimMi"},
                new ParameterItem { DisplayText = "Mod Kalibrasyon Mu", RealValue = "ModKalibrasyonMu"},
                new ParameterItem { DisplayText = "Numune Tetik Akm", RealValue = "AkmTetik"},
                new ParameterItem { DisplayText = "Numune Tetik Koi", RealValue = "KoiTetik"},
                new ParameterItem { DisplayText = "Numune Tetik Ph", RealValue = "PhTetik"},
                new ParameterItem { DisplayText = "Kapı", RealValue = "Kapi"},
                new ParameterItem { DisplayText = "Duman", RealValue = "Duman"},
                new ParameterItem { DisplayText = "Su Baskını", RealValue = "SuBaskini"},
                new ParameterItem { DisplayText = "Acil Stop", RealValue = "AcilStop"},
                new ParameterItem { DisplayText = "Pompa 1 Termik", RealValue = "Pompa1Termik"},
                new ParameterItem { DisplayText = "Pompa 2 Termik", RealValue = "Pompa2Termil"},
                new ParameterItem { DisplayText = "Temiz Su Pompası Termik", RealValue = "TemizSuTermil"},
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
            if (selectedIndex >= 0 && selectedIndex < _comboBoxCooldownItems.Count)
            {
                _coolDown = _comboBoxCooldownItems[selectedIndex].RealValue;
            }
        }

        private void ComboBoxParameter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ComboBoxParameter.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < _comboBoxParameterItems.Count)
            {
                _parameter = _comboBoxParameterItems[selectedIndex].RealValue;
            }
        }

        private void DuzenleToolStipMenuItem_Click(object sender, EventArgs e)
        {
            if (DataGridViewStatements.SelectedRows.Count > 0)
            {
                var row = DataGridViewStatements.SelectedRows[0];

                TextBoxMailSubject.Text = row.Cells[1].Value.ToString();
                ComboBoxParameter.Text = row.Cells[2].Value.ToString();
                ComboBoxStatement.Text = row.Cells[3].Value.ToString();
                TextBoxLowerLimit.Text = row.Cells[4].Value.ToString();
                TextBoxUpperLimit.Text = row.Cells[5].Value.ToString();
                ComboBoxCoolDown.Text = row.Cells[6].Value.ToString();
                TextBoxMailContent.Text = row.Cells[7].Value.ToString();
            }
        }

        private void SilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataGridViewStatements.SelectedRows.Count > 0)
            {
                var row = DataGridViewStatements.SelectedRows[0];

                MailStatement mailStatement = new MailStatement
                {
                    Id = Convert.ToInt16(row.Cells[0].Value),
                    StatementName = row.Cells[1].Value.ToString(),
                    Parameter = row.Cells[2].Value.ToString(),
                    Statement = row.Cells[3].Value.ToString(),
                    LowerLimit = Convert.ToInt16(row.Cells[4].Value),
                    UpperLimit = Convert.ToInt16(row.Cells[5].Value),
                    CoolDown = (TimeSpan)row.Cells[6].Value,
                    Content = row.Cells[7].Value.ToString(),
                };

                var res = _mailStatementManager.Delete(mailStatement);

                MessageBox.Show(res.Message);

                AssignDataGridView();
            }
        }
    }
}
