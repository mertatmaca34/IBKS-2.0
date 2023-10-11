namespace ibks.Components
{
    partial class DigitalSensorBar
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
            tableLayoutPanel2 = new TableLayoutPanel();
            PanelStatement = new Panel();
            PanelSplit2 = new Panel();
            PanelSplit1 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            LabelChannelName = new Label();
            LabelChannelDescription = new Label();
            TableLayoutPanelSystemStatement = new TableLayoutPanel();
            LabelSystemStatementTitle = new Label();
            LabelSystemStatementDescription = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            TableLayoutPanelSystemStatement.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(235, 235, 235);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(579, 48);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(PanelStatement, 0, 0);
            tableLayoutPanel2.Controls.Add(PanelSplit2, 4, 0);
            tableLayoutPanel2.Controls.Add(PanelSplit1, 2, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Controls.Add(TableLayoutPanelSystemStatement, 5, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(1, 1);
            tableLayoutPanel2.Margin = new Padding(1);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(577, 46);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // PanelStatement
            // 
            PanelStatement.BackColor = Color.Gray;
            PanelStatement.Dock = DockStyle.Fill;
            PanelStatement.Location = new Point(0, 0);
            PanelStatement.Margin = new Padding(0);
            PanelStatement.Name = "PanelStatement";
            PanelStatement.Size = new Size(8, 46);
            PanelStatement.TabIndex = 0;
            // 
            // PanelSplit2
            // 
            PanelSplit2.Anchor = AnchorStyles.None;
            PanelSplit2.BackColor = Color.FromArgb(235, 235, 235);
            PanelSplit2.Location = new Point(388, 4);
            PanelSplit2.Name = "PanelSplit2";
            PanelSplit2.Size = new Size(1, 37);
            PanelSplit2.TabIndex = 1;
            // 
            // PanelSplit1
            // 
            PanelSplit1.Anchor = AnchorStyles.None;
            PanelSplit1.BackColor = Color.FromArgb(235, 235, 235);
            PanelSplit1.Location = new Point(195, 4);
            PanelSplit1.Name = "PanelSplit1";
            PanelSplit1.Size = new Size(1, 37);
            PanelSplit1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(LabelChannelName, 0, 0);
            tableLayoutPanel3.Controls.Add(LabelChannelDescription, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(8, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 59.57F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 40.43F));
            tableLayoutPanel3.Size = new Size(183, 46);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // LabelChannelName
            // 
            LabelChannelName.Anchor = AnchorStyles.Bottom;
            LabelChannelName.AutoSize = true;
            LabelChannelName.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelChannelName.Location = new Point(11, 9);
            LabelChannelName.Name = "LabelChannelName";
            LabelChannelName.Size = new Size(160, 18);
            LabelChannelName.TabIndex = 2;
            LabelChannelName.Text = "DİJİTAL SENSÖRLER";
            // 
            // LabelChannelDescription
            // 
            LabelChannelDescription.Anchor = AnchorStyles.Top;
            LabelChannelDescription.AutoSize = true;
            LabelChannelDescription.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelChannelDescription.Location = new Point(45, 27);
            LabelChannelDescription.Name = "LabelChannelDescription";
            LabelChannelDescription.Size = new Size(92, 14);
            LabelChannelDescription.TabIndex = 2;
            LabelChannelDescription.Text = "SENSÖR İSİMLERİ";
            // 
            // TableLayoutPanelSystemStatement
            // 
            TableLayoutPanelSystemStatement.ColumnCount = 1;
            TableLayoutPanelSystemStatement.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanelSystemStatement.Controls.Add(LabelSystemStatementTitle, 0, 0);
            TableLayoutPanelSystemStatement.Controls.Add(LabelSystemStatementDescription, 0, 1);
            TableLayoutPanelSystemStatement.Dock = DockStyle.Fill;
            TableLayoutPanelSystemStatement.Location = new Point(399, 5);
            TableLayoutPanelSystemStatement.Margin = new Padding(5);
            TableLayoutPanelSystemStatement.Name = "TableLayoutPanelSystemStatement";
            TableLayoutPanelSystemStatement.RowCount = 2;
            TableLayoutPanelSystemStatement.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableLayoutPanelSystemStatement.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableLayoutPanelSystemStatement.Size = new Size(173, 36);
            TableLayoutPanelSystemStatement.TabIndex = 4;
            // 
            // LabelSystemStatementTitle
            // 
            LabelSystemStatementTitle.Anchor = AnchorStyles.Bottom;
            LabelSystemStatementTitle.AutoSize = true;
            LabelSystemStatementTitle.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelSystemStatementTitle.Location = new Point(42, 4);
            LabelSystemStatementTitle.Name = "LabelSystemStatementTitle";
            LabelSystemStatementTitle.Size = new Size(89, 14);
            LabelSystemStatementTitle.TabIndex = 0;
            LabelSystemStatementTitle.Text = "SİSTEM DURUMU";
            // 
            // LabelSystemStatementDescription
            // 
            LabelSystemStatementDescription.Anchor = AnchorStyles.Top;
            LabelSystemStatementDescription.AutoSize = true;
            LabelSystemStatementDescription.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelSystemStatementDescription.Location = new Point(80, 18);
            LabelSystemStatementDescription.Name = "LabelSystemStatementDescription";
            LabelSystemStatementDescription.Size = new Size(13, 18);
            LabelSystemStatementDescription.TabIndex = 0;
            LabelSystemStatementDescription.Text = "-";
            // 
            // DigitalSensorBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 235, 235);
            Controls.Add(tableLayoutPanel1);
            Name = "DigitalSensorBar";
            Size = new Size(579, 48);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            TableLayoutPanelSystemStatement.ResumeLayout(false);
            TableLayoutPanelSystemStatement.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel PanelStatement;
        private Panel PanelSplit2;
        private Panel PanelSplit1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label LabelChannelName;
        private Label LabelChannelDescription;
        private TableLayoutPanel TableLayoutPanelSystemStatement;
        private Label LabelSystemStatementTitle;
        private Label LabelSystemStatementDescription;
    }
}
