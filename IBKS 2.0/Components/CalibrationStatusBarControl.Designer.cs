namespace IBKS_2._0.Components
{
    partial class CalibrationStatusBarControl
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
            label1 = new Label();
            panel5 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            LabelZeroRef = new Label();
            label3 = new Label();
            LabelZeroMeas = new Label();
            label5 = new Label();
            label6 = new Label();
            LabelZeroStd = new Label();
            LabelZeroDiff = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            tableLayoutPanel1.Controls.Add(panel5, 2, 0);
            tableLayoutPanel1.Controls.Add(panel1, 5, 0);
            tableLayoutPanel1.Controls.Add(panel2, 8, 0);
            tableLayoutPanel1.Controls.Add(LabelZeroRef, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 3, 0);
            tableLayoutPanel1.Controls.Add(LabelZeroMeas, 4, 0);
            tableLayoutPanel1.Controls.Add(label5, 6, 0);
            tableLayoutPanel1.Controls.Add(label6, 9, 0);
            tableLayoutPanel1.Controls.Add(LabelZeroStd, 10, 0);
            tableLayoutPanel1.Controls.Add(LabelZeroDiff, 7, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(1, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(569, 27);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(7, 6);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 1;
            label1.Text = "Zero Ref: ";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BackColor = Color.FromArgb(235, 235, 235);
            panel5.Location = new Point(138, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(1, 21);
            panel5.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(235, 235, 235);
            panel1.Location = new Point(282, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 21);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(235, 235, 235);
            panel2.Location = new Point(426, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1, 21);
            panel2.TabIndex = 0;
            // 
            // LabelZeroRef
            // 
            LabelZeroRef.Anchor = AnchorStyles.None;
            LabelZeroRef.AutoSize = true;
            LabelZeroRef.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelZeroRef.Location = new Point(94, 4);
            LabelZeroRef.Margin = new Padding(0);
            LabelZeroRef.Name = "LabelZeroRef";
            LabelZeroRef.Size = new Size(13, 18);
            LabelZeroRef.TabIndex = 1;
            LabelZeroRef.Text = "-";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(149, 6);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 1;
            label3.Text = "Zero Meas:";
            // 
            // LabelZeroMeas
            // 
            LabelZeroMeas.Anchor = AnchorStyles.None;
            LabelZeroMeas.AutoSize = true;
            LabelZeroMeas.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelZeroMeas.Location = new Point(238, 4);
            LabelZeroMeas.Margin = new Padding(0);
            LabelZeroMeas.Name = "LabelZeroMeas";
            LabelZeroMeas.Size = new Size(13, 18);
            LabelZeroMeas.TabIndex = 1;
            LabelZeroMeas.Text = "-";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(288, 6);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 1;
            label5.Text = "Zero Diff (%):";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(441, 6);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 1;
            label6.Text = "Zero Std:";
            // 
            // LabelZeroStd
            // 
            LabelZeroStd.Anchor = AnchorStyles.None;
            LabelZeroStd.AutoSize = true;
            LabelZeroStd.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelZeroStd.Location = new Point(527, 4);
            LabelZeroStd.Margin = new Padding(0);
            LabelZeroStd.Name = "LabelZeroStd";
            LabelZeroStd.Size = new Size(13, 18);
            LabelZeroStd.TabIndex = 1;
            LabelZeroStd.Text = "-";
            // 
            // LabelZeroDiff
            // 
            LabelZeroDiff.Anchor = AnchorStyles.None;
            LabelZeroDiff.AutoSize = true;
            LabelZeroDiff.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelZeroDiff.Location = new Point(382, 4);
            LabelZeroDiff.Margin = new Padding(0);
            LabelZeroDiff.Name = "LabelZeroDiff";
            LabelZeroDiff.Size = new Size(13, 18);
            LabelZeroDiff.TabIndex = 1;
            LabelZeroDiff.Text = "-";
            // 
            // CalibrationStatusBarControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 235, 235);
            Controls.Add(tableLayoutPanel1);
            Name = "CalibrationStatusBarControl";
            Padding = new Padding(1);
            Size = new Size(571, 29);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel5;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label LabelZeroRef;
        private Label label3;
        private Label LabelZeroMeas;
        private Label label5;
        private Label label6;
        private Label LabelZeroStd;
        private Label LabelZeroDiff;
    }
}
