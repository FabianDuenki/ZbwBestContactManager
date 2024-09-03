using System;
using System.Windows.Forms;

namespace ZbW_P_Contact_Manager.UI.AdministrationTools
{
    public partial class frmEditUser : Form
    {
        public frmEditUser()
        {
            InitializeComponent();

            // Add event handlers for each TextBox TextChanged event
            txtSalutation.TextChanged += new EventHandler(txtSalutation_TextChanged);
            txtTitle.TextChanged += new EventHandler(txtTitle_TextChanged);
            txtFirstName.TextChanged += new EventHandler(txtFirstName_TextChanged);
            txtLastName.TextChanged += new EventHandler(txtLastName_TextChanged);
            txtSex.TextChanged += new EventHandler(txtSex_TextChanged);
            txtNationality.TextChanged += new EventHandler(txtNationality_TextChanged);
            txtSocialSecurityNumber.TextChanged += new EventHandler(txtSocialSecurityNumber_TextChanged);
            txtDateOfBirth.TextChanged += new EventHandler(txtDateOfBirth_TextChanged);

            // Address-related text boxes need to check a single checkbox
            txtStreet.TextChanged += new EventHandler(txtAdress_TextChanged);
            txtStreetNumber.TextChanged += new EventHandler(txtAdress_TextChanged);
            txtPlace.TextChanged += new EventHandler(txtAdress_TextChanged);
            txtZipCode.TextChanged += new EventHandler(txtAdress_TextChanged);

            // Phone number related
            txtPhoneNumberMobile.TextChanged += new EventHandler(txtPhoneNumberMobile_TextChanged);
            txtPhoneNumberPrivate.TextChanged += new EventHandler(txtPhoneNumberPrivate_TextChanged);
            txtPhoneNumberBusiness.TextChanged += new EventHandler(txtPhoneNumberBusiness_TextChanged);
            txtEmail.TextChanged += new EventHandler(txtEmail_TextChanged);

            // Employment and Department related
            txtEmployment.TextChanged += new EventHandler(txtEmployment_TextChanged);
            txtDepartment.TextChanged += new EventHandler(txtDepartment_TextChanged);

            // Trainee related
            btnTrainee.CheckedChanged += new EventHandler(btnTrainee_CheckedChanged);
            numTraineeYears.ValueChanged += new EventHandler(numTraineeYears_ValueChanged);
            numActualTraineeYear.ValueChanged += new EventHandler(numActualTraineeYear_ValueChanged);

            // Start and End Date related text boxes need to check a single checkbox
            txtStartDate.TextChanged += new EventHandler(txtStartEndDate_TextChanged);
            txtEndDate.TextChanged += new EventHandler(txtStartEndDate_TextChanged);

            txtRole.TextChanged += new EventHandler(txtRole_TextChanged);
            txtCadreLevel.TextChanged += new EventHandler(txtCadreLevel_TextChanged);
            txtCompanyName.TextChanged += new EventHandler(txtCompanyName_TextChanged);
            txtCompanyType.TextChanged += new EventHandler(txtCompanyType_TextChanged);
            txtCompanyContact.TextChanged += new EventHandler(txtCompanyContact_TextChanged);
        }

        // Event handlers for each TextBox-CheckBox pair
        private void txtSalutation_TextChanged(object sender, EventArgs e)
        {
            btnSalutationEdit.Checked = !string.IsNullOrWhiteSpace(txtSalutation.Text);
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            btnTitleEdit.Checked = !string.IsNullOrWhiteSpace(txtTitle.Text);
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            btnFirstNameEdit.Checked = !string.IsNullOrWhiteSpace(txtFirstName.Text);
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            btnLastNameEdit.Checked = !string.IsNullOrWhiteSpace(txtLastName.Text);
        }

        private void txtSex_TextChanged(object sender, EventArgs e)
        {
            btnSexEdit.Checked = !string.IsNullOrWhiteSpace(txtSex.Text);
        }

        private void txtNationality_TextChanged(object sender, EventArgs e)
        {
            btnNationalityEdit.Checked = !string.IsNullOrWhiteSpace(txtNationality.Text);
        }

