namespace IBKS_2._0.Components
{
    partial class ChannelControl
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
            LabelAvgOf60Min = new Label();
            LabelInstantData = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            LabelChannelName = new Label();
            LabelChannelDescription = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
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
            tableLayoutPanel1.TabIndex = 0;
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
            tableLayoutPanel2.Controls.Add(LabelAvgOf60Min, 5, 0);
            tableLayoutPanel2.Controls.Add(LabelInstantData, 3, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
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
            // LabelAvgOf60Min
            // 
            LabelAvgOf60Min.Anchor = AnchorStyles.None;
            LabelAvgOf60Min.AutoSize = true;
            LabelAvgOf60Min.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAvgOf60Min.Location = new Point(479, 14);
            LabelAvgOf60Min.Name = "LabelAvgOf60Min";
            LabelAvgOf60Min.Size = new Size(13, 17);
            LabelAvgOf60Min.TabIndex = 2;
            LabelAvgOf60Min.Text = "-";
            // 
            // LabelInstantData
            // 
            LabelInstantData.Anchor = AnchorStyles.None;
            LabelInstantData.AutoSize = true;
            LabelInstantData.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelInstantData.Location = new Point(286, 14);
            LabelInstantData.Name = "LabelInstantData";
            LabelInstantData.Size = new Size(13, 18);
            LabelInstantData.TabIndex = 2;
            LabelInstantData.Text = "-";
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
            LabelChannelName.Location = new Point(85, 9);
            LabelChannelName.Name = "LabelChannelName";
            LabelChannelName.Size = new Size(13, 18);
            LabelChannelName.TabIndex = 2;
            LabelChannelName.Text = "-";
            // 
            // LabelChannelDescription
            // 
            LabelChannelDescription.Anchor = AnchorStyles.Top;
            LabelChannelDescription.AutoSize = true;
            LabelChannelDescription.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelChannelDescription.Location = new Point(86, 27);
            LabelChannelDescription.Name = "LabelChannelDescription";
            LabelChannelDescription.Size = new Size(11, 14);
            LabelChannelDescription.TabIndex = 2;
            LabelChannelDescription.Text = "-";
            // 
            // ChannelControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ChannelControl";
            Size = new Size(579, 48);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel PanelStatement;
        private Panel PanelSplit2;
        private Panel PanelSplit1;
        private Label LabelInstantData;
        private Label LabelAvgOf60Min;
        private TableLayoutPanel tableLayoutPanel3;
        private Label LabelChannelName;
        private Label LabelChannelDescription;
    }
}
