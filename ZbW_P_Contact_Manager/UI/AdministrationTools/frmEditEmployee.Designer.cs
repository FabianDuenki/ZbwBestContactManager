namespace ZbW_P_Contact_Manager.UI
{
    partial class frmEditEmployee
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            employeeBindingSource = new BindingSource(components);
            employeeDetailsBindingSource = new BindingSource(components);
            personBindingSource = new BindingSource(components);
            salutationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateOfBirthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            socialSecurityNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberPrivateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberMobileDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberBusinessDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nationalityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            streetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            streetNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            zipCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            placeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeDetailsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { salutationDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, dateOfBirthDataGridViewTextBoxColumn, genderDataGridViewCheckBoxColumn, titleDataGridViewTextBoxColumn, socialSecurityNumberDataGridViewTextBoxColumn, phoneNumberPrivateDataGridViewTextBoxColumn, phoneNumberMobileDataGridViewTextBoxColumn, phoneNumberBusinessDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, nationalityDataGridViewTextBoxColumn, streetDataGridViewTextBoxColumn, streetNumberDataGridViewTextBoxColumn, zipCodeDataGridViewTextBoxColumn, placeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = personBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(547, 435);
            dataGridView1.TabIndex = 0;
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Model.Employee);
            // 
            // employeeDetailsBindingSource
            // 
            // 
            // personBindingSource
            // 
            personBindingSource.DataSource = typeof(Model.Person);
            // 
            // salutationDataGridViewTextBoxColumn
            // 
            salutationDataGridViewTextBoxColumn.DataPropertyName = "Salutation";
            salutationDataGridViewTextBoxColumn.HeaderText = "Salutation";
            salutationDataGridViewTextBoxColumn.Name = "salutationDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewCheckBoxColumn
            // 
            genderDataGridViewCheckBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewCheckBoxColumn.HeaderText = "Gender";
            genderDataGridViewCheckBoxColumn.Name = "genderDataGridViewCheckBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // socialSecurityNumberDataGridViewTextBoxColumn
            // 
            socialSecurityNumberDataGridViewTextBoxColumn.DataPropertyName = "SocialSecurityNumber";
            socialSecurityNumberDataGridViewTextBoxColumn.HeaderText = "SocialSecurityNumber";
            socialSecurityNumberDataGridViewTextBoxColumn.Name = "socialSecurityNumberDataGridViewTextBoxColumn";
            // 
            // phoneNumberPrivateDataGridViewTextBoxColumn
            // 
            phoneNumberPrivateDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumberPrivate";
            phoneNumberPrivateDataGridViewTextBoxColumn.HeaderText = "PhoneNumberPrivate";
            phoneNumberPrivateDataGridViewTextBoxColumn.Name = "phoneNumberPrivateDataGridViewTextBoxColumn";
            // 
            // phoneNumberMobileDataGridViewTextBoxColumn
            // 
            phoneNumberMobileDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumberMobile";
            phoneNumberMobileDataGridViewTextBoxColumn.HeaderText = "PhoneNumberMobile";
            phoneNumberMobileDataGridViewTextBoxColumn.Name = "phoneNumberMobileDataGridViewTextBoxColumn";
            // 
            // phoneNumberBusinessDataGridViewTextBoxColumn
            // 
            phoneNumberBusinessDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumberBusiness";
            phoneNumberBusinessDataGridViewTextBoxColumn.HeaderText = "PhoneNumberBusiness";
            phoneNumberBusinessDataGridViewTextBoxColumn.Name = "phoneNumberBusinessDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // nationalityDataGridViewTextBoxColumn
            // 
            nationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality";
            nationalityDataGridViewTextBoxColumn.HeaderText = "Nationality";
            nationalityDataGridViewTextBoxColumn.Name = "nationalityDataGridViewTextBoxColumn";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            streetDataGridViewTextBoxColumn.HeaderText = "Street";
            streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            // 
            // streetNumberDataGridViewTextBoxColumn
            // 
            streetNumberDataGridViewTextBoxColumn.DataPropertyName = "StreetNumber";
            streetNumberDataGridViewTextBoxColumn.HeaderText = "StreetNumber";
            streetNumberDataGridViewTextBoxColumn.Name = "streetNumberDataGridViewTextBoxColumn";
            // 
            // zipCodeDataGridViewTextBoxColumn
            // 
            zipCodeDataGridViewTextBoxColumn.DataPropertyName = "ZipCode";
            zipCodeDataGridViewTextBoxColumn.HeaderText = "ZipCode";
            zipCodeDataGridViewTextBoxColumn.Name = "zipCodeDataGridViewTextBoxColumn";
            // 
            // placeDataGridViewTextBoxColumn
            // 
            placeDataGridViewTextBoxColumn.DataPropertyName = "Place";
            placeDataGridViewTextBoxColumn.HeaderText = "Place";
            placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            // 
            // frmEditEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 51, 73);
            ClientSize = new Size(547, 435);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEditEmployee";
            Text = "frmEditEmployee";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeDetailsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource employeeDetailsBindingSource;
        private BindingSource employeeBindingSource;
        private DataGridViewTextBoxColumn salutationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn genderDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn socialSecurityNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberPrivateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberMobileDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberBusinessDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn streetNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn zipCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private BindingSource personBindingSource;
    }
}