namespace ZbW_P_Contact_Manager.UI
{
    partial class frmCreateCustomer
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
            btnCreateNewCustomer = new Button();
            ckbStatus = new CheckBox();
            lblCompanyContact = new Label();
            lblCompanyType = new Label();
            lblCompanyName = new Label();
            lblPhoneNumberBusiness = new Label();
            lblEmail = new Label();
            lblPhoneNumberPrivate = new Label();
            lblDateOfBirth = new Label();
            lblAddress = new Label();
            lblPhoneNumberMobile = new Label();
            lblNationality = new Label();
            lblTitle = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblSex = new Label();
            lblSalutation = new Label();
            lblStatus = new Label();
            txtStreet = new TextBox();
            txtSalutation = new ComboBox();
            txtPhoneNumberBusiness = new TextBox();
            txtTitle = new TextBox();
            txtPhoneNumberMobile = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPhoneNumberPrivate = new TextBox();
            txtSex = new ComboBox();
            txtNationality = new ComboBox();
            txtEmail = new TextBox();
            txtZipCode = new TextBox();
            txtDateOfBirth = new DateTimePicker();
            txtPlace = new TextBox();
            txtStreetNumber = new TextBox();
            txtCompanyName = new TextBox();
            txtCompanyType = new TextBox();
            txtCompanyContact = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            SuspendLayout();
            // 
            // btnCreateNewCustomer
            // 
            btnCreateNewCustomer.ForeColor = Color.Black;
            btnCreateNewCustomer.Location = new Point(371, 447);
            btnCreateNewCustomer.Name = "btnCreateNewCustomer";
            btnCreateNewCustomer.Size = new Size(141, 23);
            btnCreateNewCustomer.TabIndex = 43;
            btnCreateNewCustomer.Text = "Create New Customer";
            btnCreateNewCustomer.UseVisualStyleBackColor = true;
            btnCreateNewCustomer.Click += btnCreateNewCustomer_Click;
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
            ckbStatus.TabIndex = 119;
            ckbStatus.Text = "active";
            ckbStatus.UseVisualStyleBackColor = true;
            // 
            // lblCompanyContact
            // 
            lblCompanyContact.AutoSize = true;
            lblCompanyContact.Location = new Point(16, 408);
            lblCompanyContact.Margin = new Padding(2, 0, 2, 0);
            lblCompanyContact.Name = "lblCompanyContact";
            lblCompanyContact.Size = new Size(112, 15);
            lblCompanyContact.TabIndex = 160;
            lblCompanyContact.Text = "Company Contact*:";
            // 
            // lblCompanyType
            // 
            lblCompanyType.AutoSize = true;
            lblCompanyType.Location = new Point(16, 384);
            lblCompanyType.Margin = new Padding(2, 0, 2, 0);
            lblCompanyType.Name = "lblCompanyType";
            lblCompanyType.Size = new Size(94, 15);
            lblCompanyType.TabIndex = 158;
            lblCompanyType.Text = "Company Type*:";
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Location = new Point(16, 361);
            lblCompanyName.Margin = new Padding(2, 0, 2, 0);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(102, 15);
            lblCompanyName.TabIndex = 156;
            lblCompanyName.Text = "Company Name*:";
            // 
            // lblPhoneNumberBusiness
            // 
            lblPhoneNumberBusiness.AutoSize = true;
            lblPhoneNumberBusiness.Location = new Point(16, 309);
            lblPhoneNumberBusiness.Margin = new Padding(2, 0, 2, 0);
            lblPhoneNumberBusiness.Name = "lblPhoneNumberBusiness";
            lblPhoneNumberBusiness.Size = new Size(144, 15);
            lblPhoneNumberBusiness.TabIndex = 155;
            lblPhoneNumberBusiness.Text = "Phone Number Business*:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(16, 333);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(83, 15);
            lblEmail.TabIndex = 154;
            lblEmail.Text = "Mail Address*:";
            // 
            // lblPhoneNumberPrivate
            // 
            lblPhoneNumberPrivate.AutoSize = true;
            lblPhoneNumberPrivate.Location = new Point(16, 286);
            lblPhoneNumberPrivate.Margin = new Padding(2, 0, 2, 0);
            lblPhoneNumberPrivate.Name = "lblPhoneNumberPrivate";
            lblPhoneNumberPrivate.Size = new Size(130, 15);
            lblPhoneNumberPrivate.TabIndex = 153;
            lblPhoneNumberPrivate.Text = "Phone Number Private:";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new Point(16, 188);
            lblDateOfBirth.Margin = new Padding(2, 0, 2, 0);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(76, 15);
            lblDateOfBirth.TabIndex = 151;
            lblDateOfBirth.Text = "Date of Birth:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(16, 211);
            lblAddress.Margin = new Padding(2, 0, 2, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(57, 15);
            lblAddress.TabIndex = 150;
            lblAddress.Text = "Address*:";
            // 
            // lblPhoneNumberMobile
            // 
            lblPhoneNumberMobile.AutoSize = true;
            lblPhoneNumberMobile.Location = new Point(16, 262);
            lblPhoneNumberMobile.Margin = new Padding(2, 0, 2, 0);
            lblPhoneNumberMobile.Name = "lblPhoneNumberMobile";
            lblPhoneNumberMobile.Size = new Size(131, 15);
            lblPhoneNumberMobile.TabIndex = 149;
            lblPhoneNumberMobile.Text = "Phone Number Mobile:";
            // 
            // lblNationality
            // 
            lblNationality.AutoSize = true;
            lblNationality.Location = new Point(16, 155);
            lblNationality.Margin = new Padding(2, 0, 2, 0);
            lblNationality.Name = "lblNationality";
            lblNationality.Size = new Size(73, 15);
            lblNationality.TabIndex = 148;
            lblNationality.Text = "Nationality*:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(16, 61);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(32, 15);
            lblTitle.TabIndex = 147;
            lblTitle.Text = "Title:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(16, 84);
            lblFirstName.Margin = new Padding(2, 0, 2, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(72, 15);
            lblFirstName.TabIndex = 146;
            lblFirstName.Text = "First Name*:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(16, 108);
            lblLastName.Margin = new Padding(2, 0, 2, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(71, 15);
            lblLastName.TabIndex = 145;
            lblLastName.Text = "Last Name*:";
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Location = new Point(16, 131);
            lblSex.Margin = new Padding(2, 0, 2, 0);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(33, 15);
            lblSex.TabIndex = 144;
            lblSex.Text = "Sex*:";
            // 
            // lblSalutation
            // 
            lblSalutation.AutoSize = true;
            lblSalutation.Location = new Point(16, 38);
            lblSalutation.Margin = new Padding(2, 0, 2, 0);
            lblSalutation.Name = "lblSalutation";
            lblSalutation.Size = new Size(68, 15);
            lblSalutation.TabIndex = 143;
            lblSalutation.Text = "Salutation*:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(16, 14);
            lblStatus.Margin = new Padding(2, 0, 2, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(47, 15);
            lblStatus.TabIndex = 133;
            lblStatus.Text = "Status*:";
            // 
            // txtStreet
            // 
            txtStreet.BackColor = Color.FromArgb(227, 234, 234);
            txtStreet.Font = new Font("Microsoft Sans Serif", 9F);
            txtStreet.ForeColor = Color.Black;
            txtStreet.Location = new Point(178, 211);
            txtStreet.Margin = new Padding(4, 3, 4, 3);
            txtStreet.Name = "txtStreet";
            txtStreet.PlaceholderText = "Street";
            txtStreet.Size = new Size(182, 21);
            txtStreet.TabIndex = 128;
            txtStreet.Tag = "Street";
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
            txtSalutation.TabIndex = 120;
            txtSalutation.Tag = "Salutation";
            txtSalutation.Text = "Salutation";
            // 
            // txtPhoneNumberBusiness
            // 
            txtPhoneNumberBusiness.BackColor = Color.FromArgb(227, 234, 234);
            txtPhoneNumberBusiness.Font = new Font("Microsoft Sans Serif", 9F);
            txtPhoneNumberBusiness.ForeColor = Color.Black;
            txtPhoneNumberBusiness.Location = new Point(178, 309);
            txtPhoneNumberBusiness.Margin = new Padding(4, 3, 4, 3);
            txtPhoneNumberBusiness.Name = "txtPhoneNumberBusiness";
            txtPhoneNumberBusiness.PlaceholderText = "Phone Number Business";
            txtPhoneNumberBusiness.Size = new Size(182, 21);
            txtPhoneNumberBusiness.TabIndex = 135;
            txtPhoneNumberBusiness.Tag = "Phone Number Business ";
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
            txtTitle.TabIndex = 121;
            txtTitle.Tag = "";
            // 
            // txtPhoneNumberMobile
            // 
            txtPhoneNumberMobile.BackColor = Color.FromArgb(227, 234, 234);
            txtPhoneNumberMobile.Font = new Font("Microsoft Sans Serif", 9F);
            txtPhoneNumberMobile.ForeColor = Color.Black;
            txtPhoneNumberMobile.Location = new Point(178, 262);
            txtPhoneNumberMobile.Margin = new Padding(4, 3, 4, 3);
            txtPhoneNumberMobile.Name = "txtPhoneNumberMobile";
            txtPhoneNumberMobile.PlaceholderText = "Phone Number Mobile";
            txtPhoneNumberMobile.Size = new Size(182, 21);
            txtPhoneNumberMobile.TabIndex = 132;
            txtPhoneNumberMobile.Tag = "Phone Number Mobile";
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
            txtFirstName.TabIndex = 122;
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
            txtLastName.TabIndex = 123;
            txtLastName.Tag = "Last Name";
            // 
            // txtPhoneNumberPrivate
            // 
            txtPhoneNumberPrivate.BackColor = Color.FromArgb(227, 234, 234);
            txtPhoneNumberPrivate.Font = new Font("Microsoft Sans Serif", 9F);
            txtPhoneNumberPrivate.ForeColor = Color.Black;
            txtPhoneNumberPrivate.Location = new Point(178, 286);
            txtPhoneNumberPrivate.Margin = new Padding(4, 3, 4, 3);
            txtPhoneNumberPrivate.Name = "txtPhoneNumberPrivate";
            txtPhoneNumberPrivate.PlaceholderText = "Phone Number Private";
            txtPhoneNumberPrivate.Size = new Size(182, 21);
            txtPhoneNumberPrivate.TabIndex = 134;
            txtPhoneNumberPrivate.Tag = "Phone Number Private";
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
            txtSex.TabIndex = 124;
            txtSex.Tag = "Sex";
            txtSex.Text = "Sex";
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
            txtNationality.TabIndex = 125;
            txtNationality.Tag = "Nationality";
            txtNationality.Text = "Nationality";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(227, 234, 234);
            txtEmail.Font = new Font("Microsoft Sans Serif", 9F);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(178, 333);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(182, 21);
            txtEmail.TabIndex = 136;
            txtEmail.Tag = "Email";
            // 
            // txtZipCode
            // 
            txtZipCode.BackColor = Color.FromArgb(227, 234, 234);
            txtZipCode.Font = new Font("Microsoft Sans Serif", 9F);
            txtZipCode.ForeColor = Color.Black;
            txtZipCode.Location = new Point(366, 234);
            txtZipCode.Margin = new Padding(4, 3, 4, 3);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.PlaceholderText = "ZipCode";
            txtZipCode.Size = new Size(83, 21);
            txtZipCode.TabIndex = 131;
            txtZipCode.Tag = "ZipCode";
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Font = new Font("Microsoft Sans Serif", 9F);
            txtDateOfBirth.Format = DateTimePickerFormat.Short;
            txtDateOfBirth.Location = new Point(178, 188);
            txtDateOfBirth.Margin = new Padding(4, 3, 4, 3);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.RightToLeft = RightToLeft.Yes;
            txtDateOfBirth.ShowUpDown = true;
            txtDateOfBirth.Size = new Size(88, 21);
            txtDateOfBirth.TabIndex = 127;
            txtDateOfBirth.Tag = "Date Of Birth";
            txtDateOfBirth.Value = new DateTime(2024, 8, 7, 0, 0, 0, 0);
            // 
            // txtPlace
            // 
            txtPlace.BackColor = Color.FromArgb(227, 234, 234);
            txtPlace.Font = new Font("Microsoft Sans Serif", 9F);
            txtPlace.ForeColor = Color.Black;
            txtPlace.Location = new Point(178, 234);
            txtPlace.Margin = new Padding(4, 3, 4, 3);
            txtPlace.Name = "txtPlace";
            txtPlace.PlaceholderText = "Place";
            txtPlace.Size = new Size(182, 21);
            txtPlace.TabIndex = 130;
            txtPlace.Tag = "Place";
            // 
            // txtStreetNumber
            // 
            txtStreetNumber.BackColor = Color.FromArgb(227, 234, 234);
            txtStreetNumber.Font = new Font("Microsoft Sans Serif", 9F);
            txtStreetNumber.ForeColor = Color.Black;
            txtStreetNumber.Location = new Point(366, 211);
            txtStreetNumber.Margin = new Padding(4, 3, 4, 3);
            txtStreetNumber.Name = "txtStreetNumber";
            txtStreetNumber.PlaceholderText = "Street Number";
            txtStreetNumber.Size = new Size(83, 21);
            txtStreetNumber.TabIndex = 129;
            txtStreetNumber.Tag = "Street Number";
            // 
            // txtCompanyName
            // 
            txtCompanyName.BackColor = Color.FromArgb(227, 234, 234);
            txtCompanyName.Font = new Font("Microsoft Sans Serif", 9F);
            txtCompanyName.ForeColor = Color.Black;
            txtCompanyName.Location = new Point(178, 361);
            txtCompanyName.Margin = new Padding(4, 3, 4, 3);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.PlaceholderText = "Company Name";
            txtCompanyName.Size = new Size(182, 21);
            txtCompanyName.TabIndex = 161;
            txtCompanyName.Tag = "Company Name";
            // 
            // txtCompanyType
            // 
            txtCompanyType.BackColor = Color.FromArgb(227, 234, 234);
            txtCompanyType.Font = new Font("Microsoft Sans Serif", 9F);
            txtCompanyType.ForeColor = Color.Black;
            txtCompanyType.Location = new Point(178, 384);
            txtCompanyType.Margin = new Padding(4, 3, 4, 3);
            txtCompanyType.Name = "txtCompanyType";
            txtCompanyType.PlaceholderText = "Company Type";
            txtCompanyType.Size = new Size(182, 21);
            txtCompanyType.TabIndex = 162;
            txtCompanyType.Tag = "Company Type";
            // 
            // txtCompanyContact
            // 
            txtCompanyContact.BackColor = Color.FromArgb(227, 234, 234);
            txtCompanyContact.Font = new Font("Microsoft Sans Serif", 9F);
            txtCompanyContact.ForeColor = Color.Black;
            txtCompanyContact.Location = new Point(178, 408);
            txtCompanyContact.Margin = new Padding(4, 3, 4, 3);
            txtCompanyContact.Name = "txtCompanyContact";
            txtCompanyContact.PlaceholderText = "Company Contact";
            txtCompanyContact.Size = new Size(182, 21);
            txtCompanyContact.TabIndex = 163;
            txtCompanyContact.Tag = "Company Contact";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(122, 148, 150);
            panel1.Location = new Point(16, 178);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 2);
            panel1.TabIndex = 164;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(122, 148, 150);
            panel2.Location = new Point(16, 255);
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(485, 2);
            panel2.TabIndex = 165;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(122, 148, 150);
            panel3.Location = new Point(16, 353);
            panel3.Margin = new Padding(2, 1, 2, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(485, 2);
            panel3.TabIndex = 166;
            // 
            // frmCreateCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 49, 51);
            ClientSize = new Size(524, 482);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtCompanyContact);
            Controls.Add(txtCompanyType);
            Controls.Add(txtCompanyName);
            Controls.Add(ckbStatus);
            Controls.Add(lblCompanyContact);
            Controls.Add(lblCompanyType);
            Controls.Add(lblCompanyName);
            Controls.Add(lblPhoneNumberBusiness);
            Controls.Add(lblEmail);
            Controls.Add(lblPhoneNumberPrivate);
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
            Controls.Add(txtSalutation);
            Controls.Add(txtPhoneNumberBusiness);
            Controls.Add(txtTitle);
            Controls.Add(txtPhoneNumberMobile);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtPhoneNumberPrivate);
            Controls.Add(txtSex);
            Controls.Add(txtNationality);
            Controls.Add(txtEmail);
            Controls.Add(txtZipCode);
            Controls.Add(txtDateOfBirth);
            Controls.Add(txtPlace);
            Controls.Add(txtStreetNumber);
            Controls.Add(btnCreateNewCustomer);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmCreateCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create New Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCreateNewCustomer;
        private CheckBox ckbStatus;
        private Label lblCompanyContact;
        private Label lblCompanyType;
        private Label lblCompanyName;
        private Label lblPhoneNumberBusiness;
        private Label lblEmail;
        private Label lblPhoneNumberPrivate;
        private Label lblDateOfBirth;
        private Label lblAddress;
        private Label lblPhoneNumberMobile;
        private Label lblNationality;
        private Label lblTitle;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblSex;
        private Label lblSalutation;
        private Label lblStatus;
        private TextBox txtStreet;
        private ComboBox txtSalutation;
        private TextBox txtPhoneNumberBusiness;
        private TextBox txtTitle;
        private TextBox txtPhoneNumberMobile;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPhoneNumberPrivate;
        private ComboBox txtSex;
        private ComboBox txtNationality;
        private TextBox txtEmail;
        private TextBox txtZipCode;
        private DateTimePicker txtDateOfBirth;
        private TextBox txtPlace;
        private TextBox txtStreetNumber;
        private TextBox txtCompanyName;
        private TextBox txtCompanyType;
        private TextBox txtCompanyContact;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}