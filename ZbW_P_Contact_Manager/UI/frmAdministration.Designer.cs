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
            panel3 = new Panel();
            btnRefresh = new Button();
            btnFilter = new Button();
            btnAddEmployee = new Button();
            lblAdminlTitle = new Label();
            panel2 = new Panel();
            pnlAdminFormLoader.SuspendLayout();
            panel4.SuspendLayout();
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
            panel4.Controls.Add(listView1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 107);
            panel4.Name = "panel4";
            panel4.Size = new Size(1361, 821);
            panel4.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(122, 148, 150);
            listView1.Columns.AddRange(new ColumnHeader[] { lstStatus, lstEmployeeNumber, lstTitle, lstFirstName, lstLastName, lstGender, lstDateOfBirth, lstNationality, lstStreet, lstStreetNumber, lstZipCode, lstPlace, lstSocialSecurityNumber, lstEmail, lstPhoneNumberPrivate, lstPhoneNumberMobile, lstPhoneNumberBusiness, lstDepartement, lstStartDate, lstEndDate, lstEmployment, lstRole, lstCadreLevel, lstTraineeYears, lstActualTraineeYear, lstCompanyName, lstCompanyType, lstCompanyContact });
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(1361, 821);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // lstStatus
            // 
            lstStatus.Text = "Status";
            lstStatus.Width = 100;
            // 
            // lstEmployeeNumber
            // 
            lstEmployeeNumber.Text = "Employee Number";
            lstEmployeeNumber.Width = 100;
            // 
            // lstTitle
            // 
            lstTitle.Text = "Title";
            lstTitle.Width = 100;
            // 
            // lstFirstName
            // 
            lstFirstName.Text = "First Name";
            lstFirstName.Width = 100;
            // 
            // lstLastName
            // 
            lstLastName.Text = "Last Name";
            lstLastName.Width = 100;
            // 
            // lstGender
            // 
            lstGender.Text = "Gender";
            lstGender.Width = 100;
            // 
            // lstDateOfBirth
            // 
            lstDateOfBirth.Text = "Date of Birth";
            lstDateOfBirth.Width = 100;
            // 
            // lstNationality
            // 
            lstNationality.Text = "Nationality";
            lstNationality.Width = 100;
            // 
            // lstStreet
            // 
            lstStreet.Text = "Street";
            lstStreet.Width = 100;
            // 
            // lstStreetNumber
            // 
            lstStreetNumber.Text = "Street Number";
            lstStreetNumber.Width = 100;
            // 
            // lstZipCode
            // 
            lstZipCode.Text = "lstZipCode";
            lstZipCode.Width = 100;
            // 
            // lstPlace
            // 
            lstPlace.Text = "Place";
            lstPlace.Width = 100;
            // 
            // lstSocialSecurityNumber
            // 
            lstSocialSecurityNumber.Text = "SocialSecurityNumber";
            lstSocialSecurityNumber.Width = 100;
            // 
            // lstEmail
            // 
            lstEmail.Text = "Email";
            lstEmail.Width = 100;
            // 
            // lstPhoneNumberPrivate
            // 
            lstPhoneNumberPrivate.Text = "Phone Number Private";
            lstPhoneNumberPrivate.Width = 100;
            // 
            // lstPhoneNumberMobile
            // 
            lstPhoneNumberMobile.Text = "Phone Number Mobile";
            lstPhoneNumberMobile.Width = 100;
            // 
            // lstPhoneNumberBusiness
            // 
            lstPhoneNumberBusiness.Text = "Phone Number Business";
            lstPhoneNumberBusiness.Width = 100;
            // 
            // lstDepartement
            // 
            lstDepartement.Text = "Departement";
            lstDepartement.Width = 100;
            // 
            // lstStartDate
            // 
            lstStartDate.Text = "StartDate";
            lstStartDate.Width = 100;
            // 
            // lstEndDate
            // 
            lstEndDate.Text = "EndDate";
            lstEndDate.Width = 100;
            // 
            // lstEmployment
            // 
            lstEmployment.Text = "Employment";
            lstEmployment.Width = 100;
            // 
            // lstRole
            // 
            lstRole.Text = "Role";
            lstRole.Width = 100;
            // 
            // lstCadreLevel
            // 
            lstCadreLevel.Text = "Cadre Level";
            lstCadreLevel.Width = 100;
            // 
            // lstTraineeYears
            // 
            lstTraineeYears.Text = "TraineeYears";
            lstTraineeYears.Width = 100;
            // 
            // lstActualTraineeYear
            // 
            lstActualTraineeYear.Text = "ActualTraineeYear";
            lstActualTraineeYear.Width = 100;
            // 
            // lstCompanyName
            // 
            lstCompanyName.Text = "CompanyName";
            lstCompanyName.Width = 100;
            // 
            // lstCompanyType
            // 
            lstCompanyType.Text = "Company Type";
            lstCompanyType.Width = 100;
            // 
            // lstCompanyContact
            // 
            lstCompanyContact.Text = "Company Contact";
            lstCompanyContact.Width = 100;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(41, 49, 51);
            panel3.Controls.Add(btnRefresh);
            panel3.Controls.Add(btnFilter);
            panel3.Controls.Add(btnAddEmployee);
            panel3.Dock = DockStyle.Top;
            panel3.ForeColor = Color.Transparent;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1361, 107);
            panel3.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.Transparent;
            btnRefresh.Image = Properties.Resources.refresh;
            btnRefresh.Location = new Point(778, 23);
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
            btnFilter.Location = new Point(650, 23);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(60, 60);
            btnFilter.TabIndex = 1;
            btnFilter.UseVisualStyleBackColor = false;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.Transparent;
            btnAddEmployee.FlatAppearance.BorderSize = 0;
            btnAddEmployee.FlatStyle = FlatStyle.Flat;
            btnAddEmployee.ForeColor = Color.Transparent;
            btnAddEmployee.Image = Properties.Resources.add;
            btnAddEmployee.Location = new Point(21, 25);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(60, 60);
            btnAddEmployee.TabIndex = 0;
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
    }
}