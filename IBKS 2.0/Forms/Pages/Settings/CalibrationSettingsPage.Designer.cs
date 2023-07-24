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
            TableLayoutPanelMain = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            ButtonSave = new Button();
            calibrationSettingsBar1 = new Components.CalibrationSettingsBar();
            titleBarControl1 = new Components.TitleBarControl();
            calibrationSettingsBar2 = new Components.CalibrationSettingsBar();
            calibrationSettingsBar3 = new Components.CalibrationSettingsBar();
            calibrationSettingsBar4 = new Components.CalibrationSettingsBar();
            TableLayoutPanelMain.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanelMain
            // 
            TableLayoutPanelMain.ColumnCount = 1;
            TableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelMain.Controls.Add(tableLayoutPanel2, 0, 0);
            TableLayoutPanelMain.Controls.Add(ButtonSave, 0, 1);
            TableLayoutPanelMain.Dock = DockStyle.Fill;
            TableLayoutPanelMain.Location = new Point(0, 0);
            TableLayoutPanelMain.Name = "TableLayoutPanelMain";
            TableLayoutPanelMain.RowCount = 2;
            TableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableLayoutPanelMain.Size = new Size(1170, 621);
            TableLayoutPanelMain.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(calibrationSettingsBar4, 0, 4);
            tableLayoutPanel2.Controls.Add(calibrationSettingsBar3, 0, 3);
            tableLayoutPanel2.Controls.Add(calibrationSettingsBar2, 0, 2);
            tableLayoutPanel2.Controls.Add(calibrationSettingsBar1, 0, 1);
            tableLayoutPanel2.Controls.Add(titleBarControl1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(8, 8);
            tableLayoutPanel2.Margin = new Padding(8);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(1154, 294);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // ButtonSave
            // 
            ButtonSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonSave.BackColor = Color.White;
            ButtonSave.FlatAppearance.BorderColor = Color.FromArgb(235, 235, 235);
            ButtonSave.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            ButtonSave.FlatAppearance.MouseOverBackColor = SystemColors.ButtonFace;
            ButtonSave.FlatStyle = FlatStyle.Flat;
            ButtonSave.Location = new Point(938, 318);
            ButtonSave.Margin = new Padding(8);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(224, 43);
            ButtonSave.TabIndex = 1;
            ButtonSave.Text = "Kaydet";
            ButtonSave.UseVisualStyleBackColor = false;
            ButtonSave.Click += ButtonSave_Click;
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
            // calibrationSettingsBar4
            // 
            calibrationSettingsBar4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            calibrationSettingsBar4.BackColor = Color.FromArgb(235, 235, 235);
            calibrationSettingsBar4.Dock = DockStyle.Fill;
            calibrationSettingsBar4.Location = new Point(3, 233);
            calibrationSettingsBar4.Name = "calibrationSettingsBar4";
            calibrationSettingsBar4.Padding = new Padding(1);
            calibrationSettingsBar4.Parameter = "İletkenlik";
            calibrationSettingsBar4.Size = new Size(1148, 58);
            calibrationSettingsBar4.SpanRef = "";
            calibrationSettingsBar4.SpanTime = "";
            calibrationSettingsBar4.TabIndex = 4;
            calibrationSettingsBar4.ZeroRef = "";
            calibrationSettingsBar4.ZeroTime = "";
            // 
            // CalibrationSettingsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1170, 621);
            Controls.Add(TableLayoutPanelMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CalibrationSettingsPage";
            Text = "CalibrationSettingsPage";
            TableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayoutPanelMain;
        private TableLayoutPanel tableLayoutPanel2;
        private Button ButtonSave;
        private Components.CalibrationSettingsBar calibrationSettingsBar1;
        private Components.TitleBarControl titleBarControl1;
        private Components.CalibrationSettingsBar calibrationSettingsBar2;
        private Components.CalibrationSettingsBar calibrationSettingsBar4;
        private Components.CalibrationSettingsBar calibrationSettingsBar3;
    }
}