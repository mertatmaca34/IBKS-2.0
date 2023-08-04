using Business.Abstract;
using Entities.DTOs;

namespace IBKS_2._0.Forms.Pages.Mail
{
    public partial class MailUsersPage : Form
    {
        readonly IAuthService _authManager;
        readonly IUserService _userManager;

        public MailUsersPage(IAuthService authManager, IUserService userManager)
        {
            InitializeComponent();

            _authManager = authManager;
            _userManager = userManager;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            RegisterEvent();
        }

        private void RegisterEvent()
        {
            UserForRegisterDto userForRegisterDto = new()
            {
                FirstName = TextBoxAd.Text,
                LastName = TextBoxSoyad.Text,
                Email = TextBoxEMail.Text,
                Password = TextBoxPassword.Text
            };

            var userExists = _authManager.UserExists(userForRegisterDto.Email);

            if (!userExists.Success)
            {
                MessageBox.Show(userExists.Message);
            }
            else
            {
                var registerResult = _authManager.Register(userForRegisterDto, userForRegisterDto.Password);

                if (registerResult.Success)
                {
                    MessageBox.Show(registerResult.Message);
                }
            }

            RefreshDataGridView();
        }

        private void MailUsersPage_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void DataGridViewCustomization()
        {
            DataGridViewUsers.Columns[0].Visible = false;
            DataGridViewUsers.Columns[4].Visible = false;
            DataGridViewUsers.Columns[5].Visible = false;
            DataGridViewUsers.Columns[6].Visible = false;

            DataGridViewUsers.Columns[1].HeaderText = "Ad";
            DataGridViewUsers.Columns[2].HeaderText = "Soyad";
            DataGridViewUsers.Columns[3].HeaderText = "EMail";
        }

        private void DataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridViewUsers.SelectedRows.Count > 0)
                ContextMenuStripUser.Enabled = true;
            else
                ContextMenuStripUser.Enabled = false;
        }

        private void SilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedEMail = DataGridViewUsers.SelectedRows[0].Cells[3].Value.ToString();

            var user = _userManager.GetByMail(selectedEMail);

            if (user != null)
            {
                _userManager.Delete(user);
            }

            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            var data = _userManager.GetAll();

            if (data.Count > 0)
            {
                DataGridViewUsers.DataSource = data;

                DataGridViewCustomization();
            }
        }

        private void TextBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RegisterEvent();
            }
        }
    }
}
