namespace IBKS_2._0.Forms.Pages.Settings
{
    partial class CalibrationSettingsPage
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
            ButtonSave = new Button();
            TableLayoutPanelMain = new TableLayoutPanel();
            CalibrationSettingsBarIletkenlik = new Components.CalibrationSettingsBar();
            CalibrationSettingsBarPh = new Components.CalibrationSettingsBar();
            CalibrationSettingsBarKoi = new Components.CalibrationSettingsBar();
            CalibrationSettingsBarAkm = new Components.CalibrationSettingsBar();
            titleBarControl1 = new Components.TitleBarControl();
            tableLayoutPanel1.SuspendLayout();
            TableLayoutPanelMain.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(ButtonSave, 0, 1);
            tableLayoutPanel1.Controls.Add(TableLayoutPanelMain, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1170, 621);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ButtonSave
            // 
            ButtonSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonSave.BackColor = Color.FromArgb(0, 131, 200);
            ButtonSave.FlatAppearance.BorderColor = Color.FromArgb(235, 235, 235);
            ButtonSave.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            ButtonSave.FlatAppearance.MouseOverBackColor = SystemColors.ButtonFace;
            ButtonSave.ForeColor = Color.White;
            ButtonSave.Location = new Point(938, 318);
            ButtonSave.Margin = new Padding(8);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(224, 43);
            ButtonSave.TabIndex = 3;
            ButtonSave.Text = "Kaydet";
            ButtonSave.UseVisualStyleBackColor = false;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // TableLayoutPanelMain
            // 
            TableLayoutPanelMain.ColumnCount = 1;
            TableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelMain.Controls.Add(CalibrationSettingsBarIletkenlik, 0, 4);
            TableLayoutPanelMain.Controls.Add(CalibrationSettingsBarPh, 0, 3);
            TableLayoutPanelMain.Controls.Add(CalibrationSettingsBarKoi, 0, 2);
            TableLayoutPanelMain.Controls.Add(CalibrationSettingsBarAkm, 0, 1);
            TableLayoutPanelMain.Controls.Add(titleBarControl1, 0, 0);
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
            // CalibrationSettingsBarIletkenlik
            // 
            CalibrationSettingsBarIletkenlik.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CalibrationSettingsBarIletkenlik.BackColor = Color.FromArgb(235, 235, 235);
            CalibrationSettingsBarIletkenlik.Dock = DockStyle.Fill;
            CalibrationSettingsBarIletkenlik.Location = new Point(3, 233);
            CalibrationSettingsBarIletkenlik.Name = "CalibrationSettingsBarIletkenlik";
            CalibrationSettingsBarIletkenlik.Padding = new Padding(1);
            CalibrationSettingsBarIletkenlik.Parameter = "Iletkenlik";
            CalibrationSettingsBarIletkenlik.Size = new Size(1148, 58);
            CalibrationSettingsBarIletkenlik.SpanRef = "";
            CalibrationSettingsBarIletkenlik.SpanTime = "";
            CalibrationSettingsBarIletkenlik.TabIndex = 4;
            CalibrationSettingsBarIletkenlik.ZeroRef = "";
            CalibrationSettingsBarIletkenlik.ZeroTime = "";
            // 
            // CalibrationSettingsBarPh
            // 
            CalibrationSettingsBarPh.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CalibrationSettingsBarPh.BackColor = Color.FromArgb(235, 235, 235);
            CalibrationSettingsBarPh.Dock = DockStyle.Fill;
            CalibrationSettingsBarPh.Location = new Point(3, 169);
            CalibrationSettingsBarPh.Name = "CalibrationSettingsBarPh";
            CalibrationSettingsBarPh.Padding = new Padding(1);
            CalibrationSettingsBarPh.Parameter = "pH";
            CalibrationSettingsBarPh.Size = new Size(1148, 58);
            CalibrationSettingsBarPh.SpanRef = "";
            CalibrationSettingsBarPh.SpanTime = "";
            CalibrationSettingsBarPh.TabIndex = 3;
            CalibrationSettingsBarPh.ZeroRef = "";
            CalibrationSettingsBarPh.ZeroTime = "";
            // 
            // CalibrationSettingsBarKoi
            // 
            CalibrationSettingsBarKoi.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CalibrationSettingsBarKoi.BackColor = Color.FromArgb(235, 235, 235);
            CalibrationSettingsBarKoi.Dock = DockStyle.Fill;
            CalibrationSettingsBarKoi.Location = new Point(3, 105);
            CalibrationSettingsBarKoi.Name = "CalibrationSettingsBarKoi";
            CalibrationSettingsBarKoi.Padding = new Padding(1);
            CalibrationSettingsBarKoi.Parameter = "KOi";
            CalibrationSettingsBarKoi.Size = new Size(1148, 58);
            CalibrationSettingsBarKoi.SpanRef = "";
            CalibrationSettingsBarKoi.SpanTime = "";
            CalibrationSettingsBarKoi.TabIndex = 2;
            CalibrationSettingsBarKoi.ZeroRef = "";
            CalibrationSettingsBarKoi.ZeroTime = "";
            // 
            // CalibrationSettingsBarAkm
            // 
            CalibrationSettingsBarAkm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CalibrationSettingsBarAkm.BackColor = Color.FromArgb(235, 235, 235);
            CalibrationSettingsBarAkm.Dock = DockStyle.Fill;
            CalibrationSettingsBarAkm.Location = new Point(3, 41);
            CalibrationSettingsBarAkm.Name = "CalibrationSettingsBarAkm";
            CalibrationSettingsBarAkm.Padding = new Padding(1);
            CalibrationSettingsBarAkm.Parameter = "AKM";
            CalibrationSettingsBarAkm.Size = new Size(1148, 58);
            CalibrationSettingsBarAkm.SpanRef = "";
            CalibrationSettingsBarAkm.SpanTime = "";
            CalibrationSettingsBarAkm.TabIndex = 0;
            CalibrationSettingsBarAkm.ZeroRef = "";
            CalibrationSettingsBarAkm.ZeroTime = "";
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
            titleBarControl1.TitleBarText = "KALİBRASYON AYARLARI";
            // 
            // CalibrationSettingsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1170, 621);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CalibrationSettingsPage";
            Text = "CalibrationSettingsPage";
            Load += CalibrationSettingsPage_Load;
            tableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel TableLayoutPanelMain;
        private Components.TitleBarControl titleBarControl1;
        private Components.CalibrationSettingsBar CalibrationSettingsBarAkm;
        private Components.CalibrationSettingsBar CalibrationSettingsBarKoi;
        private Components.CalibrationSettingsBar CalibrationSettingsBarIletkenlik;
        private Components.CalibrationSettingsBar CalibrationSettingsBarPh;
        private Button ButtonSave;
    }
}