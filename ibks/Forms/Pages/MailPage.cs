using Business.Abstract;
using ibks.Forms.Pages.Mail;
using ibks.Utils;

namespace ibks.Forms.Pages
{
    public partial class MailPage : Form
    {
        private readonly IMailServerService _mailServerManager;
        private readonly IAuthService _authManager;
        private readonly IUserService _userManager;
        private readonly IMailStatementService _mailStatementManager;
        private readonly IUserMailStatementService _userMailStatementManager;

        private ToolStripMenuItem? _selectedMenuItem;

        public MailPage(IMailServerService mailServerManager, IAuthService authManager, IUserService userManager, IMailStatementService mailStatementManager, IUserMailStatementService userMailStatementManager)
        {
            InitializeComponent();

            _mailServerManager = mailServerManager;
            _authManager = authManager;
            _userManager = userManager;
            _mailStatementManager = mailStatementManager;
            _userMailStatementManager = userMailStatementManager;

            InitializeMenuItems();
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

        private void InitializeMenuItems()
        {
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.Click += MenuItem_Click!;
            }
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            Color hoverBlue = Color.FromArgb(179, 215, 243);

            if (_selectedMenuItem != null)
            {
                _selectedMenuItem.BackColor = Color.White;
            }

            _selectedMenuItem = (ToolStripMenuItem)sender;
            _selectedMenuItem.BackColor = hoverBlue;
            _selectedMenuItem.ForeColor = Color.Black;
        }

        private void MailPage_StyleChanged(object sender, EventArgs e)
        {
        }

        private void MailPage_SizeChanged(object sender, EventArgs e)
        {
            foreach (Form activeForm in PanelContent.Controls)
            {
                activeForm.Size = PanelContent.Size;
            }
        }
    }
}
