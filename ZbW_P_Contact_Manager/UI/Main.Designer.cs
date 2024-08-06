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
            btnSettings = new Button();
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
            PnlFormLoader = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            lblTitle = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(pnlNav);
            panel1.Controls.Add(btnSettings);
            panel1.Controls.Add(btnHistory);
            panel1.Controls.Add(btnImportExport);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnCustomerContact);
            panel1.Controls.Add(btnAdministration);
            panel1.Controls.Add(BtnDashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 577);
            panel1.TabIndex = 1;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.FromArgb(0, 126, 249);
            pnlNav.Location = new Point(0, 193);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(3, 100);
            pnlNav.TabIndex = 15;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Bottom;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = Color.FromArgb(0, 126, 249);
            btnSettings.Image = Properties.Resources.settings;
            btnSettings.Location = new Point(0, 535);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(186, 42);
            btnSettings.TabIndex = 14;
            btnSettings.Text = "Settings";
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            btnSettings.Leave += btnSettings_Leave;
            // 
            // btnHistory
            // 
            btnHistory.Dock = DockStyle.Top;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistory.ForeColor = Color.FromArgb(0, 126, 249);
            btnHistory.Image = Properties.Resources.bookmark_book;
            btnHistory.Location = new Point(0, 354);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(186, 42);
            btnHistory.TabIndex = 13;
            btnHistory.Text = "History       ";
            btnHistory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            btnHistory.Leave += btnHistory_Leave;
            // 
            // btnImportExport
            // 
            btnImportExport.Dock = DockStyle.Top;
            btnImportExport.FlatAppearance.BorderSize = 0;
            btnImportExport.FlatStyle = FlatStyle.Flat;
            btnImportExport.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImportExport.ForeColor = Color.FromArgb(0, 126, 249);
            btnImportExport.Image = Properties.Resources.import;
            btnImportExport.Location = new Point(0, 312);
            btnImportExport.Name = "btnImportExport";
            btnImportExport.Size = new Size(186, 42);
            btnImportExport.TabIndex = 12;
            btnImportExport.Text = "Import/Export";
            btnImportExport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnImportExport.UseVisualStyleBackColor = true;
            btnImportExport.Click += btnImportExport_Click;
            btnImportExport.Leave += btnImportExport_Leave;
            // 
            // btnSearch
            // 
            btnSearch.Dock = DockStyle.Top;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.FromArgb(0, 126, 249);
            btnSearch.Image = Properties.Resources.doc_magnifying_glass;
            btnSearch.Location = new Point(0, 270);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(186, 42);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            btnSearch.Leave += btnSearch_Leave;
            // 
            // btnCustomerContact
            // 
            btnCustomerContact.Dock = DockStyle.Top;
            btnCustomerContact.FlatAppearance.BorderSize = 0;
            btnCustomerContact.FlatStyle = FlatStyle.Flat;
            btnCustomerContact.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomerContact.ForeColor = Color.FromArgb(0, 126, 249);
            btnCustomerContact.Image = Properties.Resources.open_book;
            btnCustomerContact.Location = new Point(0, 228);
            btnCustomerContact.Name = "btnCustomerContact";
            btnCustomerContact.Size = new Size(186, 42);
            btnCustomerContact.TabIndex = 10;
            btnCustomerContact.Text = "CustomerContact";
            btnCustomerContact.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomerContact.UseVisualStyleBackColor = true;
            btnCustomerContact.Click += btnCustomerContact_Click;
            btnCustomerContact.Leave += btnCustomerContact_Leave;
            // 
            // btnAdministration
            // 
            btnAdministration.Dock = DockStyle.Top;
            btnAdministration.FlatAppearance.BorderSize = 0;
            btnAdministration.FlatStyle = FlatStyle.Flat;
            btnAdministration.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdministration.ForeColor = Color.FromArgb(0, 126, 249);
            btnAdministration.Image = Properties.Resources.calendar;
            btnAdministration.Location = new Point(0, 186);
            btnAdministration.Name = "btnAdministration";
            btnAdministration.Size = new Size(186, 42);
            btnAdministration.TabIndex = 9;
            btnAdministration.Text = "Administration";
            btnAdministration.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdministration.UseVisualStyleBackColor = true;
            btnAdministration.Click += btnAdministration_Click;
            btnAdministration.Leave += btnAdministration_Leave;
            // 
            // BtnDashboard
            // 
            BtnDashboard.Dock = DockStyle.Top;
            BtnDashboard.FlatAppearance.BorderSize = 0;
            BtnDashboard.FlatStyle = FlatStyle.Flat;
            BtnDashboard.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDashboard.ForeColor = Color.FromArgb(0, 126, 249);
            BtnDashboard.Image = Properties.Resources.home;
            BtnDashboard.Location = new Point(0, 144);
            BtnDashboard.Name = "BtnDashboard";
            BtnDashboard.Size = new Size(186, 42);
            BtnDashboard.TabIndex = 8;
            BtnDashboard.Text = "Dashboard";
            BtnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnDashboard.UseVisualStyleBackColor = true;
            BtnDashboard.Click += BtnDashboard_Click;
            BtnDashboard.Leave += BtnDashboard_Leave;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 144);
            panel2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(158, 161, 176);
            label2.Location = new Point(39, 118);
            label2.Name = "label2";
            label2.Size = new Size(108, 12);
            label2.TabIndex = 2;
            label2.Text = "Some User Text here";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(48, 97);
            label1.Name = "label1";
            label1.Size = new Size(86, 16);
            label1.TabIndex = 1;
            label1.Text = "User Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ProfileIcon_png;
            pictureBox1.Location = new Point(60, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(PnlFormLoader);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(lblTitle);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(186, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(765, 577);
            panel3.TabIndex = 2;
            // 
            // PnlFormLoader
            // 
            PnlFormLoader.Dock = DockStyle.Bottom;
            PnlFormLoader.Location = new Point(0, 100);
            PnlFormLoader.Name = "PnlFormLoader";
            PnlFormLoader.Size = new Size(765, 477);
            PnlFormLoader.TabIndex = 3;
            PnlFormLoader.Paint += PnlFormLoader_Paint;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(728, 12);
            button1.Name = "button1";
            button1.Size = new Size(25, 25);
            button1.TabIndex = 2;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(74, 79, 99);
            textBox1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(413, 18);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 31);
            textBox1.TabIndex = 1;
            textBox1.Text = "Search for something...";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(19, 34);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(162, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Dashboard";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(951, 577);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Main_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private Button btnSettings;
        private Panel panel3;
        private Label lblTitle;
        private Button button1;
        private TextBox textBox1;
        private Panel PnlFormLoader;
    }
}