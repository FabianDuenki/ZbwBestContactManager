namespace ZbW_P_Contact_Manager.UI
{
    partial class Main
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
            panel1 = new Panel();
            pnlNav = new Panel();
            btnHistory = new Button();
            btnImportExport = new Button();
            btnSearch = new Button();
            btnCustomerContact = new Button();
            btnAdministration = new Button();
            BtnDashboard = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            pnlFormLoader = new Panel();
            panel4 = new Panel();
            button1 = new Button();
            lblTitle = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 77);
            panel1.Controls.Add(pnlNav);
            panel1.Controls.Add(btnHistory);
            panel1.Controls.Add(btnImportExport);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnCustomerContact);
            panel1.Controls.Add(btnAdministration);
            panel1.Controls.Add(BtnDashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 734);
            panel1.TabIndex = 1;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.FromArgb(0, 126, 249);
            pnlNav.Location = new Point(0, 258);
            pnlNav.Margin = new Padding(4, 4, 4, 4);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(4, 133);
            pnlNav.TabIndex = 15;
            // 
            // btnHistory
            // 
            btnHistory.Dock = DockStyle.Top;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistory.ForeColor = Color.FromArgb(167, 177, 255);
            btnHistory.Image = Properties.Resources.history;
            btnHistory.Location = new Point(0, 468);
            btnHistory.Margin = new Padding(4, 4, 4, 4);
            btnHistory.Name = "btnHistory";
            btnHistory.RightToLeft = RightToLeft.No;
            btnHistory.Size = new Size(212, 56);
            btnHistory.TabIndex = 13;
            btnHistory.Text = "History       ";
            btnHistory.TextAlign = ContentAlignment.MiddleLeft;
            btnHistory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnImportExport
            // 
            btnImportExport.Dock = DockStyle.Top;
            btnImportExport.FlatAppearance.BorderSize = 0;
            btnImportExport.FlatStyle = FlatStyle.Flat;
            btnImportExport.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImportExport.ForeColor = Color.FromArgb(167, 177, 255);
            btnImportExport.Image = Properties.Resources.import;
            btnImportExport.Location = new Point(0, 412);
            btnImportExport.Margin = new Padding(4, 4, 4, 4);
            btnImportExport.Name = "btnImportExport";
            btnImportExport.RightToLeft = RightToLeft.No;
            btnImportExport.Size = new Size(212, 56);
            btnImportExport.TabIndex = 12;
            btnImportExport.Text = "Import/Export";
            btnImportExport.TextAlign = ContentAlignment.MiddleLeft;
            btnImportExport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnImportExport.UseVisualStyleBackColor = true;
            btnImportExport.Click += btnImportExport_Click;
            // 
            // btnSearch
            // 
            btnSearch.Dock = DockStyle.Top;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.FromArgb(167, 177, 255);
            btnSearch.Image = Properties.Resources.search;
            btnSearch.Location = new Point(0, 356);
            btnSearch.Margin = new Padding(4, 4, 4, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.RightToLeft = RightToLeft.No;
            btnSearch.Size = new Size(212, 56);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.TextAlign = ContentAlignment.MiddleLeft;
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnCustomerContact
            // 
            btnCustomerContact.Dock = DockStyle.Top;
            btnCustomerContact.FlatAppearance.BorderSize = 0;
            btnCustomerContact.FlatStyle = FlatStyle.Flat;
            btnCustomerContact.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomerContact.ForeColor = Color.FromArgb(167, 177, 255);
            btnCustomerContact.Image = Properties.Resources.address_book;
            btnCustomerContact.Location = new Point(0, 300);
            btnCustomerContact.Margin = new Padding(4, 4, 4, 4);
            btnCustomerContact.Name = "btnCustomerContact";
            btnCustomerContact.RightToLeft = RightToLeft.No;
            btnCustomerContact.Size = new Size(212, 56);
            btnCustomerContact.TabIndex = 10;
            btnCustomerContact.Text = "CustomerContact";
            btnCustomerContact.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomerContact.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomerContact.UseVisualStyleBackColor = true;
            // 
            // btnAdministration
            // 
            btnAdministration.Dock = DockStyle.Top;
            btnAdministration.FlatAppearance.BorderSize = 0;
            btnAdministration.FlatStyle = FlatStyle.Flat;
            btnAdministration.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdministration.ForeColor = Color.FromArgb(167, 177, 255);
            btnAdministration.Image = Properties.Resources.user_menu;
            btnAdministration.Location = new Point(0, 244);
            btnAdministration.Margin = new Padding(4, 4, 4, 4);
            btnAdministration.Name = "btnAdministration";
            btnAdministration.RightToLeft = RightToLeft.No;
            btnAdministration.Size = new Size(212, 56);
            btnAdministration.TabIndex = 9;
            btnAdministration.Text = "Administration";
            btnAdministration.TextAlign = ContentAlignment.MiddleLeft;
            btnAdministration.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdministration.UseVisualStyleBackColor = true;
            btnAdministration.Click += btnAdministration_Click;
            // 
            // BtnDashboard
            // 
            BtnDashboard.Dock = DockStyle.Top;
            BtnDashboard.FlatAppearance.BorderSize = 0;
            BtnDashboard.FlatStyle = FlatStyle.Flat;
            BtnDashboard.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDashboard.ForeColor = Color.FromArgb(167, 177, 255);
            BtnDashboard.Image = Properties.Resources.dashboard;
            BtnDashboard.Location = new Point(0, 188);
            BtnDashboard.Margin = new Padding(4, 4, 4, 4);
            BtnDashboard.Name = "BtnDashboard";
            BtnDashboard.RightToLeft = RightToLeft.No;
            BtnDashboard.Size = new Size(212, 56);
            BtnDashboard.TabIndex = 8;
            BtnDashboard.Text = "Dashboard";
            BtnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            BtnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnDashboard.UseVisualStyleBackColor = true;
            BtnDashboard.Click += BtnDashboard_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(212, 188);
            panel2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(16, 7, 250);
            label2.Location = new Point(44, 158);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(146, 14);
            label2.TabIndex = 2;
            label2.Text = "Some User Text here";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(167, 177, 255);
            label1.Location = new Point(54, 129);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 1;
            label1.Text = "User Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.test_account;
            pictureBox1.Location = new Point(68, 29);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(29, 31, 33);
            panel3.Controls.Add(pnlFormLoader);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(212, 0);
            panel3.Margin = new Padding(4, 4, 4, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(875, 734);
            panel3.TabIndex = 2;
            // 
            // pnlFormLoader
            // 
            pnlFormLoader.Dock = DockStyle.Fill;
            pnlFormLoader.Location = new Point(0, 188);
            pnlFormLoader.Margin = new Padding(2, 2, 2, 2);
            pnlFormLoader.Name = "pnlFormLoader";
            pnlFormLoader.Size = new Size(875, 546);
            pnlFormLoader.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Controls.Add(button1);
            panel4.Controls.Add(lblTitle);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(2, 2, 2, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(875, 188);
            panel4.TabIndex = 4;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.close;
            button1.Location = new Point(837, 9);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(28, 33);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(19, 22);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(195, 39);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Dashboard";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1087, 734);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Main_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Button BtnDashboard;
        private Button btnHistory;
        private Button btnImportExport;
        private Button btnSearch;
        private Button btnCustomerContact;
        private Button btnAdministration;
        private Panel pnlNav;
        private Panel panel3;
        private Panel panel4;
        private Panel pnlFormLoader;
        private Button button1;
        private Label lblTitle;
    }
}