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
            txtNationality = new ComboBox();
            txtStartDate = new DateTimePicker();
            txtEndDate = new DateTimePicker();
            txtEmployment = new ComboBox();
            txtDepartment = new ComboBox();
            txtRole = new ComboBox();
            txtCadreLevel = new NumericUpDown();
            lblStatus = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblSalutation = new Label();
            lblSex = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblTitle = new Label();
            lblSocialSecurityNumber = new Label();
            lblDateOfBirth = new Label();
            lblAddress = new Label();
            lblPhoneNumberMobile = new Label();
            lblNationality = new Label();
            lblPhoneNumberBusiness = new Label();
            lblEmail = new Label();
            lblPhoneNumberPrivate = new Label();
            lblRole = new Label();
            lblCadreLevel = new Label();
            lblDepartement = new Label();
            lblStartEndDate = new Label();
            lblEmploymentType = new Label();
            lblTraineeYears = new Label();
            lblActualTraineeYear = new Label();
            ckbStatus = new CheckBox();
            ckbTrainee = new CheckBox();
            lblTrainee = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            txtTraineeYears = new NumericUpDown();
            txtActualTraineeYears = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)txtCadreLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTraineeYears).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtActualTraineeYears).BeginInit();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(227, 234, 234);
            txtFirstName.Font = new Font("Microsoft Sans Serif", 9F);
            txtFirstName.ForeColor = Color.Black;
            txtFirstName.Location = new Point(178, 84);
            txtFirstName.Margin = new Padding(4, 3, 4, 3);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First Name";
            txtFirstName.Size = new Size(182, 21);
            txtFirstName.TabIndex = 13;
            txtFirstName.Tag = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(227, 234, 234);
            txtLastName.Font = new Font("Microsoft Sans Serif", 9F);
            txtLastName.ForeColor = Color.Black;
            txtLastName.Location = new Point(178, 108);
            txtLastName.Margin = new Padding(4, 3, 4, 3);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last Name";
            txtLastName.Size = new Size(182, 21);
            txtLastName.TabIndex = 14;
            txtLastName.Tag = "Last Name";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(227, 234, 234);
            txtTitle.Font = new Font("Microsoft Sans Serif", 9F);
            txtTitle.ForeColor = Color.Black;
            txtTitle.Location = new Point(178, 61);
            txtTitle.Margin = new Padding(4, 3, 4, 3);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Title";
            txtTitle.Size = new Size(182, 21);
            txtTitle.TabIndex = 12;
            txtTitle.Tag = "";
            // 
            // txtSocialSecurityNumber
            // 
            txtSocialSecurityNumber.BackColor = Color.FromArgb(227, 234, 234);
            txtSocialSecurityNumber.Font = new Font("Microsoft Sans Serif", 9F);
            txtSocialSecurityNumber.ForeColor = Color.Black;
            txtSocialSecurityNumber.Location = new Point(178, 178);
            txtSocialSecurityNumber.Margin = new Padding(4, 3, 4, 3);
            txtSocialSecurityNumber.Name = "txtSocialSecurityNumber";
            txtSocialSecurityNumber.PlaceholderText = "Social Security Number";
            txtSocialSecurityNumber.Size = new Size(182, 21);
            txtSocialSecurityNumber.TabIndex = 17;
            txtSocialSecurityNumber.Tag = "Social Security Number";
            txtSocialSecurityNumber.TextChanged += txtSocialSecurityNumber_TextChanged;
            txtSocialSecurityNumber.KeyPress += txtSocialSecurityNumber_KeyPress;
            // 
            // txtPhoneNumberPrivate
            // 
            txtPhoneNumberPrivate.BackColor = Color.FromArgb(227, 234, 234);
            txtPhoneNumberPrivate.Font = new Font("Microsoft Sans Serif", 9F);
            txtPhoneNumberPrivate.ForeColor = Color.Black;
            txtPhoneNumberPrivate.Location = new Point(178, 305);
            txtPhoneNumberPrivate.Margin = new Padding(4, 3, 4, 3);
            txtPhoneNumberPrivate.Name = "txtPhoneNumberPrivate";
            txtPhoneNumberPrivate.PlaceholderText = "Phone Number Private";
            txtPhoneNumberPrivate.Size = new Size(182, 21);
            txtPhoneNumberPrivate.TabIndex = 32;
            txtPhoneNumberPrivate.Tag = "Phone Number Private";
            txtPhoneNumberPrivate.TextChanged += PhoneNumberTextBox_TextChanged;
            txtPhoneNumberPrivate.KeyPress += PhoneNumberTextBox_KeyPress;
            // 
            // txtPhoneNumberMobile
            // 
            txtPhoneNumberMobile.BackColor = Color.FromArgb(227, 234, 234);
            txtPhoneNumberMobile.Font = new Font("Microsoft Sans Serif", 9F);
            txtPhoneNumberMobile.ForeColor = Color.Black;
            txtPhoneNumberMobile.Location = new Point(178, 281);
            txtPhoneNumberMobile.Margin = new Padding(4, 3, 4, 3);
            txtPhoneNumberMobile.Name = "txtPhoneNumberMobile";
            txtPhoneNumberMobile.PlaceholderText = "Phone Number Mobile";
            txtPhoneNumberMobile.Size = new Size(182, 21);
            txtPhoneNumberMobile.TabIndex = 31;
            txtPhoneNumberMobile.Tag = "Phone Number Mobile";
            txtPhoneNumberMobile.TextChanged += PhoneNumberTextBox_TextChanged;
            txtPhoneNumberMobile.KeyPress += PhoneNumberTextBox_KeyPress;
            // 
            // txtPhoneNumberBusiness
            // 
            txtPhoneNumberBusiness.BackColor = Color.FromArgb(227, 234, 234);
            txtPhoneNumberBusiness.Font = new Font("Microsoft Sans Serif", 9F);
            txtPhoneNumberBusiness.ForeColor = Color.Black;
            txtPhoneNumberBusiness.Location = new Point(178, 328);
            txtPhoneNumberBusiness.Margin = new Padding(4, 3, 4, 3);
            txtPhoneNumberBusiness.Name = "txtPhoneNumberBusiness";
            txtPhoneNumberBusiness.PlaceholderText = "Phone Number Business";
            txtPhoneNumberBusiness.Size = new Size(182, 21);
            txtPhoneNumberBusiness.TabIndex = 33;
            txtPhoneNumberBusiness.Tag = "Phone Number Business ";
            txtPhoneNumberBusiness.TextChanged += PhoneNumberTextBox_TextChanged;
            txtPhoneNumberBusiness.KeyPress += PhoneNumberTextBox_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(227, 234, 234);
            txtEmail.Font = new Font("Microsoft Sans Serif", 9F);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(178, 352);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(182, 21);
            txtEmail.TabIndex = 34;
            txtEmail.Tag = "Email";
            // 
            // txtStreet
            // 
            txtStreet.BackColor = Color.FromArgb(227, 234, 234);
            txtStreet.Font = new Font("Microsoft Sans Serif", 9F);
            txtStreet.ForeColor = Color.Black;
            txtStreet.Location = new Point(178, 230);
            txtStreet.Margin = new Padding(4, 3, 4, 3);
            txtStreet.Name = "txtStreet";
            txtStreet.PlaceholderText = "Street";
            txtStreet.Size = new Size(182, 21);
            txtStreet.TabIndex = 20;
            txtStreet.Tag = "Street";
            // 
            // txtStreetNumber
            // 
            txtStreetNumber.BackColor = Color.FromArgb(227, 234, 234);
            txtStreetNumber.Font = new Font("Microsoft Sans Serif", 9F);
            txtStreetNumber.ForeColor = Color.Black;
            txtStreetNumber.Location = new Point(366, 230);
            txtStreetNumber.Margin = new Padding(4, 3, 4, 3);
            txtStreetNumber.Name = "txtStreetNumber";
            txtStreetNumber.PlaceholderText = "Street Number";
            txtStreetNumber.Size = new Size(83, 21);
            txtStreetNumber.TabIndex = 21;
            txtStreetNumber.Tag = "Street Number";
            txtStreetNumber.TextChanged += NumberTextBox_TextChanged;
            txtStreetNumber.KeyPress += NumberTextBox_KeyPress;
            // 
            // txtZipCode
            // 
            txtZipCode.BackColor = Color.FromArgb(227, 234, 234);
            txtZipCode.Font = new Font("Microsoft Sans Serif", 9F);
            txtZipCode.ForeColor = Color.Black;
            txtZipCode.Location = new Point(366, 253);
            txtZipCode.Margin = new Padding(4, 3, 4, 3);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.PlaceholderText = "ZipCode";
            txtZipCode.Size = new Size(83, 21);
            txtZipCode.TabIndex = 23;
            txtZipCode.Tag = "ZipCode";
            txtZipCode.TextChanged += NumberTextBox_TextChanged;
            txtZipCode.KeyPress += NumberTextBox_KeyPress;
            // 
            // txtPlace
            // 
            txtPlace.BackColor = Color.FromArgb(227, 234, 234);
            txtPlace.Font = new Font("Microsoft Sans Serif", 9F);
            txtPlace.ForeColor = Color.Black;
            txtPlace.Location = new Point(178, 253);
            txtPlace.Margin = new Padding(4, 3, 4, 3);
            txtPlace.Name = "txtPlace";
            txtPlace.PlaceholderText = "Place";
            txtPlace.Size = new Size(182, 21);
            txtPlace.TabIndex = 22;
            txtPlace.Tag = "Place";
            // 
            // btnCreateNewEmployee
            // 
            btnCreateNewEmployee.ForeColor = Color.Black;
            btnCreateNewEmployee.Location = new Point(342, 625);
            btnCreateNewEmployee.Margin = new Padding(4, 3, 4, 3);
            btnCreateNewEmployee.Name = "btnCreateNewEmployee";
            btnCreateNewEmployee.Size = new Size(164, 27);
            btnCreateNewEmployee.TabIndex = 100;
            btnCreateNewEmployee.Text = "Create New Employee";
            btnCreateNewEmployee.UseVisualStyleBackColor = true;
            btnCreateNewEmployee.Click += btnCreateNewEmployee_Click;
            // 
            // txtSalutation
            // 
            txtSalutation.BackColor = Color.FromArgb(227, 234, 234);
            txtSalutation.FlatStyle = FlatStyle.Flat;
            txtSalutation.Font = new Font("Microsoft Sans Serif", 9F);
            txtSalutation.ForeColor = Color.Black;
            txtSalutation.FormattingEnabled = true;
            txtSalutation.Items.AddRange(new object[] { "Mr.", "Ms.", "Mrs." });
            txtSalutation.Location = new Point(178, 38);
            txtSalutation.Margin = new Padding(4, 3, 4, 3);
            txtSalutation.Name = "txtSalutation";
            txtSalutation.Size = new Size(182, 23);
            txtSalutation.TabIndex = 11;
            txtSalutation.Tag = "Salutation";
            txtSalutation.Text = "Salutation";
            // 
            // txtSex
            // 
            txtSex.BackColor = Color.FromArgb(227, 234, 234);
            txtSex.FlatStyle = FlatStyle.Flat;
            txtSex.Font = new Font("Microsoft Sans Serif", 9F);
            txtSex.ForeColor = Color.Black;
            txtSex.FormattingEnabled = true;
            txtSex.Items.AddRange(new object[] { "Male", "Female" });
            txtSex.Location = new Point(178, 131);
            txtSex.Margin = new Padding(4, 3, 4, 3);
            txtSex.Name = "txtSex";
            txtSex.Size = new Size(182, 23);
            txtSex.TabIndex = 15;
            txtSex.Tag = "Sex";
            txtSex.Text = "Sex";
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Font = new Font("Microsoft Sans Serif", 9F);
            txtDateOfBirth.Format = DateTimePickerFormat.Short;
            txtDateOfBirth.Location = new Point(178, 202);
            txtDateOfBirth.Margin = new Padding(4, 3, 4, 3);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.RightToLeft = RightToLeft.Yes;
            txtDateOfBirth.ShowUpDown = true;
            txtDateOfBirth.Size = new Size(88, 21);
            txtDateOfBirth.TabIndex = 18;
            txtDateOfBirth.Tag = "Date Of Birth";
            txtDateOfBirth.Value = new DateTime(2024, 8, 7, 0, 0, 0, 0);
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(0, 0);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(100, 23);
            textBoxInput.TabIndex = 0;
            // 
            // txtNationality
            // 
            txtNationality.BackColor = Color.FromArgb(227, 234, 234);
            txtNationality.FlatStyle = FlatStyle.Flat;
            txtNationality.Font = new Font("Microsoft Sans Serif", 9F);
            txtNationality.ForeColor = Color.Black;
            txtNationality.FormattingEnabled = true;
            txtNationality.Items.AddRange(new object[] { "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "The Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso", "Burundi", "Cabo Verde", "Cambodia", "Cameroon", "Canada", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo, Democratic Republic of the", "Congo, Republic of the", "Costa Rica", "Côte d’Ivoire", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor (Timor-Leste)", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "The Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea, North", "Korea, South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia, Federated States of", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar (Burma)", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "North Macedonia", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "Spain", "Sri Lanka", "Sudan", "Sudan, South", "Suriname", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe" });
            txtNationality.Location = new Point(178, 155);
            txtNationality.Name = "txtNationality";
            txtNationality.Size = new Size(182, 23);
            txtNationality.TabIndex = 16;
            txtNationality.Tag = "Nationality";
            txtNationality.Text = "Nationality";
            // 
            // txtStartDate
            // 
            txtStartDate.Font = new Font("Microsoft Sans Serif", 9F);
            txtStartDate.Format = DateTimePickerFormat.Short;
            txtStartDate.Location = new Point(178, 380);
            txtStartDate.Margin = new Padding(4, 3, 4, 3);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.RightToLeft = RightToLeft.Yes;
            txtStartDate.ShowUpDown = true;
            txtStartDate.Size = new Size(88, 21);
            txtStartDate.TabIndex = 40;
            txtStartDate.Tag = "StartDate";
            txtStartDate.Value = new DateTime(2024, 8, 7, 0, 0, 0, 0);
            // 
            // txtEndDate
            // 
            txtEndDate.Font = new Font("Microsoft Sans Serif", 9F);
            txtEndDate.Format = DateTimePickerFormat.Short;
            txtEndDate.Location = new Point(269, 380);
            txtEndDate.Margin = new Padding(4, 3, 4, 3);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.RightToLeft = RightToLeft.Yes;
            txtEndDate.ShowUpDown = true;
            txtEndDate.Size = new Size(88, 21);
            txtEndDate.TabIndex = 41;
            txtEndDate.Tag = "EndDate";
            txtEndDate.Value = new DateTime(2024, 8, 7, 0, 0, 0, 0);
            // 
            // txtEmployment
            // 
            txtEmployment.BackColor = Color.FromArgb(227, 234, 234);
            txtEmployment.FlatStyle = FlatStyle.Flat;
            txtEmployment.Font = new Font("Microsoft Sans Serif", 9F);
            txtEmployment.ForeColor = Color.Black;
            txtEmployment.FormattingEnabled = true;
            txtEmployment.Items.AddRange(new object[] { "Full-time employment", "Part-time employment", "Apprenticeship", "Traineeship", "Internship", "Casual employment", "Employment on commission", "Contract employment", "Probation", "Seasonal employment", "Leased employment", "Contingent employment" });
            txtEmployment.Location = new Point(178, 403);
            txtEmployment.Name = "txtEmployment";
            txtEmployment.Size = new Size(182, 23);
            txtEmployment.TabIndex = 42;
            txtEmployment.Tag = "Employment type";
            txtEmployment.Text = "Employment type";
            // 
            // txtDepartment
            // 
            txtDepartment.BackColor = Color.FromArgb(227, 234, 234);
            txtDepartment.FlatStyle = FlatStyle.Flat;
            txtDepartment.Font = new Font("Microsoft Sans Serif", 9F);
            txtDepartment.ForeColor = Color.Black;
            txtDepartment.FormattingEnabled = true;
            txtDepartment.Items.AddRange(new object[] { "Human Resources", "IT", "Accounting and Finance", "Marketing", "Research and Development", "Production" });
            txtDepartment.Location = new Point(178, 427);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(182, 23);
            txtDepartment.TabIndex = 43;
            txtDepartment.Tag = "Department";
            txtDepartment.Text = "Department";
            // 
            // txtRole
            // 
            txtRole.BackColor = Color.FromArgb(227, 234, 234);
            txtRole.FlatStyle = FlatStyle.Flat;
            txtRole.Font = new Font("Microsoft Sans Serif", 9F);
            txtRole.ForeColor = Color.Black;
            txtRole.FormattingEnabled = true;
            txtRole.Items.AddRange(new object[] { "Chief Executive Officer", "Chief Operating Officer", "Chief Financial Officer", "Chief Marketing Officer", "Chief Technology Officer", "Executive Assistant", "President", "Vice President", "Product Manager", "Purchasing Manager", "Project Manager", "Finance Manager", "Marketing Manager", "Office Manager", "Regional Manager", "Human Resources Manager", "Quality Control/Safety Manager", "Sales Representative", "Customer Service Representative", "Administrative Assistant", "Business Analyst", "Marketing Specialist", "Human Resource Personnel", "Accountant", "IT Technician", "Production-Team" });
            txtRole.Location = new Point(178, 450);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(182, 23);
            txtRole.TabIndex = 44;
            txtRole.Tag = "Role";
            txtRole.Text = "Role";
            // 
            // txtCadreLevel
            // 
            txtCadreLevel.Location = new Point(178, 473);
            txtCadreLevel.Name = "txtCadreLevel";
            txtCadreLevel.Size = new Size(180, 23);
            txtCadreLevel.TabIndex = 45;
            txtCadreLevel.Tag = "Cadre Level";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(16, 14);
            lblStatus.Margin = new Padding(2, 0, 2, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(47, 15);
            lblStatus.TabIndex = 31;
            lblStatus.Text = "Status*:";
            // 
            // lblSalutation
            // 
            lblSalutation.AutoSize = true;
            lblSalutation.Location = new Point(16, 38);
            lblSalutation.Margin = new Padding(2, 0, 2, 0);
            lblSalutation.Name = "lblSalutation";
            lblSalutation.Size = new Size(68, 15);
            lblSalutation.TabIndex = 101;
            lblSalutation.Text = "Salutation*:";
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Location = new Point(16, 131);
            lblSex.Margin = new Padding(2, 0, 2, 0);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(33, 15);
            lblSex.TabIndex = 102;
            lblSex.Text = "Sex*:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(16, 108);
            lblLastName.Margin = new Padding(2, 0, 2, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(71, 15);
            lblLastName.TabIndex = 103;
            lblLastName.Text = "Last Name*:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(16, 84);
            lblFirstName.Margin = new Padding(2, 0, 2, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(72, 15);
            lblFirstName.TabIndex = 104;
            lblFirstName.Text = "First Name*:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(16, 61);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(32, 15);
            lblTitle.TabIndex = 105;
            lblTitle.Text = "Title:";
            // 
            // lblSocialSecurityNumber
            // 
            lblSocialSecurityNumber.AutoSize = true;
            lblSocialSecurityNumber.Location = new Point(16, 178);
            lblSocialSecurityNumber.Margin = new Padding(2, 0, 2, 0);
            lblSocialSecurityNumber.Name = "lblSocialSecurityNumber";
            lblSocialSecurityNumber.Size = new Size(138, 15);
            lblSocialSecurityNumber.TabIndex = 110;
            lblSocialSecurityNumber.Text = "Social Security Number*:";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new Point(16, 202);
            lblDateOfBirth.Margin = new Padding(2, 0, 2, 0);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(81, 15);
            lblDateOfBirth.TabIndex = 109;
            lblDateOfBirth.Text = "Date of Birth*:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(16, 230);
            lblAddress.Margin = new Padding(2, 0, 2, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(57, 15);
            lblAddress.TabIndex = 108;
            lblAddress.Text = "Address*:";
            // 
            // lblPhoneNumberMobile
            // 
            lblPhoneNumberMobile.AutoSize = true;
            lblPhoneNumberMobile.Location = new Point(16, 281);
            lblPhoneNumberMobile.Margin = new Padding(2, 0, 2, 0);
            lblPhoneNumberMobile.Name = "lblPhoneNumberMobile";
            lblPhoneNumberMobile.Size = new Size(136, 15);
            lblPhoneNumberMobile.TabIndex = 107;
            lblPhoneNumberMobile.Text = "Phone Number Mobile*:";
            // 
            // lblNationality
            // 
            lblNationality.AutoSize = true;
            lblNationality.Location = new Point(16, 155);
            lblNationality.Margin = new Padding(2, 0, 2, 0);
            lblNationality.Name = "lblNationality";
            lblNationality.Size = new Size(73, 15);
            lblNationality.TabIndex = 106;
            lblNationality.Text = "Nationality*:";
            // 
            // lblPhoneNumberBusiness
            // 
            lblPhoneNumberBusiness.AutoSize = true;
            lblPhoneNumberBusiness.Location = new Point(16, 328);
            lblPhoneNumberBusiness.Margin = new Padding(2, 0, 2, 0);
            lblPhoneNumberBusiness.Name = "lblPhoneNumberBusiness";
            lblPhoneNumberBusiness.Size = new Size(139, 15);
            lblPhoneNumberBusiness.TabIndex = 113;
            lblPhoneNumberBusiness.Text = "Phone Number Business:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(16, 352);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(83, 15);
            lblEmail.TabIndex = 112;
            lblEmail.Text = "Mail Address*:";
            // 
            // lblPhoneNumberPrivate
            // 
            lblPhoneNumberPrivate.AutoSize = true;
            lblPhoneNumberPrivate.Location = new Point(16, 305);
            lblPhoneNumberPrivate.Margin = new Padding(2, 0, 2, 0);
            lblPhoneNumberPrivate.Name = "lblPhoneNumberPrivate";
            lblPhoneNumberPrivate.Size = new Size(135, 15);
            lblPhoneNumberPrivate.TabIndex = 111;
            lblPhoneNumberPrivate.Text = "Phone Number Private:*";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(16, 450);
            lblRole.Margin = new Padding(2, 0, 2, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(38, 15);
            lblRole.TabIndex = 118;
            lblRole.Text = "Role*:";
            // 
            // lblCadreLevel
            // 
            lblCadreLevel.AutoSize = true;
            lblCadreLevel.Location = new Point(16, 473);
            lblCadreLevel.Margin = new Padding(2, 0, 2, 0);
            lblCadreLevel.Name = "lblCadreLevel";
            lblCadreLevel.Size = new Size(73, 15);
            lblCadreLevel.TabIndex = 117;
            lblCadreLevel.Text = "CadreLevel*:";
            // 
            // lblDepartement
            // 
            lblDepartement.AutoSize = true;
            lblDepartement.Location = new Point(16, 427);
            lblDepartement.Margin = new Padding(2, 0, 2, 0);
            lblDepartement.Name = "lblDepartement";
            lblDepartement.Size = new Size(84, 15);
            lblDepartement.TabIndex = 116;
            lblDepartement.Text = "Departement*:";
            // 
            // lblStartEndDate
            // 
            lblStartEndDate.AutoSize = true;
            lblStartEndDate.Location = new Point(16, 380);
            lblStartEndDate.Margin = new Padding(2, 0, 2, 0);
            lblStartEndDate.Name = "lblStartEndDate";
            lblStartEndDate.Size = new Size(91, 15);
            lblStartEndDate.TabIndex = 115;
            lblStartEndDate.Text = "Start*/End Date:";
            // 
            // lblEmploymentType
            // 
            lblEmploymentType.AutoSize = true;
            lblEmploymentType.Location = new Point(16, 403);
            lblEmploymentType.Margin = new Padding(2, 0, 2, 0);
            lblEmploymentType.Name = "lblEmploymentType";
            lblEmploymentType.Size = new Size(109, 15);
            lblEmploymentType.TabIndex = 114;
            lblEmploymentType.Text = "Employment type*:";
            // 
            // lblTraineeYears
            // 
            lblTraineeYears.AutoSize = true;
            lblTraineeYears.Location = new Point(16, 530);
            lblTraineeYears.Margin = new Padding(2, 0, 2, 0);
            lblTraineeYears.Name = "lblTraineeYears";
            lblTraineeYears.Size = new Size(77, 15);
            lblTraineeYears.TabIndex = 120;
            lblTraineeYears.Text = "Trainee Years:";
            // 
            // lblActualTraineeYear
            // 
            lblActualTraineeYear.AutoSize = true;
            lblActualTraineeYear.Location = new Point(16, 553);
            lblActualTraineeYear.Margin = new Padding(2, 0, 2, 0);
            lblActualTraineeYear.Name = "lblActualTraineeYear";
            lblActualTraineeYear.Size = new Size(109, 15);
            lblActualTraineeYear.TabIndex = 122;
            lblActualTraineeYear.Text = "Actual Trainee Year:";
            // 
            // ckbStatus
            // 
            ckbStatus.AutoSize = true;
            ckbStatus.Checked = true;
            ckbStatus.CheckState = CheckState.Checked;
            ckbStatus.Location = new Point(178, 14);
            ckbStatus.Margin = new Padding(2, 1, 2, 1);
            ckbStatus.Name = "ckbStatus";
            ckbStatus.Size = new Size(57, 19);
            ckbStatus.TabIndex = 10;
            ckbStatus.Text = "active";
            ckbStatus.UseVisualStyleBackColor = true;
            // 
            // ckbTrainee
            // 
            ckbTrainee.AutoSize = true;
            ckbTrainee.Location = new Point(178, 506);
            ckbTrainee.Margin = new Padding(2, 1, 2, 1);
            ckbTrainee.Name = "ckbTrainee";
            ckbTrainee.Size = new Size(63, 19);
            ckbTrainee.TabIndex = 50;
            ckbTrainee.Text = "Trainee";
            ckbTrainee.UseVisualStyleBackColor = true;
            ckbTrainee.CheckedChanged += ckbTrainee_CheckedChanged;
            // 
            // lblTrainee
            // 
            lblTrainee.AutoSize = true;
            lblTrainee.Location = new Point(16, 506);
            lblTrainee.Margin = new Padding(2, 0, 2, 0);
            lblTrainee.Name = "lblTrainee";
            lblTrainee.Size = new Size(47, 15);
            lblTrainee.TabIndex = 124;
            lblTrainee.Text = "Trainee:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(122, 148, 150);
            panel1.Location = new Point(15, 222);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 2);
            panel1.TabIndex = 165;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(122, 148, 150);
            panel2.Location = new Point(15, 274);
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(485, 2);
            panel2.TabIndex = 166;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(122, 148, 150);
            panel3.Location = new Point(16, 372);
            panel3.Margin = new Padding(2, 1, 2, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(485, 2);
            panel3.TabIndex = 167;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(122, 148, 150);
            panel4.Location = new Point(16, 496);
            panel4.Margin = new Padding(2, 1, 2, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(485, 2);
            panel4.TabIndex = 168;
            // 
            // txtTraineeYears
            // 
            txtTraineeYears.Location = new Point(178, 525);
            txtTraineeYears.Name = "txtTraineeYears";
            txtTraineeYears.Size = new Size(182, 23);
            txtTraineeYears.TabIndex = 169;
            // 
            // txtActualTraineeYears
            // 
            txtActualTraineeYears.Location = new Point(178, 552);
            txtActualTraineeYears.Name = "txtActualTraineeYears";
            txtActualTraineeYears.Size = new Size(182, 23);
            txtActualTraineeYears.TabIndex = 170;
            // 
            // frmCreateEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 49, 51);
            ClientSize = new Size(524, 666);
            Controls.Add(txtActualTraineeYears);
            Controls.Add(txtTraineeYears);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(ckbTrainee);
            Controls.Add(lblTrainee);
            Controls.Add(ckbStatus);
            Controls.Add(lblActualTraineeYear);
            Controls.Add(lblTraineeYears);
            Controls.Add(lblRole);
            Controls.Add(lblCadreLevel);
            Controls.Add(lblDepartement);
            Controls.Add(lblStartEndDate);
            Controls.Add(lblEmploymentType);
            Controls.Add(lblPhoneNumberBusiness);
            Controls.Add(lblEmail);
            Controls.Add(lblPhoneNumberPrivate);
            Controls.Add(lblSocialSecurityNumber);
            Controls.Add(lblDateOfBirth);
            Controls.Add(lblAddress);
            Controls.Add(lblPhoneNumberMobile);
            Controls.Add(lblNationality);
            Controls.Add(lblTitle);
            Controls.Add(lblFirstName);
            Controls.Add(lblLastName);
            Controls.Add(lblSex);
            Controls.Add(lblSalutation);
            Controls.Add(lblStatus);
            Controls.Add(txtStreet);
            Controls.Add(txtEndDate);
            Controls.Add(txtSalutation);
            Controls.Add(txtPhoneNumberBusiness);
            Controls.Add(txtTitle);
            Controls.Add(txtPhoneNumberMobile);
            Controls.Add(txtFirstName);
            Controls.Add(txtCadreLevel);
            Controls.Add(txtLastName);
            Controls.Add(txtPhoneNumberPrivate);
            Controls.Add(txtSex);
            Controls.Add(txtRole);
            Controls.Add(txtNationality);
            Controls.Add(txtEmail);
            Controls.Add(txtSocialSecurityNumber);
            Controls.Add(txtZipCode);
            Controls.Add(txtDateOfBirth);
            Controls.Add(txtDepartment);
            Controls.Add(txtPlace);
            Controls.Add(txtStreetNumber);
            Controls.Add(txtEmployment);
            Controls.Add(btnCreateNewEmployee);
            Controls.Add(txtStartDate);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmCreateEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create New Employee";
            ((System.ComponentModel.ISupportInitialize)txtCadreLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTraineeYears).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtActualTraineeYears).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private ComboBox txtNationality;
        private DateTimePicker txtStartDate;
        private DateTimePicker txtEndDate;
        private ComboBox txtEmployment;
        private ComboBox txtDepartment;
        private ComboBox txtRole;
        private NumericUpDown txtCadreLevel;
        private Label lblStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblSalutation;
        private Label lblSex;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblTitle;
        private Label lblSocialSecurityNumber;
        private Label lblDateOfBirth;
        private Label lblAddress;
        private Label lblPhoneNumberMobile;
        private Label lblNationality;
        private Label lblPhoneNumberBusiness;
        private Label lblEmail;
        private Label lblPhoneNumberPrivate;
        private Label lblRole;
        private Label lblCadreLevel;
        private Label lblDepartement;
        private Label lblStartEndDate;
        private Label lblEmploymentType;
        private Label lblTraineeYears;
        private Label lblActualTraineeYear;
        private CheckBox ckbStatus;
        private CheckBox ckbTrainee;
        private Label lblTrainee;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private NumericUpDown txtTraineeYears;
        private NumericUpDown txtActualTraineeYears;
    }
}