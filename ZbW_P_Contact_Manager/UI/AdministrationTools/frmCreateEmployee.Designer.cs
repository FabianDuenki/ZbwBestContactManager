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
            numTraineeYears = new NumericUpDown();
            lblActualTraineeYear = new Label();
            numActualTraineeYear = new NumericUpDown();
            ckbStatus = new CheckBox();
            ckbTrainee = new CheckBox();
            lblTrainee = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)txtCadreLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTraineeYears).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numActualTraineeYear).BeginInit();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(227, 234, 234);
            txtFirstName.Font = new Font("Microsoft Sans Serif", 9F);
            txtFirstName.ForeColor = Color.Black;
            txtFirstName.Location = new Point(330, 180);
            txtFirstName.Margin = new Padding(7, 6, 7, 6);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First Name";
            txtFirstName.Size = new Size(334, 35);
            txtFirstName.TabIndex = 13;
            txtFirstName.Tag = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(227, 234, 234);
            txtLastName.Font = new Font("Microsoft Sans Serif", 9F);
            txtLastName.ForeColor = Color.Black;
            txtLastName.Location = new Point(330, 230);
            txtLastName.Margin = new Padding(7, 6, 7, 6);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last Name";
            txtLastName.Size = new Size(334, 35);
            txtLastName.TabIndex = 14;
            txtLastName.Tag = "Last Name";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(227, 234, 234);
            txtTitle.Font = new Font("Microsoft Sans Serif", 9F);
            txtTitle.ForeColor = Color.Black;
            txtTitle.Location = new Point(330, 130);
            txtTitle.Margin = new Padding(7, 6, 7, 6);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Title";
            txtTitle.Size = new Size(334, 35);
            txtTitle.TabIndex = 12;
            txtTitle.Tag = "";
            // 
            // txtSocialSecurityNumber
            // 
            txtSocialSecurityNumber.BackColor = Color.FromArgb(227, 234, 234);
            txtSocialSecurityNumber.Font = new Font("Microsoft Sans Serif", 9F);
            txtSocialSecurityNumber.ForeColor = Color.Black;
            txtSocialSecurityNumber.Location = new Point(330, 380);
            txtSocialSecurityNumber.Margin = new Padding(7, 6, 7, 6);
            txtSocialSecurityNumber.Name = "txtSocialSecurityNumber";
            txtSocialSecurityNumber.PlaceholderText = "Social Security Number";
            txtSocialSecurityNumber.Size = new Size(334, 35);
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
            txtPhoneNumberPrivate.Location = new Point(330, 650);
            txtPhoneNumberPrivate.Margin = new Padding(7, 6, 7, 6);
            txtPhoneNumberPrivate.Name = "txtPhoneNumberPrivate";
            txtPhoneNumberPrivate.PlaceholderText = "Phone Number Private";
            txtPhoneNumberPrivate.Size = new Size(334, 35);
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
            txtPhoneNumberMobile.Location = new Point(330, 600);
            txtPhoneNumberMobile.Margin = new Padding(7, 6, 7, 6);
            txtPhoneNumberMobile.Name = "txtPhoneNumberMobile";
            txtPhoneNumberMobile.PlaceholderText = "Phone Number Mobile";
            txtPhoneNumberMobile.Size = new Size(334, 35);
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
            txtPhoneNumberBusiness.Location = new Point(330, 700);
            txtPhoneNumberBusiness.Margin = new Padding(7, 6, 7, 6);
            txtPhoneNumberBusiness.Name = "txtPhoneNumberBusiness";
            txtPhoneNumberBusiness.PlaceholderText = "Phone Number Business";
            txtPhoneNumberBusiness.Size = new Size(334, 35);
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
            txtEmail.Location = new Point(330, 750);
            txtEmail.Margin = new Padding(7, 6, 7, 6);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(334, 35);
            txtEmail.TabIndex = 34;
            txtEmail.Tag = "Email";
            // 
            // txtStreet
            // 
            txtStreet.BackColor = Color.FromArgb(227, 234, 234);
            txtStreet.Font = new Font("Microsoft Sans Serif", 9F);
            txtStreet.ForeColor = Color.Black;
            txtStreet.Location = new Point(330, 490);
            txtStreet.Margin = new Padding(7, 6, 7, 6);
            txtStreet.Name = "txtStreet";
            txtStreet.PlaceholderText = "Street";
            txtStreet.Size = new Size(334, 35);
            txtStreet.TabIndex = 20;
            txtStreet.Tag = "Street";
            // 
            // txtStreetNumber
            // 
            txtStreetNumber.BackColor = Color.FromArgb(227, 234, 234);
            txtStreetNumber.Font = new Font("Microsoft Sans Serif", 9F);
            txtStreetNumber.ForeColor = Color.Black;
            txtStreetNumber.Location = new Point(680, 490);
            txtStreetNumber.Margin = new Padding(7, 6, 7, 6);
            txtStreetNumber.Name = "txtStreetNumber";
            txtStreetNumber.PlaceholderText = "Street Number";
            txtStreetNumber.Size = new Size(150, 35);
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
            txtZipCode.Location = new Point(680, 540);
            txtZipCode.Margin = new Padding(7, 6, 7, 6);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.PlaceholderText = "ZipCode";
            txtZipCode.Size = new Size(150, 35);
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
            txtPlace.Location = new Point(330, 540);
            txtPlace.Margin = new Padding(7, 6, 7, 6);
            txtPlace.Name = "txtPlace";
            txtPlace.PlaceholderText = "Place";
            txtPlace.Size = new Size(334, 35);
            txtPlace.TabIndex = 22;
            txtPlace.Tag = "Place";
            // 
            // btnCreateNewEmployee
            // 
            btnCreateNewEmployee.ForeColor = Color.Black;
            btnCreateNewEmployee.Location = new Point(636, 1333);
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
            txtSalutation.BackColor = Color.FromArgb(227, 234, 234);
            txtSalutation.FlatStyle = FlatStyle.Flat;
            txtSalutation.Font = new Font("Microsoft Sans Serif", 9F);
            txtSalutation.ForeColor = Color.Black;
            txtSalutation.FormattingEnabled = true;
            txtSalutation.Items.AddRange(new object[] { "Mr.", "Ms.", "Mrs." });
            txtSalutation.Location = new Point(330, 80);
            txtSalutation.Margin = new Padding(7, 6, 7, 6);
            txtSalutation.Name = "txtSalutation";
            txtSalutation.Size = new Size(334, 37);
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
            txtSex.Location = new Point(330, 280);
            txtSex.Margin = new Padding(7, 6, 7, 6);
            txtSex.Name = "txtSex";
            txtSex.Size = new Size(334, 37);
            txtSex.TabIndex = 15;
            txtSex.Tag = "Sex";
            txtSex.Text = "Sex";
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Font = new Font("Microsoft Sans Serif", 9F);
            txtDateOfBirth.Format = DateTimePickerFormat.Short;
            txtDateOfBirth.Location = new Point(330, 430);
            txtDateOfBirth.Margin = new Padding(7, 6, 7, 6);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.RightToLeft = RightToLeft.Yes;
            txtDateOfBirth.ShowUpDown = true;
            txtDateOfBirth.Size = new Size(160, 35);
            txtDateOfBirth.TabIndex = 18;
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
            // txtNationality
            // 
            txtNationality.BackColor = Color.FromArgb(227, 234, 234);
            txtNationality.FlatStyle = FlatStyle.Flat;
            txtNationality.Font = new Font("Microsoft Sans Serif", 9F);
            txtNationality.ForeColor = Color.Black;
            txtNationality.FormattingEnabled = true;
            txtNationality.Items.AddRange(new object[] { "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "The Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso", "Burundi", "Cabo Verde", "Cambodia", "Cameroon", "Canada", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo, Democratic Republic of the", "Congo, Republic of the", "Costa Rica", "Côte d’Ivoire", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor (Timor-Leste)", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "The Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea, North", "Korea, South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia, Federated States of", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar (Burma)", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "North Macedonia", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "Spain", "Sri Lanka", "Sudan", "Sudan, South", "Suriname", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe" });
            txtNationality.Location = new Point(330, 330);
            txtNationality.Margin = new Padding(6);
            txtNationality.Name = "txtNationality";
            txtNationality.Size = new Size(334, 37);
            txtNationality.TabIndex = 16;
            txtNationality.Tag = "Nationality";
            txtNationality.Text = "Nationality";
            // 
            // txtStartDate
            // 
            txtStartDate.Font = new Font("Microsoft Sans Serif", 9F);
            txtStartDate.Format = DateTimePickerFormat.Short;
            txtStartDate.Location = new Point(330, 810);
            txtStartDate.Margin = new Padding(7, 6, 7, 6);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.RightToLeft = RightToLeft.Yes;
            txtStartDate.ShowUpDown = true;
            txtStartDate.Size = new Size(160, 35);
            txtStartDate.TabIndex = 40;
            txtStartDate.Tag = "StartDate";
            txtStartDate.Value = new DateTime(2024, 8, 7, 0, 0, 0, 0);
            // 
            // txtEndDate
            // 
            txtEndDate.Font = new Font("Microsoft Sans Serif", 9F);
            txtEndDate.Format = DateTimePickerFormat.Short;
            txtEndDate.Location = new Point(500, 810);
            txtEndDate.Margin = new Padding(7, 6, 7, 6);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.RightToLeft = RightToLeft.Yes;
            txtEndDate.ShowUpDown = true;
            txtEndDate.Size = new Size(160, 35);
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
            txtEmployment.Location = new Point(330, 860);
            txtEmployment.Margin = new Padding(6);
            txtEmployment.Name = "txtEmployment";
            txtEmployment.Size = new Size(334, 37);
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
            txtDepartment.Location = new Point(330, 910);
            txtDepartment.Margin = new Padding(6);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(334, 37);
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
            txtRole.Location = new Point(330, 960);
            txtRole.Margin = new Padding(6);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(334, 37);
            txtRole.TabIndex = 44;
            txtRole.Tag = "Role";
            txtRole.Text = "Role";
            // 
            // txtCadreLevel
            // 
            txtCadreLevel.Location = new Point(330, 1010);
            txtCadreLevel.Margin = new Padding(6);
            txtCadreLevel.Name = "txtCadreLevel";
            txtCadreLevel.Size = new Size(334, 39);
            txtCadreLevel.TabIndex = 45;
            txtCadreLevel.Tag = "Cadre Level";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(30, 30);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(93, 32);
            lblStatus.TabIndex = 31;
            lblStatus.Text = "Status*:";
            // 
            // lblSalutation
            // 
            lblSalutation.AutoSize = true;
            lblSalutation.Location = new Point(30, 80);
            lblSalutation.Name = "lblSalutation";
            lblSalutation.Size = new Size(136, 32);
            lblSalutation.TabIndex = 101;
            lblSalutation.Text = "Salutation*:";
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Location = new Point(30, 280);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(66, 32);
            lblSex.TabIndex = 102;
            lblSex.Text = "Sex*:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(30, 230);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(141, 32);
            lblLastName.TabIndex = 103;
            lblLastName.Text = "Last Name*:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(30, 180);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(144, 32);
            lblFirstName.TabIndex = 104;
            lblFirstName.Text = "First Name*:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(30, 130);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(65, 32);
            lblTitle.TabIndex = 105;
            lblTitle.Text = "Title:";
            // 
            // lblSocialSecurityNumber
            // 
            lblSocialSecurityNumber.AutoSize = true;
            lblSocialSecurityNumber.Location = new Point(30, 380);
            lblSocialSecurityNumber.Name = "lblSocialSecurityNumber";
            lblSocialSecurityNumber.Size = new Size(278, 32);
            lblSocialSecurityNumber.TabIndex = 110;
            lblSocialSecurityNumber.Text = "Social Security Number*:";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new Point(30, 430);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(165, 32);
            lblDateOfBirth.TabIndex = 109;
            lblDateOfBirth.Text = "Date of Birth*:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(30, 490);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(113, 32);
            lblAddress.TabIndex = 108;
            lblAddress.Text = "Address*:";
            // 
            // lblPhoneNumberMobile
            // 
            lblPhoneNumberMobile.AutoSize = true;
            lblPhoneNumberMobile.Location = new Point(30, 600);
            lblPhoneNumberMobile.Name = "lblPhoneNumberMobile";
            lblPhoneNumberMobile.Size = new Size(274, 32);
            lblPhoneNumberMobile.TabIndex = 107;
            lblPhoneNumberMobile.Text = "Phone Number Mobile*:";
            // 
            // lblNationality
            // 
            lblNationality.AutoSize = true;
            lblNationality.Location = new Point(30, 330);
            lblNationality.Name = "lblNationality";
            lblNationality.Size = new Size(145, 32);
            lblNationality.TabIndex = 106;
            lblNationality.Text = "Nationality*:";
            // 
            // lblPhoneNumberBusiness
            // 
            lblPhoneNumberBusiness.AutoSize = true;
            lblPhoneNumberBusiness.Location = new Point(30, 700);
            lblPhoneNumberBusiness.Name = "lblPhoneNumberBusiness";
            lblPhoneNumberBusiness.Size = new Size(280, 32);
            lblPhoneNumberBusiness.TabIndex = 113;
            lblPhoneNumberBusiness.Text = "Phone Number Business:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(30, 750);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(166, 32);
            lblEmail.TabIndex = 112;
            lblEmail.Text = "Mail Address*:";
            // 
            // lblPhoneNumberPrivate
            // 
            lblPhoneNumberPrivate.AutoSize = true;
            lblPhoneNumberPrivate.Location = new Point(30, 650);
            lblPhoneNumberPrivate.Name = "lblPhoneNumberPrivate";
            lblPhoneNumberPrivate.Size = new Size(271, 32);
            lblPhoneNumberPrivate.TabIndex = 111;
            lblPhoneNumberPrivate.Text = "Phone Number Private:*";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(30, 960);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(75, 32);
            lblRole.TabIndex = 118;
            lblRole.Text = "Role*:";
            // 
            // lblCadreLevel
            // 
            lblCadreLevel.AutoSize = true;
            lblCadreLevel.Location = new Point(30, 1010);
            lblCadreLevel.Name = "lblCadreLevel";
            lblCadreLevel.Size = new Size(146, 32);
            lblCadreLevel.TabIndex = 117;
            lblCadreLevel.Text = "CadreLevel*:";
            // 
            // lblDepartement
            // 
            lblDepartement.AutoSize = true;
            lblDepartement.Location = new Point(30, 910);
            lblDepartement.Name = "lblDepartement";
            lblDepartement.Size = new Size(170, 32);
            lblDepartement.TabIndex = 116;
            lblDepartement.Text = "Departement*:";
            // 
            // lblStartEndDate
            // 
            lblStartEndDate.AutoSize = true;
            lblStartEndDate.Location = new Point(30, 810);
            lblStartEndDate.Name = "lblStartEndDate";
            lblStartEndDate.Size = new Size(183, 32);
            lblStartEndDate.TabIndex = 115;
            lblStartEndDate.Text = "Start*/End Date:";
            // 
            // lblEmploymentType
            // 
            lblEmploymentType.AutoSize = true;
            lblEmploymentType.Location = new Point(30, 860);
            lblEmploymentType.Name = "lblEmploymentType";
            lblEmploymentType.Size = new Size(218, 32);
            lblEmploymentType.TabIndex = 114;
            lblEmploymentType.Text = "Employment type*:";
            // 
            // lblTraineeYears
            // 
            lblTraineeYears.AutoSize = true;
            lblTraineeYears.Location = new Point(30, 1130);
            lblTraineeYears.Name = "lblTraineeYears";
            lblTraineeYears.Size = new Size(157, 32);
            lblTraineeYears.TabIndex = 120;
            lblTraineeYears.Text = "Trainee Years:";
            // 
            // numTraineeYears
            // 
            numTraineeYears.Enabled = false;
            numTraineeYears.Location = new Point(330, 1130);
            numTraineeYears.Margin = new Padding(6);
            numTraineeYears.Name = "numTraineeYears";
            numTraineeYears.Size = new Size(334, 39);
            numTraineeYears.TabIndex = 51;
            numTraineeYears.Tag = "Cadre Level";
            // 
            // lblActualTraineeYear
            // 
            lblActualTraineeYear.AutoSize = true;
            lblActualTraineeYear.Location = new Point(30, 1180);
            lblActualTraineeYear.Name = "lblActualTraineeYear";
            lblActualTraineeYear.Size = new Size(220, 32);
            lblActualTraineeYear.TabIndex = 122;
            lblActualTraineeYear.Text = "Actual Trainee Year:";
            // 
            // numActualTraineeYear
            // 
            numActualTraineeYear.Enabled = false;
            numActualTraineeYear.Location = new Point(330, 1180);
            numActualTraineeYear.Margin = new Padding(6);
            numActualTraineeYear.Name = "numActualTraineeYear";
            numActualTraineeYear.Size = new Size(334, 39);
            numActualTraineeYear.TabIndex = 52;
            numActualTraineeYear.Tag = "Cadre Level";
            // 
            // ckbStatus
            // 
            ckbStatus.AutoSize = true;
            ckbStatus.Checked = true;
            ckbStatus.CheckState = CheckState.Checked;
            ckbStatus.Location = new Point(330, 30);
            ckbStatus.Name = "ckbStatus";
            ckbStatus.Size = new Size(108, 36);
            ckbStatus.TabIndex = 10;
            ckbStatus.Text = "active";
            ckbStatus.UseVisualStyleBackColor = true;
            // 
            // ckbTrainee
            // 
            ckbTrainee.AutoSize = true;
            ckbTrainee.Location = new Point(330, 1080);
            ckbTrainee.Name = "ckbTrainee";
            ckbTrainee.Size = new Size(123, 36);
            ckbTrainee.TabIndex = 50;
            ckbTrainee.Text = "Trainee";
            ckbTrainee.UseVisualStyleBackColor = true;
            ckbTrainee.CheckedChanged += ckbTrainee_CheckedChanged;
            // 
            // lblTrainee
            // 
            lblTrainee.AutoSize = true;
            lblTrainee.Location = new Point(30, 1080);
            lblTrainee.Name = "lblTrainee";
            lblTrainee.Size = new Size(96, 32);
            lblTrainee.TabIndex = 124;
            lblTrainee.Text = "Trainee:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(122, 148, 150);
            panel1.Location = new Point(28, 474);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 5);
            panel1.TabIndex = 165;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(122, 148, 150);
            panel2.Location = new Point(28, 584);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 5);
            panel2.TabIndex = 166;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(122, 148, 150);
            panel3.Location = new Point(30, 794);
            panel3.Name = "panel3";
            panel3.Size = new Size(900, 5);
            panel3.TabIndex = 167;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(122, 148, 150);
            panel4.Location = new Point(30, 1058);
            panel4.Name = "panel4";
            panel4.Size = new Size(900, 5);
            panel4.TabIndex = 168;
            // 
            // frmCreateEmployee
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 49, 51);
            ClientSize = new Size(974, 1429);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(ckbTrainee);
            Controls.Add(lblTrainee);
            Controls.Add(ckbStatus);
            Controls.Add(lblActualTraineeYear);
            Controls.Add(numActualTraineeYear);
            Controls.Add(lblTraineeYears);
            Controls.Add(numTraineeYears);
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
            Margin = new Padding(7, 6, 7, 6);
            Name = "frmCreateEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create New Employee";
            ((System.ComponentModel.ISupportInitialize)txtCadreLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTraineeYears).EndInit();
            ((System.ComponentModel.ISupportInitialize)numActualTraineeYear).EndInit();
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
        private NumericUpDown numTraineeYears;
        private Label lblActualTraineeYear;
        private NumericUpDown numActualTraineeYear;
        private CheckBox ckbStatus;
        private CheckBox ckbTrainee;
        private Label lblTrainee;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}