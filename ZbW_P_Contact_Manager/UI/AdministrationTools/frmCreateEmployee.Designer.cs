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
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)txtCadreLevel).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(227, 234, 234);
            txtFirstName.Font = new Font("Microsoft Sans Serif", 9F);
            txtFirstName.ForeColor = Color.Black;
            txtFirstName.Location = new Point(497, 6);
            txtFirstName.Margin = new Padding(7, 6, 7, 6);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First Name";
            txtFirstName.Size = new Size(212, 35);
            txtFirstName.TabIndex = 22;
            txtFirstName.Tag = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(227, 234, 234);
            txtLastName.Font = new Font("Microsoft Sans Serif", 9F);
            txtLastName.ForeColor = Color.Black;
            txtLastName.Location = new Point(723, 6);
            txtLastName.Margin = new Padding(7, 6, 7, 6);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last Name";
            txtLastName.Size = new Size(212, 35);
            txtLastName.TabIndex = 23;
            txtLastName.Tag = "Last Name";
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(227, 234, 234);
            txtTitle.Font = new Font("Microsoft Sans Serif", 9F);
            txtTitle.ForeColor = Color.Black;
            txtTitle.Location = new Point(388, 6);
            txtTitle.Margin = new Padding(7, 6, 7, 6);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Title";
            txtTitle.Size = new Size(95, 35);
            txtTitle.TabIndex = 21;
            txtTitle.Tag = "";
            // 
            // txtSocialSecurityNumber
            // 
            txtSocialSecurityNumber.BackColor = Color.FromArgb(227, 234, 234);
            txtSocialSecurityNumber.Font = new Font("Microsoft Sans Serif", 9F);
            txtSocialSecurityNumber.ForeColor = Color.Black;
            txtSocialSecurityNumber.Location = new Point(7, 55);
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
            txtPhoneNumberPrivate.BackColor = Color.FromArgb(227, 234, 234);
            txtPhoneNumberPrivate.Font = new Font("Microsoft Sans Serif", 9F);
            txtPhoneNumberPrivate.ForeColor = Color.Black;
            txtPhoneNumberPrivate.Location = new Point(801, 6);
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
            txtPhoneNumberMobile.BackColor = Color.FromArgb(227, 234, 234);
            txtPhoneNumberMobile.Font = new Font("Microsoft Sans Serif", 9F);
            txtPhoneNumberMobile.ForeColor = Color.Black;
            txtPhoneNumberMobile.Location = new Point(517, 6);
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
            txtPhoneNumberBusiness.BackColor = Color.FromArgb(227, 234, 234);
            txtPhoneNumberBusiness.Font = new Font("Microsoft Sans Serif", 9F);
            txtPhoneNumberBusiness.ForeColor = Color.Black;
            txtPhoneNumberBusiness.Location = new Point(233, 6);
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
            txtEmail.BackColor = Color.FromArgb(227, 234, 234);
            txtEmail.Font = new Font("Microsoft Sans Serif", 9F);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(1085, 6);
            txtEmail.Margin = new Padding(7, 6, 7, 6);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(403, 35);
            txtEmail.TabIndex = 34;
            txtEmail.Tag = "Email";
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtStreet
            // 
            txtStreet.BackColor = Color.FromArgb(227, 234, 234);
            txtStreet.Font = new Font("Microsoft Sans Serif", 9F);
            txtStreet.ForeColor = Color.Black;
            txtStreet.Location = new Point(7, 6);
            txtStreet.Margin = new Padding(7, 6, 7, 6);
            txtStreet.Name = "txtStreet";
            txtStreet.PlaceholderText = "Street";
            txtStreet.Size = new Size(212, 35);
            txtStreet.TabIndex = 35;
            txtStreet.Tag = "Street";
            // 
            // txtStreetNumber
            // 
            txtStreetNumber.BackColor = Color.FromArgb(227, 234, 234);
            txtStreetNumber.Font = new Font("Microsoft Sans Serif", 9F);
            txtStreetNumber.ForeColor = Color.Black;
            txtStreetNumber.Location = new Point(349, 53);
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
            txtZipCode.BackColor = Color.FromArgb(227, 234, 234);
            txtZipCode.Font = new Font("Microsoft Sans Serif", 9F);
            txtZipCode.ForeColor = Color.Black;
            txtZipCode.Location = new Point(7, 53);
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
            txtPlace.BackColor = Color.FromArgb(227, 234, 234);
            txtPlace.Font = new Font("Microsoft Sans Serif", 9F);
            txtPlace.ForeColor = Color.Black;
            txtPlace.Location = new Point(123, 53);
            txtPlace.Margin = new Padding(7, 6, 7, 6);
            txtPlace.Name = "txtPlace";
            txtPlace.PlaceholderText = "Place";
            txtPlace.Size = new Size(212, 35);
            txtPlace.TabIndex = 38;
            txtPlace.Tag = "Place";
            // 
            // btnCreateNewEmployee
            // 
            btnCreateNewEmployee.ForeColor = Color.Black;
            btnCreateNewEmployee.Location = new Point(1255, 982);
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
            txtSalutation.Location = new Point(240, 6);
            txtSalutation.Margin = new Padding(7, 6, 7, 6);
            txtSalutation.Name = "txtSalutation";
            txtSalutation.Size = new Size(134, 37);
            txtSalutation.TabIndex = 20;
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
            txtSex.Location = new Point(949, 6);
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
            txtDateOfBirth.Location = new Point(313, 55);
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
            txtStatus.BackColor = Color.FromArgb(227, 234, 234);
            txtStatus.FlatStyle = FlatStyle.System;
            txtStatus.Font = new Font("Microsoft Sans Serif", 9F);
            txtStatus.ForeColor = Color.Black;
            txtStatus.FormattingEnabled = true;
            txtStatus.Items.AddRange(new object[] { "active", "inactive" });
            txtStatus.Location = new Point(6, 6);
            txtStatus.Margin = new Padding(6);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(221, 37);
            txtStatus.TabIndex = 26;
            txtStatus.Tag = "Status";
            txtStatus.Text = "Status";
            // 
            // txtNationality
            // 
            txtNationality.BackColor = Color.FromArgb(227, 234, 234);
            txtNationality.FlatStyle = FlatStyle.Flat;
            txtNationality.Font = new Font("Microsoft Sans Serif", 9F);
            txtNationality.ForeColor = Color.Black;
            txtNationality.FormattingEnabled = true;
            txtNationality.Items.AddRange(new object[] { "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "The Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso", "Burundi", "Cabo Verde", "Cambodia", "Cameroon", "Canada", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo, Democratic Republic of the", "Congo, Republic of the", "Costa Rica", "Côte d’Ivoire", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor (Timor-Leste)", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "The Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea, North", "Korea, South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia, Federated States of", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar (Burma)", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "North Macedonia", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "Spain", "Sri Lanka", "Sudan", "Sudan, South", "Suriname", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe" });
            txtNationality.Location = new Point(1100, 6);
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
            txtStartDate.Location = new Point(1080, 6);
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
            txtEndDate.Location = new Point(7, 6);
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
            txtEmployment.BackColor = Color.FromArgb(227, 234, 234);
            txtEmployment.FlatStyle = FlatStyle.Flat;
            txtEmployment.Font = new Font("Microsoft Sans Serif", 9F);
            txtEmployment.ForeColor = Color.Black;
            txtEmployment.FormattingEnabled = true;
            txtEmployment.Items.AddRange(new object[] { "Full-time employment", "Part-time employment", "Apprenticeship", "Traineeship", "Internship", "Casual employment", "Employment on commission", "Contract employment", "Probation", "Seasonal employment", "Leased employment", "Contingent employment" });
            txtEmployment.Location = new Point(846, 6);
            txtEmployment.Margin = new Padding(6);
            txtEmployment.Name = "txtEmployment";
            txtEmployment.Size = new Size(221, 37);
            txtEmployment.TabIndex = 43;
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
            txtDepartment.Location = new Point(635, 6);
            txtDepartment.Margin = new Padding(6);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(199, 37);
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
            txtRole.Location = new Point(424, 6);
            txtRole.Margin = new Padding(6);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(199, 37);
            txtRole.TabIndex = 44;
            txtRole.Tag = "Role";
            txtRole.Text = "Role";
            // 
            // txtCadreLevel
            // 
            txtCadreLevel.Location = new Point(189, 6);
            txtCadreLevel.Margin = new Padding(6);
            txtCadreLevel.Name = "txtCadreLevel";
            txtCadreLevel.Size = new Size(223, 39);
            txtCadreLevel.TabIndex = 45;
            txtCadreLevel.Tag = "Cadre Level";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(txtStatus);
            flowLayoutPanel1.Controls.Add(txtSalutation);
            flowLayoutPanel1.Controls.Add(txtTitle);
            flowLayoutPanel1.Controls.Add(txtFirstName);
            flowLayoutPanel1.Controls.Add(txtLastName);
            flowLayoutPanel1.Controls.Add(txtSex);
            flowLayoutPanel1.Controls.Add(txtNationality);
            flowLayoutPanel1.Controls.Add(txtSocialSecurityNumber);
            flowLayoutPanel1.Controls.Add(txtDateOfBirth);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1576, 271);
            flowLayoutPanel1.TabIndex = 101;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(txtStreet);
            flowLayoutPanel2.Controls.Add(txtPhoneNumberBusiness);
            flowLayoutPanel2.Controls.Add(txtPhoneNumberMobile);
            flowLayoutPanel2.Controls.Add(txtPhoneNumberPrivate);
            flowLayoutPanel2.Controls.Add(txtEmail);
            flowLayoutPanel2.Controls.Add(txtZipCode);
            flowLayoutPanel2.Controls.Add(txtPlace);
            flowLayoutPanel2.Controls.Add(txtStreetNumber);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 271);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1576, 285);
            flowLayoutPanel2.TabIndex = 102;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(txtEndDate);
            flowLayoutPanel3.Controls.Add(txtCadreLevel);
            flowLayoutPanel3.Controls.Add(txtRole);
            flowLayoutPanel3.Controls.Add(txtDepartment);
            flowLayoutPanel3.Controls.Add(txtEmployment);
            flowLayoutPanel3.Controls.Add(txtStartDate);
            flowLayoutPanel3.Dock = DockStyle.Top;
            flowLayoutPanel3.Location = new Point(0, 556);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(1576, 200);
            flowLayoutPanel3.TabIndex = 103;
            // 
            // frmCreateEmployee
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 49, 51);
            ClientSize = new Size(1576, 1070);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnCreateNewEmployee);
            ForeColor = Color.White;
            Margin = new Padding(7, 6, 7, 6);
            Name = "frmCreateEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Input Format Example";
            ((System.ComponentModel.ISupportInitialize)txtCadreLevel).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
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
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
    }
}