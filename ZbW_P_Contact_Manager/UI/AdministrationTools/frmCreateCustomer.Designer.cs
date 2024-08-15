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
            txtNationality = new ComboBox();
            txtStatus = new ComboBox();
            txtDateOfBirth = new DateTimePicker();
            txtSex = new ComboBox();
            txtSalutation = new ComboBox();
            txtPlace = new TextBox();
            txtZipCode = new TextBox();
            txtStreetNumber = new TextBox();
            txtStreet = new TextBox();
            txtEmail = new TextBox();
            txtPhoneNumberBusiness = new TextBox();
            txtPhoneNumberMobile = new TextBox();
            txtPhoneNumberPrivate = new TextBox();
            txtTitle = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtSocialSecurityNumber = new TextBox();
            txtCompanyName = new TextBox();
            txtCompanyType = new TextBox();
            txtCompanyContact = new TextBox();
            SuspendLayout();
            // 
            // btnCreateNewCustomer
            // 
            btnCreateNewCustomer.Location = new Point(373, 380);
            btnCreateNewCustomer.Name = "btnCreateNewCustomer";
            btnCreateNewCustomer.Size = new Size(141, 23);
            btnCreateNewCustomer.TabIndex = 43;
            btnCreateNewCustomer.Text = "Create New Customer";
            btnCreateNewCustomer.UseVisualStyleBackColor = true;
            // 
            // txtNationality
            // 
            txtNationality.BackColor = Color.FromArgb(74, 79, 99);
            txtNationality.FlatStyle = FlatStyle.Flat;
            txtNationality.Font = new Font("Microsoft Sans Serif", 9F);
            txtNationality.ForeColor = SystemColors.ScrollBar;
            txtNationality.FormattingEnabled = true;
            txtNationality.Items.AddRange(new object[] { "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "The Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso", "Burundi", "Cabo Verde", "Cambodia", "Cameroon", "Canada", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo, Democratic Republic of the", "Congo, Republic of the", "Costa Rica", "Côte d’Ivoire", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor (Timor-Leste)", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "The Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea, North", "Korea, South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia, Federated States of", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar (Burma)", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "North Macedonia", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "Spain", "Sri Lanka", "Sudan", "Sudan, South", "Suriname", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe" });
            txtNationality.Location = new Point(132, 34);
            txtNationality.Name = "txtNationality";
            txtNationality.Size = new Size(121, 23);
            txtNationality.TabIndex = 53;
            txtNationality.Tag = "Nationality";
            txtNationality.Text = "Nationality";
            // 
            // txtStatus
            // 
            txtStatus.BackColor = Color.FromArgb(74, 79, 99);
            txtStatus.FlatStyle = FlatStyle.Flat;
            txtStatus.Font = new Font("Microsoft Sans Serif", 9F);
            txtStatus.ForeColor = SystemColors.ScrollBar;
            txtStatus.FormattingEnabled = true;
            txtStatus.Items.AddRange(new object[] { "married", "single", "divorced", "widowed" });
            txtStatus.Location = new Point(5, 33);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(121, 23);
            txtStatus.TabIndex = 52;
            txtStatus.Tag = "Civil Status";
            txtStatus.Text = "Civil Status";
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Font = new Font("Microsoft Sans Serif", 9F);
            txtDateOfBirth.Format = DateTimePickerFormat.Short;
            txtDateOfBirth.Location = new Point(455, 6);
            txtDateOfBirth.Margin = new Padding(4, 3, 4, 3);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.RightToLeft = RightToLeft.Yes;
            txtDateOfBirth.ShowUpDown = true;
            txtDateOfBirth.Size = new Size(93, 21);
            txtDateOfBirth.TabIndex = 51;
            txtDateOfBirth.Tag = "Date Of Birth";
            txtDateOfBirth.Value = new DateTime(2024, 8, 7, 0, 0, 0, 0);
            SetDatePickerStyle(this.txtDateOfBirth);
            // 
            // txtSex
            // 
            txtSex.BackColor = Color.FromArgb(74, 79, 99);
            txtSex.FlatStyle = FlatStyle.Flat;
            txtSex.Font = new Font("Microsoft Sans Serif", 9F);
            txtSex.ForeColor = SystemColors.ScrollBar;
            txtSex.FormattingEnabled = true;
            txtSex.Items.AddRange(new object[] { "Male", "Female" });
            txtSex.Location = new Point(377, 6);
            txtSex.Margin = new Padding(4, 3, 4, 3);
            txtSex.Name = "txtSex";
            txtSex.Size = new Size(76, 23);
            txtSex.TabIndex = 50;
            txtSex.Tag = "Sex";
            txtSex.Text = "Sex";
            // 
            // txtSalutation
            // 
            txtSalutation.BackColor = Color.FromArgb(74, 79, 99);
            txtSalutation.FlatStyle = FlatStyle.Flat;
            txtSalutation.Font = new Font("Microsoft Sans Serif", 9F);
            txtSalutation.ForeColor = SystemColors.ScrollBar;
            txtSalutation.FormattingEnabled = true;
            txtSalutation.Items.AddRange(new object[] { "Mr.", "Ms.", "Mrs." });
            txtSalutation.Location = new Point(5, 6);
            txtSalutation.Margin = new Padding(4, 3, 4, 3);
            txtSalutation.Name = "txtSalutation";
            txtSalutation.Size = new Size(74, 23);
            txtSalutation.TabIndex = 46;
            txtSalutation.Tag = "Salutation";
            txtSalutation.Text = "Salutation";
            // 
            // txtPlace
            // 
            txtPlace.BackColor = Color.FromArgb(74, 79, 99);
            txtPlace.Font = new Font("Microsoft Sans Serif", 9F);
            txtPlace.ForeColor = SystemColors.ScrollBar;
            txtPlace.Location = new Point(279, 114);
            txtPlace.Margin = new Padding(4, 3, 4, 3);
            txtPlace.Name = "txtPlace";
            txtPlace.PlaceholderText = "Place";
            txtPlace.Size = new Size(116, 21);
            txtPlace.TabIndex = 62;
            txtPlace.Tag = "Place";
            // 
            // txtZipCode
            // 
            txtZipCode.BackColor = Color.FromArgb(74, 79, 99);
            txtZipCode.Font = new Font("Microsoft Sans Serif", 9F);
            txtZipCode.ForeColor = SystemColors.ScrollBar;
            txtZipCode.Location = new Point(218, 114);
            txtZipCode.Margin = new Padding(4, 3, 4, 3);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.PlaceholderText = "ZipCode";
            txtZipCode.Size = new Size(57, 21);
            txtZipCode.TabIndex = 61;
            txtZipCode.Tag = "ZipCode";
            txtZipCode.KeyPress += new KeyPressEventHandler(this.NumberTextBox_KeyPress);
            txtZipCode.TextChanged += new EventHandler(this.NumberTextBox_TextChanged);
            // 
            // txtStreetNumber
            // 
            txtStreetNumber.BackColor = Color.FromArgb(74, 79, 99);
            txtStreetNumber.Font = new Font("Microsoft Sans Serif", 9F);
            txtStreetNumber.ForeColor = SystemColors.ScrollBar;
            txtStreetNumber.Location = new Point(125, 114);
            txtStreetNumber.Margin = new Padding(4, 3, 4, 3);
            txtStreetNumber.Name = "txtStreetNumber";
            txtStreetNumber.PlaceholderText = "Street Number";
            txtStreetNumber.Size = new Size(89, 21);
            txtStreetNumber.TabIndex = 60;
            txtStreetNumber.Tag = "Street Number";
            txtStreetNumber.KeyPress += new KeyPressEventHandler(this.NumberTextBox_KeyPress);
            txtStreetNumber.TextChanged += new EventHandler(this.NumberTextBox_TextChanged);
            // 
            // txtStreet
            // 
            txtStreet.BackColor = Color.FromArgb(74, 79, 99);
            txtStreet.Font = new Font("Microsoft Sans Serif", 9F);
            txtStreet.ForeColor = SystemColors.ScrollBar;
            txtStreet.Location = new Point(5, 114);
            txtStreet.Margin = new Padding(4, 3, 4, 3);
            txtStreet.Name = "txtStreet";
            txtStreet.PlaceholderText = "Street";
            txtStreet.Size = new Size(116, 21);
            txtStreet.TabIndex = 59;
            txtStreet.Tag = "Street";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(74, 79, 99);
            txtEmail.Font = new Font("Microsoft Sans Serif", 9F);
            txtEmail.ForeColor = SystemColors.ScrollBar;
            txtEmail.Location = new Point(5, 87);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(219, 21);
            txtEmail.TabIndex = 58;
            txtEmail.Tag = "Email";
            // 
            // txtPhoneNumberBusiness
            // 
            txtPhoneNumberBusiness.BackColor = Color.FromArgb(74, 79, 99);
            txtPhoneNumberBusiness.Font = new Font("Microsoft Sans Serif", 9F);
            txtPhoneNumberBusiness.ForeColor = SystemColors.ScrollBar;
            txtPhoneNumberBusiness.Location = new Point(5, 195);
            txtPhoneNumberBusiness.Margin = new Padding(4, 3, 4, 3);
            txtPhoneNumberBusiness.Name = "txtPhoneNumberBusiness";
            txtPhoneNumberBusiness.PlaceholderText = "Phone Number Business";
            txtPhoneNumberBusiness.Size = new Size(147, 21);
            txtPhoneNumberBusiness.TabIndex = 57;
            txtPhoneNumberBusiness.Tag = "Phone Number Business ";
            txtPhoneNumberBusiness.KeyPress += new KeyPressEventHandler(this.PhoneNumberTextBox_KeyPress);
            txtPhoneNumberBusiness.TextChanged += new EventHandler(this.PhoneNumberTextBox_TextChanged);
            // 
            // txtPhoneNumberMobile
            // 
            txtPhoneNumberMobile.BackColor = Color.FromArgb(74, 79, 99);
            txtPhoneNumberMobile.Font = new Font("Microsoft Sans Serif", 9F);
            txtPhoneNumberMobile.ForeColor = SystemColors.ScrollBar;
            txtPhoneNumberMobile.Location = new Point(5, 168);
            txtPhoneNumberMobile.Margin = new Padding(4, 3, 4, 3);
            txtPhoneNumberMobile.Name = "txtPhoneNumberMobile";
            txtPhoneNumberMobile.PlaceholderText = "Phone Number Mobile";
            txtPhoneNumberMobile.Size = new Size(147, 21);
            txtPhoneNumberMobile.TabIndex = 56;
            txtPhoneNumberMobile.Tag = "Phone Number Mobile";
            txtPhoneNumberMobile.KeyPress += new KeyPressEventHandler(this.PhoneNumberTextBox_KeyPress);
            txtPhoneNumberMobile.TextChanged += new EventHandler(this.PhoneNumberTextBox_TextChanged);
            // 
            // txtPhoneNumberPrivate
            // 
            txtPhoneNumberPrivate.BackColor = Color.FromArgb(74, 79, 99);
            txtPhoneNumberPrivate.Font = new Font("Microsoft Sans Serif", 9F);
            txtPhoneNumberPrivate.ForeColor = SystemColors.ScrollBar;
            txtPhoneNumberPrivate.Location = new Point(5, 141);
            txtPhoneNumberPrivate.Margin = new Padding(4, 3, 4, 3);
            txtPhoneNumberPrivate.Name = "txtPhoneNumberPrivate";
            txtPhoneNumberPrivate.PlaceholderText = "Phone Number Private";
            txtPhoneNumberPrivate.Size = new Size(147, 21);
            txtPhoneNumberPrivate.TabIndex = 55;
            txtPhoneNumberPrivate.Tag = "Phone Number Private";
            txtPhoneNumberPrivate.KeyPress += new KeyPressEventHandler(this.PhoneNumberTextBox_KeyPress);
            txtPhoneNumberPrivate.TextChanged += new EventHandler(this.PhoneNumberTextBox_TextChanged);
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(74, 79, 99);
            txtTitle.Font = new Font("Microsoft Sans Serif", 9F);
            txtTitle.ForeColor = SystemColors.ScrollBar;
            txtTitle.Location = new Point(81, 7);
            txtTitle.Margin = new Padding(4, 3, 4, 3);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Title";
            txtTitle.Size = new Size(53, 21);
            txtTitle.TabIndex = 47;
            txtTitle.Tag = "";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(74, 79, 99);
            txtLastName.Font = new Font("Microsoft Sans Serif", 9F);
            txtLastName.ForeColor = SystemColors.ScrollBar;
            txtLastName.Location = new Point(257, 7);
            txtLastName.Margin = new Padding(4, 3, 4, 3);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last Name";
            txtLastName.Size = new Size(116, 21);
            txtLastName.TabIndex = 49;
            txtLastName.Tag = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(74, 79, 99);
            txtFirstName.Font = new Font("Microsoft Sans Serif", 9F);
            txtFirstName.ForeColor = SystemColors.ScrollBar;
            txtFirstName.Location = new Point(137, 7);
            txtFirstName.Margin = new Padding(4, 3, 4, 3);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First Name";
            txtFirstName.Size = new Size(116, 21);
            txtFirstName.TabIndex = 48;
            txtFirstName.Tag = "First Name";
            // 
            // txtSocialSecurityNumber
            // 
            txtSocialSecurityNumber.BackColor = Color.FromArgb(74, 79, 99);
            txtSocialSecurityNumber.Font = new Font("Microsoft Sans Serif", 9F);
            txtSocialSecurityNumber.ForeColor = SystemColors.ScrollBar;
            txtSocialSecurityNumber.Location = new Point(5, 60);
            txtSocialSecurityNumber.Margin = new Padding(4, 3, 4, 3);
            txtSocialSecurityNumber.Name = "txtSocialSecurityNumber";
            txtSocialSecurityNumber.PlaceholderText = "Social Security Number";
            txtSocialSecurityNumber.Size = new Size(159, 21);
            txtSocialSecurityNumber.TabIndex = 54;
            txtSocialSecurityNumber.Tag = "Social Security Number";
            txtSocialSecurityNumber.KeyPress += new KeyPressEventHandler(this.txtSocialSecurityNumber_KeyPress);
            txtSocialSecurityNumber.TextChanged += new EventHandler(this.txtSocialSecurityNumber_TextChanged);
            // 
            // txtCompanyName
            // 
            txtCompanyName.BackColor = Color.FromArgb(74, 79, 99);
            txtCompanyName.Font = new Font("Microsoft Sans Serif", 9F);
            txtCompanyName.ForeColor = SystemColors.ScrollBar;
            txtCompanyName.Location = new Point(5, 222);
            txtCompanyName.Margin = new Padding(4, 3, 4, 3);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.PlaceholderText = "Company Name";
            txtCompanyName.Size = new Size(116, 21);
            txtCompanyName.TabIndex = 63;
            txtCompanyName.Tag = "Company Name";
            // 
            // txtCompanyType
            // 
            txtCompanyType.BackColor = Color.FromArgb(74, 79, 99);
            txtCompanyType.Font = new Font("Microsoft Sans Serif", 9F);
            txtCompanyType.ForeColor = SystemColors.ScrollBar;
            txtCompanyType.Location = new Point(125, 222);
            txtCompanyType.Margin = new Padding(4, 3, 4, 3);
            txtCompanyType.Name = "txtCompanyType";
            txtCompanyType.PlaceholderText = "Company Type";
            txtCompanyType.Size = new Size(116, 21);
            txtCompanyType.TabIndex = 64;
            txtCompanyType.Tag = "Company Type";
            // 
            // txtCompanyContact
            // 
            txtCompanyContact.BackColor = Color.FromArgb(74, 79, 99);
            txtCompanyContact.Font = new Font("Microsoft Sans Serif", 9F);
            txtCompanyContact.ForeColor = SystemColors.ScrollBar;
            txtCompanyContact.Location = new Point(246, 222);
            txtCompanyContact.Margin = new Padding(4, 3, 4, 3);
            txtCompanyContact.Name = "txtCompanyContact";
            txtCompanyContact.PlaceholderText = "Company Contact";
            txtCompanyContact.Size = new Size(116, 21);
            txtCompanyContact.TabIndex = 65;
            txtCompanyContact.Tag = "Company Contact";
            // 
            // frmCreateCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 51, 73);
            ClientSize = new Size(547, 435);
            Controls.Add(txtCompanyContact);
            Controls.Add(txtCompanyType);
            Controls.Add(txtCompanyName);
            Controls.Add(txtNationality);
            Controls.Add(txtStatus);
            Controls.Add(txtDateOfBirth);
            Controls.Add(txtSex);
            Controls.Add(txtSalutation);
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
            Controls.Add(btnCreateNewCustomer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCreateCustomer";
            Text = "frmCreateCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCreateNewCustomer;
        private ComboBox txtNationality;
        private ComboBox txtStatus;
        private DateTimePicker txtDateOfBirth;
        private ComboBox txtSex;
        private ComboBox txtSalutation;
        private TextBox txtPlace;
        private TextBox txtZipCode;
        private TextBox txtStreetNumber;
        private TextBox txtStreet;
        private TextBox txtEmail;
        private TextBox txtPhoneNumberBusiness;
        private TextBox txtPhoneNumberMobile;
        private TextBox txtPhoneNumberPrivate;
        private TextBox txtTitle;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtSocialSecurityNumber;
        private TextBox txtCompanyName;
        private TextBox txtCompanyType;
        private TextBox txtCompanyContact;
    }
}