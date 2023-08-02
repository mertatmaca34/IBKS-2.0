using IBKS_2._0.Forms.Pages.Mail;
using IBKS_2._0.Utils;

namespace IBKS_2._0.Forms.Pages
{
    public partial class MailPage : Form
    {
        public MailPage()
        {
            InitializeComponent();
        }

        private void ButtonMailServerSettings_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new MailServerSettingsPage());
        }
    }
}
