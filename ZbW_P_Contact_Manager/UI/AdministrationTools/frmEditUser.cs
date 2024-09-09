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
    public partial class frmEditUser : Form
    {
        Person _currentUser;
        Person _updatedUser;
        UserController _userController = new UserController();
        ModelController _modelController = new ModelController();

        public frmEditUser(Person user)
        {
            _currentUser = user;

            InitializeComponent();
            ActivateTextFields();
            FillTextFields();
        }
        private void ActivateTextFields()
        {
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

            if (_currentUser.GetType() != typeof(Employee))
            {
                txtStartDate.Enabled = false;
                txtStartDate.Value = new DateTime(1900, 1, 1);
                txtEndDate.Enabled = false;
                txtEndDate.Value = new DateTime(1900, 1, 1);
                numEmployment.Enabled = false;
                numEmployment.Text = "";
                txtDepartment.Enabled = false;
                txtDepartment.Text = "";
                txtRole.Enabled = false;
                txtRole.Text = "";
                txtCadreLevel.Enabled = false;
                txtCadreLevel.Text = "";
            }

            if (_currentUser.GetType() != typeof(Trainee))
            {
                btnTraineeYearsEdit.Checked = false;
                numTraineeYears.Enabled = false;
                numActualTraineeYear.Enabled = false;
            }
            if (_currentUser.GetType() != typeof(Customer))
            {
                txtCompanyName.Enabled = false;
                txtCompanyName.Text = "";
                txtCompanyType.Enabled = false;
                txtCompanyType.Text = "";
                txtCompanyContact.Enabled = false;
                txtCompanyContact.Text = "";
            }
        }
        private void FillTextFields()
        {
            btnStatus.Checked = (_currentUser.Status == true) ? true : false;
            txtSalutation.Text = _currentUser.Salutation;
            txtTitle.Text = _currentUser.Title;
            txtFirstName.Text = _currentUser.FirstName;
            txtLastName.Text = _currentUser.LastName;
            txtSex.Text = _currentUser.Gender;
            txtNationality.Text = _currentUser.Nationality;
            txtSocialSecurityNumber.Text = _currentUser.SocialSecurityNumber;
            txtDateOfBirth.Value = _currentUser.DateOfBirth ?? new DateTime(1900,1,1);
            txtStreet.Text = _currentUser.Street;
            txtStreetNumber.Text = _currentUser.StreetNumber;
            txtPlace.Text = _currentUser.Place;
            if (_currentUser.ZipCode != null) numZipCode.Value = (decimal)_currentUser.ZipCode;
            txtPhoneNumberMobile.Text = _currentUser.PhoneNumberMobile;
            txtPhoneNumberPrivate.Text = _currentUser.PhoneNumberPrivate;
            txtPhoneNumberBusiness.Text = _currentUser.PhoneNumberBusiness;
            txtEmail.Text = _currentUser.Email;

            if (_currentUser.GetType() == typeof(Employee))
            {
                Employee employee = (Employee)_currentUser;
                txtStartDate.Value = employee.StartDate ?? new DateTime(1900, 1, 1);
                txtEndDate.Value = employee.EndDate ?? new DateTime(1900, 1, 1);
                if (employee.Employment != null) numEmployment.Value = (decimal)employee.Employment;
                txtDepartment.Text = employee.Departement;
                txtRole.Text = employee.Role;
                txtCadreLevel.Text = employee.CadreLevel.ToString();
            }
            if (_currentUser.GetType() == typeof(Trainee))
            {
                Trainee trainee = (Trainee)_currentUser;
                if (trainee.TraineeYears != null) numTraineeYears.Value = (decimal)trainee.TraineeYears;
                if (trainee.ActualTraineeYear != null) numActualTraineeYear.Value = (decimal)trainee.ActualTraineeYear;
            }
            if (_currentUser.GetType() == typeof(Customer))
            {
                Customer customer = (Customer)_currentUser;
                txtCompanyName.Text = customer.CompanyName;
                txtCompanyType.Text = customer.CompanyType;
                txtCompanyContact.Text = customer.CompanyContact;
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {

            if (_currentUser.GetType() == typeof(Trainee))
            {
                _updatedUser = new Trainee()
                {
                    TraineeYears = (int)numTraineeYears.Value,
                    ActualTraineeYear = (int)numActualTraineeYear.Value,
                    StartDate = txtStartDate.Value,
                    EndDate = txtEndDate.Value,
                    Employment = (int)numEmployment.Value,
                    Departement = txtDepartment.Text,
                    Role = txtRole.Text,
                    CadreLevel = (int)txtCadreLevel.Value
                };
            }
            else if (_currentUser.GetType() == typeof(Employee))
            {
                _updatedUser = new Employee()
                {
                    StartDate = txtStartDate.Value,
                    EndDate = txtEndDate.Value,
                    Employment = (int)numEmployment.Value,
                    Departement = txtDepartment.Text,
                    Role = txtRole.Text,
                    CadreLevel = (int)txtCadreLevel.Value
                };
            }
            else if (_currentUser.GetType() == typeof(Customer))
            {
                _updatedUser = new Customer()
                {
                    CompanyName = txtCompanyName.Text,
                    CompanyType = txtCompanyType.Text,
                    CompanyContact = txtCompanyContact.Text
                };
            }
            _updatedUser.Status = btnStatus.Checked;
            _updatedUser.Salutation = txtSalutation.Text;
            _updatedUser.Title = txtTitle.Text;
            _updatedUser.FirstName = txtFirstName.Text;
            _updatedUser.LastName = txtLastName.Text;
            _updatedUser.Gender = txtSex.Text;
            _updatedUser.Nationality = txtNationality.Text;
            _updatedUser.SocialSecurityNumber = txtSocialSecurityNumber.Text;
            _updatedUser.DateOfBirth = txtDateOfBirth.Value;
            _updatedUser.Street = txtStreet.Text;
            _updatedUser.StreetNumber = txtStreetNumber.Text;
            _updatedUser.Place = txtPlace.Text;
            _updatedUser.ZipCode = (int)numZipCode.Value;
            _updatedUser.PhoneNumberMobile = txtPhoneNumberMobile.Text;
            _updatedUser.PhoneNumberPrivate = txtPhoneNumberPrivate.Text;
            _updatedUser.PhoneNumberBusiness = txtPhoneNumberBusiness.Text;
            _updatedUser.Email = txtEmail.Text;

            if(!_currentUser.Contains(_updatedUser))
            {
                _userController.Update(_currentUser, _updatedUser);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
