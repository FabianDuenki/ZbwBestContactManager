using Model;
using System;
using System.CodeDom;
using System.Windows.Forms;
using UI.AdministrationTools.Classes;
using Controller;
using Model.Typing;
using OpenTK.Platform.Windows;
using Microsoft.VisualBasic.ApplicationServices;

namespace ZbW_P_Contact_Manager.UI.AdministrationTools
{
    public partial class frmSearchUser : Form
    {
        private Person _searchUser;
        UserController _userController = new UserController();
        ModelController _modelController = new ModelController();

        public frmSearchUser()
        {
            InitializeComponent();
            ActivateTextFields();
        }
        private void ActivateTextFields()
        {
            btnSearchUser.Enabled = (optEmployee.Checked || optCustomer.Checked || optTrainee.Checked);

            btnTraineeYearsEdit.Enabled = false;
            txtSalutation.Enabled = true;
            txtTitle.Enabled = true;
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtSex.Enabled = true;
            txtNationality.Enabled = true;
            txtSocialSecurityNumber.Enabled = true;
            txtDateOfBirth.Enabled = true;
            txtStreet.Enabled = true;
            txtStreetNumber.Enabled = true;
            txtPlace.Enabled = true;
            numZipCode.Enabled = true;
            txtPhoneNumberMobile.Enabled = true;
            txtPhoneNumberPrivate.Enabled = true;
            txtPhoneNumberBusiness.Enabled = true;
            txtEmail.Enabled = true;
            txtCompanyName.Enabled = optCustomer.Checked;
            txtCompanyType.Enabled = optCustomer.Checked;
            txtCompanyContact.Enabled = optCustomer.Checked;
            txtStartDate.Enabled = optEmployee.Checked || optTrainee.Checked;
            txtEndDate.Enabled = optEmployee.Checked || optTrainee.Checked;
            numEmployment.Enabled = optEmployee.Checked || optTrainee.Checked;
            txtDepartment.Enabled = optEmployee.Checked || optTrainee.Checked;
            txtRole.Enabled = optEmployee.Checked || optTrainee.Checked;
            txtCadreLevel.Enabled = optEmployee.Checked || optTrainee.Checked;
            btnTraineeYearsEdit.Checked = optTrainee.Checked;
            numTraineeYears.Enabled = optTrainee.Checked;
            numActualTraineeYear.Enabled = optTrainee.Checked;
        }
        private void optCustomer_CheckedChanged(object sender, EventArgs e)
        {
            ActivateTextFields();
        }
        private void optEmployee_CheckedChanged(object sender, EventArgs e)
        {
            ActivateTextFields();
        }
        private void optTrainee_CheckedChanged(object sender, EventArgs e)
        {
            ActivateTextFields();
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            if (optCustomer.Checked)
            {
                _searchUser = new Customer()
                {
                    CompanyName = txtCompanyName.Text,
                    CompanyType = txtCompanyType.Text,
                    CompanyContact = txtCompanyContact.Text
                };
            }
            else if (optEmployee.Checked)
            {
                _searchUser = new Employee()
                {
                    StartDate = txtStartDate.Value,
                    EndDate = txtEndDate.Value,
                    Employment = (int)numEmployment.Value,
                    Departement = txtDepartment.Text,
                    Role = txtRole.Text,
                    CadreLevel = (int)txtCadreLevel.Value,
                    EmployeeNumber = Guid.Empty
                };
            }
            else if (optTrainee.Checked)
            {
                _searchUser = new Trainee()
                {
                    TraineeYears = (int)numTraineeYears.Value,
                    ActualTraineeYear = (int)numActualTraineeYear.Value,
                    StartDate = txtStartDate.Value,
                    EndDate = txtEndDate.Value,
                    Employment = (int)numEmployment.Value,
                    Departement = txtDepartment.Text,
                    Role = txtRole.Text,
                    CadreLevel = (int)txtCadreLevel.Value,
                    EmployeeNumber = Guid.Empty
                };
            }
            _searchUser.Salutation = txtSalutation.Text;
            _searchUser.Title = txtTitle.Text;
            _searchUser.FirstName = txtFirstName.Text;
            _searchUser.LastName = txtLastName.Text;
            _searchUser.Gender = txtSex.Text;
            _searchUser.Nationality = txtNationality.Text;
            _searchUser.SocialSecurityNumber = txtSocialSecurityNumber.Text;
            _searchUser.DateOfBirth = txtDateOfBirth.Value;
            _searchUser.Street = txtStreet.Text;
            _searchUser.StreetNumber = txtStreetNumber.Text;
            _searchUser.Place = txtPlace.Text;
            _searchUser.ZipCode = (int)numZipCode.Value;
            _searchUser.PhoneNumberMobile = txtPhoneNumberMobile.Text;
            _searchUser.PhoneNumberPrivate = txtPhoneNumberPrivate.Text;
            _searchUser.PhoneNumberBusiness = txtPhoneNumberBusiness.Text;
            _searchUser.Email = txtEmail.Text;

            this.FilterUser = _searchUser;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public Person FilterUser
        {
            get { return _searchUser; }
            set { _searchUser = value; }
        }
    }
}
