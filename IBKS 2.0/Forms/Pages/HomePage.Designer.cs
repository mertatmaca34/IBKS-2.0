namespace IBKS_2._0.Forms.Pages
{
    partial class HomePage
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            ChannelDebi = new Components.ChannelControl();
            ChannelAkisHizi = new Components.ChannelControl();
            ChannelKoi = new Components.ChannelControl();
            ChannelIletkenlik = new Components.ChannelControl();
            ChannelPh = new Components.ChannelControl();
            ChannelSicaklik = new Components.ChannelControl();
            ChannelCozunmusOksijen = new Components.ChannelControl();
            channelControl1 = new Components.ChannelControl();
            ChannelAkm = new Components.ChannelControl();
            tableLayoutPanel3 = new TableLayoutPanel();
            channelControl10 = new Components.ChannelControl();
            digitalSensorControl1 = new Components.DigitalSensorControl();
            digitalSensorControl2 = new Components.DigitalSensorControl();
            digitalSensorControl3 = new Components.DigitalSensorControl();
            digitalSensorControl4 = new Components.DigitalSensorControl();
            digitalSensorControl5 = new Components.DigitalSensorControl();
            digitalSensorControl6 = new Components.DigitalSensorControl();
            digitalSensorControl7 = new Components.DigitalSensorControl();
            digitalSensorControl8 = new Components.DigitalSensorControl();
            digitalSensorControl9 = new Components.DigitalSensorControl();
            tableLayoutPanel5 = new TableLayoutPanel();
            washingCalibrationInfoControl1 = new Components.WashingCalibrationInfoControl();
            TimerPlcRead = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.WhiteSmoke;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel1.Controls.Add(washingCalibrationInfoControl1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.43F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.57F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(1170, 677);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.WhiteSmoke;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(ChannelDebi, 0, 8);
            tableLayoutPanel2.Controls.Add(ChannelAkisHizi, 0, 7);
            tableLayoutPanel2.Controls.Add(ChannelKoi, 0, 6);
            tableLayoutPanel2.Controls.Add(ChannelIletkenlik, 0, 5);
            tableLayoutPanel2.Controls.Add(ChannelPh, 0, 4);
            tableLayoutPanel2.Controls.Add(ChannelSicaklik, 0, 3);
            tableLayoutPanel2.Controls.Add(ChannelCozunmusOksijen, 0, 2);
            tableLayoutPanel2.Controls.Add(channelControl1, 0, 0);
            tableLayoutPanel2.Controls.Add(ChannelAkm, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(13, 13);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 9;
            tableLayoutPanel1.SetRowSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(569, 615);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // ChannelDebi
            // 
            ChannelDebi.AvgDataOf60Min = "-";
            ChannelDebi.ChannelDescription = "Tesis Debisi";
            ChannelDebi.ChannelName = "Debi";
            ChannelDebi.Dock = DockStyle.Fill;
            ChannelDebi.InstantData = "-";
            ChannelDebi.Location = new Point(3, 547);
            ChannelDebi.Name = "ChannelDebi";
            ChannelDebi.Size = new Size(563, 65);
            ChannelDebi.TabIndex = 8;
            // 
            // ChannelAkisHizi
            // 
            ChannelAkisHizi.AvgDataOf60Min = "-";
            ChannelAkisHizi.ChannelDescription = "Tank dolum boşaltım hızı";
            ChannelAkisHizi.ChannelName = "Akış Hızı";
            ChannelAkisHizi.Dock = DockStyle.Fill;
            ChannelAkisHizi.InstantData = "-";
            ChannelAkisHizi.Location = new Point(3, 479);
            ChannelAkisHizi.Name = "ChannelAkisHizi";
            ChannelAkisHizi.Size = new Size(563, 62);
            ChannelAkisHizi.TabIndex = 7;
            // 
            // ChannelKoi
            // 
            ChannelKoi.AvgDataOf60Min = "-";
            ChannelKoi.ChannelDescription = "Kimyasal Oksijen İhtiyacı";
            ChannelKoi.ChannelName = "KOi";
            ChannelKoi.Dock = DockStyle.Fill;
            ChannelKoi.InstantData = "-";
            ChannelKoi.Location = new Point(3, 411);
            ChannelKoi.Name = "ChannelKoi";
            ChannelKoi.Size = new Size(563, 62);
            ChannelKoi.TabIndex = 6;
            // 
            // ChannelIletkenlik
            // 
            ChannelIletkenlik.AvgDataOf60Min = "-";
            ChannelIletkenlik.ChannelDescription = "Sudaki İletkenlik seviyesi";
            ChannelIletkenlik.ChannelName = "İletkenlik";
            ChannelIletkenlik.Dock = DockStyle.Fill;
            ChannelIletkenlik.InstantData = "-";
            ChannelIletkenlik.Location = new Point(3, 343);
            ChannelIletkenlik.Name = "ChannelIletkenlik";
            ChannelIletkenlik.Size = new Size(563, 62);
            ChannelIletkenlik.TabIndex = 5;
            // 
            // ChannelPh
            // 
            ChannelPh.AvgDataOf60Min = "-";
            ChannelPh.ChannelDescription = "Potansiyel Hidrojen";
            ChannelPh.ChannelName = "pH";
            ChannelPh.Dock = DockStyle.Fill;
            ChannelPh.InstantData = "-";
            ChannelPh.Location = new Point(3, 275);
            ChannelPh.Name = "ChannelPh";
            ChannelPh.Size = new Size(563, 62);
            ChannelPh.TabIndex = 4;
            // 
            // ChannelSicaklik
            // 
            ChannelSicaklik.AvgDataOf60Min = "-";
            ChannelSicaklik.ChannelDescription = "Kabin içi sıcaklığı";
            ChannelSicaklik.ChannelName = "Sıcaklık";
            ChannelSicaklik.Dock = DockStyle.Fill;
            ChannelSicaklik.InstantData = "-";
            ChannelSicaklik.Location = new Point(3, 207);
            ChannelSicaklik.Name = "ChannelSicaklik";
            ChannelSicaklik.Size = new Size(563, 62);
            ChannelSicaklik.TabIndex = 3;
            // 
            // ChannelCozunmusOksijen
            // 
            ChannelCozunmusOksijen.AvgDataOf60Min = "-";
            ChannelCozunmusOksijen.ChannelDescription = "Suda bulunan gaz Oksijen miktarı";
            ChannelCozunmusOksijen.ChannelName = "Çözünmüş Oksijen";
            ChannelCozunmusOksijen.Dock = DockStyle.Fill;
            ChannelCozunmusOksijen.InstantData = "-";
            ChannelCozunmusOksijen.Location = new Point(3, 139);
            ChannelCozunmusOksijen.Name = "ChannelCozunmusOksijen";
            ChannelCozunmusOksijen.Size = new Size(563, 62);
            ChannelCozunmusOksijen.TabIndex = 2;
            // 
            // channelControl1
            // 
            channelControl1.AvgDataOf60Min = "SAATLİK ORTALAMA";
            channelControl1.ChannelDescription = "SENSÖR İSİMLERİ";
            channelControl1.ChannelName = "ANALOG SENSÖRLER";
            channelControl1.ChannelStatement = Color.FromArgb(0, 131, 200);
            channelControl1.Dock = DockStyle.Fill;
            channelControl1.InstantData = "ANLIK VERİ";
            channelControl1.Location = new Point(3, 3);
            channelControl1.Name = "channelControl1";
            channelControl1.PanelSplit1Visible = false;
            channelControl1.PanelSplit2Visible = false;
            channelControl1.Size = new Size(563, 62);
            channelControl1.TabIndex = 0;
            // 
            // ChannelAkm
            // 
            ChannelAkm.AvgDataOf60Min = "-";
            ChannelAkm.ChannelDescription = "Askıda Katı Madde";
            ChannelAkm.ChannelName = "AKM";
            ChannelAkm.Dock = DockStyle.Fill;
            ChannelAkm.InstantData = "-";
            ChannelAkm.Location = new Point(3, 71);
            ChannelAkm.Name = "ChannelAkm";
            ChannelAkm.Size = new Size(563, 62);
            ChannelAkm.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.WhiteSmoke;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(channelControl10, 0, 0);
            tableLayoutPanel3.Controls.Add(digitalSensorControl1, 0, 1);
            tableLayoutPanel3.Controls.Add(digitalSensorControl2, 1, 1);
            tableLayoutPanel3.Controls.Add(digitalSensorControl3, 2, 1);
            tableLayoutPanel3.Controls.Add(digitalSensorControl4, 2, 2);
            tableLayoutPanel3.Controls.Add(digitalSensorControl5, 1, 2);
            tableLayoutPanel3.Controls.Add(digitalSensorControl6, 0, 2);
            tableLayoutPanel3.Controls.Add(digitalSensorControl7, 0, 3);
            tableLayoutPanel3.Controls.Add(digitalSensorControl8, 1, 3);
            tableLayoutPanel3.Controls.Add(digitalSensorControl9, 2, 3);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(588, 13);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Size = new Size(569, 201);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // channelControl10
            // 
            channelControl10.AvgDataOf60Min = "";
            channelControl10.ChannelDescription = "SENSÖR İSİMLERİ";
            channelControl10.ChannelName = "DİJİTAL SENSÖRLER";
            channelControl10.ChannelStatement = Color.FromArgb(0, 131, 200);
            tableLayoutPanel3.SetColumnSpan(channelControl10, 3);
            channelControl10.InstantData = "";
            channelControl10.Location = new Point(3, 3);
            channelControl10.Name = "channelControl10";
            channelControl10.PanelSplit1Visible = false;
            channelControl10.PanelSplit2Visible = false;
            channelControl10.Size = new Size(563, 44);
            channelControl10.TabIndex = 0;
            // 
            // digitalSensorControl1
            // 
            digitalSensorControl1.BackColor = Color.White;
            digitalSensorControl1.Dock = DockStyle.Fill;
            digitalSensorControl1.Location = new Point(3, 53);
            digitalSensorControl1.Name = "digitalSensorControl1";
            digitalSensorControl1.SensorDescription = "-";
            digitalSensorControl1.SensorName = "-";
            digitalSensorControl1.Size = new Size(183, 44);
            digitalSensorControl1.TabIndex = 1;
            // 
            // digitalSensorControl2
            // 
            digitalSensorControl2.BackColor = Color.White;
            digitalSensorControl2.Dock = DockStyle.Fill;
            digitalSensorControl2.Location = new Point(192, 53);
            digitalSensorControl2.Name = "digitalSensorControl2";
            digitalSensorControl2.SensorDescription = "-";
            digitalSensorControl2.SensorName = "-";
            digitalSensorControl2.Size = new Size(183, 44);
            digitalSensorControl2.TabIndex = 1;
            // 
            // digitalSensorControl3
            // 
            digitalSensorControl3.BackColor = Color.White;
            digitalSensorControl3.Dock = DockStyle.Fill;
            digitalSensorControl3.Location = new Point(381, 53);
            digitalSensorControl3.Name = "digitalSensorControl3";
            digitalSensorControl3.SensorDescription = "-";
            digitalSensorControl3.SensorName = "-";
            digitalSensorControl3.Size = new Size(185, 44);
            digitalSensorControl3.TabIndex = 1;
            // 
            // digitalSensorControl4
            // 
            digitalSensorControl4.BackColor = Color.White;
            digitalSensorControl4.Dock = DockStyle.Fill;
            digitalSensorControl4.Location = new Point(381, 103);
            digitalSensorControl4.Name = "digitalSensorControl4";
            digitalSensorControl4.SensorDescription = "-";
            digitalSensorControl4.SensorName = "-";
            digitalSensorControl4.Size = new Size(185, 44);
            digitalSensorControl4.TabIndex = 1;
            // 
            // digitalSensorControl5
            // 
            digitalSensorControl5.BackColor = Color.White;
            digitalSensorControl5.Dock = DockStyle.Fill;
            digitalSensorControl5.Location = new Point(192, 103);
            digitalSensorControl5.Name = "digitalSensorControl5";
            digitalSensorControl5.SensorDescription = "-";
            digitalSensorControl5.SensorName = "-";
            digitalSensorControl5.Size = new Size(183, 44);
            digitalSensorControl5.TabIndex = 1;
            // 
            // digitalSensorControl6
            // 
            digitalSensorControl6.BackColor = Color.White;
            digitalSensorControl6.Dock = DockStyle.Fill;
            digitalSensorControl6.Location = new Point(3, 103);
            digitalSensorControl6.Name = "digitalSensorControl6";
            digitalSensorControl6.SensorDescription = "-";
            digitalSensorControl6.SensorName = "-";
            digitalSensorControl6.Size = new Size(183, 44);
            digitalSensorControl6.TabIndex = 1;
            // 
            // digitalSensorControl7
            // 
            digitalSensorControl7.BackColor = Color.White;
            digitalSensorControl7.Dock = DockStyle.Fill;
            digitalSensorControl7.Location = new Point(3, 153);
            digitalSensorControl7.Name = "digitalSensorControl7";
            digitalSensorControl7.SensorDescription = "-";
            digitalSensorControl7.SensorName = "-";
            digitalSensorControl7.Size = new Size(183, 45);
            digitalSensorControl7.TabIndex = 1;
            // 
            // digitalSensorControl8
            // 
            digitalSensorControl8.BackColor = Color.White;
            digitalSensorControl8.Dock = DockStyle.Fill;
            digitalSensorControl8.Location = new Point(192, 153);
            digitalSensorControl8.Name = "digitalSensorControl8";
            digitalSensorControl8.SensorDescription = "-";
            digitalSensorControl8.SensorName = "-";
            digitalSensorControl8.Size = new Size(183, 45);
            digitalSensorControl8.TabIndex = 1;
            // 
            // digitalSensorControl9
            // 
            digitalSensorControl9.BackColor = Color.White;
            digitalSensorControl9.Dock = DockStyle.Fill;
            digitalSensorControl9.Location = new Point(381, 153);
            digitalSensorControl9.Name = "digitalSensorControl9";
            digitalSensorControl9.SensorDescription = "-";
            digitalSensorControl9.SensorName = "-";
            digitalSensorControl9.Size = new Size(185, 45);
            digitalSensorControl9.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = Color.White;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel5, 2);
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(13, 634);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(1144, 30);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // washingCalibrationInfoControl1
            // 
            washingCalibrationInfoControl1.BackColor = Color.FromArgb(235, 235, 235);
            washingCalibrationInfoControl1.Dock = DockStyle.Fill;
            washingCalibrationInfoControl1.LastWashAkm = "     -";
            washingCalibrationInfoControl1.LastWashAkmImage = null;
            washingCalibrationInfoControl1.LastWashCozunmusOksijen = "     -";
            washingCalibrationInfoControl1.LastWashCozunmusOksijenImage = null;
            washingCalibrationInfoControl1.LastWashDebi = "     -";
            washingCalibrationInfoControl1.LastWashDebiImage = null;
            washingCalibrationInfoControl1.LastWashDesarjDebi = "     -";
            washingCalibrationInfoControl1.LastWashDesarjDebiImage = null;
            washingCalibrationInfoControl1.LastWashHariciDebi = "     -";
            washingCalibrationInfoControl1.LastWashHariciDebi2 = "     -";
            washingCalibrationInfoControl1.LastWashHariciDebi2Image = null;
            washingCalibrationInfoControl1.LastWashHariciDebiImage = null;
            washingCalibrationInfoControl1.LastWashIletkenlik = "     -";
            washingCalibrationInfoControl1.LastWashIletkenlikImage = null;
            washingCalibrationInfoControl1.LastWashKoi = "     -";
            washingCalibrationInfoControl1.LastWashKoiImage = null;
            washingCalibrationInfoControl1.LastWashPh = "     -";
            washingCalibrationInfoControl1.LastWashPhImage = null;
            washingCalibrationInfoControl1.LastWashSicaklik = "     -";
            washingCalibrationInfoControl1.LastWashSicaklikImage = null;
            washingCalibrationInfoControl1.Location = new Point(588, 220);
            washingCalibrationInfoControl1.Name = "washingCalibrationInfoControl1";
            washingCalibrationInfoControl1.Padding = new Padding(1);
            washingCalibrationInfoControl1.Size = new Size(569, 408);
            washingCalibrationInfoControl1.TabIndex = 4;
            // 
            // TimerPlcRead
            // 
            TimerPlcRead.Enabled = true;
            TimerPlcRead.Interval = 3000;
            TimerPlcRead.Tick += TimerPlcRead_Tick;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 677);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomePage";
            Text = "HomePage";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private Components.ChannelControl channelControl1;
        private Components.ChannelControl channelControl10;
        private Components.DigitalSensorControl digitalSensorControl1;
        private Components.DigitalSensorControl digitalSensorControl2;
        private Components.DigitalSensorControl digitalSensorControl3;
        private Components.DigitalSensorControl digitalSensorControl4;
        private Components.DigitalSensorControl digitalSensorControl5;
        private Components.DigitalSensorControl digitalSensorControl6;
        private Components.DigitalSensorControl digitalSensorControl7;
        private Components.DigitalSensorControl digitalSensorControl8;
        private Components.DigitalSensorControl digitalSensorControl9;
        private Components.ChannelControl ChannelDebi;
        private Components.ChannelControl ChannelAkisHizi;
        private Components.ChannelControl ChannelKoi;
        private Components.ChannelControl ChannelIletkenlik;
        private Components.ChannelControl ChannelPh;
        private Components.ChannelControl ChannelSicaklik;
        private Components.ChannelControl ChannelCozunmusOksijen;
        private Components.ChannelControl ChannelAkm;
        private Components.WashingCalibrationInfoControl washingCalibrationInfoControl1;
        private System.Windows.Forms.Timer TimerPlcRead;
    }
}