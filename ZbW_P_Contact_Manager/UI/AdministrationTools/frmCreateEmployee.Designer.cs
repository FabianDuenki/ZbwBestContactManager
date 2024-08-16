namespace ZbW_P_Contact_Manager.UI
{
    partial class frmCreateEmployee
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
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtTitle = new TextBox();
            txtSocialSecurityNumber = new TextBox();
            txtPhoneNumberPrivate = new TextBox();
            txtPhoneNumberMobile = new TextBox();
            txtPhoneNumberBusiness = new TextBox();
            txtEmail = new TextBox();
            txtStreet = new TextBox();
            txtStreetNumber = new TextBox();
            txtZipCode = new TextBox();
            txtPlace = new TextBox();
            btnCreateNewEmployee = new Button();
            txtSalutation = new ComboBox();
            txtSex = new ComboBox();
            txtDateOfBirth = new DateTimePicker();
            textBoxInput = new TextBox();
            txtStatus = new ComboBox();
            txtNationality = new ComboBox();
            txtStartDate = new DateTimePicker();
            txtEndDate = new DateTimePicker();
            txtEmployment = new ComboBox();
            txtDepartment = new ComboBox();
            txtRole = new ComboBox();
            txtCadreLevel = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)txtCadreLevel).BeginInit();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(74, 79, 99);
            txtFirstName.Font = new Font("Microsoft Sans Serif", 9F);
            txtFirstName.ForeColor = SystemColors.ScrollBar;
            txtFirstName.Location = new Point(249, 9);
            txtFirstName.Margin = new Padding(7, 6, 7, 6);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First Name";
            txtFirstName.Size = new Size(212, 35);
            txtFirstName.TabIndex = 22;
            txtFirstName.Tag = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(74, 79, 99);
            txtLastName.Font = new Font("Microsoft Sans Serif", 9F);
            txtLastName.ForeColor = SystemColors.ScrollBar;
            txtLastName.Location = new Point(472, 9);
            txtLastName.Margin = new Padding(7, 6, 7, 6);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last Name";
            txtLastName.Size = new Size(212, 35);
            txtLastName.TabIndex = 23;
            txtLastName.Tag = "Last Name";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(74, 79, 99);
            txtTitle.Font = new Font("Microsoft Sans Serif", 9F);
            txtTitle.ForeColor = SystemColors.ScrollBar;
            txtTitle.Location = new Point(145, 9);
            txtTitle.Margin = new Padding(7, 6, 7, 6);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Title";
            txtTitle.Size = new Size(95, 35);
            txtTitle.TabIndex = 21;
            txtTitle.Tag = "";
            // 
            // txtSocialSecurityNumber
            // 
            txtSocialSecurityNumber.BackColor = Color.FromArgb(74, 79, 99);
            txtSocialSecurityNumber.Font = new Font("Microsoft Sans Serif", 9F);
            txtSocialSecurityNumber.ForeColor = SystemColors.ScrollBar;
            txtSocialSecurityNumber.Location = new Point(4, 105);
            txtSocialSecurityNumber.Margin = new Padding(7, 6, 7, 6);
            txtSocialSecurityNumber.Name = "txtSocialSecurityNumber";
            txtSocialSecurityNumber.PlaceholderText = "Social Security Number";
            txtSocialSecurityNumber.Size = new Size(292, 35);
            txtSocialSecurityNumber.TabIndex = 30;
            txtSocialSecurityNumber.Tag = "Social Security Number";
            txtSocialSecurityNumber.TextChanged += txtSocialSecurityNumber_TextChanged;
            txtSocialSecurityNumber.KeyPress += txtSocialSecurityNumber_KeyPress;
            // 
            // txtPhoneNumberPrivate
            // 
            txtPhoneNumberPrivate.BackColor = Color.FromArgb(74, 79, 99);
            txtPhoneNumberPrivate.Font = new Font("Microsoft Sans Serif", 9F);
            txtPhoneNumberPrivate.ForeColor = SystemColors.ScrollBar;
            txtPhoneNumberPrivate.Location = new Point(4, 294);
            txtPhoneNumberPrivate.Margin = new Padding(7, 6, 7, 6);
            txtPhoneNumberPrivate.Name = "txtPhoneNumberPrivate";
            txtPhoneNumberPrivate.PlaceholderText = "Phone Number Private";
            txtPhoneNumberPrivate.Size = new Size(270, 35);
            txtPhoneNumberPrivate.TabIndex = 31;
            txtPhoneNumberPrivate.Tag = "Phone Number Private";
            txtPhoneNumberPrivate.TextChanged += PhoneNumberTextBox_TextChanged;
            txtPhoneNumberPrivate.KeyPress += PhoneNumberTextBox_KeyPress;
            // 
            // txtPhoneNumberMobile
            // 
            txtPhoneNumberMobile.BackColor = Color.FromArgb(74, 79, 99);
            txtPhoneNumberMobile.Font = new Font("Microsoft Sans Serif", 9F);
            txtPhoneNumberMobile.ForeColor = SystemColors.ScrollBar;
            txtPhoneNumberMobile.Location = new Point(4, 352);
            txtPhoneNumberMobile.Margin = new Padding(7, 6, 7, 6);
            txtPhoneNumberMobile.Name = "txtPhoneNumberMobile";
            txtPhoneNumberMobile.PlaceholderText = "Phone Number Mobile";
            txtPhoneNumberMobile.Size = new Size(270, 35);
            txtPhoneNumberMobile.TabIndex = 32;
            txtPhoneNumberMobile.Tag = "Phone Number Mobile";
            txtPhoneNumberMobile.TextChanged += PhoneNumberTextBox_TextChanged;
            txtPhoneNumberMobile.KeyPress += PhoneNumberTextBox_KeyPress;
            // 
            // txtPhoneNumberBusiness
            // 
            txtPhoneNumberBusiness.BackColor = Color.FromArgb(74, 79, 99);
            txtPhoneNumberBusiness.Font = new Font("Microsoft Sans Serif", 9F);
            txtPhoneNumberBusiness.ForeColor = SystemColors.ScrollBar;
            txtPhoneNumberBusiness.Location = new Point(4, 410);
            txtPhoneNumberBusiness.Margin = new Padding(7, 6, 7, 6);
            txtPhoneNumberBusiness.Name = "txtPhoneNumberBusiness";
            txtPhoneNumberBusiness.PlaceholderText = "Phone Number Business";
            txtPhoneNumberBusiness.Size = new Size(270, 35);
            txtPhoneNumberBusiness.TabIndex = 33;
            txtPhoneNumberBusiness.Tag = "Phone Number Business ";
            txtPhoneNumberBusiness.TextChanged += PhoneNumberTextBox_TextChanged;
            txtPhoneNumberBusiness.KeyPress += PhoneNumberTextBox_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(74, 79, 99);
            txtEmail.Font = new Font("Microsoft Sans Serif", 9F);
            txtEmail.ForeColor = SystemColors.ScrollBar;
            txtEmail.Location = new Point(4, 152);
            txtEmail.Margin = new Padding(7, 6, 7, 6);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(403, 35);
            txtEmail.TabIndex = 34;
            txtEmail.Tag = "Email";
            // 
            // txtStreet
            // 
            txtStreet.BackColor = Color.FromArgb(74, 79, 99);
            txtStreet.Font = new Font("Microsoft Sans Serif", 9F);
            txtStreet.ForeColor = SystemColors.ScrollBar;
            txtStreet.Location = new Point(4, 237);
            txtStreet.Margin = new Padding(7, 6, 7, 6);
            txtStreet.Name = "txtStreet";
            txtStreet.PlaceholderText = "Street";
            txtStreet.Size = new Size(212, 35);
            txtStreet.TabIndex = 35;
            txtStreet.Tag = "Street";
            // 
            // txtStreetNumber
            // 
            txtStreetNumber.BackColor = Color.FromArgb(74, 79, 99);
            txtStreetNumber.Font = new Font("Microsoft Sans Serif", 9F);
            txtStreetNumber.ForeColor = SystemColors.ScrollBar;
            txtStreetNumber.Location = new Point(227, 237);
            txtStreetNumber.Margin = new Padding(7, 6, 7, 6);
            txtStreetNumber.Name = "txtStreetNumber";
            txtStreetNumber.PlaceholderText = "Street Number";
            txtStreetNumber.Size = new Size(162, 35);
            txtStreetNumber.TabIndex = 36;
            txtStreetNumber.Tag = "Street Number";
            txtStreetNumber.TextChanged += NumberTextBox_TextChanged;
            txtStreetNumber.KeyPress += NumberTextBox_KeyPress;
            // 
            // txtZipCode
            // 
            txtZipCode.BackColor = Color.FromArgb(74, 79, 99);
            txtZipCode.Font = new Font("Microsoft Sans Serif", 9F);
            txtZipCode.ForeColor = SystemColors.ScrollBar;
            txtZipCode.Location = new Point(399, 237);
            txtZipCode.Margin = new Padding(7, 6, 7, 6);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.PlaceholderText = "ZipCode";
            txtZipCode.Size = new Size(102, 35);
            txtZipCode.TabIndex = 37;
            txtZipCode.Tag = "ZipCode";
            txtZipCode.TextChanged += NumberTextBox_TextChanged;
            txtZipCode.KeyPress += NumberTextBox_KeyPress;
            // 
            // txtPlace
            // 
            txtPlace.BackColor = Color.FromArgb(74, 79, 99);
            txtPlace.Font = new Font("Microsoft Sans Serif", 9F);
            txtPlace.ForeColor = SystemColors.ScrollBar;
            txtPlace.Location = new Point(513, 237);
            txtPlace.Margin = new Padding(7, 6, 7, 6);
            txtPlace.Name = "txtPlace";
            txtPlace.PlaceholderText = "Place";
            txtPlace.Size = new Size(212, 35);
            txtPlace.TabIndex = 38;
            txtPlace.Tag = "Place";
            // 
            // btnCreateNewEmployee
            // 
            btnCreateNewEmployee.Location = new Point(704, 845);
            btnCreateNewEmployee.Margin = new Padding(7, 6, 7, 6);
            btnCreateNewEmployee.Name = "btnCreateNewEmployee";
            btnCreateNewEmployee.Size = new Size(305, 58);
            btnCreateNewEmployee.TabIndex = 100;
            btnCreateNewEmployee.Text = "Create New Employee";
            btnCreateNewEmployee.UseVisualStyleBackColor = true;
            btnCreateNewEmployee.Click += btnCreateNewEmployee_Click;
            // 
            // txtSalutation
            // 
            txtSalutation.BackColor = Color.FromArgb(74, 79, 99);
            txtSalutation.FlatStyle = FlatStyle.Flat;
            txtSalutation.Font = new Font("Microsoft Sans Serif", 9F);
            txtSalutation.ForeColor = SystemColors.ScrollBar;
            txtSalutation.FormattingEnabled = true;
            txtSalutation.Items.AddRange(new object[] { "Mr.", "Ms.", "Mrs." });
            txtSalutation.Location = new Point(4, 6);
            txtSalutation.Margin = new Padding(7, 6, 7, 6);
            txtSalutation.Name = "txtSalutation";
            txtSalutation.Size = new Size(134, 37);
            txtSalutation.TabIndex = 20;
            txtSalutation.Tag = "Salutation";
            txtSalutation.Text = "Salutation";
            // 
            // txtSex
            // 
            txtSex.BackColor = Color.FromArgb(74, 79, 99);
            txtSex.FlatStyle = FlatStyle.Flat;
            txtSex.Font = new Font("Microsoft Sans Serif", 9F);
            txtSex.ForeColor = SystemColors.ScrollBar;
            txtSex.FormattingEnabled = true;
            txtSex.Items.AddRange(new object[] { "Male", "Female" });
            txtSex.Location = new Point(695, 6);
            txtSex.Margin = new Padding(7, 6, 7, 6);
            txtSex.Name = "txtSex";
            txtSex.Size = new Size(138, 37);
            txtSex.TabIndex = 24;
            txtSex.Tag = "Sex";
            txtSex.Text = "Sex";
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Font = new Font("Microsoft Sans Serif", 9F);
            txtDateOfBirth.Format = DateTimePickerFormat.Short;
            txtDateOfBirth.Location = new Point(839, 6);
            txtDateOfBirth.Margin = new Padding(7, 6, 7, 6);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.RightToLeft = RightToLeft.Yes;
            txtDateOfBirth.ShowUpDown = true;
            txtDateOfBirth.Size = new Size(169, 35);
            txtDateOfBirth.TabIndex = 25;
            txtDateOfBirth.Tag = "Date Of Birth";
            txtDateOfBirth.Value = new DateTime(2024, 8, 7, 0, 0, 0, 0);
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(0, 0);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(100, 39);
            textBoxInput.TabIndex = 0;
            // 
            // txtStatus
            // 
            txtStatus.BackColor = Color.FromArgb(74, 79, 99);
            txtStatus.FlatStyle = FlatStyle.System;
            txtStatus.Font = new Font("Microsoft Sans Serif", 9F);
            txtStatus.ForeColor = SystemColors.ScrollBar;
            txtStatus.FormattingEnabled = true;
            txtStatus.Items.AddRange(new object[] { "active", "inactive" });
            txtStatus.Location = new Point(236, 56);
            txtStatus.Margin = new Padding(6);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(221, 37);
            txtStatus.TabIndex = 26;
            txtStatus.Tag = "Status";
            txtStatus.Text = "Status";
            // 
            // txtNationality
            // 
            txtNationality.BackColor = Color.FromArgb(74, 79, 99);
            txtNationality.FlatStyle = FlatStyle.Flat;
            txtNationality.Font = new Font("Microsoft Sans Serif", 9F);
            txtNationality.ForeColor = SystemColors.ScrollBar;
            txtNationality.FormattingEnabled = true;
            txtNationality.Items.AddRange(new object[] { "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "The Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso", "Burundi", "Cabo Verde", "Cambodia", "Cameroon", "Canada", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo, Democratic Republic of the", "Congo, Republic of the", "Costa Rica", "Côte d’Ivoire", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor (Timor-Leste)", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "The Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea, North", "Korea, South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia, Federated States of", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar (Burma)", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "North Macedonia", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "Spain", "Sri Lanka", "Sudan", "Sudan, South", "Suriname", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe" });
            txtNationality.Location = new Point(4, 56);
            txtNationality.Margin = new Padding(6);
            txtNationality.Name = "txtNationality";
            txtNationality.Size = new Size(221, 37);
            txtNationality.TabIndex = 27;
            txtNationality.Tag = "Nationality";
            txtNationality.Text = "Nationality";
            // 
            // txtStartDate
            // 
            txtStartDate.Font = new Font("Microsoft Sans Serif", 9F);
            txtStartDate.Format = DateTimePickerFormat.Short;
            txtStartDate.Location = new Point(4, 467);
            txtStartDate.Margin = new Padding(7, 6, 7, 6);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.RightToLeft = RightToLeft.Yes;
            txtStartDate.ShowUpDown = true;
            txtStartDate.Size = new Size(169, 35);
            txtStartDate.TabIndex = 40;
            txtStartDate.Tag = "StartDate";
            txtStartDate.Value = new DateTime(2024, 8, 7, 0, 0, 0, 0);
            // 
            // txtEndDate
            // 
            txtEndDate.Font = new Font("Microsoft Sans Serif", 9F);
            txtEndDate.Format = DateTimePickerFormat.Short;
            txtEndDate.Location = new Point(191, 467);
            txtEndDate.Margin = new Padding(7, 6, 7, 6);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.RightToLeft = RightToLeft.Yes;
            txtEndDate.ShowUpDown = true;
            txtEndDate.Size = new Size(169, 35);
            txtEndDate.TabIndex = 41;
            txtEndDate.Tag = "EndDate";
            txtEndDate.Value = new DateTime(2024, 8, 7, 0, 0, 0, 0);
            // 
            // txtEmployment
            // 
            txtEmployment.BackColor = Color.FromArgb(74, 79, 99);
            txtEmployment.FlatStyle = FlatStyle.Flat;
            txtEmployment.Font = new Font("Microsoft Sans Serif", 9F);
            txtEmployment.ForeColor = SystemColors.ScrollBar;
            txtEmployment.FormattingEnabled = true;
            txtEmployment.Items.AddRange(new object[] { "Full-time employment", "Part-time employment", "Apprenticeship", "Traineeship", "Internship", "Casual employment", "Employment on commission", "Contract employment", "Probation", "Seasonal employment", "Leased employment", "Contingent employment" });
            txtEmployment.Location = new Point(377, 467);
            txtEmployment.Margin = new Padding(6);
            txtEmployment.Name = "txtEmployment";
            txtEmployment.Size = new Size(221, 37);
            txtEmployment.TabIndex = 43;
            txtEmployment.Tag = "Employment type";
            txtEmployment.Text = "Employment type";
            // 
            // txtDepartment
            // 
            txtDepartment.BackColor = Color.FromArgb(74, 79, 99);
            txtDepartment.FlatStyle = FlatStyle.Flat;
            txtDepartment.Font = new Font("Microsoft Sans Serif", 9F);
            txtDepartment.ForeColor = SystemColors.ScrollBar;
            txtDepartment.FormattingEnabled = true;
            txtDepartment.Items.AddRange(new object[] { "Human Resources", "IT", "Accounting and Finance", "Marketing", "Research and Development", "Production" });
            txtDepartment.Location = new Point(4, 529);
            txtDepartment.Margin = new Padding(6);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(199, 37);
            txtDepartment.TabIndex = 43;
            txtDepartment.Tag = "Department";
            txtDepartment.Text = "Department";
            // 
            // txtRole
            // 
            txtRole.BackColor = Color.FromArgb(74, 79, 99);
            txtRole.FlatStyle = FlatStyle.Flat;
            txtRole.Font = new Font("Microsoft Sans Serif", 9F);
            txtRole.ForeColor = SystemColors.ScrollBar;
            txtRole.FormattingEnabled = true;
            txtRole.Items.AddRange(new object[] { "Chief Executive Officer", "Chief Operating Officer", "Chief Financial Officer", "Chief Marketing Officer", "Chief Technology Officer", "Executive Assistant", "President", "Vice President", "Product Manager", "Purchasing Manager", "Project Manager", "Finance Manager", "Marketing Manager", "Office Manager", "Regional Manager", "Human Resources Manager", "Quality Control/Safety Manager", "Sales Representative", "Customer Service Representative", "Administrative Assistant", "Business Analyst", "Marketing Specialist", "Human Resource Personnel", "Accountant", "IT Technician", "Production-Team" });
            txtRole.Location = new Point(217, 529);
            txtRole.Margin = new Padding(6);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(199, 37);
            txtRole.TabIndex = 44;
            txtRole.Tag = "Role";
            txtRole.Text = "Role";
            // 
            // txtCadreLevel
            // 
            txtCadreLevel.Location = new Point(431, 529);
            txtCadreLevel.Margin = new Padding(6);
            txtCadreLevel.Name = "txtCadreLevel";
            txtCadreLevel.Size = new Size(223, 39);
            txtCadreLevel.TabIndex = 45;
            txtCadreLevel.Tag = "Cadre Level";
            // 
            // frmCreateEmployee
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 51, 73);
            ClientSize = new Size(1016, 928);
            Controls.Add(txtCadreLevel);
            Controls.Add(txtRole);
            Controls.Add(txtDepartment);
            Controls.Add(txtEmployment);
            Controls.Add(txtEndDate);
            Controls.Add(txtStartDate);
            Controls.Add(txtNationality);
            Controls.Add(txtStatus);
            Controls.Add(txtDateOfBirth);
            Controls.Add(txtSex);
            Controls.Add(txtSalutation);
            Controls.Add(btnCreateNewEmployee);
            Controls.Add(txtPlace);
            Controls.Add(txtZipCode);
            Controls.Add(txtStreetNumber);
            Controls.Add(txtStreet);
            Controls.Add(txtEmail);
            Controls.Add(txtPhoneNumberBusiness);
            Controls.Add(txtPhoneNumberMobile);
            Controls.Add(txtPhoneNumberPrivate);
            Controls.Add(txtTitle);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtSocialSecurityNumber);
            Margin = new Padding(7, 6, 7, 6);
            Name = "frmCreateEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Input Format Example";
            ((System.ComponentModel.ISupportInitialize)txtCadreLevel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSalutationEmployee;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtTitle;
        private TextBox txtSocialSecurityNumber;
        private TextBox txtPhoneNumberPrivate;
        private TextBox txtPhoneNumberMobile;
        private TextBox txtPhoneNumberBusiness;
        private TextBox txtEmail;
        private TextBox txtStreet;
        private TextBox txtStreetNumber;
        private TextBox txtZipCode;
        private TextBox txtPlace;
        private Button btnCreateNewEmployee;
        private ComboBox txtSalutation;
        private ComboBox txtSex;
        private DateTimePicker txtDateOfBirth;
        private System.Windows.Forms.TextBox textBoxInput;
        private ComboBox txtStatus;
        private ComboBox txtNationality;
        private DateTimePicker txtStartDate;
        private DateTimePicker txtEndDate;
        private ComboBox txtEmployment;
        private ComboBox txtDepartment;
        private ComboBox txtRole;
        private NumericUpDown txtCadreLevel;
    }
}