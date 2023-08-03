using Business.Abstract;
using Entities.DTOs;

namespace IBKS_2._0.Forms.Pages.Mail
{
    public partial class MailUsersPage : Form
    {
        readonly IAuthService _authManager;

        public MailUsersPage(IAuthService authManager)
        {
            InitializeComponent();

            _authManager = authManager;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
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
        }

        private void MailUsersPage_Load(object sender, EventArgs e)
        {
            
        }
    }
}
