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
            TableLayoutPanelMain.SuspendLayout();
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
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayoutPanelMain;
        private TableLayoutPanel tableLayoutPanel2;
        private Components.TitleBarControl titleBarControl1;
        private Components.CalibrationSettingsBar calibrationSettingsBar1;
        private Components.CalibrationSettingsBar calibrationSettingsBar4;
        private Components.CalibrationSettingsBar calibrationSettingsBar3;
        private Components.CalibrationSettingsBar calibrationSettingsBar2;
        private Button ButtonSave;
    }
}