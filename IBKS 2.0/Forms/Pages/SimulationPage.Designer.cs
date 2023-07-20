namespace IBKS_2._0.Forms.Pages
{
    partial class SimulationPage
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
            PanelDoor = new Panel();
            TimerSimulation = new System.Windows.Forms.Timer(components);
            PictureBoxPump1 = new PictureBox();
            PictureBoxPump2 = new PictureBox();
            label1 = new Label();
            LabelAkm = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            LabelKoi = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label5 = new Label();
            LabelPh = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            label7 = new Label();
            LabelIletkenlik = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            label9 = new Label();
            LabelOksijen = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            label11 = new Label();
            LabelAkisHizi = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            label13 = new Label();
            label14 = new Label();
            tableLayoutPanel8 = new TableLayoutPanel();
            label15 = new Label();
            label16 = new Label();
            tableLayoutPanel9 = new TableLayoutPanel();
            label17 = new Label();
            label18 = new Label();
            tableLayoutPanel10 = new TableLayoutPanel();
            label19 = new Label();
            label20 = new Label();
            tableLayoutPanel11 = new TableLayoutPanel();
            label21 = new Label();
            label22 = new Label();
            tableLayoutPanel12 = new TableLayoutPanel();
            label23 = new Label();
            label24 = new Label();
            tableLayoutPanel13 = new TableLayoutPanel();
            label25 = new Label();
            LabelSicaklik = new Label();
            tableLayoutPanel14 = new TableLayoutPanel();
            label27 = new Label();
            label28 = new Label();
            ((System.ComponentModel.ISupportInitialize)PictureBoxPump1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxPump2).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            SuspendLayout();
            // 
            // PanelDoor
            // 
            PanelDoor.BackColor = Color.Transparent;
            PanelDoor.BackgroundImage = Properties.Resources.door_closed;
            PanelDoor.BackgroundImageLayout = ImageLayout.None;
            PanelDoor.Location = new Point(947, 616);
            PanelDoor.Name = "PanelDoor";
            PanelDoor.Size = new Size(127, 63);
            PanelDoor.TabIndex = 0;
            // 
            // TimerSimulation
            // 
            TimerSimulation.Enabled = true;
            TimerSimulation.Interval = 1000;
            TimerSimulation.Tick += TimerSimulation_Tick;
            // 
            // PictureBoxPump1
            // 
            PictureBoxPump1.BackColor = Color.Transparent;
            PictureBoxPump1.Image = Properties.Resources.pump1_idle;
            PictureBoxPump1.Location = new Point(775, 476);
            PictureBoxPump1.Name = "PictureBoxPump1";
            PictureBoxPump1.Size = new Size(70, 76);
            PictureBoxPump1.SizeMode = PictureBoxSizeMode.AutoSize;
            PictureBoxPump1.TabIndex = 1;
            PictureBoxPump1.TabStop = false;
            // 
            // PictureBoxPump2
            // 
            PictureBoxPump2.BackColor = Color.Transparent;
            PictureBoxPump2.Image = Properties.Resources.pump2_idle;
            PictureBoxPump2.Location = new Point(908, 476);
            PictureBoxPump2.Name = "PictureBoxPump2";
            PictureBoxPump2.Size = new Size(70, 76);
            PictureBoxPump2.SizeMode = PictureBoxSizeMode.AutoSize;
            PictureBoxPump2.TabIndex = 1;
            PictureBoxPump2.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(20, 5);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 2;
            label1.Text = "AKM";
            // 
            // LabelAkm
            // 
            LabelAkm.Anchor = AnchorStyles.Top;
            LabelAkm.AutoSize = true;
            LabelAkm.BackColor = Color.Transparent;
            LabelAkm.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelAkm.ForeColor = Color.Lime;
            LabelAkm.Location = new Point(30, 20);
            LabelAkm.Name = "LabelAkm";
            LabelAkm.Size = new Size(14, 15);
            LabelAkm.TabIndex = 2;
            LabelAkm.Text = "0";
            LabelAkm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(LabelAkm, 0, 1);
            tableLayoutPanel1.Location = new Point(1034, 121);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(74, 40);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(LabelKoi, 0, 1);
            tableLayoutPanel2.Location = new Point(1034, 174);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(74, 40);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(23, 5);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 2;
            label3.Text = "KOi";
            // 
            // LabelKoi
            // 
            LabelKoi.Anchor = AnchorStyles.Top;
            LabelKoi.AutoSize = true;
            LabelKoi.BackColor = Color.Transparent;
            LabelKoi.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelKoi.ForeColor = Color.Lime;
            LabelKoi.Location = new Point(30, 20);
            LabelKoi.Name = "LabelKoi";
            LabelKoi.Size = new Size(14, 15);
            LabelKoi.TabIndex = 2;
            LabelKoi.Text = "0";
            LabelKoi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.Transparent;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label5, 0, 0);
            tableLayoutPanel3.Controls.Add(LabelPh, 0, 1);
            tableLayoutPanel3.Location = new Point(760, 125);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(74, 40);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(26, 5);
            label5.Name = "label5";
            label5.Size = new Size(22, 15);
            label5.TabIndex = 2;
            label5.Text = "pH";
            // 
            // LabelPh
            // 
            LabelPh.Anchor = AnchorStyles.Top;
            LabelPh.AutoSize = true;
            LabelPh.BackColor = Color.Transparent;
            LabelPh.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPh.ForeColor = Color.Lime;
            LabelPh.Location = new Point(30, 20);
            LabelPh.Name = "LabelPh";
            LabelPh.Size = new Size(14, 15);
            LabelPh.TabIndex = 2;
            LabelPh.Text = "0";
            LabelPh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.Transparent;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label7, 0, 0);
            tableLayoutPanel4.Controls.Add(LabelIletkenlik, 0, 1);
            tableLayoutPanel4.Location = new Point(760, 197);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(74, 40);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(8, 5);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 2;
            label7.Text = "İletkenlik";
            // 
            // LabelIletkenlik
            // 
            LabelIletkenlik.Anchor = AnchorStyles.Top;
            LabelIletkenlik.AutoSize = true;
            LabelIletkenlik.BackColor = Color.Transparent;
            LabelIletkenlik.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelIletkenlik.ForeColor = Color.Lime;
            LabelIletkenlik.Location = new Point(30, 20);
            LabelIletkenlik.Name = "LabelIletkenlik";
            LabelIletkenlik.Size = new Size(14, 15);
            LabelIletkenlik.TabIndex = 2;
            LabelIletkenlik.Text = "0";
            LabelIletkenlik.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = Color.Transparent;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label9, 0, 0);
            tableLayoutPanel5.Controls.Add(LabelOksijen, 0, 1);
            tableLayoutPanel5.Location = new Point(760, 239);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(74, 40);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 5);
            label9.Name = "label9";
            label9.Size = new Size(50, 15);
            label9.TabIndex = 2;
            label9.Text = "Oksijen";
            // 
            // LabelOksijen
            // 
            LabelOksijen.Anchor = AnchorStyles.Top;
            LabelOksijen.AutoSize = true;
            LabelOksijen.BackColor = Color.Transparent;
            LabelOksijen.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelOksijen.ForeColor = Color.Lime;
            LabelOksijen.Location = new Point(30, 20);
            LabelOksijen.Name = "LabelOksijen";
            LabelOksijen.Size = new Size(14, 15);
            LabelOksijen.TabIndex = 2;
            LabelOksijen.Text = "0";
            LabelOksijen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.BackColor = Color.Transparent;
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(label11, 0, 0);
            tableLayoutPanel6.Controls.Add(LabelAkisHizi, 0, 1);
            tableLayoutPanel6.Location = new Point(760, 379);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(74, 40);
            tableLayoutPanel6.TabIndex = 3;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(9, 5);
            label11.Name = "label11";
            label11.Size = new Size(55, 15);
            label11.TabIndex = 2;
            label11.Text = "Akış Hızı";
            // 
            // LabelAkisHizi
            // 
            LabelAkisHizi.Anchor = AnchorStyles.Top;
            LabelAkisHizi.AutoSize = true;
            LabelAkisHizi.BackColor = Color.Transparent;
            LabelAkisHizi.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelAkisHizi.ForeColor = Color.Lime;
            LabelAkisHizi.Location = new Point(30, 20);
            LabelAkisHizi.Name = "LabelAkisHizi";
            LabelAkisHizi.Size = new Size(14, 15);
            LabelAkisHizi.TabIndex = 2;
            LabelAkisHizi.Text = "0";
            LabelAkisHizi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.BackColor = Color.Transparent;
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(label13, 0, 0);
            tableLayoutPanel7.Controls.Add(label14, 0, 1);
            tableLayoutPanel7.Location = new Point(329, 503);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(74, 40);
            tableLayoutPanel7.TabIndex = 3;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Bottom;
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(21, 5);
            label13.Name = "label13";
            label13.Size = new Size(32, 15);
            label13.TabIndex = 2;
            label13.Text = "Debi";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top;
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Lime;
            label14.Location = new Point(30, 20);
            label14.Name = "label14";
            label14.Size = new Size(14, 15);
            label14.TabIndex = 2;
            label14.Text = "0";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.BackColor = Color.Transparent;
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(label15, 0, 0);
            tableLayoutPanel8.Controls.Add(label16, 0, 1);
            tableLayoutPanel8.Location = new Point(97, 621);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(74, 40);
            tableLayoutPanel8.TabIndex = 3;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Bottom;
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(7, 5);
            label15.Name = "label15";
            label15.Size = new Size(60, 15);
            label15.TabIndex = 2;
            label15.Text = "Deş. Debi";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top;
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Lime;
            label16.Location = new Point(30, 20);
            label16.Name = "label16";
            label16.Size = new Size(14, 15);
            label16.TabIndex = 2;
            label16.Text = "0";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.BackColor = Color.Transparent;
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Controls.Add(label17, 0, 0);
            tableLayoutPanel9.Controls.Add(label18, 0, 1);
            tableLayoutPanel9.Location = new Point(185, 621);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Size = new Size(74, 40);
            tableLayoutPanel9.TabIndex = 3;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Bottom;
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(14, 5);
            label17.Name = "label17";
            label17.Size = new Size(46, 15);
            label17.TabIndex = 2;
            label17.Text = "H. Debi";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top;
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.Lime;
            label18.Location = new Point(30, 20);
            label18.Name = "label18";
            label18.Size = new Size(14, 15);
            label18.TabIndex = 2;
            label18.Text = "0";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.BackColor = Color.Transparent;
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Controls.Add(label19, 0, 0);
            tableLayoutPanel10.Controls.Add(label20, 0, 1);
            tableLayoutPanel10.Location = new Point(273, 621);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 2;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(74, 40);
            tableLayoutPanel10.TabIndex = 3;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Bottom;
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(9, 5);
            label19.Name = "label19";
            label19.Size = new Size(56, 15);
            label19.TabIndex = 2;
            label19.Text = "H. Debi 2";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top;
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.Lime;
            label20.Location = new Point(30, 20);
            label20.Name = "label20";
            label20.Size = new Size(14, 15);
            label20.TabIndex = 2;
            label20.Text = "0";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.BackColor = Color.Transparent;
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Controls.Add(label21, 0, 0);
            tableLayoutPanel11.Controls.Add(label22, 0, 1);
            tableLayoutPanel11.Location = new Point(198, 64);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 2;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(74, 40);
            tableLayoutPanel11.TabIndex = 3;
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Bottom;
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(11, 5);
            label21.Name = "label21";
            label21.Size = new Size(51, 15);
            label21.TabIndex = 2;
            label21.Text = "AKTİF P.";
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Top;
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.Lime;
            label22.Location = new Point(7, 20);
            label22.Name = "label22";
            label22.Size = new Size(59, 15);
            label22.TabIndex = 2;
            label22.Text = "POMPA 1";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.BackColor = Color.Transparent;
            tableLayoutPanel12.ColumnCount = 1;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Controls.Add(label23, 0, 0);
            tableLayoutPanel12.Controls.Add(label24, 0, 1);
            tableLayoutPanel12.Location = new Point(198, 112);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 2;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Size = new Size(74, 40);
            tableLayoutPanel12.TabIndex = 3;
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Bottom;
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label23.Location = new Point(10, 5);
            label23.Name = "label23";
            label23.Size = new Size(53, 15);
            label23.TabIndex = 2;
            label23.Text = "Frekans";
            // 
            // label24
            // 
            label24.Anchor = AnchorStyles.Top;
            label24.AutoSize = true;
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label24.ForeColor = Color.Lime;
            label24.Location = new Point(18, 20);
            label24.Name = "label24";
            label24.Size = new Size(38, 15);
            label24.TabIndex = 2;
            label24.Text = "45 Hz";
            label24.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.BackColor = Color.Transparent;
            tableLayoutPanel13.ColumnCount = 1;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Controls.Add(label25, 0, 0);
            tableLayoutPanel13.Controls.Add(LabelSicaklik, 0, 1);
            tableLayoutPanel13.Location = new Point(197, 175);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 2;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Size = new Size(74, 40);
            tableLayoutPanel13.TabIndex = 3;
            // 
            // label25
            // 
            label25.Anchor = AnchorStyles.Bottom;
            label25.AutoSize = true;
            label25.BackColor = Color.Transparent;
            label25.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label25.Location = new Point(11, 5);
            label25.Name = "label25";
            label25.Size = new Size(52, 15);
            label25.TabIndex = 2;
            label25.Text = "Sıcaklık";
            // 
            // LabelSicaklik
            // 
            LabelSicaklik.Anchor = AnchorStyles.Top;
            LabelSicaklik.AutoSize = true;
            LabelSicaklik.BackColor = Color.Transparent;
            LabelSicaklik.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelSicaklik.ForeColor = Color.Lime;
            LabelSicaklik.Location = new Point(30, 20);
            LabelSicaklik.Name = "LabelSicaklik";
            LabelSicaklik.Size = new Size(14, 15);
            LabelSicaklik.TabIndex = 2;
            LabelSicaklik.Text = "0";
            LabelSicaklik.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.BackColor = Color.Transparent;
            tableLayoutPanel14.ColumnCount = 1;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.Controls.Add(label27, 0, 0);
            tableLayoutPanel14.Controls.Add(label28, 0, 1);
            tableLayoutPanel14.Location = new Point(197, 224);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 2;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.Size = new Size(74, 40);
            tableLayoutPanel14.TabIndex = 3;
            // 
            // label27
            // 
            label27.Anchor = AnchorStyles.Bottom;
            label27.AutoSize = true;
            label27.BackColor = Color.Transparent;
            label27.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label27.Location = new Point(20, 5);
            label27.Name = "label27";
            label27.Size = new Size(33, 15);
            label27.TabIndex = 2;
            label27.Text = "Nem";
            // 
            // label28
            // 
            label28.Anchor = AnchorStyles.Top;
            label28.AutoSize = true;
            label28.BackColor = Color.Transparent;
            label28.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label28.ForeColor = Color.Lime;
            label28.Location = new Point(30, 20);
            label28.Name = "label28";
            label28.Size = new Size(14, 15);
            label28.TabIndex = 2;
            label28.Text = "0";
            label28.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SimulationPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Properties.Resources.system_auto1;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1170, 677);
            Controls.Add(tableLayoutPanel10);
            Controls.Add(tableLayoutPanel9);
            Controls.Add(tableLayoutPanel8);
            Controls.Add(tableLayoutPanel14);
            Controls.Add(tableLayoutPanel13);
            Controls.Add(tableLayoutPanel12);
            Controls.Add(tableLayoutPanel11);
            Controls.Add(tableLayoutPanel7);
            Controls.Add(tableLayoutPanel6);
            Controls.Add(tableLayoutPanel5);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(PictureBoxPump2);
            Controls.Add(PictureBoxPump1);
            Controls.Add(PanelDoor);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SimulationPage";
            Text = "SimulationPage";
            ((System.ComponentModel.ISupportInitialize)PictureBoxPump1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxPump2).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel13.PerformLayout();
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel14.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelDoor;
        private System.Windows.Forms.Timer TimerSimulation;
        private PictureBox PictureBoxPump1;
        private PictureBox PictureBoxPump2;
        private Label label1;
        private Label LabelAkm;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private Label LabelKoi;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label5;
        private Label LabelPh;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label7;
        private Label LabelIletkenlik;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label9;
        private Label LabelOksijen;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label11;
        private Label LabelAkisHizi;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label13;
        private Label label14;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label15;
        private Label label16;
        private TableLayoutPanel tableLayoutPanel9;
        private Label label17;
        private Label label18;
        private TableLayoutPanel tableLayoutPanel10;
        private Label label19;
        private Label label20;
        private TableLayoutPanel tableLayoutPanel11;
        private Label label21;
        private Label label22;
        private TableLayoutPanel tableLayoutPanel12;
        private Label label23;
        private Label label24;
        private TableLayoutPanel tableLayoutPanel13;
        private Label label25;
        private Label LabelSicaklik;
        private TableLayoutPanel tableLayoutPanel14;
        private Label label27;
        private Label label28;
    }
}