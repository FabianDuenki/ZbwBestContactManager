namespace ZbW_P_Contact_Manager.UI
{
    partial class MainSizeable
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
            pnlMain = new Panel();
            pnlMainPanel = new Panel();
            pnlFormLoader = new Panel();
            pnlMainPanelTop = new Panel();
            lblTitle = new Label();
            pnlLeftMenu = new Panel();
            pnlMenuButtons = new Panel();
            pnlNav = new Panel();
            btnSettings = new Button();
            btnHistory = new Button();
            btnImportExport = new Button();
            btnSearch = new Button();
            btnCustomerContact = new Button();
            btnAdministration = new Button();
            BtnDashboard = new Button();
            pnlUserDetails = new Panel();
            lblUserName = new Label();
            lblUserIcon = new PictureBox();
            pnlMain.SuspendLayout();
            pnlMainPanel.SuspendLayout();
            pnlMainPanelTop.SuspendLayout();
            pnlLeftMenu.SuspendLayout();
            pnlMenuButtons.SuspendLayout();
            pnlUserDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lblUserIcon).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlMainPanel);
            pnlMain.Controls.Add(pnlLeftMenu);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1724, 1329);
            pnlMain.TabIndex = 0;
            // 
            // pnlMainPanel
            // 
            pnlMainPanel.Controls.Add(pnlFormLoader);
            pnlMainPanel.Controls.Add(pnlMainPanelTop);
            pnlMainPanel.Dock = DockStyle.Fill;
            pnlMainPanel.Location = new Point(350, 0);
            pnlMainPanel.Name = "pnlMainPanel";
            pnlMainPanel.Size = new Size(1374, 1329);
            pnlMainPanel.TabIndex = 1;
            // 
            // pnlFormLoader
            // 
            pnlFormLoader.Dock = DockStyle.Fill;
            pnlFormLoader.Location = new Point(0, 300);
            pnlFormLoader.Name = "pnlFormLoader";
            pnlFormLoader.Size = new Size(1374, 1029);
            pnlFormLoader.TabIndex = 1;
            // 
            // pnlMainPanelTop
            // 
            pnlMainPanelTop.Controls.Add(lblTitle);
            pnlMainPanelTop.Dock = DockStyle.Top;
            pnlMainPanelTop.Location = new Point(0, 0);
            pnlMainPanelTop.Name = "pnlMainPanelTop";
            pnlMainPanelTop.Size = new Size(1374, 300);
            pnlMainPanelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(206, 213, 255);
            lblTitle.Location = new Point(22, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(100, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            // 
            // pnlLeftMenu
            // 
            pnlLeftMenu.Controls.Add(pnlMenuButtons);
            pnlLeftMenu.Controls.Add(pnlUserDetails);
            pnlLeftMenu.Dock = DockStyle.Left;
            pnlLeftMenu.Location = new Point(0, 0);
            pnlLeftMenu.Name = "pnlLeftMenu";
            pnlLeftMenu.Size = new Size(350, 1329);
            pnlLeftMenu.TabIndex = 0;
            // 
            // pnlMenuButtons
            // 
            pnlMenuButtons.BackColor = Color.FromArgb(0, 0, 77);
            pnlMenuButtons.Controls.Add(pnlNav);
            pnlMenuButtons.Controls.Add(btnSettings);
            pnlMenuButtons.Controls.Add(btnHistory);
            pnlMenuButtons.Controls.Add(btnImportExport);
            pnlMenuButtons.Controls.Add(btnSearch);
            pnlMenuButtons.Controls.Add(btnCustomerContact);
            pnlMenuButtons.Controls.Add(btnAdministration);
            pnlMenuButtons.Controls.Add(BtnDashboard);
            pnlMenuButtons.Dock = DockStyle.Fill;
            pnlMenuButtons.Location = new Point(0, 300);
            pnlMenuButtons.Name = "pnlMenuButtons";
            pnlMenuButtons.Size = new Size(350, 1029);
            pnlMenuButtons.TabIndex = 1;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.FromArgb(167, 177, 255);
            pnlNav.Location = new Point(0, 193);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(3, 100);
            pnlNav.TabIndex = 7;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Bottom;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold);
            btnSettings.ForeColor = Color.FromArgb(167, 177, 255);
            btnSettings.Image = Properties.Resources.settings;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(0, 959);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(350, 70);
            btnSettings.TabIndex = 6;
            btnSettings.Text = "Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnHistory
            // 
            btnHistory.Dock = DockStyle.Top;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold);
            btnHistory.ForeColor = Color.FromArgb(167, 177, 255);
            btnHistory.Image = Properties.Resources.dashboard;
            btnHistory.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistory.Location = new Point(0, 350);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(350, 70);
            btnHistory.TabIndex = 5;
            btnHistory.Text = "History";
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
            btnImportExport.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold);
            btnImportExport.ForeColor = Color.FromArgb(167, 177, 255);
            btnImportExport.Image = Properties.Resources.import;
            btnImportExport.ImageAlign = ContentAlignment.MiddleLeft;
            btnImportExport.Location = new Point(0, 280);
            btnImportExport.Name = "btnImportExport";
            btnImportExport.Size = new Size(350, 70);
            btnImportExport.TabIndex = 4;
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
            btnSearch.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold);
            btnSearch.ForeColor = Color.FromArgb(167, 177, 255);
            btnSearch.Image = Properties.Resources.search;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(0, 210);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(350, 70);
            btnSearch.TabIndex = 3;
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
            btnCustomerContact.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold);
            btnCustomerContact.ForeColor = Color.FromArgb(167, 177, 255);
            btnCustomerContact.Image = Properties.Resources.address_book;
            btnCustomerContact.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomerContact.Location = new Point(0, 140);
            btnCustomerContact.Name = "btnCustomerContact";
            btnCustomerContact.Size = new Size(350, 70);
            btnCustomerContact.TabIndex = 2;
            btnCustomerContact.Text = "CustomerContact";
            btnCustomerContact.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomerContact.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomerContact.UseVisualStyleBackColor = true;
            btnCustomerContact.Click += btnCustomerContact_Click;
            // 
            // btnAdministration
            // 
            btnAdministration.Dock = DockStyle.Top;
            btnAdministration.FlatAppearance.BorderSize = 0;
            btnAdministration.FlatStyle = FlatStyle.Flat;
            btnAdministration.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold);
            btnAdministration.ForeColor = Color.FromArgb(167, 177, 255);
            btnAdministration.Image = Properties.Resources.user_menu;
            btnAdministration.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdministration.Location = new Point(0, 70);
            btnAdministration.Name = "btnAdministration";
            btnAdministration.Size = new Size(350, 70);
            btnAdministration.TabIndex = 1;
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
            BtnDashboard.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold);
            BtnDashboard.ForeColor = Color.FromArgb(167, 177, 255);
            BtnDashboard.Image = Properties.Resources.dashboard;
            BtnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            BtnDashboard.Location = new Point(0, 0);
            BtnDashboard.Name = "BtnDashboard";
            BtnDashboard.Size = new Size(350, 70);
            BtnDashboard.TabIndex = 0;
            BtnDashboard.Text = "Dashboard";
            BtnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            BtnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnDashboard.UseVisualStyleBackColor = true;
            BtnDashboard.Click += BtnDashboard_Click;
            // 
            // pnlUserDetails
            // 
            pnlUserDetails.BackColor = Color.FromArgb(0, 0, 77);
            pnlUserDetails.Controls.Add(lblUserName);
            pnlUserDetails.Controls.Add(lblUserIcon);
            pnlUserDetails.Dock = DockStyle.Top;
            pnlUserDetails.Location = new Point(0, 0);
            pnlUserDetails.Name = "pnlUserDetails";
            pnlUserDetails.Size = new Size(350, 300);
            pnlUserDetails.TabIndex = 0;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUserName.ForeColor = Color.FromArgb(167, 177, 255);
            lblUserName.Location = new Point(90, 165);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(139, 32);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "User Name";
            // 
            // lblUserIcon
            // 
            lblUserIcon.Image = Properties.Resources.test_account;
            lblUserIcon.Location = new Point(110, 50);
            lblUserIcon.Name = "lblUserIcon";
            lblUserIcon.Size = new Size(100, 100);
            lblUserIcon.SizeMode = PictureBoxSizeMode.Zoom;
            lblUserIcon.TabIndex = 0;
            lblUserIcon.TabStop = false;
            // 
            // MainSizeable
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 52, 57);
            ClientSize = new Size(1724, 1329);
            Controls.Add(pnlMain);
            MinimumSize = new Size(1750, 1400);
            Name = "MainSizeable";
            Text = "Customer Contact Tool";
            WindowState = FormWindowState.Maximized;
            pnlMain.ResumeLayout(false);
            pnlMainPanel.ResumeLayout(false);
            pnlMainPanelTop.ResumeLayout(false);
            pnlMainPanelTop.PerformLayout();
            pnlLeftMenu.ResumeLayout(false);
            pnlMenuButtons.ResumeLayout(false);
            pnlUserDetails.ResumeLayout(false);
            pnlUserDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lblUserIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Panel pnlMainPanel;
        private Panel pnlLeftMenu;
        private Panel pnlMenuButtons;
        private Panel pnlUserDetails;
        private Panel pnlFormLoader;
        private Panel pnlMainPanelTop;
        private Button BtnDashboard;
        private Button btnHistory;
        private Button btnImportExport;
        private Button btnSearch;
        private Button btnCustomerContact;
        private Button btnAdministration;
        private Button btnSettings;
        private PictureBox lblUserIcon;
        private Label lblUserName;
        private Label lblTitle;
        private Panel pnlNav;
    }
}