using System;
using System.Drawing;
using System.Windows.Forms;
using ZbW_P_Contact_Manager.UI.AdministrationTools;
//using ZbW_P_Contact_Manager.UI.AdministrationTools;

namespace ZbW_P_Contact_Manager.UI
{
    public partial class frmAdministration : Form
    {
        // Constructor for the Administration form
        public frmAdministration()
        {
            InitializeComponent();
        }


        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            frmCreateEmployee frmCreateEmployee = new frmCreateEmployee();

            // Show the frmCreateEmployee as a modal dialog
            if (frmCreateEmployee.ShowDialog() == DialogResult.OK)
            {
                // Retrieve the new employee data if needed
                string Status = frmCreateEmployee.Status;
                string Salutation = frmCreateEmployee.Salutation;
                string Title = frmCreateEmployee.Title;
                string FistName = frmCreateEmployee.FirstName;
                string LastName = frmCreateEmployee.LastName;

                string Gender = frmCreateEmployee.Gender;
                string DateOfBirth = frmCreateEmployee.DateOfBirth;
                string Nationality = frmCreateEmployee.Nationality;

                string Street = frmCreateEmployee.Street;
                string StreetNumber = frmCreateEmployee.StreetNumber;
                string ZipCode = frmCreateEmployee.ZipCode;
                string Place = frmCreateEmployee.Place;

                string SocialSecurityNumber = frmCreateEmployee.SocialSecurityNumber;
                string Email = frmCreateEmployee.Email;

                string PhoneNumberPrivate = frmCreateEmployee.PhoneNumberPrivate;
                string PhoneNumberMobile = frmCreateEmployee.PhoneNumberMobile;
                string PhoneNumberBusiness = frmCreateEmployee.PhoneNumberBusiness;

                string Departement = frmCreateEmployee.Department;
                string StartDate = frmCreateEmployee.StartDate;
                string EndDate = frmCreateEmployee.EndDate;
                string Employment = frmCreateEmployee.Employment;
                string Role = frmCreateEmployee.Role;
                string CadreLevel = frmCreateEmployee.CadreLevel;


                // Add the employee to your system, e.g., to a list or database
                // Example: AddEmployeeToList(employeeName, employeeId);
            }
        }

        private void btnCreateNewCustomer_Click(object sender, EventArgs e)
        {
            frmCreateCustomer frmCreateCustomer = new frmCreateCustomer();

            // Show the frmCreatecustomer as a modal dialog
            if (frmCreateCustomer.ShowDialog() == DialogResult.OK)
            {
                /* Retrieve the new customer data if needed
                string customerStatus = frmCreatecustomer.customerStatus;
                string customerSalutation = frmCreatecustomer.customerSalutation;
                string customerTitle = frmCreatecustomer.customerTitle;
                string customerFistName = frmCreatecustomer.customerFirstName;
                string customerLastName = frmCreatecustomer.customerLastName;

                string customerGender = frmCreatecustomer.customerGender;
                string customerDateOfBirth = frmCreatecustomer.customerDateOfBirth;
                string customerNationality = frmCreatecustomer.customerNationality;

                string customerStreet = frmCreatecustomer.customerStreet;
                string customerStreetNumber = frmCreatecustomer.customerStreetNumber;
                string customerZipCode = frmCreatecustomer.customerZipCode;
                string customerPlace = frmCreatecustomer.customerPlace;

                string customerSocialSecurityNumber = frmCreatecustomer.customerSocialSecurityNumber;
                string customerEmail = frmCreatecustomer.customerEmail;

                string customerPhoneNumberPrivate = frmCreatecustomer.customerPhoneNumberPrivate;
                string customerPhoneNumberMobile = frmCreatecustomer.customerPhoneNumberMobile;
                string customerPhoneNumberBusiness = frmCreatecustomer.customerPhoneNumberBusiness;

                string customerDepartement = frmCreatecustomer.customerDepartment;
                string customerStartDate = frmCreatecustomer.customerStartDate;
                string customerEndDate = frmCreatecustomer.customerEndDate;
                string customerEmployment = frmCreatecustomer.customerEmployment;
                string customerRole = frmCreatecustomer.customerRole;
                string customerCadreLevel = frmCreatecustomer.customerCadreLevel;
                */


                // Add the customer to your system, e.g., to a list or database
                // Example: AddcustomerToList(customerName, customerId);
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            frmEditUser frmEditUser = new frmEditUser();
            if (frmEditUser.ShowDialog() == DialogResult.OK)
            {

            }

        }
    }
}
