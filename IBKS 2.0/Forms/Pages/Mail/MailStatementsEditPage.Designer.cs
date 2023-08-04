namespace IBKS_2._0.Forms.Pages.Mail
{
    partial class MailStatementsEditPage
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
            tableLayoutPanel3 = new TableLayoutPanel();
            titleBarControl2 = new Components.TitleBarControl();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel14 = new TableLayoutPanel();
            ButtonSave = new Button();
            tableLayoutPanel13 = new TableLayoutPanel();
            tableLayoutPanel11 = new TableLayoutPanel();
            TextBoxMailContent = new TextBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            label2 = new Label();
            ComboBoxStatement = new ComboBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            label1 = new Label();
            ComboBoxParameter = new ComboBox();
            pictureBox1 = new PictureBox();
            TableLayoutPanelLimits = new TableLayoutPanel();
            TextBoxLowerLimit = new TextBox();
            TextBoxUpperLimit = new TextBox();
            tableLayoutPanel10 = new TableLayoutPanel();
            label3 = new Label();
            ComboBoxCoolDown = new ComboBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            TextBoxMailSubject = new TextBox();
            tableLayoutPanel12 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            titleBarControl1 = new Components.TitleBarControl();
            tableLayoutPanel6 = new TableLayoutPanel();
            DataGridViewStatements = new DataGridView();
            ContextMenuStripStatement = new ContextMenuStrip(components);
            DuzenleToolStipMenuItem = new ToolStripMenuItem();
            SilToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            TableLayoutPanelLimits.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewStatements).BeginInit();
            ContextMenuStripStatement.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1170, 621);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(titleBarControl2, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(8, 8);
            tableLayoutPanel3.Margin = new Padding(8);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(569, 605);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // titleBarControl2
            // 
            titleBarControl2.BackColor = Color.FromArgb(235, 235, 235);
            titleBarControl2.Dock = DockStyle.Fill;
            titleBarControl2.Location = new Point(3, 3);
            titleBarControl2.Name = "titleBarControl2";
            titleBarControl2.Padding = new Padding(1);
            titleBarControl2.Size = new Size(563, 32);
            titleBarControl2.TabIndex = 2;
            titleBarControl2.TitleBarText = "MAİL DURUMU DÜZENLE";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = Color.FromArgb(235, 235, 235);
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel14, 0, 9);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel13, 0, 6);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel11, 0, 7);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel8, 0, 2);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel7, 0, 1);
            tableLayoutPanel5.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel5.Controls.Add(TableLayoutPanelLimits, 0, 4);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel10, 0, 5);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel4, 0, 7);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel12, 0, 3);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 41);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 10;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel5.Size = new Size(563, 561);
            tableLayoutPanel5.TabIndex = 5;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.BackColor = Color.WhiteSmoke;
            tableLayoutPanel14.ColumnCount = 1;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.Controls.Add(ButtonSave, 0, 0);
            tableLayoutPanel14.Dock = DockStyle.Fill;
            tableLayoutPanel14.Location = new Point(0, 511);
            tableLayoutPanel14.Margin = new Padding(0);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 1;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.Size = new Size(563, 50);
            tableLayoutPanel14.TabIndex = 15;
            // 
            // ButtonSave
            // 
            ButtonSave.Anchor = AnchorStyles.None;
            ButtonSave.BackColor = Color.FromArgb(0, 131, 200);
            ButtonSave.FlatAppearance.BorderColor = Color.FromArgb(235, 235, 235);
            ButtonSave.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            ButtonSave.FlatAppearance.MouseOverBackColor = SystemColors.ButtonFace;
            ButtonSave.ForeColor = Color.White;
            ButtonSave.Location = new Point(169, 8);
            ButtonSave.Margin = new Padding(8);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(224, 34);
            ButtonSave.TabIndex = 7;
            ButtonSave.Text = "Kaydet";
            ButtonSave.UseVisualStyleBackColor = false;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.BackColor = Color.WhiteSmoke;
            tableLayoutPanel13.ColumnCount = 1;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(0, 336);
            tableLayoutPanel13.Margin = new Padding(0);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 1;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Size = new Size(563, 25);
            tableLayoutPanel13.TabIndex = 14;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.BackColor = Color.White;
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Controls.Add(TextBoxMailContent, 0, 0);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(1, 412);
            tableLayoutPanel11.Margin = new Padding(1);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(561, 98);
            tableLayoutPanel11.TabIndex = 11;
            // 
            // TextBoxMailContent
            // 
            TextBoxMailContent.Anchor = AnchorStyles.None;
            TextBoxMailContent.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxMailContent.Location = new Point(56, 18);
            TextBoxMailContent.Multiline = true;
            TextBoxMailContent.Name = "TextBoxMailContent";
            TextBoxMailContent.PlaceholderText = "Mail İçeriği";
            TextBoxMailContent.Size = new Size(448, 61);
            TextBoxMailContent.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.BackColor = Color.White;
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(label2, 0, 0);
            tableLayoutPanel8.Controls.Add(ComboBoxStatement, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(1, 162);
            tableLayoutPanel8.Margin = new Padding(1);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(561, 48);
            tableLayoutPanel8.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(111, 15);
            label2.Name = "label2";
            label2.Size = new Size(58, 18);
            label2.TabIndex = 0;
            label2.Text = "Durum:";
            // 
            // ComboBoxStatement
            // 
            ComboBoxStatement.Anchor = AnchorStyles.None;
            ComboBoxStatement.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBoxStatement.FormattingEnabled = true;
            ComboBoxStatement.Items.AddRange(new object[] { "Limit Aşımı", "Varsa", "Yoksa" });
            ComboBoxStatement.Location = new Point(312, 11);
            ComboBoxStatement.Name = "ComboBoxStatement";
            ComboBoxStatement.Size = new Size(216, 26);
            ComboBoxStatement.TabIndex = 1;
            ComboBoxStatement.SelectedIndexChanged += ComboBoxStatement_SelectedIndexChanged;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.BackColor = Color.White;
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(label1, 0, 0);
            tableLayoutPanel7.Controls.Add(ComboBoxParameter, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(1, 112);
            tableLayoutPanel7.Margin = new Padding(1);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(561, 48);
            tableLayoutPanel7.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(63, 15);
            label1.Name = "label1";
            label1.Size = new Size(153, 18);
            label1.TabIndex = 0;
            label1.Text = "Etkileyen Parametre:";
            // 
            // ComboBoxParameter
            // 
            ComboBoxParameter.Anchor = AnchorStyles.None;
            ComboBoxParameter.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBoxParameter.FormattingEnabled = true;
            ComboBoxParameter.Items.AddRange(new object[] { "Tesis Debi", "Tesis Günlük Debi", "Deşarj Debi", "Harici Debi", "Harici Debi 2", "Numune Hız", "Numune Debi", "pH", "İletkenlik", "Çözünmüş Oksijen", "Numune Sıcaklık", "Koi", "Akm", "Kabin Nem", "Kabin Sıcaklık", "Pompa 1 Hz", "Pompa 2 Hz", "Ups Kapasite", "Ups Yük", "Günlük Yıkama", "Haftalık Yıkama", "Kapı", "Duman", "Su Baskını", "Acil Stop", "Pompa 1 Termik", "Pompa 2 Termik", "Temiz Su Pompası Termik", "Yıkama Tankı", "Enerji", "Pompa 1 Çalışıyor Mu", "Pompa 2 Çalışıyor Mu", "Mod Auto Mu", "Mod Bakım Mı", "Mod Kalibrasyon Mu", "Numune Tetik Akm", "Numune Tetik Koi", "Numune Tetik Ph", "Veri Geçerliliği" });
            ComboBoxParameter.Location = new Point(312, 11);
            ComboBoxParameter.Name = "ComboBoxParameter";
            ComboBoxParameter.Size = new Size(216, 26);
            ComboBoxParameter.TabIndex = 1;
            ComboBoxParameter.SelectedIndexChanged += ComboBoxParameter_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.mail_configuration_256px;
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Margin = new Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(561, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // TableLayoutPanelLimits
            // 
            TableLayoutPanelLimits.BackColor = Color.White;
            TableLayoutPanelLimits.ColumnCount = 2;
            TableLayoutPanelLimits.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanelLimits.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanelLimits.Controls.Add(TextBoxLowerLimit, 0, 0);
            TableLayoutPanelLimits.Controls.Add(TextBoxUpperLimit, 1, 0);
            TableLayoutPanelLimits.Dock = DockStyle.Fill;
            TableLayoutPanelLimits.Enabled = false;
            TableLayoutPanelLimits.Location = new Point(1, 237);
            TableLayoutPanelLimits.Margin = new Padding(1);
            TableLayoutPanelLimits.Name = "TableLayoutPanelLimits";
            TableLayoutPanelLimits.RowCount = 1;
            TableLayoutPanelLimits.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanelLimits.Size = new Size(561, 48);
            TableLayoutPanelLimits.TabIndex = 8;
            // 
            // TextBoxLowerLimit
            // 
            TextBoxLowerLimit.Anchor = AnchorStyles.None;
            TextBoxLowerLimit.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxLowerLimit.Location = new Point(32, 11);
            TextBoxLowerLimit.Name = "TextBoxLowerLimit";
            TextBoxLowerLimit.PlaceholderText = "Alt Limit";
            TextBoxLowerLimit.Size = new Size(216, 26);
            TextBoxLowerLimit.TabIndex = 0;
            // 
            // TextBoxUpperLimit
            // 
            TextBoxUpperLimit.Anchor = AnchorStyles.None;
            TextBoxUpperLimit.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxUpperLimit.Location = new Point(312, 11);
            TextBoxUpperLimit.Name = "TextBoxUpperLimit";
            TextBoxUpperLimit.PlaceholderText = "Üst Limit";
            TextBoxUpperLimit.Size = new Size(216, 26);
            TextBoxUpperLimit.TabIndex = 0;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.BackColor = Color.White;
            tableLayoutPanel10.ColumnCount = 2;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Controls.Add(label3, 0, 0);
            tableLayoutPanel10.Controls.Add(ComboBoxCoolDown, 1, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(1, 287);
            tableLayoutPanel10.Margin = new Padding(1);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Size = new Size(561, 48);
            tableLayoutPanel10.TabIndex = 9;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(78, 15);
            label3.Name = "label3";
            label3.Size = new Size(123, 18);
            label3.TabIndex = 0;
            label3.Text = "Bekleme Süresi:";
            // 
            // ComboBoxCoolDown
            // 
            ComboBoxCoolDown.Anchor = AnchorStyles.None;
            ComboBoxCoolDown.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBoxCoolDown.FormattingEnabled = true;
            ComboBoxCoolDown.Location = new Point(312, 11);
            ComboBoxCoolDown.Name = "ComboBoxCoolDown";
            ComboBoxCoolDown.Size = new Size(216, 26);
            ComboBoxCoolDown.TabIndex = 1;
            ComboBoxCoolDown.SelectedIndexChanged += ComboBoxCoolDown_SelectedIndexChanged;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.White;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(TextBoxMailSubject, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(1, 362);
            tableLayoutPanel4.Margin = new Padding(1);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(561, 48);
            tableLayoutPanel4.TabIndex = 10;
            // 
            // TextBoxMailSubject
            // 
            TextBoxMailSubject.Anchor = AnchorStyles.None;
            TextBoxMailSubject.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxMailSubject.Location = new Point(56, 11);
            TextBoxMailSubject.Name = "TextBoxMailSubject";
            TextBoxMailSubject.PlaceholderText = "Mail Konusu";
            TextBoxMailSubject.Size = new Size(448, 26);
            TextBoxMailSubject.TabIndex = 1;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.BackColor = Color.WhiteSmoke;
            tableLayoutPanel12.ColumnCount = 1;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(0, 211);
            tableLayoutPanel12.Margin = new Padding(0);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Size = new Size(563, 25);
            tableLayoutPanel12.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(titleBarControl1, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(593, 8);
            tableLayoutPanel2.Margin = new Padding(8);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(569, 605);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // titleBarControl1
            // 
            titleBarControl1.BackColor = Color.FromArgb(235, 235, 235);
            titleBarControl1.Dock = DockStyle.Fill;
            titleBarControl1.Location = new Point(3, 3);
            titleBarControl1.Name = "titleBarControl1";
            titleBarControl1.Padding = new Padding(1);
            titleBarControl1.Size = new Size(563, 32);
            titleBarControl1.TabIndex = 2;
            titleBarControl1.TitleBarText = "MAİL DURUMLARI";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.BackColor = Color.FromArgb(235, 235, 235);
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(DataGridViewStatements, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 41);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(563, 561);
            tableLayoutPanel6.TabIndex = 3;
            // 
            // DataGridViewStatements
            // 
            DataGridViewStatements.AllowUserToAddRows = false;
            DataGridViewStatements.AllowUserToDeleteRows = false;
            DataGridViewStatements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewStatements.BackgroundColor = Color.White;
            DataGridViewStatements.BorderStyle = BorderStyle.None;
            DataGridViewStatements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewStatements.ContextMenuStrip = ContextMenuStripStatement;
            DataGridViewStatements.Dock = DockStyle.Fill;
            DataGridViewStatements.Location = new Point(1, 1);
            DataGridViewStatements.Margin = new Padding(1);
            DataGridViewStatements.MultiSelect = false;
            DataGridViewStatements.Name = "DataGridViewStatements";
            DataGridViewStatements.ReadOnly = true;
            DataGridViewStatements.RowHeadersVisible = false;
            DataGridViewStatements.RowTemplate.Height = 25;
            DataGridViewStatements.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewStatements.Size = new Size(561, 559);
            DataGridViewStatements.TabIndex = 0;
            // 
            // ContextMenuStripStatement
            // 
            ContextMenuStripStatement.Items.AddRange(new ToolStripItem[] { DuzenleToolStipMenuItem, SilToolStripMenuItem });
            ContextMenuStripStatement.Name = "ContextMenuStripStatement";
            ContextMenuStripStatement.Size = new Size(181, 70);
            // 
            // DuzenleToolStipMenuItem
            // 
            DuzenleToolStipMenuItem.Name = "DuzenleToolStipMenuItem";
            DuzenleToolStipMenuItem.Size = new Size(180, 22);
            DuzenleToolStipMenuItem.Text = "Düzenle";
            DuzenleToolStipMenuItem.Click += DuzenleToolStipMenuItem_Click;
            // 
            // SilToolStripMenuItem
            // 
            SilToolStripMenuItem.Name = "SilToolStripMenuItem";
            SilToolStripMenuItem.Size = new Size(180, 22);
            SilToolStripMenuItem.Text = "Sil";
            SilToolStripMenuItem.Click += SilToolStripMenuItem_Click;
            // 
            // MailStatementsEditPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1170, 621);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MailStatementsEditPage";
            Text = "MailStatementsEditPage";
            Load += MailStatementsEditPage_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            TableLayoutPanelLimits.ResumeLayout(false);
            TableLayoutPanelLimits.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewStatements).EndInit();
            ContextMenuStripStatement.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Components.TitleBarControl titleBarControl2;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel2;
        private Components.TitleBarControl titleBarControl1;
        private TableLayoutPanel tableLayoutPanel6;
        private DataGridView DataGridViewStatements;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label1;
        private ComboBox ComboBoxParameter;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label2;
        private ComboBox ComboBoxStatement;
        private TableLayoutPanel TableLayoutPanelLimits;
        private TextBox TextBoxLowerLimit;
        private TextBox TextBoxUpperLimit;
        private TableLayoutPanel tableLayoutPanel10;
        private Label label3;
        private ComboBox ComboBoxCoolDown;
        private TableLayoutPanel tableLayoutPanel11;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox TextBoxMailSubject;
        private TextBox TextBoxMailContent;
        private TableLayoutPanel tableLayoutPanel12;
        private TableLayoutPanel tableLayoutPanel14;
        private TableLayoutPanel tableLayoutPanel13;
        private Button ButtonSave;
        private ContextMenuStrip ContextMenuStripStatement;
        private ToolStripMenuItem DuzenleToolStipMenuItem;
        private ToolStripMenuItem SilToolStripMenuItem;
    }
}