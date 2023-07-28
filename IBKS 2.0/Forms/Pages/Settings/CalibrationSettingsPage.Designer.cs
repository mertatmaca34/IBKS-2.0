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
            calibrationSettingsBar4 = new Components.CalibrationSettingsBar();
            calibrationSettingsBar3 = new Components.CalibrationSettingsBar();
            calibrationSettingsBar2 = new Components.CalibrationSettingsBar();
            calibrationSettingsBar1 = new Components.CalibrationSettingsBar();
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
            TableLayoutPanelMain.Controls.Add(calibrationSettingsBar4, 0, 4);
            TableLayoutPanelMain.Controls.Add(calibrationSettingsBar3, 0, 3);
            TableLayoutPanelMain.Controls.Add(calibrationSettingsBar2, 0, 2);
            TableLayoutPanelMain.Controls.Add(calibrationSettingsBar1, 0, 1);
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
            // calibrationSettingsBar4
            // 
            calibrationSettingsBar4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            calibrationSettingsBar4.BackColor = Color.FromArgb(235, 235, 235);
            calibrationSettingsBar4.Dock = DockStyle.Fill;
            calibrationSettingsBar4.Location = new Point(3, 233);
            calibrationSettingsBar4.Name = "calibrationSettingsBar4";
            calibrationSettingsBar4.Padding = new Padding(1);
            calibrationSettingsBar4.Parameter = "Iletkenlik";
            calibrationSettingsBar4.Size = new Size(1148, 58);
            calibrationSettingsBar4.SpanRef = "";
            calibrationSettingsBar4.SpanTime = "";
            calibrationSettingsBar4.TabIndex = 4;
            calibrationSettingsBar4.ZeroRef = "";
            calibrationSettingsBar4.ZeroTime = "";
            // 
            // calibrationSettingsBar3
            // 
            calibrationSettingsBar3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            calibrationSettingsBar3.BackColor = Color.FromArgb(235, 235, 235);
            calibrationSettingsBar3.Dock = DockStyle.Fill;
            calibrationSettingsBar3.Location = new Point(3, 169);
            calibrationSettingsBar3.Name = "calibrationSettingsBar3";
            calibrationSettingsBar3.Padding = new Padding(1);
            calibrationSettingsBar3.Parameter = "pH";
            calibrationSettingsBar3.Size = new Size(1148, 58);
            calibrationSettingsBar3.SpanRef = "";
            calibrationSettingsBar3.SpanTime = "";
            calibrationSettingsBar3.TabIndex = 3;
            calibrationSettingsBar3.ZeroRef = "";
            calibrationSettingsBar3.ZeroTime = "";
            // 
            // calibrationSettingsBar2
            // 
            calibrationSettingsBar2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            calibrationSettingsBar2.BackColor = Color.FromArgb(235, 235, 235);
            calibrationSettingsBar2.Dock = DockStyle.Fill;
            calibrationSettingsBar2.Location = new Point(3, 105);
            calibrationSettingsBar2.Name = "calibrationSettingsBar2";
            calibrationSettingsBar2.Padding = new Padding(1);
            calibrationSettingsBar2.Parameter = "KOi";
            calibrationSettingsBar2.Size = new Size(1148, 58);
            calibrationSettingsBar2.SpanRef = "";
            calibrationSettingsBar2.SpanTime = "";
            calibrationSettingsBar2.TabIndex = 2;
            calibrationSettingsBar2.ZeroRef = "";
            calibrationSettingsBar2.ZeroTime = "";
            // 
            // calibrationSettingsBar1
            // 
            calibrationSettingsBar1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            calibrationSettingsBar1.BackColor = Color.FromArgb(235, 235, 235);
            calibrationSettingsBar1.Dock = DockStyle.Fill;
            calibrationSettingsBar1.Location = new Point(3, 41);
            calibrationSettingsBar1.Name = "calibrationSettingsBar1";
            calibrationSettingsBar1.Padding = new Padding(1);
            calibrationSettingsBar1.Parameter = "AKM";
            calibrationSettingsBar1.Size = new Size(1148, 58);
            calibrationSettingsBar1.SpanRef = "";
            calibrationSettingsBar1.SpanTime = "";
            calibrationSettingsBar1.TabIndex = 0;
            calibrationSettingsBar1.ZeroRef = "";
            calibrationSettingsBar1.ZeroTime = "";
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
            tableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel TableLayoutPanelMain;
        private Components.TitleBarControl titleBarControl1;
        private Components.CalibrationSettingsBar calibrationSettingsBar1;
        private Components.CalibrationSettingsBar calibrationSettingsBar2;
        private Components.CalibrationSettingsBar calibrationSettingsBar4;
        private Components.CalibrationSettingsBar calibrationSettingsBar3;
        private Button ButtonSave;
    }
}