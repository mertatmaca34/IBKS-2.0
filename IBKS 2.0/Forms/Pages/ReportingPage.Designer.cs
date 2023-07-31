namespace IBKS_2._0.Forms.Pages
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
            tableLayoutPanel1 = new TableLayoutPanel();
            titleBarControl1 = new Components.TitleBarControl();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox6 = new GroupBox();
            RadioButtonLogData = new RadioButton();
            RadioButtonCalibrationData = new RadioButton();
            RadioButtonInstantData = new RadioButton();
            groupBox3 = new GroupBox();
            RadioButtonSortByLast = new RadioButton();
            RadioButtonSortByFirst = new RadioButton();
            groupBox2 = new GroupBox();
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
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewDatas).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.4575386F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.54246F));
            tableLayoutPanel1.Controls.Add(titleBarControl1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(8);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 63.5410919F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 36.4589081F));
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
            tableLayoutPanel2.Size = new Size(207, 617);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.White;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(groupBox6, 0, 0);
            tableLayoutPanel3.Controls.Add(groupBox3, 0, 3);
            tableLayoutPanel3.Controls.Add(groupBox2, 0, 2);
            tableLayoutPanel3.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel3.Controls.Add(ButtonGenerate, 0, 4);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tableLayoutPanel3.Location = new Point(1, 1);
            tableLayoutPanel3.Margin = new Padding(1);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(3);
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.972085F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 13.1362886F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 29.06404F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 13.1362886F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 31.6912975F));
            tableLayoutPanel3.Size = new Size(205, 615);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(RadioButtonLogData);
            groupBox6.Controls.Add(RadioButtonCalibrationData);
            groupBox6.Controls.Add(RadioButtonInstantData);
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox6.Location = new Point(6, 6);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(193, 73);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            groupBox6.Text = "RAPOR TİPİ";
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
            groupBox3.Size = new Size(193, 74);
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
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(6, 165);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(193, 171);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "TARİH";
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
            groupBox1.Location = new Point(6, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(193, 74);
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
            // 
            // ButtonGenerate
            // 
            ButtonGenerate.BackColor = Color.FromArgb(0, 131, 200);
            ButtonGenerate.Dock = DockStyle.Top;
            ButtonGenerate.ForeColor = Color.White;
            ButtonGenerate.Location = new Point(6, 422);
            ButtonGenerate.Name = "ButtonGenerate";
            ButtonGenerate.Size = new Size(193, 40);
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
            tableLayoutPanel4.Location = new Point(224, 49);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel1.SetRowSpan(tableLayoutPanel4, 2);
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(935, 617);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // DataGridViewDatas
            // 
            DataGridViewDatas.BackgroundColor = Color.White;
            DataGridViewDatas.BorderStyle = BorderStyle.None;
            DataGridViewDatas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewDatas.Dock = DockStyle.Fill;
            DataGridViewDatas.Location = new Point(1, 1);
            DataGridViewDatas.Margin = new Padding(1);
            DataGridViewDatas.Name = "DataGridViewDatas";
            DataGridViewDatas.RowTemplate.Height = 25;
            DataGridViewDatas.Size = new Size(933, 615);
            DataGridViewDatas.TabIndex = 0;
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
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewDatas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Components.TitleBarControl titleBarControl1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
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
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridView DataGridViewDatas;
        private GroupBox groupBox6;
        private RadioButton RadioButtonLogData;
        private RadioButton RadioButtonCalibrationData;
        private RadioButton RadioButtonInstantData;
    }
}