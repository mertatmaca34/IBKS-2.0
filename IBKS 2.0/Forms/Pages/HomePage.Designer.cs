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
            DigitalSensorKapi = new Components.DigitalSensorControl();
            DigitalSensorDuman = new Components.DigitalSensorControl();
            DigitalSensorSuBaskini = new Components.DigitalSensorControl();
            DigitalSensorPompa2Termik = new Components.DigitalSensorControl();
            DigitalSensorPompa1Termik = new Components.DigitalSensorControl();
            DigitalSensorAcilStop = new Components.DigitalSensorControl();
            DigitalSensorTSuPompaTermik = new Components.DigitalSensorControl();
            DigitalSensorYikamaTanki = new Components.DigitalSensorControl();
            DigitalSensorEnerji = new Components.DigitalSensorControl();
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
            tableLayoutPanel3.Controls.Add(DigitalSensorKapi, 0, 1);
            tableLayoutPanel3.Controls.Add(DigitalSensorDuman, 1, 1);
            tableLayoutPanel3.Controls.Add(DigitalSensorSuBaskini, 2, 1);
            tableLayoutPanel3.Controls.Add(DigitalSensorPompa2Termik, 2, 2);
            tableLayoutPanel3.Controls.Add(DigitalSensorPompa1Termik, 1, 2);
            tableLayoutPanel3.Controls.Add(DigitalSensorAcilStop, 0, 2);
            tableLayoutPanel3.Controls.Add(DigitalSensorTSuPompaTermik, 0, 3);
            tableLayoutPanel3.Controls.Add(DigitalSensorYikamaTanki, 1, 3);
            tableLayoutPanel3.Controls.Add(DigitalSensorEnerji, 2, 3);
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
            // DigitalSensorKapi
            // 
            DigitalSensorKapi.BackColor = Color.White;
            DigitalSensorKapi.Dock = DockStyle.Fill;
            DigitalSensorKapi.Location = new Point(3, 53);
            DigitalSensorKapi.Name = "DigitalSensorKapi";
            DigitalSensorKapi.SensorDescription = "Kabin Kapısı";
            DigitalSensorKapi.SensorName = "Kapı";
            DigitalSensorKapi.Size = new Size(183, 44);
            DigitalSensorKapi.TabIndex = 1;
            // 
            // DigitalSensorDuman
            // 
            DigitalSensorDuman.BackColor = Color.White;
            DigitalSensorDuman.Dock = DockStyle.Fill;
            DigitalSensorDuman.Location = new Point(192, 53);
            DigitalSensorDuman.Name = "DigitalSensorDuman";
            DigitalSensorDuman.SensorDescription = "Kabin içi duman durumu";
            DigitalSensorDuman.SensorName = "Duman";
            DigitalSensorDuman.Size = new Size(183, 44);
            DigitalSensorDuman.TabIndex = 1;
            // 
            // DigitalSensorSuBaskini
            // 
            DigitalSensorSuBaskini.BackColor = Color.White;
            DigitalSensorSuBaskini.Dock = DockStyle.Fill;
            DigitalSensorSuBaskini.Location = new Point(381, 53);
            DigitalSensorSuBaskini.Name = "DigitalSensorSuBaskini";
            DigitalSensorSuBaskini.SensorDescription = "Kabiniçi su baskını";
            DigitalSensorSuBaskini.SensorName = "Su Baskını";
            DigitalSensorSuBaskini.Size = new Size(185, 44);
            DigitalSensorSuBaskini.TabIndex = 1;
            // 
            // DigitalSensorPompa2Termik
            // 
            DigitalSensorPompa2Termik.BackColor = Color.White;
            DigitalSensorPompa2Termik.Dock = DockStyle.Fill;
            DigitalSensorPompa2Termik.Location = new Point(381, 103);
            DigitalSensorPompa2Termik.Name = "DigitalSensorPompa2Termik";
            DigitalSensorPompa2Termik.SensorDescription = "Pompa 2 Termik atma durumu";
            DigitalSensorPompa2Termik.SensorName = "Pompa 2 Termik";
            DigitalSensorPompa2Termik.Size = new Size(185, 44);
            DigitalSensorPompa2Termik.TabIndex = 1;
            // 
            // DigitalSensorPompa1Termik
            // 
            DigitalSensorPompa1Termik.BackColor = Color.White;
            DigitalSensorPompa1Termik.Dock = DockStyle.Fill;
            DigitalSensorPompa1Termik.Location = new Point(192, 103);
            DigitalSensorPompa1Termik.Name = "DigitalSensorPompa1Termik";
            DigitalSensorPompa1Termik.SensorDescription = "Pompa 1 Termik atma durumu";
            DigitalSensorPompa1Termik.SensorName = "Pompa 1 Termik";
            DigitalSensorPompa1Termik.Size = new Size(183, 44);
            DigitalSensorPompa1Termik.TabIndex = 1;
            // 
            // DigitalSensorAcilStop
            // 
            DigitalSensorAcilStop.BackColor = Color.White;
            DigitalSensorAcilStop.Dock = DockStyle.Fill;
            DigitalSensorAcilStop.Location = new Point(3, 103);
            DigitalSensorAcilStop.Name = "DigitalSensorAcilStop";
            DigitalSensorAcilStop.SensorDescription = "Acil Stop butonu durumu";
            DigitalSensorAcilStop.SensorName = "Acil Stop";
            DigitalSensorAcilStop.Size = new Size(183, 44);
            DigitalSensorAcilStop.TabIndex = 1;
            // 
            // DigitalSensorTSuPompaTermik
            // 
            DigitalSensorTSuPompaTermik.BackColor = Color.White;
            DigitalSensorTSuPompaTermik.Dock = DockStyle.Fill;
            DigitalSensorTSuPompaTermik.Location = new Point(3, 153);
            DigitalSensorTSuPompaTermik.Name = "DigitalSensorTSuPompaTermik";
            DigitalSensorTSuPompaTermik.SensorDescription = "Temiz Su P. Termik atma durumu";
            DigitalSensorTSuPompaTermik.SensorName = "T. Su Pompa Termik";
            DigitalSensorTSuPompaTermik.Size = new Size(183, 45);
            DigitalSensorTSuPompaTermik.TabIndex = 1;
            // 
            // DigitalSensorYikamaTanki
            // 
            DigitalSensorYikamaTanki.BackColor = Color.White;
            DigitalSensorYikamaTanki.Dock = DockStyle.Fill;
            DigitalSensorYikamaTanki.Location = new Point(192, 153);
            DigitalSensorYikamaTanki.Name = "DigitalSensorYikamaTanki";
            DigitalSensorYikamaTanki.SensorDescription = "Yıkama Tankı dolu/boş bilgisi";
            DigitalSensorYikamaTanki.SensorName = "Yıkama Tankı";
            DigitalSensorYikamaTanki.Size = new Size(183, 45);
            DigitalSensorYikamaTanki.TabIndex = 1;
            // 
            // DigitalSensorEnerji
            // 
            DigitalSensorEnerji.BackColor = Color.White;
            DigitalSensorEnerji.Dock = DockStyle.Fill;
            DigitalSensorEnerji.Location = new Point(381, 153);
            DigitalSensorEnerji.Name = "DigitalSensorEnerji";
            DigitalSensorEnerji.SensorDescription = "Kabin elektrik enerjisi durumu";
            DigitalSensorEnerji.SensorName = "Enerji";
            DigitalSensorEnerji.Size = new Size(185, 45);
            DigitalSensorEnerji.TabIndex = 1;
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
        private Components.DigitalSensorControl DigitalSensorKapi;
        private Components.DigitalSensorControl DigitalSensorDuman;
        private Components.DigitalSensorControl DigitalSensorSuBaskini;
        private Components.DigitalSensorControl DigitalSensorPompa2Termik;
        private Components.DigitalSensorControl DigitalSensorPompa1Termik;
        private Components.DigitalSensorControl DigitalSensorAcilStop;
        private Components.DigitalSensorControl DigitalSensorTSuPompaTermik;
        private Components.DigitalSensorControl DigitalSensorYikamaTanki;
        private Components.DigitalSensorControl DigitalSensorEnerji;
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