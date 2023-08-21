namespace ibks.Forms.Pages
{
    partial class MailPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PanelContent = new Panel();
            menuStrip1 = new MenuStrip();
            ButtonMailStatements = new ToolStripMenuItem();
            ButtonMailUsers = new ToolStripMenuItem();
            ButtonEditMailStatements = new ToolStripMenuItem();
            ButtonMailServerSettings = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // PanelContent
            // 
            PanelContent.Dock = DockStyle.Fill;
            PanelContent.Location = new Point(0, 56);
            PanelContent.Name = "PanelContent";
            PanelContent.Size = new Size(1170, 621);
            PanelContent.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.Items.AddRange(new ToolStripItem[] { ButtonMailStatements, ButtonMailUsers, ButtonEditMailStatements, ButtonMailServerSettings });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1170, 56);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // ButtonMailStatements
            // 
            ButtonMailStatements.Checked = true;
            ButtonMailStatements.CheckState = CheckState.Indeterminate;
            ButtonMailStatements.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonMailStatements.Image = Properties.Resources.mail_statements_48px;
            ButtonMailStatements.ImageScaling = ToolStripItemImageScaling.None;
            ButtonMailStatements.Name = "ButtonMailStatements";
            ButtonMailStatements.Size = new Size(166, 52);
            ButtonMailStatements.Text = "MAİL DURUMLARI";
            ButtonMailStatements.Click += ButtonMailStatements_Click;
            // 
            // ButtonMailUsers
            // 
            ButtonMailUsers.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonMailUsers.Image = Properties.Resources.mail_user48px;
            ButtonMailUsers.ImageScaling = ToolStripItemImageScaling.None;
            ButtonMailUsers.Name = "ButtonMailUsers";
            ButtonMailUsers.Size = new Size(150, 52);
            ButtonMailUsers.Text = "KULLANICILAR";
            ButtonMailUsers.Click += ButtonMailUsers_Click;
            // 
            // ButtonEditMailStatements
            // 
            ButtonEditMailStatements.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonEditMailStatements.Image = Properties.Resources.mail_statement_edit48px;
            ButtonEditMailStatements.ImageScaling = ToolStripItemImageScaling.None;
            ButtonEditMailStatements.Name = "ButtonEditMailStatements";
            ButtonEditMailStatements.Size = new Size(203, 52);
            ButtonEditMailStatements.Text = "MAİL DURUMU DÜZENLE";
            ButtonEditMailStatements.Click += ButtonEditMailStatements_Click;
            // 
            // ButtonMailServerSettings
            // 
            ButtonMailServerSettings.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonMailServerSettings.Image = Properties.Resources.mail_server48px;
            ButtonMailServerSettings.ImageScaling = ToolStripItemImageScaling.None;
            ButtonMailServerSettings.Name = "ButtonMailServerSettings";
            ButtonMailServerSettings.Size = new Size(173, 52);
            ButtonMailServerSettings.Text = "SUNUCU AYARLARI";
            ButtonMailServerSettings.Click += ButtonMailServerSettings_Click;
            // 
            // MailPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1170, 677);
            Controls.Add(PanelContent);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MailPage";
            Text = "MailPage";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelContent;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ButtonMailStatements;
        private ToolStripMenuItem ButtonMailUsers;
        private ToolStripMenuItem ButtonEditMailStatements;
        private ToolStripMenuItem ButtonMailServerSettings;
    }
}