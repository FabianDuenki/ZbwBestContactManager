namespace ZbW_P_Contact_Manager.UI.AdministrationTools
{
    partial class FrmSearchUser
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            numEmployment = new NumericUpDown();
            lblZipCode = new Label();
            lblPlace = new Label();
            lblStreetNumber = new Label();
            txtStreetNumber = new TextBox();
            numZipCode = new NumericUpDown();
            btnCompanyContactEdit = new CheckBox();
            btnCompanyTypeEdit = new CheckBox();
            btnCompanyNameEdit = new CheckBox();
            panel5 = new Panel();
            txtCompanyContact = new TextBox();
            txtCompanyType = new TextBox();
            txtCompanyName = new TextBox();
            lblCompanyContact = new Label();
            lblCompanyType = new Label();
            lblCompanyName = new Label();
            btnActualTraineeYearEdit = new CheckBox();
            btnTraineeYearsEdit = new CheckBox();
            btnCadreLevelEdit = new CheckBox();
            btnRoleEdit = new CheckBox();
            btnDepartementEdit = new CheckBox();
            btnEmplyomentTypeEdit = new CheckBox();
            btnStartEndDateEdit = new CheckBox();
            btnEmailEdit = new CheckBox();
            btnPhoneNumberBusinessEdit = new CheckBox();
            btnPhoneNumberPrivateEdit = new CheckBox();
            btnPhoneNumberMobileEdit = new CheckBox();
            btnAdressEdit = new CheckBox();
            btnSexEdit = new CheckBox();
            btnLastNameEdit = new CheckBox();
            btnFirstNameEdit = new CheckBox();
            btnDateOfBirthEdit = new CheckBox();
            btnSocialSecurityNumberEdit = new CheckBox();
            btnNationalityEdit = new CheckBox();
            btnTitleEdit = new CheckBox();
            btnSalutationEdit = new CheckBox();
            checkBox1 = new CheckBox();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            lblActualTraineeYear = new Label();
            numActualTraineeYear = new NumericUpDown();
            lblTraineeYears = new Label();
            numTraineeYears = new NumericUpDown();
            lblRole = new Label();
            lblCadreLevel = new Label();
            lblDepartement = new Label();
            lblStartEndDate = new Label();
            lblEmploymentType = new Label();
            lblPhoneNumberBusiness = new Label();
            lblEmail = new Label();
            lblPhoneNumberPrivate = new Label();
            lblSocialSecurityNumber = new Label();
            lblDateOfBirth = new Label();
            lblAddress = new Label();
            lblPhoneNumberMobile = new Label();
            lblNationality = new Label();
            lblTitle = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblSex = new Label();
            lblSalutation = new Label();
            lblUserType = new Label();
            txtStreet = new TextBox();
            txtEndDate = new DateTimePicker();
            txtSalutation = new ComboBox();
            txtPhoneNumberBusiness = new TextBox();
            txtTitle = new TextBox();
            txtPhoneNumberMobile = new TextBox();
            txtFirstName = new TextBox();
            txtCadreLevel = new NumericUpDown();
            txtLastName = new TextBox();
            txtPhoneNumberPrivate = new TextBox();
            txtSex = new ComboBox();
            txtRole = new ComboBox();
            txtNationality = new ComboBox();
            txtEmail = new TextBox();
            txtSocialSecurityNumber = new TextBox();
            txtDateOfBirth = new DateTimePicker();
            txtDepartment = new ComboBox();
            txtPlace = new TextBox();
            btnSearchUser = new Button();
            txtStartDate = new DateTimePicker();
            optCustomer = new RadioButton();
            optEmployee = new RadioButton();
            optTrainee = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)numEmployment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numZipCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numActualTraineeYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTraineeYears).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCadreLevel).BeginInit();
            SuspendLayout();
            // 
            // numEmployment
            // 
            numEmployment.Location = new Point(207, 422);
            numEmployment.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            numEmployment.Name = "numEmployment";
            numEmployment.Size = new Size(182, 23);
            numEmployment.TabIndex = 345;
            // 
            // lblZipCode
            // 
            lblZipCode.AutoSize = true;
            lblZipCode.ForeColor = SystemColors.Control;
            lblZipCode.Location = new Point(109, 262);
            lblZipCode.Margin = new Padding(2, 0, 2, 0);
            lblZipCode.Name = "lblZipCode";
            lblZipCode.Size = new Size(63, 15);
            lblZipCode.TabIndex = 344;
            lblZipCode.Text = "Zip Code*:";
            // 
            // lblPlace
            // 
            lblPlace.AutoSize = true;
            lblPlace.ForeColor = SystemColors.Control;
            lblPlace.Location = new Point(45, 262);
            lblPlace.Margin = new Padding(2, 0, 2, 0);
            lblPlace.Name = "lblPlace";
            lblPlace.Size = new Size(43, 15);
            lblPlace.TabIndex = 343;
            lblPlace.Text = "Place*:";
            // 
            // lblStreetNumber
            // 
            lblStreetNumber.AutoSize = true;
            lblStreetNumber.ForeColor = SystemColors.Control;
            lblStreetNumber.Location = new Point(109, 234);
            lblStreetNumber.Margin = new Padding(2, 0, 2, 0);
            lblStreetNumber.Name = "lblStreetNumber";
            lblStreetNumber.Size = new Size(92, 15);
            lblStreetNumber.TabIndex = 342;
            lblStreetNumber.Text = "Street Number*:";
            // 
            // txtStreetNumber
            // 
            txtStreetNumber.BackColor = Color.FromArgb(227, 234, 234);
            txtStreetNumber.Font = new Font("Microsoft Sans Serif", 9F);
            txtStreetNumber.ForeColor = Color.Black;
            txtStreetNumber.Location = new Point(396, 234);
            txtStreetNumber.Margin = new Padding(4, 3, 4, 3);
            txtStreetNumber.Name = "txtStreetNumber";
            txtStreetNumber.PlaceholderText = "Street Number";
            txtStreetNumber.Size = new Size(104, 21);
            txtStreetNumber.TabIndex = 341;
            txtStreetNumber.Tag = "Street";
            // 
            // numZipCode
            // 
            numZipCode.Location = new Point(396, 262);
            numZipCode.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            numZipCode.Name = "numZipCode";
            numZipCode.Size = new Size(104, 23);
            numZipCode.TabIndex = 340;
            // 
            // btnCompanyContactEdit
            // 
            btnCompanyContactEdit.AutoSize = true;
            btnCompanyContactEdit.Location = new Point(26, 634);
            btnCompanyContactEdit.Margin = new Padding(2, 1, 2, 1);
            btnCompanyContactEdit.Name = "btnCompanyContactEdit";
            btnCompanyContactEdit.Size = new Size(15, 14);
            btnCompanyContactEdit.TabIndex = 339;
            btnCompanyContactEdit.UseVisualStyleBackColor = true;
            // 
            // btnCompanyTypeEdit
            // 
            btnCompanyTypeEdit.AutoSize = true;
            btnCompanyTypeEdit.Location = new Point(26, 611);
            btnCompanyTypeEdit.Margin = new Padding(2, 1, 2, 1);
            btnCompanyTypeEdit.Name = "btnCompanyTypeEdit";
            btnCompanyTypeEdit.Size = new Size(15, 14);
            btnCompanyTypeEdit.TabIndex = 338;
            btnCompanyTypeEdit.UseVisualStyleBackColor = true;
            // 
            // btnCompanyNameEdit
            // 
            btnCompanyNameEdit.AutoSize = true;
            btnCompanyNameEdit.Location = new Point(26, 588);
            btnCompanyNameEdit.Margin = new Padding(2, 1, 2, 1);
            btnCompanyNameEdit.Name = "btnCompanyNameEdit";
            btnCompanyNameEdit.Size = new Size(15, 14);
            btnCompanyNameEdit.TabIndex = 337;
            btnCompanyNameEdit.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(122, 148, 150);
            panel5.Location = new Point(44, 579);
            panel5.Margin = new Padding(2, 1, 2, 1);
            panel5.Name = "panel5";
            panel5.Size = new Size(485, 2);
            panel5.TabIndex = 336;
            // 
            // txtCompanyContact
            // 
            txtCompanyContact.BackColor = Color.FromArgb(227, 234, 234);
            txtCompanyContact.Font = new Font("Microsoft Sans Serif", 9F);
            txtCompanyContact.ForeColor = Color.Black;
            txtCompanyContact.Location = new Point(206, 634);
            txtCompanyContact.Margin = new Padding(4, 3, 4, 3);
            txtCompanyContact.Name = "txtCompanyContact";
            txtCompanyContact.PlaceholderText = "Company Contact";
            txtCompanyContact.Size = new Size(182, 21);
            txtCompanyContact.TabIndex = 335;
            txtCompanyContact.Tag = "Company Contact";
            // 
            // txtCompanyType
            // 
            txtCompanyType.BackColor = Color.FromArgb(227, 234, 234);
            txtCompanyType.Font = new Font("Microsoft Sans Serif", 9F);
            txtCompanyType.ForeColor = Color.Black;
            txtCompanyType.Location = new Point(206, 610);
            txtCompanyType.Margin = new Padding(4, 3, 4, 3);
            txtCompanyType.Name = "txtCompanyType";
            txtCompanyType.PlaceholderText = "Company Type";
            txtCompanyType.Size = new Size(182, 21);
            txtCompanyType.TabIndex = 334;
            txtCompanyType.Tag = "Company Type";
            // 
            // txtCompanyName
            // 
            txtCompanyName.BackColor = Color.FromArgb(227, 234, 234);
            txtCompanyName.Font = new Font("Microsoft Sans Serif", 9F);
            txtCompanyName.ForeColor = Color.Black;
            txtCompanyName.Location = new Point(206, 587);
            txtCompanyName.Margin = new Padding(4, 3, 4, 3);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.PlaceholderText = "Company Name";
            txtCompanyName.Size = new Size(182, 21);
            txtCompanyName.TabIndex = 333;
            txtCompanyName.Tag = "Company Name";
            // 
            // lblCompanyContact
            // 
            lblCompanyContact.AutoSize = true;
            lblCompanyContact.ForeColor = SystemColors.Control;
            lblCompanyContact.Location = new Point(44, 634);
            lblCompanyContact.Margin = new Padding(2, 0, 2, 0);
            lblCompanyContact.Name = "lblCompanyContact";
            lblCompanyContact.Size = new Size(112, 15);
            lblCompanyContact.TabIndex = 332;
            lblCompanyContact.Text = "Company Contact*:";
            // 
            // lblCompanyType
            // 
            lblCompanyType.AutoSize = true;
            lblCompanyType.ForeColor = SystemColors.Control;
            lblCompanyType.Location = new Point(44, 610);
            lblCompanyType.Margin = new Padding(2, 0, 2, 0);
            lblCompanyType.Name = "lblCompanyType";
            lblCompanyType.Size = new Size(94, 15);
            lblCompanyType.TabIndex = 331;
            lblCompanyType.Text = "Company Type*:";
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.ForeColor = SystemColors.Control;
            lblCompanyName.Location = new Point(44, 587);
            lblCompanyName.Margin = new Padding(2, 0, 2, 0);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(102, 15);
            lblCompanyName.TabIndex = 330;
            lblCompanyName.Text = "Company Name*:";
            // 
            // btnActualTraineeYearEdit
            // 
            btnActualTraineeYearEdit.AutoSize = true;
            btnActualTraineeYearEdit.Location = new Point(26, 552);
            btnActualTraineeYearEdit.Margin = new Padding(2, 1, 2, 1);
            btnActualTraineeYearEdit.Name = "btnActualTraineeYearEdit";
            btnActualTraineeYearEdit.Size = new Size(15, 14);
            btnActualTraineeYearEdit.TabIndex = 329;
            btnActualTraineeYearEdit.UseVisualStyleBackColor = true;
            // 
            // btnTraineeYearsEdit
            // 
            btnTraineeYearsEdit.AutoSize = true;
            btnTraineeYearsEdit.Location = new Point(26, 529);
            btnTraineeYearsEdit.Margin = new Padding(2, 1, 2, 1);
            btnTraineeYearsEdit.Name = "btnTraineeYearsEdit";
            btnTraineeYearsEdit.Size = new Size(15, 14);
            btnTraineeYearsEdit.TabIndex = 328;
            btnTraineeYearsEdit.UseVisualStyleBackColor = true;
            // 
            // btnCadreLevelEdit
            // 
            btnCadreLevelEdit.AutoSize = true;
            btnCadreLevelEdit.Location = new Point(26, 495);
            btnCadreLevelEdit.Margin = new Padding(2, 1, 2, 1);
            btnCadreLevelEdit.Name = "btnCadreLevelEdit";
            btnCadreLevelEdit.Size = new Size(15, 14);
            btnCadreLevelEdit.TabIndex = 327;
            btnCadreLevelEdit.UseVisualStyleBackColor = true;
            // 
            // btnRoleEdit
            // 
            btnRoleEdit.AutoSize = true;
            btnRoleEdit.Location = new Point(26, 471);
            btnRoleEdit.Margin = new Padding(2, 1, 2, 1);
            btnRoleEdit.Name = "btnRoleEdit";
            btnRoleEdit.Size = new Size(15, 14);
            btnRoleEdit.TabIndex = 326;
            btnRoleEdit.UseVisualStyleBackColor = true;
            // 
            // btnDepartementEdit
            // 
            btnDepartementEdit.AutoSize = true;
            btnDepartementEdit.Location = new Point(26, 448);
            btnDepartementEdit.Margin = new Padding(2, 1, 2, 1);
            btnDepartementEdit.Name = "btnDepartementEdit";
            btnDepartementEdit.Size = new Size(15, 14);
            btnDepartementEdit.TabIndex = 325;
            btnDepartementEdit.UseVisualStyleBackColor = true;
            // 
            // btnEmplyomentTypeEdit
            // 
            btnEmplyomentTypeEdit.AutoSize = true;
            btnEmplyomentTypeEdit.Location = new Point(26, 425);
            btnEmplyomentTypeEdit.Margin = new Padding(2, 1, 2, 1);
            btnEmplyomentTypeEdit.Name = "btnEmplyomentTypeEdit";
            btnEmplyomentTypeEdit.Size = new Size(15, 14);
            btnEmplyomentTypeEdit.TabIndex = 324;
            btnEmplyomentTypeEdit.UseVisualStyleBackColor = true;
            // 
            // btnStartEndDateEdit
            // 
            btnStartEndDateEdit.AutoSize = true;
            btnStartEndDateEdit.Location = new Point(26, 402);
            btnStartEndDateEdit.Margin = new Padding(2, 1, 2, 1);
            btnStartEndDateEdit.Name = "btnStartEndDateEdit";
            btnStartEndDateEdit.Size = new Size(15, 14);
            btnStartEndDateEdit.TabIndex = 323;
            btnStartEndDateEdit.UseVisualStyleBackColor = true;
            // 
            // btnEmailEdit
            // 
            btnEmailEdit.AutoSize = true;
            btnEmailEdit.Location = new Point(26, 372);
            btnEmailEdit.Margin = new Padding(2, 1, 2, 1);
            btnEmailEdit.Name = "btnEmailEdit";
            btnEmailEdit.Size = new Size(15, 14);
            btnEmailEdit.TabIndex = 322;
            btnEmailEdit.UseVisualStyleBackColor = true;
            // 
            // btnPhoneNumberBusinessEdit
            // 
            btnPhoneNumberBusinessEdit.AutoSize = true;
            btnPhoneNumberBusinessEdit.Location = new Point(26, 349);
            btnPhoneNumberBusinessEdit.Margin = new Padding(2, 1, 2, 1);
            btnPhoneNumberBusinessEdit.Name = "btnPhoneNumberBusinessEdit";
            btnPhoneNumberBusinessEdit.Size = new Size(15, 14);
            btnPhoneNumberBusinessEdit.TabIndex = 321;
            btnPhoneNumberBusinessEdit.UseVisualStyleBackColor = true;
            // 
            // btnPhoneNumberPrivateEdit
            // 
            btnPhoneNumberPrivateEdit.AutoSize = true;
            btnPhoneNumberPrivateEdit.Location = new Point(26, 326);
            btnPhoneNumberPrivateEdit.Margin = new Padding(2, 1, 2, 1);
            btnPhoneNumberPrivateEdit.Name = "btnPhoneNumberPrivateEdit";
            btnPhoneNumberPrivateEdit.Size = new Size(15, 14);
            btnPhoneNumberPrivateEdit.TabIndex = 320;
            btnPhoneNumberPrivateEdit.UseVisualStyleBackColor = true;
            // 
            // btnPhoneNumberMobileEdit
            // 
            btnPhoneNumberMobileEdit.AutoSize = true;
            btnPhoneNumberMobileEdit.Location = new Point(26, 303);
            btnPhoneNumberMobileEdit.Margin = new Padding(2, 1, 2, 1);
            btnPhoneNumberMobileEdit.Name = "btnPhoneNumberMobileEdit";
            btnPhoneNumberMobileEdit.Size = new Size(15, 14);
            btnPhoneNumberMobileEdit.TabIndex = 319;
            btnPhoneNumberMobileEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdressEdit
            // 
            btnAdressEdit.AutoSize = true;
            btnAdressEdit.Location = new Point(26, 234);
            btnAdressEdit.Margin = new Padding(2, 1, 2, 1);
            btnAdressEdit.Name = "btnAdressEdit";
            btnAdressEdit.Size = new Size(15, 14);
            btnAdressEdit.TabIndex = 318;
            btnAdressEdit.UseVisualStyleBackColor = true;
            // 
            // btnSexEdit
            // 
            btnSexEdit.AutoSize = true;
            btnSexEdit.Location = new Point(26, 134);
            btnSexEdit.Margin = new Padding(2, 1, 2, 1);
            btnSexEdit.Name = "btnSexEdit";
            btnSexEdit.Size = new Size(15, 14);
            btnSexEdit.TabIndex = 317;
            btnSexEdit.UseVisualStyleBackColor = true;
            // 
            // btnLastNameEdit
            // 
            btnLastNameEdit.AutoSize = true;
            btnLastNameEdit.Location = new Point(26, 111);
            btnLastNameEdit.Margin = new Padding(2, 1, 2, 1);
            btnLastNameEdit.Name = "btnLastNameEdit";
            btnLastNameEdit.Size = new Size(15, 14);
            btnLastNameEdit.TabIndex = 316;
            btnLastNameEdit.UseVisualStyleBackColor = true;
            // 
            // btnFirstNameEdit
            // 
            btnFirstNameEdit.AutoSize = true;
            btnFirstNameEdit.Location = new Point(26, 88);
            btnFirstNameEdit.Margin = new Padding(2, 1, 2, 1);
            btnFirstNameEdit.Name = "btnFirstNameEdit";
            btnFirstNameEdit.Size = new Size(15, 14);
            btnFirstNameEdit.TabIndex = 315;
            btnFirstNameEdit.UseVisualStyleBackColor = true;
            // 
            // btnDateOfBirthEdit
            // 
            btnDateOfBirthEdit.AutoSize = true;
            btnDateOfBirthEdit.Location = new Point(26, 205);
            btnDateOfBirthEdit.Margin = new Padding(2, 1, 2, 1);
            btnDateOfBirthEdit.Name = "btnDateOfBirthEdit";
            btnDateOfBirthEdit.Size = new Size(15, 14);
            btnDateOfBirthEdit.TabIndex = 314;
            btnDateOfBirthEdit.UseVisualStyleBackColor = true;
            // 
            // btnSocialSecurityNumberEdit
            // 
            btnSocialSecurityNumberEdit.AutoSize = true;
            btnSocialSecurityNumberEdit.Location = new Point(26, 182);
            btnSocialSecurityNumberEdit.Margin = new Padding(2, 1, 2, 1);
            btnSocialSecurityNumberEdit.Name = "btnSocialSecurityNumberEdit";
            btnSocialSecurityNumberEdit.Size = new Size(15, 14);
            btnSocialSecurityNumberEdit.TabIndex = 313;
            btnSocialSecurityNumberEdit.UseVisualStyleBackColor = true;
            // 
            // btnNationalityEdit
            // 
            btnNationalityEdit.AutoSize = true;
            btnNationalityEdit.Location = new Point(26, 159);
            btnNationalityEdit.Margin = new Padding(2, 1, 2, 1);
            btnNationalityEdit.Name = "btnNationalityEdit";
            btnNationalityEdit.Size = new Size(15, 14);
            btnNationalityEdit.TabIndex = 312;
            btnNationalityEdit.UseVisualStyleBackColor = true;
            // 
            // btnTitleEdit
            // 
            btnTitleEdit.AutoSize = true;
            btnTitleEdit.Location = new Point(26, 65);
            btnTitleEdit.Margin = new Padding(2, 1, 2, 1);
            btnTitleEdit.Name = "btnTitleEdit";
            btnTitleEdit.Size = new Size(15, 14);
            btnTitleEdit.TabIndex = 311;
            btnTitleEdit.UseVisualStyleBackColor = true;
            // 
            // btnSalutationEdit
            // 
            btnSalutationEdit.AutoSize = true;
            btnSalutationEdit.Location = new Point(26, 42);
            btnSalutationEdit.Margin = new Padding(2, 1, 2, 1);
            btnSalutationEdit.Name = "btnSalutationEdit";
            btnSalutationEdit.Size = new Size(15, 14);
            btnSalutationEdit.TabIndex = 310;
            btnSalutationEdit.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(26, 19);
            checkBox1.Margin = new Padding(2, 1, 2, 1);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 309;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(122, 148, 150);
            panel4.Location = new Point(45, 517);
            panel4.Margin = new Padding(2, 1, 2, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(485, 2);
            panel4.TabIndex = 308;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(122, 148, 150);
            panel3.Location = new Point(45, 393);
            panel3.Margin = new Padding(2, 1, 2, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(485, 2);
            panel3.TabIndex = 307;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(122, 148, 150);
            panel2.Location = new Point(44, 295);
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(485, 2);
            panel2.TabIndex = 306;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(122, 148, 150);
            panel1.Location = new Point(44, 225);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 2);
            panel1.TabIndex = 305;
            // 
            // lblActualTraineeYear
            // 
            lblActualTraineeYear.AutoSize = true;
            lblActualTraineeYear.ForeColor = SystemColors.Control;
            lblActualTraineeYear.Location = new Point(45, 551);
            lblActualTraineeYear.Margin = new Padding(2, 0, 2, 0);
            lblActualTraineeYear.Name = "lblActualTraineeYear";
            lblActualTraineeYear.Size = new Size(109, 15);
            lblActualTraineeYear.TabIndex = 304;
            lblActualTraineeYear.Text = "Actual Trainee Year:";
            // 
            // numActualTraineeYear
            // 
            numActualTraineeYear.Enabled = false;
            numActualTraineeYear.Location = new Point(207, 551);
            numActualTraineeYear.Name = "numActualTraineeYear";
            numActualTraineeYear.Size = new Size(180, 23);
            numActualTraineeYear.TabIndex = 283;
            numActualTraineeYear.Tag = "Cadre Level";
            // 
            // lblTraineeYears
            // 
            lblTraineeYears.AutoSize = true;
            lblTraineeYears.ForeColor = SystemColors.Control;
            lblTraineeYears.Location = new Point(45, 528);
            lblTraineeYears.Margin = new Padding(2, 0, 2, 0);
            lblTraineeYears.Name = "lblTraineeYears";
            lblTraineeYears.Size = new Size(77, 15);
            lblTraineeYears.TabIndex = 303;
            lblTraineeYears.Text = "Trainee Years:";
            // 
            // numTraineeYears
            // 
            numTraineeYears.Enabled = false;
            numTraineeYears.Location = new Point(207, 528);
            numTraineeYears.Name = "numTraineeYears";
            numTraineeYears.Size = new Size(180, 23);
            numTraineeYears.TabIndex = 282;
            numTraineeYears.Tag = "Cadre Level";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.ForeColor = SystemColors.Control;
            lblRole.Location = new Point(45, 471);
            lblRole.Margin = new Padding(2, 0, 2, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(38, 15);
            lblRole.TabIndex = 302;
            lblRole.Text = "Role*:";
            // 
            // lblCadreLevel
            // 
            lblCadreLevel.AutoSize = true;
            lblCadreLevel.ForeColor = SystemColors.Control;
            lblCadreLevel.Location = new Point(45, 494);
            lblCadreLevel.Margin = new Padding(2, 0, 2, 0);
            lblCadreLevel.Name = "lblCadreLevel";
            lblCadreLevel.Size = new Size(73, 15);
            lblCadreLevel.TabIndex = 301;
            lblCadreLevel.Text = "CadreLevel*:";
            // 
            // lblDepartement
            // 
            lblDepartement.AutoSize = true;
            lblDepartement.ForeColor = SystemColors.Control;
            lblDepartement.Location = new Point(45, 448);
            lblDepartement.Margin = new Padding(2, 0, 2, 0);
            lblDepartement.Name = "lblDepartement";
            lblDepartement.Size = new Size(84, 15);
            lblDepartement.TabIndex = 300;
            lblDepartement.Text = "Departement*:";
            // 
            // lblStartEndDate
            // 
            lblStartEndDate.AutoSize = true;
            lblStartEndDate.ForeColor = SystemColors.Control;
            lblStartEndDate.Location = new Point(45, 401);
            lblStartEndDate.Margin = new Padding(2, 0, 2, 0);
            lblStartEndDate.Name = "lblStartEndDate";
            lblStartEndDate.Size = new Size(91, 15);
            lblStartEndDate.TabIndex = 299;
            lblStartEndDate.Text = "Start*/End Date:";
            // 
            // lblEmploymentType
            // 
            lblEmploymentType.AutoSize = true;
            lblEmploymentType.ForeColor = SystemColors.Control;
            lblEmploymentType.Location = new Point(45, 424);
            lblEmploymentType.Margin = new Padding(2, 0, 2, 0);
            lblEmploymentType.Name = "lblEmploymentType";
            lblEmploymentType.Size = new Size(109, 15);
            lblEmploymentType.TabIndex = 298;
            lblEmploymentType.Text = "Employment type*:";
            // 
            // lblPhoneNumberBusiness
            // 
            lblPhoneNumberBusiness.AutoSize = true;
            lblPhoneNumberBusiness.ForeColor = SystemColors.Control;
            lblPhoneNumberBusiness.Location = new Point(45, 349);
            lblPhoneNumberBusiness.Margin = new Padding(2, 0, 2, 0);
            lblPhoneNumberBusiness.Name = "lblPhoneNumberBusiness";
            lblPhoneNumberBusiness.Size = new Size(139, 15);
            lblPhoneNumberBusiness.TabIndex = 297;
            lblPhoneNumberBusiness.Text = "Phone Number Business:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = SystemColors.Control;
            lblEmail.Location = new Point(45, 373);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(83, 15);
            lblEmail.TabIndex = 296;
            lblEmail.Text = "Mail Address*:";
            // 
            // lblPhoneNumberPrivate
            // 
            lblPhoneNumberPrivate.AutoSize = true;
            lblPhoneNumberPrivate.ForeColor = SystemColors.Control;
            lblPhoneNumberPrivate.Location = new Point(45, 326);
            lblPhoneNumberPrivate.Margin = new Padding(2, 0, 2, 0);
            lblPhoneNumberPrivate.Name = "lblPhoneNumberPrivate";
            lblPhoneNumberPrivate.Size = new Size(135, 15);
            lblPhoneNumberPrivate.TabIndex = 295;
            lblPhoneNumberPrivate.Text = "Phone Number Private:*";
            // 
            // lblSocialSecurityNumber
            // 
            lblSocialSecurityNumber.AutoSize = true;
            lblSocialSecurityNumber.ForeColor = SystemColors.Control;
            lblSocialSecurityNumber.Location = new Point(45, 181);
            lblSocialSecurityNumber.Margin = new Padding(2, 0, 2, 0);
            lblSocialSecurityNumber.Name = "lblSocialSecurityNumber";
            lblSocialSecurityNumber.Size = new Size(138, 15);
            lblSocialSecurityNumber.TabIndex = 294;
            lblSocialSecurityNumber.Text = "Social Security Number*:";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.ForeColor = SystemColors.Control;
            lblDateOfBirth.Location = new Point(45, 205);
            lblDateOfBirth.Margin = new Padding(2, 0, 2, 0);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(81, 15);
            lblDateOfBirth.TabIndex = 293;
            lblDateOfBirth.Text = "Date of Birth*:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.ForeColor = SystemColors.Control;
            lblAddress.Location = new Point(45, 234);
            lblAddress.Margin = new Padding(2, 0, 2, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(45, 15);
            lblAddress.TabIndex = 292;
            lblAddress.Text = "Street*:";
            // 
            // lblPhoneNumberMobile
            // 
            lblPhoneNumberMobile.AutoSize = true;
            lblPhoneNumberMobile.ForeColor = SystemColors.Control;
            lblPhoneNumberMobile.Location = new Point(45, 302);
            lblPhoneNumberMobile.Margin = new Padding(2, 0, 2, 0);
            lblPhoneNumberMobile.Name = "lblPhoneNumberMobile";
            lblPhoneNumberMobile.Size = new Size(136, 15);
            lblPhoneNumberMobile.TabIndex = 291;
            lblPhoneNumberMobile.Text = "Phone Number Mobile*:";
            // 
            // lblNationality
            // 
            lblNationality.AutoSize = true;
            lblNationality.ForeColor = SystemColors.Control;
            lblNationality.Location = new Point(45, 158);
            lblNationality.Margin = new Padding(2, 0, 2, 0);
            lblNationality.Name = "lblNationality";
            lblNationality.Size = new Size(73, 15);
            lblNationality.TabIndex = 290;
            lblNationality.Text = "Nationality*:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.ForeColor = SystemColors.Control;
            lblTitle.Location = new Point(45, 64);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(32, 15);
            lblTitle.TabIndex = 289;
            lblTitle.Text = "Title:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.ForeColor = SystemColors.Control;
            lblFirstName.Location = new Point(45, 87);
            lblFirstName.Margin = new Padding(2, 0, 2, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(72, 15);
            lblFirstName.TabIndex = 288;
            lblFirstName.Text = "First Name*:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.ForeColor = SystemColors.Control;
            lblLastName.Location = new Point(45, 111);
            lblLastName.Margin = new Padding(2, 0, 2, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(71, 15);
            lblLastName.TabIndex = 287;
            lblLastName.Text = "Last Name*:";
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.ForeColor = SystemColors.Control;
            lblSex.Location = new Point(45, 134);
            lblSex.Margin = new Padding(2, 0, 2, 0);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(33, 15);
            lblSex.TabIndex = 286;
            lblSex.Text = "Sex*:";
            // 
            // lblSalutation
            // 
            lblSalutation.AutoSize = true;
            lblSalutation.ForeColor = SystemColors.Control;
            lblSalutation.Location = new Point(45, 41);
            lblSalutation.Margin = new Padding(2, 0, 2, 0);
            lblSalutation.Name = "lblSalutation";
            lblSalutation.Size = new Size(68, 15);
            lblSalutation.TabIndex = 285;
            lblSalutation.Text = "Salutation*:";
            // 
            // lblUserType
            // 
            lblUserType.AutoSize = true;
            lblUserType.ForeColor = SystemColors.Control;
            lblUserType.Location = new Point(45, 17);
            lblUserType.Margin = new Padding(2, 0, 2, 0);
            lblUserType.Name = "lblUserType";
            lblUserType.Size = new Size(65, 15);
            lblUserType.TabIndex = 272;
            lblUserType.Text = "User Type*:";
            // 
            // txtStreet
            // 
            txtStreet.BackColor = Color.FromArgb(227, 234, 234);
            txtStreet.Font = new Font("Microsoft Sans Serif", 9F);
            txtStreet.ForeColor = Color.Black;
            txtStreet.Location = new Point(207, 233);
            txtStreet.Margin = new Padding(4, 3, 4, 3);
            txtStreet.Name = "txtStreet";
            txtStreet.PlaceholderText = "Street";
            txtStreet.Size = new Size(182, 21);
            txtStreet.TabIndex = 270;
            txtStreet.Tag = "Street";
            // 
            // txtEndDate
            // 
            txtEndDate.Font = new Font("Microsoft Sans Serif", 9F);
            txtEndDate.Format = DateTimePickerFormat.Short;
            txtEndDate.Location = new Point(298, 396);
            txtEndDate.Margin = new Padding(4, 3, 4, 3);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.RightToLeft = RightToLeft.Yes;
            txtEndDate.ShowUpDown = true;
            txtEndDate.Size = new Size(88, 21);
            txtEndDate.TabIndex = 278;
            txtEndDate.Tag = "EndDate";
            txtEndDate.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // txtSalutation
            // 
            txtSalutation.BackColor = Color.FromArgb(227, 234, 234);
            txtSalutation.FlatStyle = FlatStyle.Flat;
            txtSalutation.Font = new Font("Microsoft Sans Serif", 9F);
            txtSalutation.ForeColor = Color.Black;
            txtSalutation.FormattingEnabled = true;
            txtSalutation.Items.AddRange(new object[] { "Mr.", "Ms.", "Mrs." });
            txtSalutation.Location = new Point(207, 41);
            txtSalutation.Margin = new Padding(4, 3, 4, 3);
            txtSalutation.Name = "txtSalutation";
            txtSalutation.Size = new Size(182, 23);
            txtSalutation.TabIndex = 262;
            txtSalutation.Tag = "Salutation";
            // 
            // txtPhoneNumberBusiness
            // 
            txtPhoneNumberBusiness.BackColor = Color.FromArgb(227, 234, 234);
            txtPhoneNumberBusiness.Font = new Font("Microsoft Sans Serif", 9F);
            txtPhoneNumberBusiness.ForeColor = Color.Black;
            txtPhoneNumberBusiness.Location = new Point(207, 349);
            txtPhoneNumberBusiness.Margin = new Padding(4, 3, 4, 3);
            txtPhoneNumberBusiness.Name = "txtPhoneNumberBusiness";
            txtPhoneNumberBusiness.PlaceholderText = "Phone Number Business";
            txtPhoneNumberBusiness.Size = new Size(182, 21);
            txtPhoneNumberBusiness.TabIndex = 275;
            txtPhoneNumberBusiness.Tag = "Phone Number Business ";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(227, 234, 234);
            txtTitle.Font = new Font("Microsoft Sans Serif", 9F);
            txtTitle.ForeColor = Color.Black;
            txtTitle.Location = new Point(207, 64);
            txtTitle.Margin = new Padding(4, 3, 4, 3);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Title";
            txtTitle.Size = new Size(182, 21);
            txtTitle.TabIndex = 263;
            txtTitle.Tag = "";
            // 
            // txtPhoneNumberMobile
            // 
            txtPhoneNumberMobile.BackColor = Color.FromArgb(227, 234, 234);
            txtPhoneNumberMobile.Font = new Font("Microsoft Sans Serif", 9F);
            txtPhoneNumberMobile.ForeColor = Color.Black;
            txtPhoneNumberMobile.Location = new Point(207, 302);
            txtPhoneNumberMobile.Margin = new Padding(4, 3, 4, 3);
            txtPhoneNumberMobile.Name = "txtPhoneNumberMobile";
            txtPhoneNumberMobile.PlaceholderText = "Phone Number Mobile";
            txtPhoneNumberMobile.Size = new Size(182, 21);
            txtPhoneNumberMobile.TabIndex = 273;
            txtPhoneNumberMobile.Tag = "Phone Number Mobile";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(227, 234, 234);
            txtFirstName.Font = new Font("Microsoft Sans Serif", 9F);
            txtFirstName.ForeColor = Color.Black;
            txtFirstName.Location = new Point(207, 87);
            txtFirstName.Margin = new Padding(4, 3, 4, 3);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First Name";
            txtFirstName.Size = new Size(182, 21);
            txtFirstName.TabIndex = 264;
            txtFirstName.Tag = "First Name";
            // 
            // txtCadreLevel
            // 
            txtCadreLevel.Location = new Point(207, 494);
            txtCadreLevel.Name = "txtCadreLevel";
            txtCadreLevel.Size = new Size(180, 23);
            txtCadreLevel.TabIndex = 281;
            txtCadreLevel.Tag = "Cadre Level";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(227, 234, 234);
            txtLastName.Font = new Font("Microsoft Sans Serif", 9F);
            txtLastName.ForeColor = Color.Black;
            txtLastName.Location = new Point(207, 111);
            txtLastName.Margin = new Padding(4, 3, 4, 3);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last Name";
            txtLastName.Size = new Size(182, 21);
            txtLastName.TabIndex = 265;
            txtLastName.Tag = "Last Name";
            // 
            // txtPhoneNumberPrivate
            // 
            txtPhoneNumberPrivate.BackColor = Color.FromArgb(227, 234, 234);
            txtPhoneNumberPrivate.Font = new Font("Microsoft Sans Serif", 9F);
            txtPhoneNumberPrivate.ForeColor = Color.Black;
            txtPhoneNumberPrivate.Location = new Point(207, 326);
            txtPhoneNumberPrivate.Margin = new Padding(4, 3, 4, 3);
            txtPhoneNumberPrivate.Name = "txtPhoneNumberPrivate";
            txtPhoneNumberPrivate.PlaceholderText = "Phone Number Private";
            txtPhoneNumberPrivate.Size = new Size(182, 21);
            txtPhoneNumberPrivate.TabIndex = 274;
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
            txtSex.Location = new Point(207, 134);
            txtSex.Margin = new Padding(4, 3, 4, 3);
            txtSex.Name = "txtSex";
            txtSex.Size = new Size(182, 23);
            txtSex.TabIndex = 266;
            txtSex.Tag = "Sex";
            // 
            // txtRole
            // 
            txtRole.BackColor = Color.FromArgb(227, 234, 234);
            txtRole.FlatStyle = FlatStyle.Flat;
            txtRole.Font = new Font("Microsoft Sans Serif", 9F);
            txtRole.ForeColor = Color.Black;
            txtRole.FormattingEnabled = true;
            txtRole.Items.AddRange(new object[] { "Chief Executive Officer", "Chief Operating Officer", "Chief Financial Officer", "Chief Marketing Officer", "Chief Technology Officer", "Executive Assistant", "President", "Vice President", "Product Manager", "Purchasing Manager", "Project Manager", "Finance Manager", "Marketing Manager", "Office Manager", "Regional Manager", "Human Resources Manager", "Quality Control/Safety Manager", "Sales Representative", "Customer Service Representative", "Administrative Assistant", "Business Analyst", "Marketing Specialist", "Human Resource Personnel", "Accountant", "IT Technician", "Production-Team" });
            txtRole.Location = new Point(207, 471);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(182, 23);
            txtRole.TabIndex = 280;
            txtRole.Tag = "Role";
            // 
            // txtNationality
            // 
            txtNationality.BackColor = Color.FromArgb(227, 234, 234);
            txtNationality.FlatStyle = FlatStyle.Flat;
            txtNationality.Font = new Font("Microsoft Sans Serif", 9F);
            txtNationality.ForeColor = Color.Black;
            txtNationality.FormattingEnabled = true;
            txtNationality.Items.AddRange(new object[] { "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "The Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso", "Burundi", "Cabo Verde", "Cambodia", "Cameroon", "Canada", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo, Democratic Republic of the", "Congo, Republic of the", "Costa Rica", "Côte d’Ivoire", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor (Timor-Leste)", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "The Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea, North", "Korea, South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia, Federated States of", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar (Burma)", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "North Macedonia", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "Spain", "Sri Lanka", "Sudan", "Sudan, South", "Suriname", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe" });
            txtNationality.Location = new Point(207, 158);
            txtNationality.Name = "txtNationality";
            txtNationality.Size = new Size(182, 23);
            txtNationality.TabIndex = 267;
            txtNationality.Tag = "Nationality";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(227, 234, 234);
            txtEmail.Font = new Font("Microsoft Sans Serif", 9F);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(207, 373);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(182, 21);
            txtEmail.TabIndex = 276;
            txtEmail.Tag = "Email";
            // 
            // txtSocialSecurityNumber
            // 
            txtSocialSecurityNumber.BackColor = Color.FromArgb(227, 234, 234);
            txtSocialSecurityNumber.Font = new Font("Microsoft Sans Serif", 9F);
            txtSocialSecurityNumber.ForeColor = Color.Black;
            txtSocialSecurityNumber.Location = new Point(207, 181);
            txtSocialSecurityNumber.Margin = new Padding(4, 3, 4, 3);
            txtSocialSecurityNumber.Name = "txtSocialSecurityNumber";
            txtSocialSecurityNumber.PlaceholderText = "Social Security Number";
            txtSocialSecurityNumber.Size = new Size(182, 21);
            txtSocialSecurityNumber.TabIndex = 268;
            txtSocialSecurityNumber.Tag = "Social Security Number";
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Font = new Font("Microsoft Sans Serif", 9F);
            txtDateOfBirth.Format = DateTimePickerFormat.Short;
            txtDateOfBirth.Location = new Point(207, 205);
            txtDateOfBirth.Margin = new Padding(4, 3, 4, 3);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.RightToLeft = RightToLeft.Yes;
            txtDateOfBirth.ShowUpDown = true;
            txtDateOfBirth.Size = new Size(88, 21);
            txtDateOfBirth.TabIndex = 269;
            txtDateOfBirth.Tag = "Date Of Birth";
            txtDateOfBirth.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // txtDepartment
            // 
            txtDepartment.BackColor = Color.FromArgb(227, 234, 234);
            txtDepartment.FlatStyle = FlatStyle.Flat;
            txtDepartment.Font = new Font("Microsoft Sans Serif", 9F);
            txtDepartment.ForeColor = Color.Black;
            txtDepartment.FormattingEnabled = true;
            txtDepartment.Items.AddRange(new object[] { "Human Resources", "IT", "Accounting and Finance", "Marketing", "Research and Development", "Production" });
            txtDepartment.Location = new Point(207, 448);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(182, 23);
            txtDepartment.TabIndex = 279;
            txtDepartment.Tag = "Department";
            // 
            // txtPlace
            // 
            txtPlace.BackColor = Color.FromArgb(227, 234, 234);
            txtPlace.Font = new Font("Microsoft Sans Serif", 9F);
            txtPlace.ForeColor = Color.Black;
            txtPlace.Location = new Point(207, 262);
            txtPlace.Margin = new Padding(4, 3, 4, 3);
            txtPlace.Name = "txtPlace";
            txtPlace.PlaceholderText = "Place";
            txtPlace.Size = new Size(182, 21);
            txtPlace.TabIndex = 271;
            txtPlace.Tag = "Place";
            // 
            // btnSearchUser
            // 
            btnSearchUser.ForeColor = Color.Black;
            btnSearchUser.Location = new Point(375, 712);
            btnSearchUser.Margin = new Padding(4, 3, 4, 3);
            btnSearchUser.Name = "btnSearchUser";
            btnSearchUser.Size = new Size(164, 27);
            btnSearchUser.TabIndex = 284;
            btnSearchUser.Text = "Search User";
            btnSearchUser.UseVisualStyleBackColor = true;
            btnSearchUser.Click += btnSearchUser_Click;
            // 
            // txtStartDate
            // 
            txtStartDate.Font = new Font("Microsoft Sans Serif", 9F);
            txtStartDate.Format = DateTimePickerFormat.Short;
            txtStartDate.Location = new Point(207, 396);
            txtStartDate.Margin = new Padding(4, 3, 4, 3);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.RightToLeft = RightToLeft.Yes;
            txtStartDate.ShowUpDown = true;
            txtStartDate.Size = new Size(88, 21);
            txtStartDate.TabIndex = 277;
            txtStartDate.Tag = "StartDate";
            txtStartDate.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // optCustomer
            // 
            optCustomer.AutoSize = true;
            optCustomer.Location = new Point(207, 12);
            optCustomer.Name = "optCustomer";
            optCustomer.Size = new Size(77, 19);
            optCustomer.TabIndex = 346;
            optCustomer.TabStop = true;
            optCustomer.Text = "Customer";
            optCustomer.UseVisualStyleBackColor = true;
            optCustomer.CheckedChanged += optCustomer_CheckedChanged;
            // 
            // optEmployee
            // 
            optEmployee.AutoSize = true;
            optEmployee.Location = new Point(290, 12);
            optEmployee.Name = "optEmployee";
            optEmployee.Size = new Size(77, 19);
            optEmployee.TabIndex = 347;
            optEmployee.TabStop = true;
            optEmployee.Text = "Employee";
            optEmployee.UseVisualStyleBackColor = true;
            optEmployee.CheckedChanged += optEmployee_CheckedChanged;
            // 
            // optTrainee
            // 
            optTrainee.AutoSize = true;
            optTrainee.Location = new Point(373, 12);
            optTrainee.Name = "optTrainee";
            optTrainee.Size = new Size(62, 19);
            optTrainee.TabIndex = 348;
            optTrainee.TabStop = true;
            optTrainee.Text = "Trainee";
            optTrainee.TextAlign = ContentAlignment.BottomLeft;
            optTrainee.UseVisualStyleBackColor = true;
            optTrainee.CheckedChanged += optTrainee_CheckedChanged;
            // 
            // frmSearchUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 49, 51);
            ClientSize = new Size(564, 757);
            Controls.Add(optTrainee);
            Controls.Add(optCustomer);
            Controls.Add(optEmployee);
            Controls.Add(numEmployment);
            Controls.Add(lblZipCode);
            Controls.Add(lblPlace);
            Controls.Add(lblStreetNumber);
            Controls.Add(txtStreetNumber);
            Controls.Add(numZipCode);
            Controls.Add(btnCompanyContactEdit);
            Controls.Add(btnCompanyTypeEdit);
            Controls.Add(btnCompanyNameEdit);
            Controls.Add(panel5);
            Controls.Add(txtCompanyContact);
            Controls.Add(txtCompanyType);
            Controls.Add(txtCompanyName);
            Controls.Add(lblCompanyContact);
            Controls.Add(lblCompanyType);
            Controls.Add(lblCompanyName);
            Controls.Add(btnActualTraineeYearEdit);
            Controls.Add(btnTraineeYearsEdit);
            Controls.Add(btnCadreLevelEdit);
            Controls.Add(btnRoleEdit);
            Controls.Add(btnDepartementEdit);
            Controls.Add(btnEmplyomentTypeEdit);
            Controls.Add(btnStartEndDateEdit);
            Controls.Add(btnEmailEdit);
            Controls.Add(btnPhoneNumberBusinessEdit);
            Controls.Add(btnPhoneNumberPrivateEdit);
            Controls.Add(btnPhoneNumberMobileEdit);
            Controls.Add(btnAdressEdit);
            Controls.Add(btnSexEdit);
            Controls.Add(btnLastNameEdit);
            Controls.Add(btnFirstNameEdit);
            Controls.Add(btnDateOfBirthEdit);
            Controls.Add(btnSocialSecurityNumberEdit);
            Controls.Add(btnNationalityEdit);
            Controls.Add(btnTitleEdit);
            Controls.Add(btnSalutationEdit);
            Controls.Add(checkBox1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
            Controls.Add(lblUserType);
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
            Controls.Add(txtDateOfBirth);
            Controls.Add(txtDepartment);
            Controls.Add(txtPlace);
            Controls.Add(btnSearchUser);
            Controls.Add(txtStartDate);
            ForeColor = SystemColors.Control;
            Name = "frmSearchUser";
            Text = "Search User";
            ((System.ComponentModel.ISupportInitialize)numEmployment).EndInit();
            ((System.ComponentModel.ISupportInitialize)numZipCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)numActualTraineeYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTraineeYears).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCadreLevel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private NumericUpDown numEmployment;
        private Label lblZipCode;
        private Label lblPlace;
        private Label lblStreetNumber;
        private TextBox txtStreetNumber;
        private NumericUpDown numZipCode;
        private CheckBox btnCompanyContactEdit;
        private CheckBox btnCompanyTypeEdit;
        private CheckBox btnCompanyNameEdit;
        private Panel panel5;
        private TextBox txtCompanyContact;
        private TextBox txtCompanyType;
        private TextBox txtCompanyName;
        private Label lblCompanyContact;
        private Label lblCompanyType;
        private Label lblCompanyName;
        private CheckBox btnActualTraineeYearEdit;
        private CheckBox btnTraineeYearsEdit;
        private CheckBox btnCadreLevelEdit;
        private CheckBox btnRoleEdit;
        private CheckBox btnDepartementEdit;
        private CheckBox btnEmplyomentTypeEdit;
        private CheckBox btnStartEndDateEdit;
        private CheckBox btnEmailEdit;
        private CheckBox btnPhoneNumberBusinessEdit;
        private CheckBox btnPhoneNumberPrivateEdit;
        private CheckBox btnPhoneNumberMobileEdit;
        private CheckBox btnAdressEdit;
        private CheckBox btnSexEdit;
        private CheckBox btnLastNameEdit;
        private CheckBox btnFirstNameEdit;
        private CheckBox btnDateOfBirthEdit;
        private CheckBox btnSocialSecurityNumberEdit;
        private CheckBox btnNationalityEdit;
        private CheckBox btnTitleEdit;
        private CheckBox btnSalutationEdit;
        private CheckBox checkBox1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private CheckBox btnStatus;
        private Label lblActualTraineeYear;
        private NumericUpDown numActualTraineeYear;
        private Label lblTraineeYears;
        private NumericUpDown numTraineeYears;
        private Label lblRole;
        private Label lblCadreLevel;
        private Label lblDepartement;
        private Label lblStartEndDate;
        private Label lblEmploymentType;
        private Label lblPhoneNumberBusiness;
        private Label lblEmail;
        private Label lblPhoneNumberPrivate;
        private Label lblSocialSecurityNumber;
        private Label lblDateOfBirth;
        private Label lblAddress;
        private Label lblPhoneNumberMobile;
        private Label lblNationality;
        private Label lblTitle;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblSex;
        private Label lblSalutation;
        private Label lblUserType;
        private TextBox txtStreet;
        private DateTimePicker txtEndDate;
        private ComboBox txtSalutation;
        private TextBox txtPhoneNumberBusiness;
        private TextBox txtTitle;
        private TextBox txtPhoneNumberMobile;
        private TextBox txtFirstName;
        private NumericUpDown txtCadreLevel;
        private TextBox txtLastName;
        private TextBox txtPhoneNumberPrivate;
        private ComboBox txtSex;
        private ComboBox txtRole;
        private ComboBox txtNationality;
        private TextBox txtEmail;
        private TextBox txtSocialSecurityNumber;
        private DateTimePicker txtDateOfBirth;
        private ComboBox txtDepartment;
        private TextBox txtPlace;
        private Button btnSearchUser;
        private DateTimePicker txtStartDate;
        private RadioButton optCustomer;
        private RadioButton optEmployee;
        private RadioButton optTrainee;
    }
}