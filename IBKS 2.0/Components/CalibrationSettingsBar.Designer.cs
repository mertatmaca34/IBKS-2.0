namespace IBKS_2._0.Components
{
    partial class CalibrationSettingsBar
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
            panel2 = new Panel();
            LabelParameter = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            ComboBoxZeroRef = new ComboBox();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label3 = new Label();
            ComboBoxZeroTime = new ComboBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            ComboBoxSpanRef = new ComboBox();
            label4 = new Label();
            panel4 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            ComboBoxSpanTime = new ComboBox();
            label5 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 9;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(LabelParameter, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 3, 0);
            tableLayoutPanel1.Controls.Add(panel3, 5, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 2, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 4, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 6, 0);
            tableLayoutPanel1.Controls.Add(panel4, 7, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 8, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(1, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(993, 58);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(235, 235, 235);
            panel2.Location = new Point(194, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1, 50);
            panel2.TabIndex = 4;
            // 
            // LabelParameter
            // 
            LabelParameter.Anchor = AnchorStyles.None;
            LabelParameter.AutoSize = true;
            LabelParameter.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelParameter.Location = new Point(74, 20);
            LabelParameter.Name = "LabelParameter";
            LabelParameter.Size = new Size(41, 18);
            LabelParameter.TabIndex = 3;
            LabelParameter.Text = "AKM";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(235, 235, 235);
            panel1.Location = new Point(394, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 50);
            panel1.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.FromArgb(235, 235, 235);
            panel3.Location = new Point(594, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 50);
            panel3.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(ComboBoxZeroRef, 0, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(200, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel2.Size = new Size(190, 58);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // ComboBoxZeroRef
            // 
            ComboBoxZeroRef.Dock = DockStyle.Fill;
            ComboBoxZeroRef.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxZeroRef.FormattingEnabled = true;
            ComboBoxZeroRef.Items.AddRange(new object[] { "0", "7" });
            ComboBoxZeroRef.Location = new Point(8, 28);
            ComboBoxZeroRef.Margin = new Padding(8);
            ComboBoxZeroRef.Name = "ComboBoxZeroRef";
            ComboBoxZeroRef.Size = new Size(174, 23);
            ComboBoxZeroRef.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(38, 1);
            label1.Name = "label1";
            label1.Size = new Size(113, 18);
            label1.TabIndex = 3;
            label1.Text = "Zero Referans:";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(ComboBoxZeroTime, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(400, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel3.Size = new Size(190, 58);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(48, 1);
            label3.Name = "label3";
            label3.Size = new Size(94, 18);
            label3.TabIndex = 3;
            label3.Text = "Zero Süresi:";
            // 
            // ComboBoxZeroTime
            // 
            ComboBoxZeroTime.Dock = DockStyle.Fill;
            ComboBoxZeroTime.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxZeroTime.FormattingEnabled = true;
            ComboBoxZeroTime.Items.AddRange(new object[] { "10", "15", "30", "60", "90", "180" });
            ComboBoxZeroTime.Location = new Point(8, 28);
            ComboBoxZeroTime.Margin = new Padding(8);
            ComboBoxZeroTime.Name = "ComboBoxZeroTime";
            ComboBoxZeroTime.Size = new Size(174, 23);
            ComboBoxZeroTime.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(ComboBoxSpanRef, 0, 1);
            tableLayoutPanel4.Controls.Add(label4, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(600, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel4.Size = new Size(190, 58);
            tableLayoutPanel4.TabIndex = 6;
            // 
            // ComboBoxSpanRef
            // 
            ComboBoxSpanRef.Dock = DockStyle.Fill;
            ComboBoxSpanRef.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxSpanRef.FormattingEnabled = true;
            ComboBoxSpanRef.Items.AddRange(new object[] { "4", "10", "1413" });
            ComboBoxSpanRef.Location = new Point(8, 28);
            ComboBoxSpanRef.Margin = new Padding(8);
            ComboBoxSpanRef.Name = "ComboBoxSpanRef";
            ComboBoxSpanRef.Size = new Size(174, 23);
            ComboBoxSpanRef.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(36, 1);
            label4.Name = "label4";
            label4.Size = new Size(117, 18);
            label4.TabIndex = 3;
            label4.Text = "Span Referans:";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.FromArgb(235, 235, 235);
            panel4.Location = new Point(794, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1, 50);
            panel4.TabIndex = 5;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(ComboBoxSpanTime, 0, 1);
            tableLayoutPanel5.Controls.Add(label5, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(800, 0);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel5.Size = new Size(193, 58);
            tableLayoutPanel5.TabIndex = 6;
            // 
            // ComboBoxSpanTime
            // 
            ComboBoxSpanTime.Dock = DockStyle.Fill;
            ComboBoxSpanTime.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxSpanTime.FormattingEnabled = true;
            ComboBoxSpanTime.Items.AddRange(new object[] { "10", "15", "30", "60", "90", "180" });
            ComboBoxSpanTime.Location = new Point(8, 28);
            ComboBoxSpanTime.Margin = new Padding(8);
            ComboBoxSpanTime.Name = "ComboBoxSpanTime";
            ComboBoxSpanTime.Size = new Size(177, 23);
            ComboBoxSpanTime.TabIndex = 5;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(47, 1);
            label5.Name = "label5";
            label5.Size = new Size(98, 18);
            label5.TabIndex = 3;
            label5.Text = "Span Süresi:";
            // 
            // CalibrationSettingsBar
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(235, 235, 235);
            Controls.Add(tableLayoutPanel1);
            Name = "CalibrationSettingsBar";
            Padding = new Padding(1);
            Size = new Size(995, 60);
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
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label LabelParameter;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label1;
        private Label label3;
        private ComboBox ComboBoxZeroTime;
        private Label label4;
        private Label label5;
        private ComboBox ComboBoxSpanTime;
        private ComboBox ComboBoxZeroRef;
        private ComboBox ComboBoxSpanRef;
    }
}
