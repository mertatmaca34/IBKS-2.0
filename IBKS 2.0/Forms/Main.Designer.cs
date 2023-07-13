namespace IBKS_2._0.Forms
{
    partial class Main
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
            button8 = new Button();
            ButtonSettingPage = new Button();
            ButtonReportingPage = new Button();
            ButtonMailPage = new Button();
            ButtonCalibrationPage = new Button();
            ButtonSimulationPage = new Button();
            ButtonHomePage = new Button();
            PanelContent = new Panel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(button8, 0, 7);
            tableLayoutPanel1.Controls.Add(ButtonSettingPage, 0, 5);
            tableLayoutPanel1.Controls.Add(ButtonReportingPage, 0, 4);
            tableLayoutPanel1.Controls.Add(ButtonMailPage, 0, 3);
            tableLayoutPanel1.Controls.Add(ButtonCalibrationPage, 0, 2);
            tableLayoutPanel1.Controls.Add(ButtonSimulationPage, 0, 1);
            tableLayoutPanel1.Controls.Add(ButtonHomePage, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            tableLayoutPanel1.Size = new Size(90, 681);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Fill;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.DimGray;
            button8.Image = Properties.Resources.black_and_white_24px;
            button8.Location = new Point(8, 605);
            button8.Margin = new Padding(8);
            button8.Name = "button8";
            button8.Size = new Size(74, 68);
            button8.TabIndex = 8;
            button8.Text = "Gece Modu";
            button8.TextAlign = ContentAlignment.BottomCenter;
            button8.UseVisualStyleBackColor = true;
            // 
            // ButtonSettingPage
            // 
            ButtonSettingPage.Dock = DockStyle.Fill;
            ButtonSettingPage.FlatAppearance.BorderSize = 0;
            ButtonSettingPage.FlatStyle = FlatStyle.Flat;
            ButtonSettingPage.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSettingPage.ForeColor = Color.DimGray;
            ButtonSettingPage.Image = Properties.Resources.settings_24px;
            ButtonSettingPage.Location = new Point(8, 428);
            ButtonSettingPage.Margin = new Padding(8);
            ButtonSettingPage.Name = "ButtonSettingPage";
            ButtonSettingPage.Size = new Size(74, 68);
            ButtonSettingPage.TabIndex = 6;
            ButtonSettingPage.Text = "Ayarlar";
            ButtonSettingPage.TextAlign = ContentAlignment.BottomCenter;
            ButtonSettingPage.UseVisualStyleBackColor = true;
            // 
            // ButtonReportingPage
            // 
            ButtonReportingPage.Dock = DockStyle.Fill;
            ButtonReportingPage.FlatAppearance.BorderSize = 0;
            ButtonReportingPage.FlatStyle = FlatStyle.Flat;
            ButtonReportingPage.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonReportingPage.ForeColor = Color.DimGray;
            ButtonReportingPage.Image = Properties.Resources.save_24px;
            ButtonReportingPage.Location = new Point(8, 344);
            ButtonReportingPage.Margin = new Padding(8);
            ButtonReportingPage.Name = "ButtonReportingPage";
            ButtonReportingPage.Size = new Size(74, 68);
            ButtonReportingPage.TabIndex = 5;
            ButtonReportingPage.Text = "Raporlama";
            ButtonReportingPage.TextAlign = ContentAlignment.BottomCenter;
            ButtonReportingPage.UseVisualStyleBackColor = true;
            ButtonReportingPage.Click += ButtonReportingPage_Click;
            // 
            // ButtonMailPage
            // 
            ButtonMailPage.Dock = DockStyle.Fill;
            ButtonMailPage.FlatAppearance.BorderSize = 0;
            ButtonMailPage.FlatStyle = FlatStyle.Flat;
            ButtonMailPage.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonMailPage.ForeColor = Color.DimGray;
            ButtonMailPage.Image = Properties.Resources.alarm_24px;
            ButtonMailPage.Location = new Point(8, 260);
            ButtonMailPage.Margin = new Padding(8);
            ButtonMailPage.Name = "ButtonMailPage";
            ButtonMailPage.Size = new Size(74, 68);
            ButtonMailPage.TabIndex = 4;
            ButtonMailPage.Text = "Mail";
            ButtonMailPage.TextAlign = ContentAlignment.BottomCenter;
            ButtonMailPage.UseVisualStyleBackColor = true;
            ButtonMailPage.Click += ButtonMailPage_Click;
            // 
            // ButtonCalibrationPage
            // 
            ButtonCalibrationPage.Dock = DockStyle.Fill;
            ButtonCalibrationPage.FlatAppearance.BorderSize = 0;
            ButtonCalibrationPage.FlatStyle = FlatStyle.Flat;
            ButtonCalibrationPage.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonCalibrationPage.ForeColor = Color.DimGray;
            ButtonCalibrationPage.Image = Properties.Resources.azimuth_24px;
            ButtonCalibrationPage.Location = new Point(8, 176);
            ButtonCalibrationPage.Margin = new Padding(8);
            ButtonCalibrationPage.Name = "ButtonCalibrationPage";
            ButtonCalibrationPage.Size = new Size(74, 68);
            ButtonCalibrationPage.TabIndex = 3;
            ButtonCalibrationPage.Text = "Kalibrasyon";
            ButtonCalibrationPage.TextAlign = ContentAlignment.BottomCenter;
            ButtonCalibrationPage.UseVisualStyleBackColor = true;
            ButtonCalibrationPage.Click += ButtonCalibrationPage_Click;
            // 
            // ButtonSimulationPage
            // 
            ButtonSimulationPage.Dock = DockStyle.Fill;
            ButtonSimulationPage.FlatAppearance.BorderSize = 0;
            ButtonSimulationPage.FlatStyle = FlatStyle.Flat;
            ButtonSimulationPage.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSimulationPage.ForeColor = Color.DimGray;
            ButtonSimulationPage.Image = Properties.Resources.monitor_24px;
            ButtonSimulationPage.Location = new Point(8, 92);
            ButtonSimulationPage.Margin = new Padding(8);
            ButtonSimulationPage.Name = "ButtonSimulationPage";
            ButtonSimulationPage.Size = new Size(74, 68);
            ButtonSimulationPage.TabIndex = 2;
            ButtonSimulationPage.Text = "Simülasyon";
            ButtonSimulationPage.TextAlign = ContentAlignment.BottomCenter;
            ButtonSimulationPage.UseVisualStyleBackColor = true;
            ButtonSimulationPage.Click += ButtonSimulationPage_Click;
            // 
            // ButtonHomePage
            // 
            ButtonHomePage.Dock = DockStyle.Fill;
            ButtonHomePage.FlatAppearance.BorderSize = 0;
            ButtonHomePage.FlatStyle = FlatStyle.Flat;
            ButtonHomePage.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonHomePage.ForeColor = Color.DimGray;
            ButtonHomePage.Image = Properties.Resources.filled_home_24px;
            ButtonHomePage.Location = new Point(8, 8);
            ButtonHomePage.Margin = new Padding(8);
            ButtonHomePage.Name = "ButtonHomePage";
            ButtonHomePage.Size = new Size(74, 68);
            ButtonHomePage.TabIndex = 1;
            ButtonHomePage.Text = "Anasayfa";
            ButtonHomePage.TextAlign = ContentAlignment.BottomCenter;
            ButtonHomePage.UseVisualStyleBackColor = true;
            ButtonHomePage.Click += ButtonHomePage_Click;
            // 
            // PanelContent
            // 
            PanelContent.Dock = DockStyle.Fill;
            PanelContent.Location = new Point(90, 0);
            PanelContent.Name = "PanelContent";
            PanelContent.Size = new Size(1174, 681);
            PanelContent.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1264, 681);
            Controls.Add(PanelContent);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(1280, 720);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Main_Load;
            SizeChanged += Main_SizeChanged;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button ButtonHomePage;
        private Button button8;
        private Button ButtonSettingPage;
        private Button ButtonReportingPage;
        private Button ButtonMailPage;
        private Button ButtonCalibrationPage;
        private Button ButtonSimulationPage;
        private Panel PanelContent;
    }
}