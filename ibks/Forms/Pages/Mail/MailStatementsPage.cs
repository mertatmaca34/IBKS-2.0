using Business.Abstract;
using Business.Constants;
using Entities.Concrete;

namespace ibks.Forms.Pages.Mail
{
    public partial class MailStatementsPage : Form
    {
        readonly IUserService _userManager;
        readonly IMailStatementService _mailStatementManager;
        readonly IUserMailStatementService _userMailStatementManager;

        public MailStatementsPage(IUserService userManager, IMailStatementService mailStatementManager, IUserMailStatementService userMailStatementManager)
        {
            InitializeComponent();

            _userManager = userManager;
            _mailStatementManager = mailStatementManager;
            _userMailStatementManager = userMailStatementManager;
        }

        private void MailStatementsPage_Load(object sender, EventArgs e)
        {
            AssignComboBoxUsers();
            AssignDataGridViewMailStatements();
        }

        private void AssignDataGridViewMailStatements()
        {
            var data = _mailStatementManager.GetAll();

            if (data.Data.Count > 0)
            {
                DataGridViewMailStatements.DataSource = data.Data;

                DataGridViewMailStatements.Columns[1].Visible = false;

                DataGridViewMailStatements.Columns[2].HeaderText = "Konu Başlığı";
                DataGridViewMailStatements.Columns[3].HeaderText = "Parametre";
                DataGridViewMailStatements.Columns[4].HeaderText = "Durum";
                DataGridViewMailStatements.Columns[5].HeaderText = "Alt Limit";
                DataGridViewMailStatements.Columns[6].HeaderText = "Üst Limit";
                DataGridViewMailStatements.Columns[7].HeaderText = "Soğuma Süresi";
                DataGridViewMailStatements.Columns[8].HeaderText = "Mail İçeriği";
            }

            DataGridViewMailStatements.Refresh();
        }

        private void AssignComboBoxUsers()
        {
            var users = _userManager.GetAll();

            if (users != null)
            {
                foreach (var user in users)
                {
                    ComboBoxSelectedUser.Items.Add($"{user.Email}");
                }
            }
        }

        private void DataGridViewMailStatements_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                var cell = DataGridViewMailStatements.Rows[e.RowIndex].Cells[0];
                bool statementComboBox = Convert.ToBoolean(cell.EditedFormattedValue);

                var mailStatementId = DataGridViewMailStatements.Rows[e.RowIndex].Cells[1].Value;

                var user = _userManager.GetByMail(ComboBoxSelectedUser.Text);

                if (user != null)
                {
                    UserMailStatement userMailStatement = new()
                    {
                        MailStatementId = (int)mailStatementId,
                        UserId = user.Id
                    };

                    var existEntity = _userMailStatementManager.Get(u => u.UserId == userMailStatement.UserId && u.MailStatementId == userMailStatement.MailStatementId);

                    if (!statementComboBox)
                    {
                        var res = _userMailStatementManager.Add(userMailStatement);

                        cell.Value = true;

                        MessageBox.Show(res.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        cell.Value = false;

                        var res = _userMailStatementManager.Delete(existEntity.Data[0]);

                        MessageBox.Show(res.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(Messages.InvalidUser, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ComboBoxSelectedUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            var user = _userManager.GetByMail(ComboBoxSelectedUser.Text);

            if (user != null)
            {
                var userMailStatements = _userMailStatementManager.Get(x => x.UserId == user.Id);

                for (int i = 0; i < DataGridViewMailStatements.Rows.Count; i++)
                {
                    var mailStatementId = Convert.ToInt16(DataGridViewMailStatements.Rows[i].Cells[1].Value);

                    var isItOnTheTable = userMailStatements.Data.Find(x => x.MailStatementId == mailStatementId);

                    if (isItOnTheTable != null)
                    {
                        DataGridViewMailStatements.Rows[i].Cells[0].Value = true;
                    }
                    else
                    {
                        DataGridViewMailStatements.Rows[i].Cells[0].Value = false;
                    }
                }
            }
        }
    }
}
