using Business.Abstract;
using Business.Constants;
using Entities.Concrete;

namespace ibks.Forms.Pages.Mail
{
    public partial class MailServerSettingsPage : Form
    {
        IMailServerService _mailServerManager;

        public MailServerSettingsPage(IMailServerService mailServerManager)
        {
            InitializeComponent();

            _mailServerManager = mailServerManager;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                MailServer mailServer = new MailServer
                {
                    UseSSL = CheckBoxSSL.Checked,
                    Host = TextBoxHost.Text,
                    Port = TextBoxPort.Text,
                    UserName = TextBoxUsername.Text,
                    Password = TextBoxPassword.Text,
                    UseDefaultCredentials = CheckBoxCredentials.Checked
                };

                var res = _mailServerManager.Add(mailServer);

                if (res.Success)
                {
                    MessageBox.Show(res.Message);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Messages.MissData);
            }
        }

        private void MailServerSettingsPage_Load(object sender, EventArgs e)
        {
            var data = _mailServerManager.Get();

            if (data.Success)
            {
                CheckBoxSSL.Checked = data.Data.UseSSL;
                TextBoxHost.Text = data.Data.Host;
                TextBoxPort.Text = data.Data.Port;
                TextBoxUsername.Text = data.Data.UserName;
                TextBoxPassword.Text = data.Data.Password;
                CheckBoxCredentials.Checked = data.Data.UseDefaultCredentials;
            }
        }
    }
}
