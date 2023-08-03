using Business.Abstract;
using IBKS_2._0.Forms.Pages.Mail;
using IBKS_2._0.Utils;

namespace IBKS_2._0.Forms.Pages
{
    public partial class MailPage : Form
    {
        readonly IMailServerService _mailServerManager;

        public MailPage(IMailServerService mailServerManager)
        {
            InitializeComponent();

            _mailServerManager = mailServerManager;
        }

        private void ButtonMailServerSettings_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new MailServerSettingsPage(_mailServerManager));
        }

        private void ButtonMailUsers_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new MailUsersPage());
        }

        private void ButtonMailStatements_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new MailStatementsPage());
        }

        private void ButtonEditMailStatements_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new MailStatementsEditPage());
        }
    }
}
