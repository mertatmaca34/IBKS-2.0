using Business.Abstract;
using Entities.DTOs;

namespace ibks.Forms
{
    public partial class LoginForm : Form
    {
        readonly IAuthService _authManager;

        public bool ReturnValue { get; set; }

        public LoginForm(IAuthService authManager)
        {
            InitializeComponent();

            _authManager = authManager;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            LoginEvent();
        }

        private void TextBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginEvent();
            }
        }
        private void LoginEvent()
        {
            UserForLoginDto userForLoginDto = new UserForLoginDto
            {
                Email = TextBoxEMail.Text,
                Password = TextBoxPassword.Text
            };

            var userToLogin = _authManager.Login(userForLoginDto);
            if (!userToLogin.Success)
            {
                MessageBox.Show(userToLogin.Message);

                this.ReturnValue = false;
                this.Close();
            }
            else
            {
                MessageBox.Show(userToLogin.Message);

                this.ReturnValue = true;
                this.Close();
            }
        }
    }
}
