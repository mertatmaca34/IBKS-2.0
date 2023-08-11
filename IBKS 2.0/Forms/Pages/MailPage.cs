using Business.Abstract;
using IBKS_2._0.Forms.Pages.Mail;
using IBKS_2._0.Utils;

namespace IBKS_2._0.Forms.Pages
{
    public partial class MailPage : Form
    {
        readonly IMailServerService _mailServerManager;
        readonly IAuthService _authManager;
        readonly IUserService _userManager;
        readonly IMailStatementService _mailStatementManager;
        readonly IUserMailStatementService _userMailStatementManager;
        public MailPage(IMailServerService mailServerManager, IAuthService authManager, IUserService userManager, IMailStatementService mailStatementManager, IUserMailStatementService userMailStatementManager)
        {
            InitializeComponent();

            _mailServerManager = mailServerManager;
            _authManager = authManager;
            _userManager = userManager;
            _mailStatementManager = mailStatementManager;
            _userMailStatementManager = userMailStatementManager;
        }

        private void ButtonMailServerSettings_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new MailServerSettingsPage(_mailServerManager));
        }

        private void ButtonMailUsers_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new MailUsersPage(_authManager, _userManager));
        }

        private void ButtonMailStatements_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new MailStatementsPage(_userManager, _mailStatementManager, _userMailStatementManager));
        }

        private void ButtonEditMailStatements_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new MailStatementsEditPage(_mailStatementManager, _userMailStatementManager));
        }
    }
}
