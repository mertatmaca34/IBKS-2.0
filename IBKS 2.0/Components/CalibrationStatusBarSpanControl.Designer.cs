namespace IBKS_2._0.Components
{
    partial class CalibrationStatusBarSpanControl
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
            LabelZeroStd = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            panel5 = new Panel();
            LabelSpanStd = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            LabelSpanRef = new Label();
            label4 = new Label();
            LabelSpanMeas = new Label();
            label5 = new Label();
            label6 = new Label();
            LabelSpanDiff = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // LabelZeroStd
            // 
            LabelZeroStd.Anchor = AnchorStyles.None;
            LabelZeroStd.AutoSize = true;
            LabelZeroStd.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelZeroStd.Location = new Point(182, 41);
            LabelZeroStd.Margin = new Padding(0);
            LabelZeroStd.Name = "LabelZeroStd";
            LabelZeroStd.Size = new Size(13, 18);
            LabelZeroStd.TabIndex = 1;
            LabelZeroStd.Text = "-";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 11;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 20);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(20, 60);
            label1.TabIndex = 1;
            label1.Text = "Zero Ref: ";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BackColor = Color.FromArgb(235, 235, 235);
            panel5.Location = new Point(46, 39);
            panel5.Name = "panel5";
            panel5.Size = new Size(1, 21);
            panel5.TabIndex = 0;
            // 
            // LabelSpanStd
            // 
            LabelSpanStd.Anchor = AnchorStyles.None;
            LabelSpanStd.AutoSize = true;
            LabelSpanStd.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelSpanStd.Location = new Point(528, 5);
            LabelSpanStd.Margin = new Padding(0);
            LabelSpanStd.Name = "LabelSpanStd";
            LabelSpanStd.Size = new Size(13, 18);
            LabelSpanStd.TabIndex = 1;
            LabelSpanStd.Text = "-";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 11;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(panel1, 2, 0);
            tableLayoutPanel2.Controls.Add(panel2, 5, 0);
            tableLayoutPanel2.Controls.Add(panel3, 8, 0);
            tableLayoutPanel2.Controls.Add(LabelSpanRef, 1, 0);
            tableLayoutPanel2.Controls.Add(label4, 3, 0);
            tableLayoutPanel2.Controls.Add(LabelSpanMeas, 4, 0);
            tableLayoutPanel2.Controls.Add(label5, 6, 0);
            tableLayoutPanel2.Controls.Add(label6, 9, 0);
            tableLayoutPanel2.Controls.Add(LabelSpanStd, 10, 0);
            tableLayoutPanel2.Controls.Add(LabelSpanDiff, 7, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(571, 29);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(8, 7);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 1;
            label3.Text = "Span Ref:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(235, 235, 235);
            panel1.Location = new Point(138, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 21);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(235, 235, 235);
            panel2.Location = new Point(282, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1, 21);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.FromArgb(235, 235, 235);
            panel3.Location = new Point(426, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 21);
            panel3.TabIndex = 0;
            // 
            // LabelSpanRef
            // 
            LabelSpanRef.Anchor = AnchorStyles.None;
            LabelSpanRef.AutoSize = true;
            LabelSpanRef.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelSpanRef.Location = new Point(94, 5);
            LabelSpanRef.Margin = new Padding(0);
            LabelSpanRef.Name = "LabelSpanRef";
            LabelSpanRef.Size = new Size(13, 18);
            LabelSpanRef.TabIndex = 1;
            LabelSpanRef.Text = "-";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(148, 7);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 1;
            label4.Text = "Span Meas:";
            // 
            // LabelSpanMeas
            // 
            LabelSpanMeas.Anchor = AnchorStyles.None;
            LabelSpanMeas.AutoSize = true;
            LabelSpanMeas.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelSpanMeas.Location = new Point(238, 5);
            LabelSpanMeas.Margin = new Padding(0);
            LabelSpanMeas.Name = "LabelSpanMeas";
            LabelSpanMeas.Size = new Size(13, 18);
            LabelSpanMeas.TabIndex = 1;
            LabelSpanMeas.Text = "-";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(295, 0);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(52, 29);
            label5.TabIndex = 1;
            label5.Text = "Span Diff (%):";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(440, 7);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 1;
            label6.Text = "Span Std:";
            // 
            // LabelSpanDiff
            // 
            LabelSpanDiff.Anchor = AnchorStyles.None;
            LabelSpanDiff.AutoSize = true;
            LabelSpanDiff.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelSpanDiff.Location = new Point(382, 5);
            LabelSpanDiff.Margin = new Padding(0);
            LabelSpanDiff.Name = "LabelSpanDiff";
            LabelSpanDiff.Size = new Size(13, 18);
            LabelSpanDiff.TabIndex = 1;
            LabelSpanDiff.Text = "-";
            // 
            // CalibrationStatusBarControl2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Name = "CalibrationStatusBarControl2";
            Size = new Size(571, 29);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LabelZeroStd;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Panel panel5;
        private Label LabelSpanStd;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label LabelSpanRef;
        private Label label4;
        private Label LabelSpanMeas;
        private Label label5;
        private Label label6;
        private Label LabelSpanDiff;
    }
}
