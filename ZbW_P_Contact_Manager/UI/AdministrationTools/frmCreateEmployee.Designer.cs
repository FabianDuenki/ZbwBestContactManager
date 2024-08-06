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
            txtStatus = new TextBox();
            txtNationality = new TextBox();
            txtStreet = new TextBox();
            txtStreetNumber = new TextBox();
            txtZipCode = new TextBox();
            txtPlace = new TextBox();
            txtDepartement = new TextBox();
            txtStartDate = new TextBox();
            txtEndDate = new TextBox();
            txtEmployment = new TextBox();
            txtRole = new TextBox();
            txtCadreLevel = new TextBox();
            btnCreateNewEmployee = new Button();
            txtSalutation = new ComboBox();
            txtSex = new ComboBox();
            txtDateOfBirth = new DateTimePicker();
            textBoxInput = new TextBox();
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
            txtFirstName.Size = new Size(116, 21);
            txtFirstName.TabIndex = 22;
            txtFirstName.Tag = " ";
            txtFirstName.Text = "FirstName";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(74, 79, 99);
            txtLastName.Font = new Font("Microsoft Sans Serif", 9F);
            txtLastName.ForeColor = SystemColors.ScrollBar;
            txtLastName.Location = new Point(254, 4);
            txtLastName.Margin = new Padding(4, 3, 4, 3);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(116, 21);
            txtLastName.TabIndex = 23;
            txtLastName.Tag = " ";
            txtLastName.Text = "LastName";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(74, 79, 99);
            txtTitle.Font = new Font("Microsoft Sans Serif", 9F);
            txtTitle.ForeColor = SystemColors.ScrollBar;
            txtTitle.Location = new Point(78, 4);
            txtTitle.Margin = new Padding(4, 3, 4, 3);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(53, 21);
            txtTitle.TabIndex = 21;
            txtTitle.Tag = " ";
            txtTitle.Text = "Title";
            // 
            // txtSocialSecurityNumber
            // 
            txtSocialSecurityNumber.BackColor = Color.FromArgb(74, 79, 99);
            txtSocialSecurityNumber.Font = new Font("Microsoft Sans Serif", 9F);
            txtSocialSecurityNumber.ForeColor = SystemColors.ScrollBar;
            txtSocialSecurityNumber.Location = new Point(14, 84);
            txtSocialSecurityNumber.Margin = new Padding(4, 3, 4, 3);
            txtSocialSecurityNumber.Name = "txtSocialSecurityNumber";
            txtSocialSecurityNumber.Size = new Size(130, 21);
            txtSocialSecurityNumber.TabIndex = 30;
            txtSocialSecurityNumber.Tag = " ";
            txtSocialSecurityNumber.Text = "SocialSecurityNumber";
            txtSocialSecurityNumber.TextChanged += txtSocialSecurityNumber_TextChanged;
            txtSocialSecurityNumber.KeyPress += txtSocialSecurityNumber_KeyPress;
            // 
            // txtPhoneNumberPrivate
            // 
            txtPhoneNumberPrivate.BackColor = Color.FromArgb(74, 79, 99);
            txtPhoneNumberPrivate.Font = new Font("Microsoft Sans Serif", 9F);
            txtPhoneNumberPrivate.ForeColor = SystemColors.ScrollBar;
            txtPhoneNumberPrivate.Location = new Point(152, 84);
            txtPhoneNumberPrivate.Margin = new Padding(4, 3, 4, 3);
            txtPhoneNumberPrivate.Name = "txtPhoneNumberPrivate";
            txtPhoneNumberPrivate.Size = new Size(116, 21);
            txtPhoneNumberPrivate.TabIndex = 31;
            txtPhoneNumberPrivate.Tag = " ";
            txtPhoneNumberPrivate.Text = "PhoneNumberPrivate";
            // 
            // txtPhoneNumberMobile
            // 
            txtPhoneNumberMobile.BackColor = Color.FromArgb(74, 79, 99);
            txtPhoneNumberMobile.Font = new Font("Microsoft Sans Serif", 9F);
            txtPhoneNumberMobile.ForeColor = SystemColors.ScrollBar;
            txtPhoneNumberMobile.Location = new Point(276, 84);
            txtPhoneNumberMobile.Margin = new Padding(4, 3, 4, 3);
            txtPhoneNumberMobile.Name = "txtPhoneNumberMobile";
            txtPhoneNumberMobile.Size = new Size(116, 21);
            txtPhoneNumberMobile.TabIndex = 32;
            txtPhoneNumberMobile.Tag = " ";
            txtPhoneNumberMobile.Text = "PhoneNumberMobile";
            // 
            // txtPhoneNumberBusiness
            // 
            txtPhoneNumberBusiness.BackColor = Color.FromArgb(74, 79, 99);
            txtPhoneNumberBusiness.Font = new Font("Microsoft Sans Serif", 9F);
            txtPhoneNumberBusiness.ForeColor = SystemColors.ScrollBar;
            txtPhoneNumberBusiness.Location = new Point(400, 84);
            txtPhoneNumberBusiness.Margin = new Padding(4, 3, 4, 3);
            txtPhoneNumberBusiness.Name = "txtPhoneNumberBusiness";
            txtPhoneNumberBusiness.Size = new Size(116, 21);
            txtPhoneNumberBusiness.TabIndex = 33;
            txtPhoneNumberBusiness.Tag = " ";
            txtPhoneNumberBusiness.Text = "PhoneNumberBusiness ";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(74, 79, 99);
            txtEmail.Font = new Font("Microsoft Sans Serif", 9F);
            txtEmail.ForeColor = SystemColors.ScrollBar;
            txtEmail.Location = new Point(13, 111);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(116, 21);
            txtEmail.TabIndex = 34;
            txtEmail.Tag = " ";
            txtEmail.Text = "Email";
            // 
            // txtStatus
            // 
            txtStatus.BackColor = Color.FromArgb(74, 79, 99);
            txtStatus.Font = new Font("Microsoft Sans Serif", 9F);
            txtStatus.ForeColor = SystemColors.ScrollBar;
            txtStatus.Location = new Point(2, 32);
            txtStatus.Margin = new Padding(4, 3, 4, 3);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(116, 21);
            txtStatus.TabIndex = 26;
            txtStatus.Tag = " ";
            txtStatus.Text = "Status";
            // 
            // txtNationality
            // 
            txtNationality.BackColor = Color.FromArgb(74, 79, 99);
            txtNationality.Font = new Font("Microsoft Sans Serif", 9F);
            txtNationality.ForeColor = SystemColors.ScrollBar;
            txtNationality.Location = new Point(126, 32);
            txtNationality.Margin = new Padding(4, 3, 4, 3);
            txtNationality.Name = "txtNationality";
            txtNationality.Size = new Size(116, 21);
            txtNationality.TabIndex = 27;
            txtNationality.Tag = " ";
            txtNationality.Text = "Nationality";
            // 
            // txtStreet
            // 
            txtStreet.BackColor = Color.FromArgb(74, 79, 99);
            txtStreet.Font = new Font("Microsoft Sans Serif", 9F);
            txtStreet.ForeColor = SystemColors.ScrollBar;
            txtStreet.Location = new Point(14, 176);
            txtStreet.Margin = new Padding(4, 3, 4, 3);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(116, 21);
            txtStreet.TabIndex = 35;
            txtStreet.Tag = " ";
            txtStreet.Text = "Street";
            // 
            // txtStreetNumber
            // 
            txtStreetNumber.BackColor = Color.FromArgb(74, 79, 99);
            txtStreetNumber.Font = new Font("Microsoft Sans Serif", 9F);
            txtStreetNumber.ForeColor = SystemColors.ScrollBar;
            txtStreetNumber.Location = new Point(137, 176);
            txtStreetNumber.Margin = new Padding(4, 3, 4, 3);
            txtStreetNumber.Name = "txtStreetNumber";
            txtStreetNumber.Size = new Size(116, 21);
            txtStreetNumber.TabIndex = 36;
            txtStreetNumber.Tag = " ";
            txtStreetNumber.Text = "StreetNumber";
            // 
            // txtZipCode
            // 
            txtZipCode.BackColor = Color.FromArgb(74, 79, 99);
            txtZipCode.Font = new Font("Microsoft Sans Serif", 9F);
            txtZipCode.ForeColor = SystemColors.ScrollBar;
            txtZipCode.Location = new Point(261, 176);
            txtZipCode.Margin = new Padding(4, 3, 4, 3);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(116, 21);
            txtZipCode.TabIndex = 37;
            txtZipCode.Tag = " ";
            txtZipCode.Text = "ZipCode";
            // 
            // txtPlace
            // 
            txtPlace.BackColor = Color.FromArgb(74, 79, 99);
            txtPlace.Font = new Font("Microsoft Sans Serif", 9F);
            txtPlace.ForeColor = SystemColors.ScrollBar;
            txtPlace.Location = new Point(385, 176);
            txtPlace.Margin = new Padding(4, 3, 4, 3);
            txtPlace.Name = "txtPlace";
            txtPlace.Size = new Size(116, 21);
            txtPlace.TabIndex = 38;
            txtPlace.Tag = " ";
            txtPlace.Text = "Place";
            // 
            // txtDepartement
            // 
            txtDepartement.BackColor = Color.FromArgb(74, 79, 99);
            txtDepartement.Font = new Font("Microsoft Sans Serif", 9F);
            txtDepartement.ForeColor = SystemColors.ScrollBar;
            txtDepartement.Location = new Point(13, 282);
            txtDepartement.Margin = new Padding(4, 3, 4, 3);
            txtDepartement.Name = "txtDepartement";
            txtDepartement.Size = new Size(116, 21);
            txtDepartement.TabIndex = 43;
            txtDepartement.Tag = " ";
            txtDepartement.Text = "Departement";
            // 
            // txtStartDate
            // 
            txtStartDate.BackColor = Color.FromArgb(74, 79, 99);
            txtStartDate.Font = new Font("Microsoft Sans Serif", 9F);
            txtStartDate.ForeColor = SystemColors.ScrollBar;
            txtStartDate.Location = new Point(13, 242);
            txtStartDate.Margin = new Padding(4, 3, 4, 3);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Size = new Size(116, 21);
            txtStartDate.TabIndex = 40;
            txtStartDate.Tag = " ";
            txtStartDate.Text = "StartDate";
            // 
            // txtEndDate
            // 
            txtEndDate.BackColor = Color.FromArgb(74, 79, 99);
            txtEndDate.Font = new Font("Microsoft Sans Serif", 9F);
            txtEndDate.ForeColor = SystemColors.ScrollBar;
            txtEndDate.Location = new Point(134, 242);
            txtEndDate.Margin = new Padding(4, 3, 4, 3);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.Size = new Size(116, 21);
            txtEndDate.TabIndex = 41;
            txtEndDate.Tag = " ";
            txtEndDate.Text = "EndDate";
            // 
            // txtEmployment
            // 
            txtEmployment.BackColor = Color.FromArgb(74, 79, 99);
            txtEmployment.Font = new Font("Microsoft Sans Serif", 9F);
            txtEmployment.ForeColor = SystemColors.ScrollBar;
            txtEmployment.Location = new Point(254, 242);
            txtEmployment.Margin = new Padding(4, 3, 4, 3);
            txtEmployment.Name = "txtEmployment";
            txtEmployment.Size = new Size(116, 21);
            txtEmployment.TabIndex = 42;
            txtEmployment.Tag = " ";
            txtEmployment.Text = "Employment";
            // 
            // txtRole
            // 
            txtRole.BackColor = Color.FromArgb(74, 79, 99);
            txtRole.Font = new Font("Microsoft Sans Serif", 9F);
            txtRole.ForeColor = SystemColors.ScrollBar;
            txtRole.Location = new Point(134, 282);
            txtRole.Margin = new Padding(4, 3, 4, 3);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(116, 21);
            txtRole.TabIndex = 44;
            txtRole.Tag = " ";
            txtRole.Text = "Role";
            // 
            // txtCadreLevel
            // 
            txtCadreLevel.BackColor = Color.FromArgb(74, 79, 99);
            txtCadreLevel.Font = new Font("Microsoft Sans Serif", 9F);
            txtCadreLevel.ForeColor = SystemColors.ScrollBar;
            txtCadreLevel.Location = new Point(254, 282);
            txtCadreLevel.Margin = new Padding(4, 3, 4, 3);
            txtCadreLevel.Name = "txtCadreLevel";
            txtCadreLevel.Size = new Size(116, 21);
            txtCadreLevel.TabIndex = 45;
            txtCadreLevel.Tag = " ";
            txtCadreLevel.Text = "CadreLevel";
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
            txtSalutation.FormattingEnabled = true;
            txtSalutation.Items.AddRange(new object[] { "Mr.", "Ms.", "Mrs." });
            txtSalutation.Location = new Point(2, 3);
            txtSalutation.Margin = new Padding(4, 3, 4, 3);
            txtSalutation.Name = "txtSalutation";
            txtSalutation.Size = new Size(74, 23);
            txtSalutation.TabIndex = 20;
            txtSalutation.Text = "Salutation";
            // 
            // txtSex
            // 
            txtSex.FormattingEnabled = true;
            txtSex.Items.AddRange(new object[] { "Male", "Female" });
            txtSex.Location = new Point(374, 3);
            txtSex.Margin = new Padding(4, 3, 4, 3);
            txtSex.Name = "txtSex";
            txtSex.Size = new Size(76, 23);
            txtSex.TabIndex = 24;
            txtSex.Text = "Sex";
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Format = DateTimePickerFormat.Short;
            txtDateOfBirth.Location = new Point(452, 3);
            txtDateOfBirth.Margin = new Padding(4, 3, 4, 3);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.RightToLeft = RightToLeft.Yes;
            txtDateOfBirth.ShowUpDown = true;
            txtDateOfBirth.Size = new Size(93, 23);
            txtDateOfBirth.TabIndex = 25;
            txtDateOfBirth.Value = new DateTime(2024, 8, 7, 0, 0, 0, 0);
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(0, 0);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(100, 23);
            textBoxInput.TabIndex = 0;
            // 
            // frmCreateEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 51, 73);
            ClientSize = new Size(547, 435);
            Controls.Add(txtDateOfBirth);
            Controls.Add(txtSex);
            Controls.Add(txtSalutation);
            Controls.Add(btnCreateNewEmployee);
            Controls.Add(txtCadreLevel);
            Controls.Add(txtRole);
            Controls.Add(txtEmployment);
            Controls.Add(txtEndDate);
            Controls.Add(txtStartDate);
            Controls.Add(txtDepartement);
            Controls.Add(txtPlace);
            Controls.Add(txtZipCode);
            Controls.Add(txtStreetNumber);
            Controls.Add(txtStreet);
            Controls.Add(txtNationality);
            Controls.Add(txtStatus);
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
        private TextBox txtStatus;
        private TextBox txtNationality;
        private TextBox txtStreet;
        private TextBox txtStreetNumber;
        private TextBox txtZipCode;
        private TextBox txtPlace;
        private TextBox txtDepartement;
        private TextBox txtStartDate;
        private TextBox txtEndDate;
        private TextBox txtEmployment;
        private TextBox txtRole;
        private TextBox txtCadreLevel;
        private Button btnCreateNewEmployee;
        private ComboBox txtSalutation;
        private ComboBox txtSex;
        private DateTimePicker txtDateOfBirth;
        private System.Windows.Forms.TextBox textBoxInput;
    }
}