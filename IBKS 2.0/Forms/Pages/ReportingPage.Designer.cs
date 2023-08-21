namespace ibks.Forms.Pages
{
    partial class ReportingPage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            titleBarControl1 = new Components.TitleBarControl();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            GroupBoxReportTypes = new GroupBox();
            RadioButtonLogData = new RadioButton();
            RadioButtonSampleData = new RadioButton();
            RadioButtonCalibrationData = new RadioButton();
            RadioButtonInstantData = new RadioButton();
            groupBox3 = new GroupBox();
            RadioButtonSortByLast = new RadioButton();
            RadioButtonSortByFirst = new RadioButton();
            GroupBoxDate = new GroupBox();
            groupBox5 = new GroupBox();
            DateTimePickerLastTime = new DateTimePicker();
            DateTimePickerLastDate = new DateTimePicker();
            groupBox4 = new GroupBox();
            DateTimePickerFirstTime = new DateTimePicker();
            DateTimePickerFirstDate = new DateTimePicker();
            groupBox1 = new GroupBox();
            RadioButtonCustom = new RadioButton();
            RadioButtonMonthly = new RadioButton();
            RadioButtonWeekly = new RadioButton();
            RadioButtonDaily = new RadioButton();
            ButtonGenerate = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            DataGridViewDatas = new DataGridView();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            ButtonSaveAsExcel = new Button();
            ButtonSaveAsPdf = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            GroupBoxReportTypes.SuspendLayout();
            groupBox3.SuspendLayout();
            GroupBoxDate.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewDatas).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(titleBarControl1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(8);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1170, 677);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // titleBarControl1
            // 
            titleBarControl1.BackColor = Color.FromArgb(235, 235, 235);
            tableLayoutPanel1.SetColumnSpan(titleBarControl1, 2);
            titleBarControl1.Dock = DockStyle.Fill;
            titleBarControl1.Location = new Point(11, 11);
            titleBarControl1.Name = "titleBarControl1";
            titleBarControl1.Padding = new Padding(1);
            titleBarControl1.Size = new Size(1148, 32);
            titleBarControl1.TabIndex = 0;
            titleBarControl1.TitleBarText = "Raporlama Ekranı";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(235, 235, 235);
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(11, 49);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel1.SetRowSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(214, 617);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.White;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(GroupBoxReportTypes, 0, 0);
            tableLayoutPanel3.Controls.Add(groupBox3, 0, 3);
            tableLayoutPanel3.Controls.Add(GroupBoxDate, 0, 2);
            tableLayoutPanel3.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel3.Controls.Add(ButtonGenerate, 0, 4);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tableLayoutPanel3.Location = new Point(1, 1);
            tableLayoutPanel3.Margin = new Padding(1);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(3);
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 176F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(212, 615);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // GroupBoxReportTypes
            // 
            GroupBoxReportTypes.Controls.Add(RadioButtonLogData);
            GroupBoxReportTypes.Controls.Add(RadioButtonSampleData);
            GroupBoxReportTypes.Controls.Add(RadioButtonCalibrationData);
            GroupBoxReportTypes.Controls.Add(RadioButtonInstantData);
            GroupBoxReportTypes.Dock = DockStyle.Fill;
            GroupBoxReportTypes.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            GroupBoxReportTypes.Location = new Point(6, 6);
            GroupBoxReportTypes.Name = "GroupBoxReportTypes";
            GroupBoxReportTypes.Size = new Size(200, 74);
            GroupBoxReportTypes.TabIndex = 5;
            GroupBoxReportTypes.TabStop = false;
            GroupBoxReportTypes.Text = "RAPOR TİPİ";
            // 
            // RadioButtonLogData
            // 
            RadioButtonLogData.AutoSize = true;
            RadioButtonLogData.Location = new Point(6, 47);
            RadioButtonLogData.Name = "RadioButtonLogData";
            RadioButtonLogData.Size = new Size(53, 19);
            RadioButtonLogData.TabIndex = 2;
            RadioButtonLogData.TabStop = true;
            RadioButtonLogData.Text = "Kayıt";
            RadioButtonLogData.UseVisualStyleBackColor = true;
            // 
            // RadioButtonSampleData
            // 
            RadioButtonSampleData.AutoSize = true;
            RadioButtonSampleData.Location = new Point(88, 47);
            RadioButtonSampleData.Name = "RadioButtonSampleData";
            RadioButtonSampleData.Size = new Size(72, 19);
            RadioButtonSampleData.TabIndex = 2;
            RadioButtonSampleData.TabStop = true;
            RadioButtonSampleData.Text = "Numune";
            RadioButtonSampleData.UseVisualStyleBackColor = true;
            // 
            // RadioButtonCalibrationData
            // 
            RadioButtonCalibrationData.AutoSize = true;
            RadioButtonCalibrationData.Location = new Point(88, 22);
            RadioButtonCalibrationData.Name = "RadioButtonCalibrationData";
            RadioButtonCalibrationData.Size = new Size(92, 19);
            RadioButtonCalibrationData.TabIndex = 2;
            RadioButtonCalibrationData.TabStop = true;
            RadioButtonCalibrationData.Text = "Kalibrasyon";
            RadioButtonCalibrationData.UseVisualStyleBackColor = true;
            // 
            // RadioButtonInstantData
            // 
            RadioButtonInstantData.AutoSize = true;
            RadioButtonInstantData.Location = new Point(6, 22);
            RadioButtonInstantData.Name = "RadioButtonInstantData";
            RadioButtonInstantData.Size = new Size(62, 19);
            RadioButtonInstantData.TabIndex = 2;
            RadioButtonInstantData.TabStop = true;
            RadioButtonInstantData.Text = "Ölçüm";
            RadioButtonInstantData.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(RadioButtonSortByLast);
            groupBox3.Controls.Add(RadioButtonSortByFirst);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(6, 342);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 74);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "SIRALAMA";
            // 
            // RadioButtonSortByLast
            // 
            RadioButtonSortByLast.AutoSize = true;
            RadioButtonSortByLast.Location = new Point(6, 46);
            RadioButtonSortByLast.Name = "RadioButtonSortByLast";
            RadioButtonSortByLast.Size = new Size(115, 19);
            RadioButtonSortByLast.TabIndex = 2;
            RadioButtonSortByLast.TabStop = true;
            RadioButtonSortByLast.Text = "Son Veriye Göre";
            RadioButtonSortByLast.UseVisualStyleBackColor = true;
            // 
            // RadioButtonSortByFirst
            // 
            RadioButtonSortByFirst.AutoSize = true;
            RadioButtonSortByFirst.Location = new Point(6, 21);
            RadioButtonSortByFirst.Name = "RadioButtonSortByFirst";
            RadioButtonSortByFirst.Size = new Size(106, 19);
            RadioButtonSortByFirst.TabIndex = 2;
            RadioButtonSortByFirst.TabStop = true;
            RadioButtonSortByFirst.Text = "İlk Veriye Göre";
            RadioButtonSortByFirst.UseVisualStyleBackColor = true;
            // 
            // GroupBoxDate
            // 
            GroupBoxDate.Controls.Add(groupBox5);
            GroupBoxDate.Controls.Add(groupBox4);
            GroupBoxDate.Dock = DockStyle.Fill;
            GroupBoxDate.Enabled = false;
            GroupBoxDate.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            GroupBoxDate.Location = new Point(6, 166);
            GroupBoxDate.Name = "GroupBoxDate";
            GroupBoxDate.Size = new Size(200, 170);
            GroupBoxDate.TabIndex = 3;
            GroupBoxDate.TabStop = false;
            GroupBoxDate.Text = "TARİH";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(DateTimePickerLastTime);
            groupBox5.Controls.Add(DateTimePickerLastDate);
            groupBox5.Location = new Point(6, 95);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(187, 69);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Bitiş";
            // 
            // DateTimePickerLastTime
            // 
            DateTimePickerLastTime.Dock = DockStyle.Bottom;
            DateTimePickerLastTime.Format = DateTimePickerFormat.Time;
            DateTimePickerLastTime.Location = new Point(3, 45);
            DateTimePickerLastTime.Name = "DateTimePickerLastTime";
            DateTimePickerLastTime.ShowUpDown = true;
            DateTimePickerLastTime.Size = new Size(181, 21);
            DateTimePickerLastTime.TabIndex = 3;
            DateTimePickerLastTime.Value = new DateTime(2023, 7, 31, 0, 0, 0, 0);
            // 
            // DateTimePickerLastDate
            // 
            DateTimePickerLastDate.Dock = DockStyle.Top;
            DateTimePickerLastDate.Location = new Point(3, 17);
            DateTimePickerLastDate.Name = "DateTimePickerLastDate";
            DateTimePickerLastDate.Size = new Size(181, 21);
            DateTimePickerLastDate.TabIndex = 2;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(DateTimePickerFirstTime);
            groupBox4.Controls.Add(DateTimePickerFirstDate);
            groupBox4.Location = new Point(6, 20);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(187, 69);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Başlangıç";
            // 
            // DateTimePickerFirstTime
            // 
            DateTimePickerFirstTime.Dock = DockStyle.Bottom;
            DateTimePickerFirstTime.Format = DateTimePickerFormat.Time;
            DateTimePickerFirstTime.Location = new Point(3, 45);
            DateTimePickerFirstTime.Name = "DateTimePickerFirstTime";
            DateTimePickerFirstTime.ShowUpDown = true;
            DateTimePickerFirstTime.Size = new Size(181, 21);
            DateTimePickerFirstTime.TabIndex = 3;
            DateTimePickerFirstTime.Value = new DateTime(2023, 7, 31, 0, 0, 0, 0);
            // 
            // DateTimePickerFirstDate
            // 
            DateTimePickerFirstDate.Dock = DockStyle.Top;
            DateTimePickerFirstDate.Location = new Point(3, 17);
            DateTimePickerFirstDate.Name = "DateTimePickerFirstDate";
            DateTimePickerFirstDate.Size = new Size(181, 21);
            DateTimePickerFirstDate.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RadioButtonCustom);
            groupBox1.Controls.Add(RadioButtonMonthly);
            groupBox1.Controls.Add(RadioButtonWeekly);
            groupBox1.Controls.Add(RadioButtonDaily);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(6, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 74);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "PERİYOT";
            // 
            // RadioButtonCustom
            // 
            RadioButtonCustom.AutoSize = true;
            RadioButtonCustom.Location = new Point(88, 47);
            RadioButtonCustom.Name = "RadioButtonCustom";
            RadioButtonCustom.Size = new Size(50, 19);
            RadioButtonCustom.TabIndex = 2;
            RadioButtonCustom.TabStop = true;
            RadioButtonCustom.Text = "Özel";
            RadioButtonCustom.UseVisualStyleBackColor = true;
            RadioButtonCustom.CheckedChanged += RadioButtonCustom_CheckedChanged;
            // 
            // RadioButtonMonthly
            // 
            RadioButtonMonthly.AutoSize = true;
            RadioButtonMonthly.Location = new Point(6, 47);
            RadioButtonMonthly.Name = "RadioButtonMonthly";
            RadioButtonMonthly.Size = new Size(52, 19);
            RadioButtonMonthly.TabIndex = 2;
            RadioButtonMonthly.TabStop = true;
            RadioButtonMonthly.Text = "Aylık";
            RadioButtonMonthly.UseVisualStyleBackColor = true;
            RadioButtonMonthly.CheckedChanged += RadioButtonMonthly_CheckedChanged;
            // 
            // RadioButtonWeekly
            // 
            RadioButtonWeekly.AutoSize = true;
            RadioButtonWeekly.Location = new Point(88, 22);
            RadioButtonWeekly.Name = "RadioButtonWeekly";
            RadioButtonWeekly.Size = new Size(68, 19);
            RadioButtonWeekly.TabIndex = 2;
            RadioButtonWeekly.TabStop = true;
            RadioButtonWeekly.Text = "Haftalık";
            RadioButtonWeekly.UseVisualStyleBackColor = true;
            RadioButtonWeekly.CheckedChanged += RadioButtonWeekly_CheckedChanged;
            // 
            // RadioButtonDaily
            // 
            RadioButtonDaily.AutoSize = true;
            RadioButtonDaily.Location = new Point(6, 22);
            RadioButtonDaily.Name = "RadioButtonDaily";
            RadioButtonDaily.Size = new Size(64, 19);
            RadioButtonDaily.TabIndex = 2;
            RadioButtonDaily.TabStop = true;
            RadioButtonDaily.Text = "Günlük";
            RadioButtonDaily.UseVisualStyleBackColor = true;
            RadioButtonDaily.CheckedChanged += RadioButtonDaily_CheckedChanged;
            // 
            // ButtonGenerate
            // 
            ButtonGenerate.BackColor = Color.FromArgb(0, 131, 200);
            ButtonGenerate.Dock = DockStyle.Top;
            ButtonGenerate.ForeColor = Color.White;
            ButtonGenerate.Location = new Point(6, 422);
            ButtonGenerate.Name = "ButtonGenerate";
            ButtonGenerate.Size = new Size(200, 40);
            ButtonGenerate.TabIndex = 2;
            ButtonGenerate.Text = "OLUŞTUR";
            ButtonGenerate.UseVisualStyleBackColor = false;
            ButtonGenerate.Click += ButtonGenerate_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.FromArgb(235, 235, 235);
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(DataGridViewDatas, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(231, 89);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(928, 577);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // DataGridViewDatas
            // 
            DataGridViewDatas.AllowUserToDeleteRows = false;
            DataGridViewDatas.AllowUserToResizeRows = false;
            DataGridViewDatas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewDatas.BackgroundColor = Color.White;
            DataGridViewDatas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 131, 200);
            dataGridViewCellStyle1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridViewDatas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewDatas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewDatas.Dock = DockStyle.Fill;
            DataGridViewDatas.Location = new Point(1, 1);
            DataGridViewDatas.Margin = new Padding(1);
            DataGridViewDatas.Name = "DataGridViewDatas";
            DataGridViewDatas.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewDatas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewDatas.RowTemplate.Height = 25;
            DataGridViewDatas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewDatas.Size = new Size(926, 575);
            DataGridViewDatas.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = Color.FromArgb(235, 235, 235);
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(231, 49);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(928, 34);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.BackColor = Color.White;
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 32F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 32F));
            tableLayoutPanel6.Controls.Add(ButtonSaveAsExcel, 1, 0);
            tableLayoutPanel6.Controls.Add(ButtonSaveAsPdf, 2, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(1, 1);
            tableLayoutPanel6.Margin = new Padding(1);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(926, 32);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // ButtonSaveAsExcel
            // 
            ButtonSaveAsExcel.BackgroundImage = Properties.Resources.microsoft_excel_2019_32px;
            ButtonSaveAsExcel.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonSaveAsExcel.Dock = DockStyle.Fill;
            ButtonSaveAsExcel.Location = new Point(865, 3);
            ButtonSaveAsExcel.Name = "ButtonSaveAsExcel";
            ButtonSaveAsExcel.Size = new Size(26, 26);
            ButtonSaveAsExcel.TabIndex = 2;
            ButtonSaveAsExcel.UseVisualStyleBackColor = true;
            ButtonSaveAsExcel.Click += ButtonSaveAsExcel_Click;
            // 
            // ButtonSaveAsPdf
            // 
            ButtonSaveAsPdf.BackgroundImage = Properties.Resources.pdf_32px;
            ButtonSaveAsPdf.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonSaveAsPdf.Dock = DockStyle.Fill;
            ButtonSaveAsPdf.Location = new Point(897, 3);
            ButtonSaveAsPdf.Name = "ButtonSaveAsPdf";
            ButtonSaveAsPdf.Size = new Size(26, 26);
            ButtonSaveAsPdf.TabIndex = 1;
            ButtonSaveAsPdf.UseVisualStyleBackColor = true;
            ButtonSaveAsPdf.Click += ButtonSaveAsPdf_Click;
            // 
            // ReportingPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1170, 677);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportingPage";
            Text = "ReportingPage";
            Load += ReportingPage_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            GroupBoxReportTypes.ResumeLayout(false);
            GroupBoxReportTypes.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            GroupBoxDate.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewDatas).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Components.TitleBarControl titleBarControl1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox1;
        private GroupBox GroupBoxDate;
        private GroupBox groupBox3;
        private Button ButtonGenerate;
        private RadioButton RadioButtonCustom;
        private RadioButton RadioButtonMonthly;
        private RadioButton RadioButtonWeekly;
        private RadioButton RadioButtonDaily;
        private GroupBox groupBox4;
        private DateTimePicker DateTimePickerFirstTime;
        private DateTimePicker DateTimePickerFirstDate;
        private GroupBox groupBox5;
        private DateTimePicker DateTimePickerLastTime;
        private DateTimePicker DateTimePickerLastDate;
        private RadioButton RadioButtonSortByFirst;
        private RadioButton RadioButtonSortByLast;
        private GroupBox GroupBoxReportTypes;
        private RadioButton RadioButtonLogData;
        private RadioButton RadioButtonCalibrationData;
        private RadioButton RadioButtonInstantData;
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridView DataGridViewDatas;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private Button ButtonSaveAsPdf;
        private Button ButtonSaveAsExcel;
        private RadioButton RadioButtonSampleData;
    }
}