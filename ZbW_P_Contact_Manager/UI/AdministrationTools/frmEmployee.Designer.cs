namespace ZbW_P_Contact_Manager.UI
{
    partial class frmEmployee
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
            txtFirstName.Location = new Point(134, 4);
            txtFirstName.Margin = new Padding(4, 3, 4, 3);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First Name";
            txtFirstName.Size = new Size(116, 21);
            txtFirstName.TabIndex = 22;
            txtFirstName.Tag = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(74, 79, 99);
            txtLastName.Font = new Font("Microsoft Sans Serif", 9F);
            txtLastName.ForeColor = SystemColors.ScrollBar;
            txtLastName.Location = new Point(254, 4);
            txtLastName.Margin = new Padding(4, 3, 4, 3);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last Name";
            txtLastName.Size = new Size(116, 21);
            txtLastName.TabIndex = 23;
            txtLastName.Tag = "Last Name";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(74, 79, 99);
            txtTitle.Font = new Font("Microsoft Sans Serif", 9F);
            txtTitle.ForeColor = SystemColors.ScrollBar;
            txtTitle.Location = new Point(78, 4);
            txtTitle.Margin = new Padding(4, 3, 4, 3);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Title";
            txtTitle.Size = new Size(53, 21);
            txtTitle.TabIndex = 21;
            txtTitle.Tag = "";
            // 
            // txtSocialSecurityNumber
            // 
            txtSocialSecurityNumber.BackColor = Color.FromArgb(74, 79, 99);
            txtSocialSecurityNumber.Font = new Font("Microsoft Sans Serif", 9F);
            txtSocialSecurityNumber.ForeColor = SystemColors.ScrollBar;
            txtSocialSecurityNumber.Location = new Point(2, 57);
            txtSocialSecurityNumber.Margin = new Padding(4, 3, 4, 3);
            txtSocialSecurityNumber.Name = "txtSocialSecurityNumber";
            txtSocialSecurityNumber.PlaceholderText = "Social Security Number";
            txtSocialSecurityNumber.Size = new Size(159, 21);
            txtSocialSecurityNumber.TabIndex = 30;
            txtSocialSecurityNumber.Tag = "Social Security Number";
            txtSocialSecurityNumber.TextChanged += new EventHandler(this.txtSocialSecurityNumber_TextChanged);
            txtSocialSecurityNumber.KeyPress += new KeyPressEventHandler(this.txtSocialSecurityNumber_KeyPress);
            // 
            // txtPhoneNumberPrivate
            // 
            txtPhoneNumberPrivate.BackColor = Color.FromArgb(74, 79, 99);
            txtPhoneNumberPrivate.Font = new Font("Microsoft Sans Serif", 9F);
            txtPhoneNumberPrivate.ForeColor = SystemColors.ScrollBar;
            txtPhoneNumberPrivate.Location = new Point(2, 138);
            txtPhoneNumberPrivate.Margin = new Padding(4, 3, 4, 3);
            txtPhoneNumberPrivate.Name = "txtPhoneNumberPrivate";
            txtPhoneNumberPrivate.PlaceholderText = "Phone Number Private";
            txtPhoneNumberPrivate.Size = new Size(147, 21);
            txtPhoneNumberPrivate.TabIndex = 31;
            txtPhoneNumberPrivate.Tag = "Phone Number Private";
            txtPhoneNumberPrivate.KeyPress += new KeyPressEventHandler(this.PhoneNumberTextBox_KeyPress);
            txtPhoneNumberPrivate.TextChanged += new EventHandler(this.PhoneNumberTextBox_TextChanged);
            // 
            // txtPhoneNumberMobile
            // 
            txtPhoneNumberMobile.BackColor = Color.FromArgb(74, 79, 99);
            txtPhoneNumberMobile.Font = new Font("Microsoft Sans Serif", 9F);
            txtPhoneNumberMobile.ForeColor = SystemColors.ScrollBar;
            txtPhoneNumberMobile.Location = new Point(2, 165);
            txtPhoneNumberMobile.Margin = new Padding(4, 3, 4, 3);
            txtPhoneNumberMobile.Name = "txtPhoneNumberMobile";
            txtPhoneNumberMobile.PlaceholderText = "Phone Number Mobile";
            txtPhoneNumberMobile.Size = new Size(147, 21);
            txtPhoneNumberMobile.TabIndex = 32;
            txtPhoneNumberMobile.Tag = "Phone Number Mobile";
            txtPhoneNumberMobile.KeyPress += new KeyPressEventHandler(this.PhoneNumberTextBox_KeyPress);
            txtPhoneNumberMobile.TextChanged += new EventHandler(this.PhoneNumberTextBox_TextChanged);
            // 
            // txtPhoneNumberBusiness
            // 
            txtPhoneNumberBusiness.BackColor = Color.FromArgb(74, 79, 99);
            txtPhoneNumberBusiness.Font = new Font("Microsoft Sans Serif", 9F);
            txtPhoneNumberBusiness.ForeColor = SystemColors.ScrollBar;
            txtPhoneNumberBusiness.Location = new Point(2, 192);
            txtPhoneNumberBusiness.Margin = new Padding(4, 3, 4, 3);
            txtPhoneNumberBusiness.Name = "txtPhoneNumberBusiness";
            txtPhoneNumberBusiness.PlaceholderText = "Phone Number Business";
            txtPhoneNumberBusiness.Size = new Size(147, 21);
            txtPhoneNumberBusiness.TabIndex = 33;
            txtPhoneNumberBusiness.Tag = "Phone Number Business ";
            txtPhoneNumberBusiness.KeyPress += new KeyPressEventHandler(this.PhoneNumberTextBox_KeyPress);
            txtPhoneNumberBusiness.TextChanged += new EventHandler(this.PhoneNumberTextBox_TextChanged);
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(74, 79, 99);
            txtEmail.Font = new Font("Microsoft Sans Serif", 9F);
            txtEmail.ForeColor = SystemColors.ScrollBar;
            txtEmail.Location = new Point(2, 84);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(219, 21);
            txtEmail.TabIndex = 34;
            txtEmail.Tag = "Email";
            // 
            // txtStreet
            // 
            txtStreet.BackColor = Color.FromArgb(74, 79, 99);
            txtStreet.Font = new Font("Microsoft Sans Serif", 9F);
            txtStreet.ForeColor = SystemColors.ScrollBar;
            txtStreet.Location = new Point(2, 111);
            txtStreet.Margin = new Padding(4, 3, 4, 3);
            txtStreet.Name = "txtStreet";
            txtStreet.PlaceholderText = "Street";
            txtStreet.Size = new Size(116, 21);
            txtStreet.TabIndex = 35;
            txtStreet.Tag = "Street";
            // 
            // txtStreetNumber
            // 
            txtStreetNumber.BackColor = Color.FromArgb(74, 79, 99);
            txtStreetNumber.Font = new Font("Microsoft Sans Serif", 9F);
            txtStreetNumber.ForeColor = SystemColors.ScrollBar;
            txtStreetNumber.Location = new Point(122, 111);
            txtStreetNumber.Margin = new Padding(4, 3, 4, 3);
            txtStreetNumber.Name = "txtStreetNumber";
            txtStreetNumber.PlaceholderText = "Street Number";
            txtStreetNumber.Size = new Size(89, 21);
            txtStreetNumber.TabIndex = 36;
            txtStreetNumber.Tag = "Street Number";
            txtStreetNumber.KeyPress += new KeyPressEventHandler(this.NumberTextBox_KeyPress);
            txtStreetNumber.TextChanged += new EventHandler(this.NumberTextBox_TextChanged);
            // 
            // txtZipCode
            // 
            txtZipCode.BackColor = Color.FromArgb(74, 79, 99);
            txtZipCode.Font = new Font("Microsoft Sans Serif", 9F);
            txtZipCode.ForeColor = SystemColors.ScrollBar;
            txtZipCode.Location = new Point(215, 111);
            txtZipCode.Margin = new Padding(4, 3, 4, 3);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.PlaceholderText = "ZipCode";
            txtZipCode.Size = new Size(57, 21);
            txtZipCode.TabIndex = 37;
            txtZipCode.Tag = "ZipCode";
            txtZipCode.KeyPress += new KeyPressEventHandler(this.NumberTextBox_KeyPress);
            txtZipCode.TextChanged += new EventHandler(this.NumberTextBox_TextChanged);
            // 
            // txtPlace
            // 
            txtPlace.BackColor = Color.FromArgb(74, 79, 99);
            txtPlace.Font = new Font("Microsoft Sans Serif", 9F);
            txtPlace.ForeColor = SystemColors.ScrollBar;
            txtPlace.Location = new Point(276, 111);
            txtPlace.Margin = new Padding(4, 3, 4, 3);
            txtPlace.Name = "txtPlace";
            txtPlace.PlaceholderText = "Place";
            txtPlace.Size = new Size(116, 21);
            txtPlace.TabIndex = 38;
            txtPlace.Tag = "Place";
            // 
            // btnCreateNewEmployee
            // 
            btnCreateNewEmployee.Location = new Point(379, 396);
            btnCreateNewEmployee.Margin = new Padding(4, 3, 4, 3);
            btnCreateNewEmployee.Name = "btnCreateNewEmployee";
            btnCreateNewEmployee.Size = new Size(164, 27);
            btnCreateNewEmployee.TabIndex = 100;
            btnCreateNewEmployee.Text = "Create New Employee";
            btnCreateNewEmployee.UseVisualStyleBackColor = true;
            // 
            // txtSalutation
            // 
            txtSalutation.BackColor = Color.FromArgb(74, 79, 99);
            txtSalutation.FlatStyle = FlatStyle.Flat;
            txtSalutation.Font = new Font("Microsoft Sans Serif", 9F);
            txtSalutation.ForeColor = SystemColors.ScrollBar;
            txtSalutation.FormattingEnabled = true;
            txtSalutation.Items.AddRange(new object[] { "Mr.", "Ms.", "Mrs." });
            txtSalutation.Location = new Point(2, 3);
            txtSalutation.Margin = new Padding(4, 3, 4, 3);
            txtSalutation.Name = "txtSalutation";
            txtSalutation.Size = new Size(74, 23);
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
            txtSex.Location = new Point(374, 3);
            txtSex.Margin = new Padding(4, 3, 4, 3);
            txtSex.Name = "txtSex";
            txtSex.Size = new Size(76, 23);
            txtSex.TabIndex = 24;
            txtSex.Tag = "Sex";
            txtSex.Text = "Sex";
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Font = new Font("Microsoft Sans Serif", 9F);
            txtDateOfBirth.Format = DateTimePickerFormat.Short;
            txtDateOfBirth.Location = new Point(452, 3);
            txtDateOfBirth.Margin = new Padding(4, 3, 4, 3);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.RightToLeft = RightToLeft.Yes;
            txtDateOfBirth.ShowUpDown = true;
            txtDateOfBirth.Size = new Size(93, 21);
            txtDateOfBirth.TabIndex = 25;
            txtDateOfBirth.Tag = "Date Of Birth";
            txtDateOfBirth.Value = new DateTime(2024, 8, 7, 0, 0, 0, 0);
            SetDatePickerStyle(this.txtDateOfBirth);
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(0, 0);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(100, 23);
            textBoxInput.TabIndex = 0;
            // 
            // txtStatus
            // 
            txtStatus.BackColor = Color.FromArgb(74, 79, 99);
            txtStatus.FlatStyle = FlatStyle.Flat;
            txtStatus.Font = new Font("Microsoft Sans Serif", 9F);
            txtStatus.ForeColor = SystemColors.ScrollBar;
            txtStatus.FormattingEnabled = true;
            txtStatus.Items.AddRange(new object[] { "married", "single", "divorced", "widowed" });
            txtStatus.Location = new Point(2, 30);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(121, 23);
            txtStatus.TabIndex = 26;
            txtStatus.Tag = "Civil Status";
            txtStatus.Text = "Civil Status";
            // 
            // txtNationality
            // 
            txtNationality.BackColor = Color.FromArgb(74, 79, 99);
            txtNationality.FlatStyle = FlatStyle.Flat;
            txtNationality.Font = new Font("Microsoft Sans Serif", 9F);
            txtNationality.ForeColor = SystemColors.ScrollBar;
            txtNationality.FormattingEnabled = true;
            txtNationality.Items.AddRange(new object[] { "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "The Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso", "Burundi", "Cabo Verde", "Cambodia", "Cameroon", "Canada", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo, Democratic Republic of the", "Congo, Republic of the", "Costa Rica", "Côte d’Ivoire", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor (Timor-Leste)", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "The Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea, North", "Korea, South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia, Federated States of", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar (Burma)", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "North Macedonia", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "Spain", "Sri Lanka", "Sudan", "Sudan, South", "Suriname", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe" });
            txtNationality.Location = new Point(129, 31);
            txtNationality.Name = "txtNationality";
            txtNationality.Size = new Size(121, 23);
            txtNationality.TabIndex = 27;
            txtNationality.Tag = "Nationality";
            txtNationality.Text = "Nationality";
            // 
            // txtStartDate
            // 
            txtStartDate.Font = new Font("Microsoft Sans Serif", 9F);
            txtStartDate.Format = DateTimePickerFormat.Short;
            txtStartDate.Location = new Point(2, 219);
            txtStartDate.Margin = new Padding(4, 3, 4, 3);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.RightToLeft = RightToLeft.Yes;
            txtStartDate.ShowUpDown = true;
            txtStartDate.Size = new Size(93, 21);
            txtStartDate.TabIndex = 40;
            txtStartDate.Tag = "StartDate";
            txtStartDate.Value = new DateTime(2024, 8, 7, 0, 0, 0, 0);
            SetDatePickerStyle(this.txtStartDate);
            // 
            // txtEndDate
            // 
            txtEndDate.Font = new Font("Microsoft Sans Serif", 9F);
            txtEndDate.Format = DateTimePickerFormat.Short;
            txtEndDate.Location = new Point(103, 219);
            txtEndDate.Margin = new Padding(4, 3, 4, 3);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.RightToLeft = RightToLeft.Yes;
            txtEndDate.ShowUpDown = true;
            txtEndDate.Size = new Size(93, 21);
            txtEndDate.TabIndex = 41;
            txtEndDate.Tag = "EndDate";
            txtEndDate.Value = new DateTime(2024, 8, 7, 0, 0, 0, 0);
            SetDatePickerStyle(this.txtEndDate);
            // 
            // txtEmployment
            // 
            txtEmployment.BackColor = Color.FromArgb(74, 79, 99);
            txtEmployment.FlatStyle = FlatStyle.Flat;
            txtEmployment.Font = new Font("Microsoft Sans Serif", 9F);
            txtEmployment.ForeColor = SystemColors.ScrollBar;
            txtEmployment.FormattingEnabled = true;
            txtEmployment.Items.AddRange(new object[] { "Full-time employment", "Part-time employment", "Apprenticeship", "Traineeship", "Internship", "Casual employment", "Employment on commission", "Contract employment", "Probation", "Seasonal employment", "Leased employment", "Contingent employment" });
            txtEmployment.Location = new Point(203, 219);
            txtEmployment.Name = "txtEmployment";
            txtEmployment.Size = new Size(121, 23);
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
            txtDepartment.Location = new Point(2, 248);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(109, 23);
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
            txtRole.Location = new Point(117, 248);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(109, 23);
            txtRole.TabIndex = 44;
            txtRole.Tag = "Role";
            txtRole.Text = "Role";
            // 
            // txtCadreLevel
            // 
            txtCadreLevel.Location = new Point(232, 248);
            txtCadreLevel.Name = "txtCadreLevel";
            txtCadreLevel.Size = new Size(120, 23);
            txtCadreLevel.TabIndex = 45;
            txtCadreLevel.Tag = "Cadre Level";
            // 
            // frmCreateEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 51, 73);
            ClientSize = new Size(547, 435);
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
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmCreateEmployee";
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