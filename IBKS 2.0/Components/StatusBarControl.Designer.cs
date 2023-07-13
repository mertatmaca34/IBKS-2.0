namespace IBKS_2._0.Components
{
    partial class StatusBarControl
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            LabelBaglantiDurumu = new Label();
            LabelBaglantiZamani = new Label();
            LabelGYikamayaKalan = new Label();
            LabelHYikamaKalan = new Label();
            LabelSistemSaati = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 9;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 3, 0);
            tableLayoutPanel1.Controls.Add(panel3, 5, 0);
            tableLayoutPanel1.Controls.Add(panel4, 7, 0);
            tableLayoutPanel1.Controls.Add(LabelBaglantiDurumu, 0, 0);
            tableLayoutPanel1.Controls.Add(LabelBaglantiZamani, 2, 0);
            tableLayoutPanel1.Controls.Add(LabelGYikamayaKalan, 4, 0);
            tableLayoutPanel1.Controls.Add(LabelHYikamaKalan, 6, 0);
            tableLayoutPanel1.Controls.Add(LabelSistemSaati, 8, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(1, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1142, 28);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(235, 235, 235);
            panel1.Location = new Point(224, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 22);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(235, 235, 235);
            panel2.Location = new Point(454, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1, 22);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.FromArgb(235, 235, 235);
            panel3.Location = new Point(684, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 22);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.FromArgb(235, 235, 235);
            panel4.Location = new Point(914, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(1, 22);
            panel4.TabIndex = 0;
            // 
            // LabelBaglantiDurumu
            // 
            LabelBaglantiDurumu.Anchor = AnchorStyles.None;
            LabelBaglantiDurumu.AutoSize = true;
            LabelBaglantiDurumu.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelBaglantiDurumu.Location = new Point(66, 7);
            LabelBaglantiDurumu.Name = "LabelBaglantiDurumu";
            LabelBaglantiDurumu.Size = new Size(88, 14);
            LabelBaglantiDurumu.TabIndex = 1;
            LabelBaglantiDurumu.Text = "Bağlantı Durumu:";
            // 
            // LabelBaglantiZamani
            // 
            LabelBaglantiZamani.Anchor = AnchorStyles.None;
            LabelBaglantiZamani.AutoSize = true;
            LabelBaglantiZamani.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelBaglantiZamani.Location = new Point(297, 7);
            LabelBaglantiZamani.Name = "LabelBaglantiZamani";
            LabelBaglantiZamani.Size = new Size(86, 14);
            LabelBaglantiZamani.TabIndex = 1;
            LabelBaglantiZamani.Text = "Bağlantı Zamanı:";
            // 
            // LabelGYikamayaKalan
            // 
            LabelGYikamayaKalan.Anchor = AnchorStyles.None;
            LabelGYikamayaKalan.AutoSize = true;
            LabelGYikamayaKalan.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelGYikamayaKalan.Location = new Point(518, 7);
            LabelGYikamayaKalan.Name = "LabelGYikamayaKalan";
            LabelGYikamayaKalan.Size = new Size(104, 14);
            LabelGYikamayaKalan.TabIndex = 1;
            LabelGYikamayaKalan.Text = "G. Yıkamaya Kalan: ";
            // 
            // LabelHYikamaKalan
            // 
            LabelHYikamaKalan.Anchor = AnchorStyles.None;
            LabelHYikamaKalan.AutoSize = true;
            LabelHYikamaKalan.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelHYikamaKalan.Location = new Point(748, 7);
            LabelHYikamaKalan.Name = "LabelHYikamaKalan";
            LabelHYikamaKalan.Size = new Size(103, 14);
            LabelHYikamaKalan.TabIndex = 1;
            LabelHYikamaKalan.Text = "H. Yıkamaya Kalan: ";
            // 
            // LabelSistemSaati
            // 
            LabelSistemSaati.Anchor = AnchorStyles.None;
            LabelSistemSaati.AutoSize = true;
            LabelSistemSaati.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelSistemSaati.Location = new Point(995, 7);
            LabelSistemSaati.Name = "LabelSistemSaati";
            LabelSistemSaati.Size = new Size(72, 14);
            LabelSistemSaati.TabIndex = 1;
            LabelSistemSaati.Text = "Sistem Saati: ";
            // 
            // StatusBarControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 235, 235);
            Controls.Add(tableLayoutPanel1);
            Name = "StatusBarControl";
            Padding = new Padding(1);
            Size = new Size(1144, 30);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label LabelBaglantiDurumu;
        private Label LabelBaglantiZamani;
        private Label LabelGYikamayaKalan;
        private Label LabelHYikamaKalan;
        private Label LabelSistemSaati;
    }
}
