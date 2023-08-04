using Business.Abstract;
using Business.Constants;
using Entities.Concrete;

namespace IBKS_2._0.Forms.Pages.Mail
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
            if (e.ColumnIndex == 0)
            {
                bool statementComboBox = Convert.ToBoolean(DataGridViewMailStatements.Rows[e.RowIndex].Cells[0].EditedFormattedValue);
                var mailStatementId = DataGridViewMailStatements.Rows[e.RowIndex].Cells[1].Value;
                var userId = _userManager.GetByMail(ComboBoxSelectedUser.Text);

                if (userId != null)
                {
                    UserMailStatement userMailStatement = new()
                    {
                        MailStatementId = (int)mailStatementId,
                        UserId = userId.Id
                    };

                    if (!statementComboBox)
                    {
                        var res = _userMailStatementManager.Add(userMailStatement);

                        statementComboBox = true;

                        MessageBox.Show(res.Message);
                    }
                    else
                    {
                        statementComboBox = false;

                        var res = _userMailStatementManager.Delete(userMailStatement);

                        MessageBox.Show(res.Message);
                    }
                }
                else
                {
                    MessageBox.Show(Messages.InvalidUser);
                }
            }
        }
    }
}
