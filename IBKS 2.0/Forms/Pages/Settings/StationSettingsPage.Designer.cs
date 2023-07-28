namespace IBKS_2._0.Forms.Pages.Settings
{
    partial class StationSettingsPage
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
            tableLayoutPanel1 = new TableLayoutPanel();
            TableLayoutPanelMain = new TableLayoutPanel();
            ButtonSave = new Button();
            stationSettingsControl2 = new Components.StationSettingsControl();
            titleBarControl1 = new Components.TitleBarControl();
            stationSettingsControl1 = new Components.StationSettingsControl();
            tableLayoutPanel1.SuspendLayout();
            TableLayoutPanelMain.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(TableLayoutPanelMain, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1170, 621);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // TableLayoutPanelMain
            // 
            TableLayoutPanelMain.ColumnCount = 1;
            TableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelMain.Controls.Add(ButtonSave, 0, 3);
            TableLayoutPanelMain.Controls.Add(stationSettingsControl2, 0, 2);
            TableLayoutPanelMain.Controls.Add(titleBarControl1, 0, 0);
            TableLayoutPanelMain.Controls.Add(stationSettingsControl1, 0, 1);
            TableLayoutPanelMain.Dock = DockStyle.Fill;
            TableLayoutPanelMain.Location = new Point(8, 8);
            TableLayoutPanelMain.Margin = new Padding(8);
            TableLayoutPanelMain.Name = "TableLayoutPanelMain";
            TableLayoutPanelMain.RowCount = 5;
            TableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            TableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelMain.Size = new Size(1154, 294);
            TableLayoutPanelMain.TabIndex = 0;
            // 
            // ButtonSave
            // 
            ButtonSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonSave.BackColor = Color.FromArgb(0, 131, 200);
            ButtonSave.FlatAppearance.BorderColor = Color.FromArgb(235, 235, 235);
            ButtonSave.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            ButtonSave.FlatAppearance.MouseOverBackColor = SystemColors.ButtonFace;
            ButtonSave.ForeColor = Color.White;
            ButtonSave.Location = new Point(930, 174);
            ButtonSave.Margin = new Padding(8, 8, 0, 8);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(224, 43);
            ButtonSave.TabIndex = 3;
            ButtonSave.Text = "Kaydet";
            ButtonSave.UseVisualStyleBackColor = false;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // stationSettingsControl2
            // 
            stationSettingsControl2.AyarDegeri = "";
            stationSettingsControl2.BackColor = Color.FromArgb(235, 235, 235);
            stationSettingsControl2.Dock = DockStyle.Fill;
            stationSettingsControl2.Location = new Point(3, 105);
            stationSettingsControl2.Name = "stationSettingsControl2";
            stationSettingsControl2.AyarAdi = "SİM ID:";
            stationSettingsControl2.Size = new Size(1148, 58);
            stationSettingsControl2.TabIndex = 3;
            // 
            // titleBarControl1
            // 
            titleBarControl1.BackColor = Color.FromArgb(235, 235, 235);
            titleBarControl1.Dock = DockStyle.Fill;
            titleBarControl1.Location = new Point(3, 3);
            titleBarControl1.Name = "titleBarControl1";
            titleBarControl1.Padding = new Padding(1);
            titleBarControl1.Size = new Size(1148, 32);
            titleBarControl1.TabIndex = 1;
            titleBarControl1.TitleBarText = "İSTASYON AYARLARI";
            // 
            // stationSettingsControl1
            // 
            stationSettingsControl1.AyarDegeri = "";
            stationSettingsControl1.BackColor = Color.FromArgb(235, 235, 235);
            stationSettingsControl1.Dock = DockStyle.Fill;
            stationSettingsControl1.Location = new Point(3, 41);
            stationSettingsControl1.Name = "stationSettingsControl1";
            stationSettingsControl1.AyarAdi = "İSTASYON ADI:";
            stationSettingsControl1.Size = new Size(1148, 58);
            stationSettingsControl1.TabIndex = 2;
            // 
            // StationSettingsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1170, 621);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StationSettingsPage";
            Text = "StationSettingsPage";
            tableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button ButtonSave;
        private TableLayoutPanel TableLayoutPanelMain;
        private Components.TitleBarControl titleBarControl1;
        private Components.StationSettingsControl stationSettingsControl1;
        private Components.StationSettingsControl stationSettingsControl2;
    }
}