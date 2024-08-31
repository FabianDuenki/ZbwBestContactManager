namespace ZbW_P_Contact_Manager.UI
{
    partial class frmAdministration
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
            pnlAdminFormLoader = new Panel();
            panel4 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            listView1 = new ListView();
            lstStatus = new ColumnHeader();
            lstEmployeeNumber = new ColumnHeader();
            lstTitle = new ColumnHeader();
            lstFirstName = new ColumnHeader();
            lstLastName = new ColumnHeader();
            lstGender = new ColumnHeader();
            lstDateOfBirth = new ColumnHeader();
            lstNationality = new ColumnHeader();
            lstStreet = new ColumnHeader();
            lstStreetNumber = new ColumnHeader();
            lstZipCode = new ColumnHeader();
            lstPlace = new ColumnHeader();
            lstSocialSecurityNumber = new ColumnHeader();
            lstEmail = new ColumnHeader();
            lstPhoneNumberPrivate = new ColumnHeader();
            lstPhoneNumberMobile = new ColumnHeader();
            lstPhoneNumberBusiness = new ColumnHeader();
            lstDepartement = new ColumnHeader();
            lstStartDate = new ColumnHeader();
            lstEndDate = new ColumnHeader();
            lstEmployment = new ColumnHeader();
            lstRole = new ColumnHeader();
            lstCadreLevel = new ColumnHeader();
            lstTraineeYears = new ColumnHeader();
            lstActualTraineeYear = new ColumnHeader();
            lstCompanyName = new ColumnHeader();
            lstCompanyType = new ColumnHeader();
            lstCompanyContact = new ColumnHeader();
            tabPage2 = new TabPage();
            panel3 = new Panel();
            btnEditUser = new Button();
            btnCreateNewCustomer = new Button();
            btnRefresh = new Button();
            btnFilter = new Button();
            btnAddEmployee = new Button();
            lblAdminlTitle = new Label();
            panel2 = new Panel();
            tabPage3 = new TabPage();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            columnHeader17 = new ColumnHeader();
            columnHeader18 = new ColumnHeader();
            columnHeader19 = new ColumnHeader();
            columnHeader20 = new ColumnHeader();
            columnHeader21 = new ColumnHeader();
            columnHeader22 = new ColumnHeader();
            columnHeader23 = new ColumnHeader();
            columnHeader24 = new ColumnHeader();
            columnHeader25 = new ColumnHeader();
            columnHeader26 = new ColumnHeader();
            columnHeader27 = new ColumnHeader();
            columnHeader28 = new ColumnHeader();
            pnlAdminFormLoader.SuspendLayout();
            panel4.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAdminFormLoader
            // 
            pnlAdminFormLoader.Controls.Add(panel4);
            pnlAdminFormLoader.Controls.Add(panel3);
            pnlAdminFormLoader.Dock = DockStyle.Fill;
            pnlAdminFormLoader.Location = new Point(0, 90);
            pnlAdminFormLoader.Margin = new Padding(6);
            pnlAdminFormLoader.Name = "pnlAdminFormLoader";
            pnlAdminFormLoader.Size = new Size(1361, 928);
            pnlAdminFormLoader.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(tabControl1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 90);
            panel4.Name = "panel4";
            panel4.Size = new Size(1361, 838);
            panel4.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1361, 838);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listView1);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1345, 784);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Employee";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(122, 148, 150);
            listView1.Columns.AddRange(new ColumnHeader[] { lstStatus, lstEmployeeNumber, lstTitle, lstFirstName, lstLastName, lstGender, lstDateOfBirth, lstNationality, lstStreet, lstStreetNumber, lstZipCode, lstPlace, lstSocialSecurityNumber, lstEmail, lstPhoneNumberPrivate, lstPhoneNumberMobile, lstPhoneNumberBusiness, lstDepartement, lstStartDate, lstEndDate, lstEmployment, lstRole, lstCadreLevel, lstTraineeYears, lstActualTraineeYear, lstCompanyName, lstCompanyType, lstCompanyContact });
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(3, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(1339, 778);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // lstStatus
            // 
            lstStatus.Text = "Status";
            lstStatus.Width = 150;
            // 
            // lstEmployeeNumber
            // 
            lstEmployeeNumber.Text = "Employee Number";
            lstEmployeeNumber.Width = 150;
            // 
            // lstTitle
            // 
            lstTitle.Text = "Title";
            lstTitle.Width = 150;
            // 
            // lstFirstName
            // 
            lstFirstName.Text = "First Name";
            lstFirstName.Width = 150;
            // 
            // lstLastName
            // 
            lstLastName.Text = "Last Name";
            lstLastName.Width = 150;
            // 
            // lstGender
            // 
            lstGender.Text = "Gender";
            lstGender.Width = 150;
            // 
            // lstDateOfBirth
            // 
            lstDateOfBirth.Text = "Date of Birth";
            lstDateOfBirth.Width = 150;
            // 
            // lstNationality
            // 
            lstNationality.Text = "Nationality";
            lstNationality.Width = 150;
            // 
            // lstStreet
            // 
            lstStreet.Text = "Street";
            lstStreet.Width = 150;
            // 
            // lstStreetNumber
            // 
            lstStreetNumber.Text = "Street Number";
            lstStreetNumber.Width = 150;
            // 
            // lstZipCode
            // 
            lstZipCode.Text = "lstZipCode";
            lstZipCode.Width = 150;
            // 
            // lstPlace
            // 
            lstPlace.Text = "Place";
            lstPlace.Width = 150;
            // 
            // lstSocialSecurityNumber
            // 
            lstSocialSecurityNumber.Text = "SocialSecurityNumber";
            lstSocialSecurityNumber.Width = 150;
            // 
            // lstEmail
            // 
            lstEmail.Text = "Email";
            lstEmail.Width = 150;
            // 
            // lstPhoneNumberPrivate
            // 
            lstPhoneNumberPrivate.Text = "Phone Number Private";
            lstPhoneNumberPrivate.Width = 150;
            // 
            // lstPhoneNumberMobile
            // 
            lstPhoneNumberMobile.Text = "Phone Number Mobile";
            lstPhoneNumberMobile.Width = 150;
            // 
            // lstPhoneNumberBusiness
            // 
            lstPhoneNumberBusiness.Text = "Phone Number Business";
            lstPhoneNumberBusiness.Width = 150;
            // 
            // lstDepartement
            // 
            lstDepartement.Text = "Departement";
            lstDepartement.Width = 150;
            // 
            // lstStartDate
            // 
            lstStartDate.Text = "StartDate";
            lstStartDate.Width = 150;
            // 
            // lstEndDate
            // 
            lstEndDate.Text = "EndDate";
            lstEndDate.Width = 150;
            // 
            // lstEmployment
            // 
            lstEmployment.Text = "Employment";
            lstEmployment.Width = 150;
            // 
            // lstRole
            // 
            lstRole.Text = "Role";
            lstRole.Width = 150;
            // 
            // lstCadreLevel
            // 
            lstCadreLevel.Text = "Cadre Level";
            lstCadreLevel.Width = 150;
            // 
            // lstTraineeYears
            // 
            lstTraineeYears.Text = "TraineeYears";
            lstTraineeYears.Width = 150;
            // 
            // lstActualTraineeYear
            // 
            lstActualTraineeYear.Text = "ActualTraineeYear";
            lstActualTraineeYear.Width = 150;
            // 
            // lstCompanyName
            // 
            lstCompanyName.Text = "CompanyName";
            lstCompanyName.Width = 150;
            // 
            // lstCompanyType
            // 
            lstCompanyType.Text = "Company Type";
            lstCompanyType.Width = 150;
            // 
            // lstCompanyContact
            // 
            lstCompanyContact.Text = "Company Contact";
            lstCompanyContact.Width = 150;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listView2);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1345, 784);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Customer";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(62, 73, 76);
            panel3.Controls.Add(btnEditUser);
            panel3.Controls.Add(btnCreateNewCustomer);
            panel3.Controls.Add(btnRefresh);
            panel3.Controls.Add(btnFilter);
            panel3.Controls.Add(btnAddEmployee);
            panel3.Dock = DockStyle.Top;
            panel3.ForeColor = Color.Transparent;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1361, 90);
            panel3.TabIndex = 1;
            // 
            // btnEditUser
            // 
            btnEditUser.BackColor = Color.FromArgb(81, 102, 105);
            btnEditUser.FlatAppearance.BorderSize = 0;
            btnEditUser.FlatStyle = FlatStyle.Popup;
            btnEditUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditUser.ForeColor = Color.FromArgb(167, 177, 255);
            btnEditUser.Image = Properties.Resources.edit;
            btnEditUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditUser.Location = new Point(710, 17);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(284, 58);
            btnEditUser.TabIndex = 4;
            btnEditUser.Text = "Edit existing User";
            btnEditUser.TextAlign = ContentAlignment.MiddleLeft;
            btnEditUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditUser.UseVisualStyleBackColor = false;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // btnCreateNewCustomer
            // 
            btnCreateNewCustomer.BackColor = Color.FromArgb(81, 102, 105);
            btnCreateNewCustomer.FlatAppearance.BorderSize = 0;
            btnCreateNewCustomer.FlatStyle = FlatStyle.Popup;
            btnCreateNewCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCreateNewCustomer.ForeColor = Color.FromArgb(167, 177, 255);
            btnCreateNewCustomer.Image = Properties.Resources.add;
            btnCreateNewCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateNewCustomer.Location = new Point(365, 17);
            btnCreateNewCustomer.Name = "btnCreateNewCustomer";
            btnCreateNewCustomer.Size = new Size(327, 58);
            btnCreateNewCustomer.TabIndex = 3;
            btnCreateNewCustomer.Text = "Create new Customer";
            btnCreateNewCustomer.TextAlign = ContentAlignment.MiddleLeft;
            btnCreateNewCustomer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCreateNewCustomer.UseVisualStyleBackColor = false;
            btnCreateNewCustomer.Click += btnCreateNewCustomer_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.Transparent;
            btnRefresh.Image = Properties.Resources.refresh;
            btnRefresh.Location = new Point(1289, 16);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(60, 60);
            btnRefresh.TabIndex = 2;
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.Transparent;
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.ForeColor = Color.Transparent;
            btnFilter.Image = Properties.Resources.filter;
            btnFilter.Location = new Point(1194, 16);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(60, 60);
            btnFilter.TabIndex = 1;
            btnFilter.UseVisualStyleBackColor = false;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.FromArgb(81, 102, 105);
            btnAddEmployee.FlatAppearance.BorderSize = 0;
            btnAddEmployee.FlatStyle = FlatStyle.Popup;
            btnAddEmployee.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddEmployee.ForeColor = Color.FromArgb(167, 177, 255);
            btnAddEmployee.Image = Properties.Resources.add;
            btnAddEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddEmployee.Location = new Point(12, 17);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(334, 58);
            btnAddEmployee.TabIndex = 0;
            btnAddEmployee.Text = "Create new Employee";
            btnAddEmployee.TextAlign = ContentAlignment.MiddleLeft;
            btnAddEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // lblAdminlTitle
            // 
            lblAdminlTitle.AutoSize = true;
            lblAdminlTitle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblAdminlTitle.Location = new Point(11, 19);
            lblAdminlTitle.Margin = new Padding(6, 0, 6, 0);
            lblAdminlTitle.Name = "lblAdminlTitle";
            lblAdminlTitle.Size = new Size(366, 44);
            lblAdminlTitle.TabIndex = 1;
            lblAdminlTitle.Text = "Administration Tool";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(41, 49, 51);
            panel2.Controls.Add(lblAdminlTitle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(6);
            panel2.Name = "panel2";
            panel2.Size = new Size(1361, 90);
            panel2.TabIndex = 4;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(8, 46);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1345, 784);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            listView2.BackColor = Color.FromArgb(122, 148, 150);
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader13, columnHeader14, columnHeader15, columnHeader16, columnHeader17, columnHeader18, columnHeader19, columnHeader20, columnHeader21, columnHeader22, columnHeader23, columnHeader24, columnHeader25, columnHeader26, columnHeader27, columnHeader28 });
            listView2.Dock = DockStyle.Fill;
            listView2.Location = new Point(3, 3);
            listView2.Name = "listView2";
            listView2.Size = new Size(1339, 778);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Status";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Employee Number";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Title";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "First Name";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Last Name";
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Gender";
            columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Date of Birth";
            columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Nationality";
            columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Street";
            columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Street Number";
            columnHeader10.Width = 150;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "lstZipCode";
            columnHeader11.Width = 150;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Place";
            columnHeader12.Width = 150;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "SocialSecurityNumber";
            columnHeader13.Width = 150;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Email";
            columnHeader14.Width = 150;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Phone Number Private";
            columnHeader15.Width = 150;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Phone Number Mobile";
            columnHeader16.Width = 150;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "Phone Number Business";
            columnHeader17.Width = 150;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "Departement";
            columnHeader18.Width = 150;
            // 
            // columnHeader19
            // 
            columnHeader19.Text = "StartDate";
            columnHeader19.Width = 150;
            // 
            // columnHeader20
            // 
            columnHeader20.Text = "EndDate";
            columnHeader20.Width = 150;
            // 
            // columnHeader21
            // 
            columnHeader21.Text = "Employment";
            columnHeader21.Width = 150;
            // 
            // columnHeader22
            // 
            columnHeader22.Text = "Role";
            columnHeader22.Width = 150;
            // 
            // columnHeader23
            // 
            columnHeader23.Text = "Cadre Level";
            columnHeader23.Width = 150;
            // 
            // columnHeader24
            // 
            columnHeader24.Text = "TraineeYears";
            columnHeader24.Width = 150;
            // 
            // columnHeader25
            // 
            columnHeader25.Text = "ActualTraineeYear";
            columnHeader25.Width = 150;
            // 
            // columnHeader26
            // 
            columnHeader26.Text = "CompanyName";
            columnHeader26.Width = 150;
            // 
            // columnHeader27
            // 
            columnHeader27.Text = "Company Type";
            columnHeader27.Width = 150;
            // 
            // columnHeader28
            // 
            columnHeader28.Text = "Company Contact";
            columnHeader28.Width = 150;
            // 
            // frmAdministration
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1361, 1018);
            Controls.Add(pnlAdminFormLoader);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "frmAdministration";
            Text = "frmAdministration";
            pnlAdminFormLoader.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlAdminFormLoader;
        private Label lblAdminlTitle;
        private Panel panel2;
        private Panel panel3;
        private Button btnAddEmployee;
        private Panel panel4;
        private ListView listView1;
        private ColumnHeader lstStatus;
        private ColumnHeader lstEmployeeNumber;
        private ColumnHeader lstTitle;
        private ColumnHeader lstFirstName;
        private ColumnHeader lstLastName;
        private ColumnHeader lstGender;
        private ColumnHeader lstDateOfBirth;
        private ColumnHeader lstNationality;
        private ColumnHeader lstStreet;
        private ColumnHeader lstStreetNumber;
        private ColumnHeader lstZipCode;
        private ColumnHeader lstPlace;
        private ColumnHeader lstSocialSecurityNumber;
        private ColumnHeader lstEmail;
        private ColumnHeader lstPhoneNumberPrivate;
        private ColumnHeader lstPhoneNumberMobile;
        private ColumnHeader lstPhoneNumberBusiness;
        private ColumnHeader lstDepartement;
        private ColumnHeader lstStartDate;
        private ColumnHeader lstEndDate;
        private ColumnHeader lstEmployment;
        private ColumnHeader lstRole;
        private ColumnHeader lstCadreLevel;
        private ColumnHeader lstTraineeYears;
        private ColumnHeader lstActualTraineeYear;
        private ColumnHeader lstCompanyName;
        private ColumnHeader lstCompanyType;
        private ColumnHeader lstCompanyContact;
        private Button btnFilter;
        private Button btnRefresh;
        private Button btnCreateNewCustomer;
        private Button btnEditUser;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListView listView2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader20;
        private ColumnHeader columnHeader21;
        private ColumnHeader columnHeader22;
        private ColumnHeader columnHeader23;
        private ColumnHeader columnHeader24;
        private ColumnHeader columnHeader25;
        private ColumnHeader columnHeader26;
        private ColumnHeader columnHeader27;
        private ColumnHeader columnHeader28;
        private TabPage tabPage3;
    }
}