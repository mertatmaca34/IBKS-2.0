namespace ibks.Forms.Pages
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
            ChannelDebi = new ibks.Components.ChannelControl();
            ChannelAkisHizi = new ibks.Components.ChannelControl();
            ChannelKoi = new ibks.Components.ChannelControl();
            ChannelIletkenlik = new ibks.Components.ChannelControl();
            ChannelPh = new ibks.Components.ChannelControl();
            ChannelSicaklik = new ibks.Components.ChannelControl();
            ChannelCozunmusOksijen = new ibks.Components.ChannelControl();
            channelControl1 = new ibks.Components.ChannelControl();
            ChannelAkm = new ibks.Components.ChannelControl();
            tableLayoutPanel3 = new TableLayoutPanel();
            DigitalSensorKapi = new ibks.Components.DigitalSensorControl();
            DigitalSensorDuman = new ibks.Components.DigitalSensorControl();
            DigitalSensorSuBaskini = new ibks.Components.DigitalSensorControl();
            DigitalSensorPompa2Termik = new ibks.Components.DigitalSensorControl();
            DigitalSensorPompa1Termik = new ibks.Components.DigitalSensorControl();
            DigitalSensorAcilStop = new ibks.Components.DigitalSensorControl();
            DigitalSensorTSuPompaTermik = new ibks.Components.DigitalSensorControl();
            DigitalSensorYikamaTanki = new ibks.Components.DigitalSensorControl();
            DigitalSensorEnerji = new ibks.Components.DigitalSensorControl();
            DigitalSensorBar = new ibks.Components.DigitalSensorBar();
            StationInfoControl = new ibks.Components.StationInfoControl();
            StatusBarControl = new ibks.Components.StatusBarControl();
            TimerAssignUI = new System.Windows.Forms.Timer(components);
            TimerGetMissingDates = new System.Windows.Forms.Timer(components);
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
            tableLayoutPanel1.Controls.Add(StationInfoControl, 1, 1);
            tableLayoutPanel1.Controls.Add(StatusBarControl, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
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
            tableLayoutPanel2.Location = new Point(8, 8);
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
            tableLayoutPanel2.Size = new Size(574, 625);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // ChannelDebi
            // 
            ChannelDebi.AvgDataOf60Min = "-";
            ChannelDebi.ChannelDescription = "Tesis Debisi";
            ChannelDebi.ChannelName = "Debi";
            ChannelDebi.Dock = DockStyle.Fill;
            ChannelDebi.InstantData = "-";
            ChannelDebi.Location = new Point(3, 555);
            ChannelDebi.Name = "ChannelDebi";
            ChannelDebi.Size = new Size(568, 67);
            ChannelDebi.TabIndex = 8;
            // 
            // ChannelAkisHizi
            // 
            ChannelAkisHizi.AvgDataOf60Min = "-";
            ChannelAkisHizi.ChannelDescription = "Tank dolum boşaltım hızı";
            ChannelAkisHizi.ChannelName = "Akış Hızı";
            ChannelAkisHizi.Dock = DockStyle.Fill;
            ChannelAkisHizi.InstantData = "-";
            ChannelAkisHizi.Location = new Point(3, 486);
            ChannelAkisHizi.Name = "ChannelAkisHizi";
            ChannelAkisHizi.Size = new Size(568, 63);
            ChannelAkisHizi.TabIndex = 7;
            // 
            // ChannelKoi
            // 
            ChannelKoi.AvgDataOf60Min = "-";
            ChannelKoi.ChannelDescription = "Kimyasal Oksijen İhtiyacı";
            ChannelKoi.ChannelName = "KOi";
            ChannelKoi.Dock = DockStyle.Fill;
            ChannelKoi.InstantData = "-";
            ChannelKoi.Location = new Point(3, 417);
            ChannelKoi.Name = "ChannelKoi";
            ChannelKoi.Size = new Size(568, 63);
            ChannelKoi.TabIndex = 6;
            // 
            // ChannelIletkenlik
            // 
            ChannelIletkenlik.AvgDataOf60Min = "-";
            ChannelIletkenlik.ChannelDescription = "Sudaki İletkenlik seviyesi";
            ChannelIletkenlik.ChannelName = "İletkenlik";
            ChannelIletkenlik.Dock = DockStyle.Fill;
            ChannelIletkenlik.InstantData = "-";
            ChannelIletkenlik.Location = new Point(3, 348);
            ChannelIletkenlik.Name = "ChannelIletkenlik";
            ChannelIletkenlik.Size = new Size(568, 63);
            ChannelIletkenlik.TabIndex = 5;
            // 
            // ChannelPh
            // 
            ChannelPh.AvgDataOf60Min = "-";
            ChannelPh.ChannelDescription = "Potansiyel Hidrojen";
            ChannelPh.ChannelName = "pH";
            ChannelPh.Dock = DockStyle.Fill;
            ChannelPh.InstantData = "-";
            ChannelPh.Location = new Point(3, 279);
            ChannelPh.Name = "ChannelPh";
            ChannelPh.Size = new Size(568, 63);
            ChannelPh.TabIndex = 4;
            // 
            // ChannelSicaklik
            // 
            ChannelSicaklik.AvgDataOf60Min = "-";
            ChannelSicaklik.ChannelDescription = "Kabin içi sıcaklığı";
            ChannelSicaklik.ChannelName = "Sıcaklık";
            ChannelSicaklik.Dock = DockStyle.Fill;
            ChannelSicaklik.InstantData = "-";
            ChannelSicaklik.Location = new Point(3, 210);
            ChannelSicaklik.Name = "ChannelSicaklik";
            ChannelSicaklik.Size = new Size(568, 63);
            ChannelSicaklik.TabIndex = 3;
            // 
            // ChannelCozunmusOksijen
            // 
            ChannelCozunmusOksijen.AvgDataOf60Min = "-";
            ChannelCozunmusOksijen.ChannelDescription = "Suda bulunan gaz Oksijen miktarı";
            ChannelCozunmusOksijen.ChannelName = "Çözünmüş Oksijen";
            ChannelCozunmusOksijen.Dock = DockStyle.Fill;
            ChannelCozunmusOksijen.InstantData = "-";
            ChannelCozunmusOksijen.Location = new Point(3, 141);
            ChannelCozunmusOksijen.Name = "ChannelCozunmusOksijen";
            ChannelCozunmusOksijen.Size = new Size(568, 63);
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
            channelControl1.Size = new Size(568, 63);
            channelControl1.TabIndex = 0;
            // 
            // ChannelAkm
            // 
            ChannelAkm.AvgDataOf60Min = "-";
            ChannelAkm.ChannelDescription = "Askıda Katı Madde";
            ChannelAkm.ChannelName = "AKM";
            ChannelAkm.Dock = DockStyle.Fill;
            ChannelAkm.InstantData = "-";
            ChannelAkm.Location = new Point(3, 72);
            ChannelAkm.Name = "ChannelAkm";
            ChannelAkm.Size = new Size(568, 63);
            ChannelAkm.TabIndex = 1;
            ChannelAkm.Load += ChannelAkm_Load;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.WhiteSmoke;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(DigitalSensorKapi, 0, 1);
            tableLayoutPanel3.Controls.Add(DigitalSensorDuman, 1, 1);
            tableLayoutPanel3.Controls.Add(DigitalSensorSuBaskini, 2, 1);
            tableLayoutPanel3.Controls.Add(DigitalSensorPompa2Termik, 2, 2);
            tableLayoutPanel3.Controls.Add(DigitalSensorPompa1Termik, 1, 2);
            tableLayoutPanel3.Controls.Add(DigitalSensorAcilStop, 0, 2);
            tableLayoutPanel3.Controls.Add(DigitalSensorTSuPompaTermik, 0, 3);
            tableLayoutPanel3.Controls.Add(DigitalSensorYikamaTanki, 1, 3);
            tableLayoutPanel3.Controls.Add(DigitalSensorEnerji, 2, 3);
            tableLayoutPanel3.Controls.Add(DigitalSensorBar, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(588, 8);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Size = new Size(574, 205);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // DigitalSensorKapi
            // 
            DigitalSensorKapi.BackColor = Color.White;
            DigitalSensorKapi.Dock = DockStyle.Fill;
            DigitalSensorKapi.Location = new Point(3, 54);
            DigitalSensorKapi.Name = "DigitalSensorKapi";
            DigitalSensorKapi.SensorDescription = "Kabin Kapısı";
            DigitalSensorKapi.SensorName = "Kapı";
            DigitalSensorKapi.Size = new Size(185, 45);
            DigitalSensorKapi.TabIndex = 1;
            // 
            // DigitalSensorDuman
            // 
            DigitalSensorDuman.BackColor = Color.White;
            DigitalSensorDuman.Dock = DockStyle.Fill;
            DigitalSensorDuman.Location = new Point(194, 54);
            DigitalSensorDuman.Name = "DigitalSensorDuman";
            DigitalSensorDuman.SensorDescription = "Kabin içi duman durumu";
            DigitalSensorDuman.SensorName = "Duman";
            DigitalSensorDuman.Size = new Size(185, 45);
            DigitalSensorDuman.TabIndex = 1;
            // 
            // DigitalSensorSuBaskini
            // 
            DigitalSensorSuBaskini.BackColor = Color.White;
            DigitalSensorSuBaskini.Dock = DockStyle.Fill;
            DigitalSensorSuBaskini.Location = new Point(385, 54);
            DigitalSensorSuBaskini.Name = "DigitalSensorSuBaskini";
            DigitalSensorSuBaskini.SensorDescription = "Kabiniçi su baskını";
            DigitalSensorSuBaskini.SensorName = "Su Baskını";
            DigitalSensorSuBaskini.Size = new Size(186, 45);
            DigitalSensorSuBaskini.TabIndex = 1;
            // 
            // DigitalSensorPompa2Termik
            // 
            DigitalSensorPompa2Termik.BackColor = Color.White;
            DigitalSensorPompa2Termik.Dock = DockStyle.Fill;
            DigitalSensorPompa2Termik.Location = new Point(385, 105);
            DigitalSensorPompa2Termik.Name = "DigitalSensorPompa2Termik";
            DigitalSensorPompa2Termik.SensorDescription = "Pompa 2 Termik atma durumu";
            DigitalSensorPompa2Termik.SensorName = "Pompa 2 Termik";
            DigitalSensorPompa2Termik.Size = new Size(186, 45);
            DigitalSensorPompa2Termik.TabIndex = 1;
            // 
            // DigitalSensorPompa1Termik
            // 
            DigitalSensorPompa1Termik.BackColor = Color.White;
            DigitalSensorPompa1Termik.Dock = DockStyle.Fill;
            DigitalSensorPompa1Termik.Location = new Point(194, 105);
            DigitalSensorPompa1Termik.Name = "DigitalSensorPompa1Termik";
            DigitalSensorPompa1Termik.SensorDescription = "Pompa 1 Termik atma durumu";
            DigitalSensorPompa1Termik.SensorName = "Pompa 1 Termik";
            DigitalSensorPompa1Termik.Size = new Size(185, 45);
            DigitalSensorPompa1Termik.TabIndex = 1;
            // 
            // DigitalSensorAcilStop
            // 
            DigitalSensorAcilStop.BackColor = Color.White;
            DigitalSensorAcilStop.Dock = DockStyle.Fill;
            DigitalSensorAcilStop.Location = new Point(3, 105);
            DigitalSensorAcilStop.Name = "DigitalSensorAcilStop";
            DigitalSensorAcilStop.SensorDescription = "Acil Stop butonu durumu";
            DigitalSensorAcilStop.SensorName = "Acil Stop";
            DigitalSensorAcilStop.Size = new Size(185, 45);
            DigitalSensorAcilStop.TabIndex = 1;
            // 
            // DigitalSensorTSuPompaTermik
            // 
            DigitalSensorTSuPompaTermik.BackColor = Color.White;
            DigitalSensorTSuPompaTermik.Dock = DockStyle.Fill;
            DigitalSensorTSuPompaTermik.Location = new Point(3, 156);
            DigitalSensorTSuPompaTermik.Name = "DigitalSensorTSuPompaTermik";
            DigitalSensorTSuPompaTermik.SensorDescription = "Temiz Su P. Termik atma durumu";
            DigitalSensorTSuPompaTermik.SensorName = "T. Su Pompa Termik";
            DigitalSensorTSuPompaTermik.Size = new Size(185, 46);
            DigitalSensorTSuPompaTermik.TabIndex = 1;
            // 
            // DigitalSensorYikamaTanki
            // 
            DigitalSensorYikamaTanki.BackColor = Color.White;
            DigitalSensorYikamaTanki.Dock = DockStyle.Fill;
            DigitalSensorYikamaTanki.Location = new Point(194, 156);
            DigitalSensorYikamaTanki.Name = "DigitalSensorYikamaTanki";
            DigitalSensorYikamaTanki.SensorDescription = "Yıkama Tankı dolu/boş bilgisi";
            DigitalSensorYikamaTanki.SensorName = "Yıkama Tankı";
            DigitalSensorYikamaTanki.Size = new Size(185, 46);
            DigitalSensorYikamaTanki.TabIndex = 1;
            // 
            // DigitalSensorEnerji
            // 
            DigitalSensorEnerji.BackColor = Color.White;
            DigitalSensorEnerji.Dock = DockStyle.Fill;
            DigitalSensorEnerji.Location = new Point(385, 156);
            DigitalSensorEnerji.Name = "DigitalSensorEnerji";
            DigitalSensorEnerji.SensorDescription = "Kabin elektrik enerjisi durumu";
            DigitalSensorEnerji.SensorName = "Enerji";
            DigitalSensorEnerji.Size = new Size(186, 46);
            DigitalSensorEnerji.TabIndex = 1;
            // 
            // DigitalSensorBar
            // 
            DigitalSensorBar.BackColor = Color.FromArgb(235, 235, 235);
            DigitalSensorBar.ChannelDescription = "SENSÖR İSİMLERİ";
            DigitalSensorBar.ChannelName = "DİJİTAL SENSÖRLER";
            DigitalSensorBar.ChannelStatement = Color.FromArgb(0, 131, 200);
            tableLayoutPanel3.SetColumnSpan(DigitalSensorBar, 3);
            DigitalSensorBar.Dock = DockStyle.Fill;
            DigitalSensorBar.Location = new Point(3, 3);
            DigitalSensorBar.Name = "DigitalSensorBar";
            DigitalSensorBar.PanelSplit1Visible = false;
            DigitalSensorBar.PanelSplit2Visible = false;
            DigitalSensorBar.Size = new Size(568, 45);
            DigitalSensorBar.SystemStatementColor = Color.White;
            DigitalSensorBar.SystemStatementDescriptionTextColor = Color.White;
            DigitalSensorBar.SystemStatementText = "-";
            DigitalSensorBar.SystemStatementTitleTextColor = Color.White;
            DigitalSensorBar.TabIndex = 2;
            // 
            // StationInfoControl
            // 
            StationInfoControl.BackColor = Color.FromArgb(235, 235, 235);
            StationInfoControl.Dock = DockStyle.Fill;
            StationInfoControl.IletkenlikCalibration = "     -";
            StationInfoControl.IletkenlikCalibrationImage = null;
            StationInfoControl.LastWashAkm = "     -";
            StationInfoControl.LastWashAkmImage = null;
            StationInfoControl.LastWashCozunmusOksijen = "     -";
            StationInfoControl.LastWashCozunmusOksijenImage = null;
            StationInfoControl.LastWashDebi = "     -";
            StationInfoControl.LastWashDebiImage = null;
            StationInfoControl.LastWashDesarjDebi = "     -";
            StationInfoControl.LastWashDesarjDebiImage = null;
            StationInfoControl.LastWashHariciDebi = "     -";
            StationInfoControl.LastWashHariciDebi2 = "     -";
            StationInfoControl.LastWashHariciDebi2Image = null;
            StationInfoControl.LastWashHariciDebiImage = null;
            StationInfoControl.LastWashIletkenlik = "     -";
            StationInfoControl.LastWashIletkenlikImage = null;
            StationInfoControl.LastWashKoi = "     -";
            StationInfoControl.LastWashKoiImage = null;
            StationInfoControl.LastWashPh = "     -";
            StationInfoControl.LastWashPhImage = null;
            StationInfoControl.LastWashSicaklik = "     -";
            StationInfoControl.LastWashSicaklikImage = null;
            StationInfoControl.LastWashWeekAkm = "     -";
            StationInfoControl.LastWashWeekAkmImage = null;
            StationInfoControl.LastWashWeekCozunmusOksijen = "     -";
            StationInfoControl.LastWashWeekCozunmusOksijenImage = null;
            StationInfoControl.LastWashWeekDebi = "     -";
            StationInfoControl.LastWashWeekDebiImage = null;
            StationInfoControl.LastWashWeekDesarjDebi = "     -";
            StationInfoControl.LastWashWeekDesarjDebiImage = null;
            StationInfoControl.LastWashWeekHariciDebi = "     -";
            StationInfoControl.LastWashWeekHariciDebi2 = "     -";
            StationInfoControl.LastWashWeekHariciDebi2Image = null;
            StationInfoControl.LastWashWeekHariciDebiImage = null;
            StationInfoControl.LastWashWeekIletkenlik = "     -";
            StationInfoControl.LastWashWeekIletkenlikImage = null;
            StationInfoControl.LastWashWeekKoi = "     -";
            StationInfoControl.LastWashWeekKoiImage = null;
            StationInfoControl.LastWashWeekPh = "     -";
            StationInfoControl.LastWashWeekPhImage = null;
            StationInfoControl.LastWashWeekSicaklik = "     -";
            StationInfoControl.LastWashWeekSicaklikImage = null;
            StationInfoControl.Location = new Point(588, 219);
            StationInfoControl.Name = "StationInfoControl";
            StationInfoControl.Padding = new Padding(1);
            StationInfoControl.PhCalibration = "     -";
            StationInfoControl.PhCalibrationImage = null;
            StationInfoControl.Size = new Size(574, 414);
            StationInfoControl.TabIndex = 4;
            // 
            // StatusBarControl
            // 
            StatusBarControl.BackColor = Color.FromArgb(235, 235, 235);
            tableLayoutPanel1.SetColumnSpan(StatusBarControl, 2);
            StatusBarControl.ConnectionStatement = "Bağlantı Durumu:";
            StatusBarControl.ConnectionTime = "Bağlantı Zamanı:";
            StatusBarControl.Dock = DockStyle.Fill;
            StatusBarControl.GunlukYikamaKalan = "G. Yıkamaya Kalan: ";
            StatusBarControl.HaftalikYikamaKalan = "H. Yıkamaya Kalan: ";
            StatusBarControl.Location = new Point(8, 639);
            StatusBarControl.Name = "StatusBarControl";
            StatusBarControl.Padding = new Padding(1);
            StatusBarControl.SistemSaati = "Sistem Saati: ";
            StatusBarControl.Size = new Size(1154, 30);
            StatusBarControl.TabIndex = 5;
            // 
            // TimerAssignUI
            // 
            TimerAssignUI.Enabled = true;
            TimerAssignUI.Interval = 5000;
            TimerAssignUI.Tick += TimerAssignUI_Tick;
            // 
            // TimerGetMissingDates
            // 
            TimerGetMissingDates.Enabled = true;
            TimerGetMissingDates.Interval = 600000;
            TimerGetMissingDates.Tick += TimerGetMissingDates_Tick;
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
        private Components.ChannelControl channelControl1;
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
        private Components.StationInfoControl StationInfoControl;
        private System.Windows.Forms.Timer TimerAssignUI;
        private Components.StatusBarControl StatusBarControl;
        private Components.DigitalSensorBar DigitalSensorBar;
        private System.Windows.Forms.Timer TimerGetMissingDates;
        private Components.ChannelControl ChannelAkm;
    }
}