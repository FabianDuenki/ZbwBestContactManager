﻿namespace ZbW_P_Contact_Manager.UI
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
            btnImportExport = new Button();
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
            pnlMain.Margin = new Padding(2, 1, 2, 1);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1014, 497);
            pnlMain.TabIndex = 0;
            // 
            // pnlMainPanel
            // 
            pnlMainPanel.Controls.Add(pnlFormLoader);
            pnlMainPanel.Controls.Add(pnlMainPanelTop);
            pnlMainPanel.Dock = DockStyle.Fill;
            pnlMainPanel.Location = new Point(188, 0);
            pnlMainPanel.Margin = new Padding(2, 1, 2, 1);
            pnlMainPanel.Name = "pnlMainPanel";
            pnlMainPanel.Size = new Size(826, 497);
            pnlMainPanel.TabIndex = 1;
            // 
            // pnlFormLoader
            // 
            pnlFormLoader.Dock = DockStyle.Fill;
            pnlFormLoader.Location = new Point(0, 141);
            pnlFormLoader.Margin = new Padding(2, 1, 2, 1);
            pnlFormLoader.Name = "pnlFormLoader";
            pnlFormLoader.Size = new Size(826, 356);
            pnlFormLoader.TabIndex = 1;
            // 
            // pnlMainPanelTop
            // 
            pnlMainPanelTop.Controls.Add(lblTitle);
            pnlMainPanelTop.Dock = DockStyle.Top;
            pnlMainPanelTop.Location = new Point(0, 0);
            pnlMainPanelTop.Margin = new Padding(2, 1, 2, 1);
            pnlMainPanelTop.Name = "pnlMainPanelTop";
            pnlMainPanelTop.Size = new Size(826, 141);
            pnlMainPanelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(206, 213, 255);
            lblTitle.Location = new Point(12, 13);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(50, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            // 
            // pnlLeftMenu
            // 
            pnlLeftMenu.Controls.Add(pnlMenuButtons);
            pnlLeftMenu.Controls.Add(pnlUserDetails);
            pnlLeftMenu.Dock = DockStyle.Left;
            pnlLeftMenu.Location = new Point(0, 0);
            pnlLeftMenu.Margin = new Padding(2, 1, 2, 1);
            pnlLeftMenu.Name = "pnlLeftMenu";
            pnlLeftMenu.Size = new Size(188, 497);
            pnlLeftMenu.TabIndex = 0;
            // 
            // pnlMenuButtons
            // 
            pnlMenuButtons.BackColor = Color.FromArgb(0, 0, 77);
            pnlMenuButtons.Controls.Add(pnlNav);
            pnlMenuButtons.Controls.Add(btnImportExport);
            pnlMenuButtons.Controls.Add(btnAdministration);
            pnlMenuButtons.Controls.Add(BtnDashboard);
            pnlMenuButtons.Dock = DockStyle.Fill;
            pnlMenuButtons.Location = new Point(0, 141);
            pnlMenuButtons.Margin = new Padding(2, 1, 2, 1);
            pnlMenuButtons.Name = "pnlMenuButtons";
            pnlMenuButtons.Size = new Size(188, 356);
            pnlMenuButtons.TabIndex = 1;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.FromArgb(167, 177, 255);
            pnlNav.Location = new Point(0, 90);
            pnlNav.Margin = new Padding(2, 1, 2, 1);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(2, 47);
            pnlNav.TabIndex = 7;
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
            btnImportExport.Location = new Point(0, 66);
            btnImportExport.Margin = new Padding(2, 1, 2, 1);
            btnImportExport.Name = "btnImportExport";
            btnImportExport.Size = new Size(188, 33);
            btnImportExport.TabIndex = 4;
            btnImportExport.Text = "Import/Export";
            btnImportExport.TextAlign = ContentAlignment.MiddleLeft;
            btnImportExport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnImportExport.UseVisualStyleBackColor = true;
            btnImportExport.Click += btnImportExport_Click;
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
            btnAdministration.Location = new Point(0, 33);
            btnAdministration.Margin = new Padding(2, 1, 2, 1);
            btnAdministration.Name = "btnAdministration";
            btnAdministration.Size = new Size(188, 33);
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
            BtnDashboard.Margin = new Padding(2, 1, 2, 1);
            BtnDashboard.Name = "BtnDashboard";
            BtnDashboard.Size = new Size(188, 33);
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
            pnlUserDetails.Margin = new Padding(2, 1, 2, 1);
            pnlUserDetails.Name = "pnlUserDetails";
            pnlUserDetails.Size = new Size(188, 141);
            pnlUserDetails.TabIndex = 0;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUserName.ForeColor = Color.FromArgb(167, 177, 255);
            lblUserName.Location = new Point(48, 77);
            lblUserName.Margin = new Padding(2, 0, 2, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(69, 15);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "User Name";
            // 
            // lblUserIcon
            // 
            lblUserIcon.Image = Properties.Resources.test_account;
            lblUserIcon.Location = new Point(59, 23);
            lblUserIcon.Margin = new Padding(2, 1, 2, 1);
            lblUserIcon.Name = "lblUserIcon";
            lblUserIcon.Size = new Size(54, 47);
            lblUserIcon.SizeMode = PictureBoxSizeMode.Zoom;
            lblUserIcon.TabIndex = 0;
            lblUserIcon.TabStop = false;
            // 
            // MainSizeable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 52, 57);
            ClientSize = new Size(1014, 497);
            Controls.Add(pnlMain);
            Margin = new Padding(2, 1, 2, 1);
            MinimumSize = new Size(1030, 505);
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
        private Button btnImportExport;
        private Button btnAdministration;
        private PictureBox lblUserIcon;
        private Label lblUserName;
        private Label lblTitle;
        private Panel pnlNav;
    }
}