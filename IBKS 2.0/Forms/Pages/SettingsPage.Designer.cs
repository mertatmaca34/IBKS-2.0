namespace IBKS_2._0.Forms.Pages
{
    partial class SettingsPage
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
            menuStrip1 = new MenuStrip();
            istasyonAyarlarıToolStripMenuItem = new ToolStripMenuItem();
            aPIAyarlarıToolStripMenuItem = new ToolStripMenuItem();
            plcAyarlarıToolStripMenuItem = new ToolStripMenuItem();
            kalibrasyonAyarlarıToolStripMenuItem = new ToolStripMenuItem();
            PanelContent = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { istasyonAyarlarıToolStripMenuItem, aPIAyarlarıToolStripMenuItem, plcAyarlarıToolStripMenuItem, kalibrasyonAyarlarıToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1170, 56);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // istasyonAyarlarıToolStripMenuItem
            // 
            istasyonAyarlarıToolStripMenuItem.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            istasyonAyarlarıToolStripMenuItem.Image = Properties.Resources.place_marker_48px;
            istasyonAyarlarıToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            istasyonAyarlarıToolStripMenuItem.Name = "istasyonAyarlarıToolStripMenuItem";
            istasyonAyarlarıToolStripMenuItem.Size = new Size(182, 52);
            istasyonAyarlarıToolStripMenuItem.Text = "İSTASYON AYARLARI";
            // 
            // aPIAyarlarıToolStripMenuItem
            // 
            aPIAyarlarıToolStripMenuItem.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            aPIAyarlarıToolStripMenuItem.Image = Properties.Resources.rest_api_48px;
            aPIAyarlarıToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            aPIAyarlarıToolStripMenuItem.Name = "aPIAyarlarıToolStripMenuItem";
            aPIAyarlarıToolStripMenuItem.Size = new Size(133, 52);
            aPIAyarlarıToolStripMenuItem.Text = "API Ayarları";
            // 
            // plcAyarlarıToolStripMenuItem
            // 
            plcAyarlarıToolStripMenuItem.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            plcAyarlarıToolStripMenuItem.Image = Properties.Resources.electronics_48px;
            plcAyarlarıToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            plcAyarlarıToolStripMenuItem.Name = "plcAyarlarıToolStripMenuItem";
            plcAyarlarıToolStripMenuItem.Size = new Size(132, 52);
            plcAyarlarıToolStripMenuItem.Text = "Plc Ayarları";
            // 
            // kalibrasyonAyarlarıToolStripMenuItem
            // 
            kalibrasyonAyarlarıToolStripMenuItem.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            kalibrasyonAyarlarıToolStripMenuItem.Image = Properties.Resources.azimuth_48px;
            kalibrasyonAyarlarıToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            kalibrasyonAyarlarıToolStripMenuItem.Name = "kalibrasyonAyarlarıToolStripMenuItem";
            kalibrasyonAyarlarıToolStripMenuItem.Size = new Size(181, 52);
            kalibrasyonAyarlarıToolStripMenuItem.Text = "Kalibrasyon Ayarları";
            // 
            // PanelContent
            // 
            PanelContent.Dock = DockStyle.Fill;
            PanelContent.Location = new Point(0, 56);
            PanelContent.Name = "PanelContent";
            PanelContent.Size = new Size(1170, 621);
            PanelContent.TabIndex = 1;
            // 
            // SettingsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1170, 677);
            Controls.Add(PanelContent);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "SettingsPage";
            Text = "SettingsPage";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem istasyonAyarlarıToolStripMenuItem;
        private ToolStripMenuItem aPIAyarlarıToolStripMenuItem;
        private ToolStripMenuItem plcAyarlarıToolStripMenuItem;
        private ToolStripMenuItem kalibrasyonAyarlarıToolStripMenuItem;
        private Panel PanelContent;
    }
}