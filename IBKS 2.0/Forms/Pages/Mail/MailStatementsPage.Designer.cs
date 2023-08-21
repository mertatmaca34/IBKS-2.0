namespace ibks.Forms.Pages.Mail
{
    partial class MailStatementsPage
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            titleBarControl1 = new Components.TitleBarControl();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label1 = new Label();
            ComboBoxSelectedUser = new ComboBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            DataGridViewMailStatements = new DataGridView();
            ComboBoxSec = new DataGridViewCheckBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewMailStatements).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(1170, 621);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(titleBarControl1, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(8, 8);
            tableLayoutPanel2.Margin = new Padding(8, 8, 8, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1154, 89);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // titleBarControl1
            // 
            titleBarControl1.BackColor = Color.FromArgb(235, 235, 235);
            titleBarControl1.Dock = DockStyle.Fill;
            titleBarControl1.Location = new Point(3, 3);
            titleBarControl1.Name = "titleBarControl1";
            titleBarControl1.Padding = new Padding(1);
            titleBarControl1.Size = new Size(1148, 32);
            titleBarControl1.TabIndex = 2;
            titleBarControl1.TitleBarText = "MAİL GÖNDERİLECEK KULLANICI";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.FromArgb(235, 235, 235);
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 41);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1148, 45);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.White;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label1, 0, 0);
            tableLayoutPanel4.Controls.Add(ComboBoxSelectedUser, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(1, 1);
            tableLayoutPanel4.Margin = new Padding(1);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1146, 43);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(229, 12);
            label1.Name = "label1";
            label1.Size = new Size(115, 18);
            label1.TabIndex = 0;
            label1.Text = "Seçili Kullanıcı: ";
            // 
            // ComboBoxSelectedUser
            // 
            ComboBoxSelectedUser.Anchor = AnchorStyles.None;
            ComboBoxSelectedUser.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxSelectedUser.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBoxSelectedUser.FormattingEnabled = true;
            ComboBoxSelectedUser.Location = new Point(702, 8);
            ComboBoxSelectedUser.Name = "ComboBoxSelectedUser";
            ComboBoxSelectedUser.Size = new Size(314, 26);
            ComboBoxSelectedUser.TabIndex = 1;
            ComboBoxSelectedUser.SelectedIndexChanged += ComboBoxSelectedUser_SelectedIndexChanged;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = Color.FromArgb(235, 235, 235);
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(DataGridViewMailStatements, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(11, 103);
            tableLayoutPanel5.Margin = new Padding(11, 3, 11, 11);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(1148, 507);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // DataGridViewMailStatements
            // 
            DataGridViewMailStatements.AllowUserToAddRows = false;
            DataGridViewMailStatements.AllowUserToDeleteRows = false;
            DataGridViewMailStatements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewMailStatements.BackgroundColor = Color.White;
            DataGridViewMailStatements.BorderStyle = BorderStyle.None;
            DataGridViewMailStatements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewMailStatements.Columns.AddRange(new DataGridViewColumn[] { ComboBoxSec });
            DataGridViewMailStatements.Dock = DockStyle.Fill;
            DataGridViewMailStatements.Location = new Point(1, 1);
            DataGridViewMailStatements.Margin = new Padding(1);
            DataGridViewMailStatements.MultiSelect = false;
            DataGridViewMailStatements.Name = "DataGridViewMailStatements";
            DataGridViewMailStatements.ReadOnly = true;
            DataGridViewMailStatements.RowHeadersVisible = false;
            DataGridViewMailStatements.RowTemplate.Height = 25;
            DataGridViewMailStatements.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewMailStatements.Size = new Size(1146, 505);
            DataGridViewMailStatements.TabIndex = 0;
            DataGridViewMailStatements.CellContentClick += DataGridViewMailStatements_CellContentClick;
            // 
            // ComboBoxSec
            // 
            ComboBoxSec.FillWeight = 30F;
            ComboBoxSec.HeaderText = "Seç";
            ComboBoxSec.Name = "ComboBoxSec";
            ComboBoxSec.ReadOnly = true;
            // 
            // MailStatementsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1170, 621);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MailStatementsPage";
            Text = "MailStatementsPage";
            Load += MailStatementsPage_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewMailStatements).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Components.TitleBarControl titleBarControl1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private ComboBox ComboBoxSelectedUser;
        private TableLayoutPanel tableLayoutPanel5;
        private DataGridView DataGridViewMailStatements;
        private DataGridViewCheckBoxColumn ComboBoxSec;
    }
}