        private void txtSocialSecurityNumber_TextChanged(object sender, EventArgs e)
        {
            btnSocialSecurityNumberEdit.Checked = !string.IsNullOrWhiteSpace(txtSocialSecurityNumber.Text);
        }

        private void txtDateOfBirth_TextChanged(object sender, EventArgs e)
        {
            btnDateOfBirthEdit.Checked = !string.IsNullOrWhiteSpace(txtDateOfBirth.Text);
        }

        // Event handler for Address fields: Checkbox is checked if any field is filled
        private void txtAdress_TextChanged(object sender, EventArgs e)
        {
            btnAdressEdit.Checked = !string.IsNullOrWhiteSpace(txtStreet.Text) ||
                                    !string.IsNullOrWhiteSpace(txtStreetNumber.Text) ||
                                    !string.IsNullOrWhiteSpace(txtPlace.Text) ||
                                    !string.IsNullOrWhiteSpace(txtZipCode.Text);
        }

        private void txtPhoneNumberMobile_TextChanged(object sender, EventArgs e)
        {
            btnPhoneNumberMobileEdit.Checked = !string.IsNullOrWhiteSpace(txtPhoneNumberMobile.Text);
        }

        private void txtPhoneNumberPrivate_TextChanged(object sender, EventArgs e)
        {
            btnPhoneNumberPrivateEdit.Checked = !string.IsNullOrWhiteSpace(txtPhoneNumberPrivate.Text);
        }

        private void txtPhoneNumberBusiness_TextChanged(object sender, EventArgs e)
        {
            btnPhoneNumberBusinessEdit.Checked = !string.IsNullOrWhiteSpace(txtPhoneNumberBusiness.Text);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            btnEmailEdit.Checked = !string.IsNullOrWhiteSpace(txtEmail.Text);
        }

        private void txtEmployment_TextChanged(object sender, EventArgs e)
        {
            btnEmplyomentTypeEdit.Checked = !string.IsNullOrWhiteSpace(txtEmployment.Text);
        }

        private void txtDepartment_TextChanged(object sender, EventArgs e)
        {
            btnDepartementEdit.Checked = !string.IsNullOrWhiteSpace(txtDepartment.Text);
        }

        private void txtRole_TextChanged(object sender, EventArgs e)
        {
            btnRoleEdit.Checked = !string.IsNullOrWhiteSpace(txtRole.Text);
        }

        private void txtCadreLevel_TextChanged(object sender, EventArgs e)
        {
            btnCadreLevelEdit.Checked = !string.IsNullOrWhiteSpace(txtCadreLevel.Text);
        }

        // Check if either Start Date or End Date has text
        private void txtStartEndDate_TextChanged(object sender, EventArgs e)
        {
            btnStartEndDateEdit.Checked = !string.IsNullOrWhiteSpace(txtStartDate.Text) ||
                                          !string.IsNullOrWhiteSpace(txtEndDate.Text);
        }

        // Event handler for Trainee checkbox state change
        private void btnTrainee_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = btnTrainee.Checked;
            numActualTraineeYear.Enabled = isChecked;
            numTraineeYears.Enabled = isChecked;
        }

        // Event handler for Trainee Years
        private void numTraineeYears_ValueChanged(object sender, EventArgs e)
        {
            btnTraineeYearsEdit.Checked = numTraineeYears.Value > 0;
        }

        // Event handler for Actual Trainee Year
        private void numActualTraineeYear_ValueChanged(object sender, EventArgs e)
        {
            btnActualTraineeYearEdit.Checked = numActualTraineeYear.Value > 0;
        }

        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {
            btnCompanyNameEdit.Checked = !string.IsNullOrWhiteSpace(txtCompanyName.Text);
        }

        private void txtCompanyType_TextChanged(object sender, EventArgs e)
        {
            btnCompanyTypeEdit.Checked = !string.IsNullOrWhiteSpace(txtCompanyType.Text);
        }

        private void txtCompanyContact_TextChanged(object sender, EventArgs e)
        {
            btnCompanyContactEdit.Checked = !string.IsNullOrWhiteSpace(txtCompanyContact.Text);
        }
    }
}
