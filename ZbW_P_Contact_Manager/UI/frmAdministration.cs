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
                string employeeStatus = frmCreateEmployee.EmployeeStatus;
                string employeeSalutation = frmCreateEmployee.EmployeeSalutation;
                string employeeTitle = frmCreateEmployee.EmployeeTitle;
                string employeeFistName = frmCreateEmployee.EmployeeFirstName;
                string employeeLastName = frmCreateEmployee.EmployeeLastName;

                string employeeGender = frmCreateEmployee.EmployeeGender;
                string employeeDateOfBirth = frmCreateEmployee.EmployeeDateOfBirth;
                string employeeNationality = frmCreateEmployee.EmployeeNationality;

                string employeeStreet = frmCreateEmployee.EmployeeStreet;
                string employeeStreetNumber = frmCreateEmployee.EmployeeStreetNumber;
                string employeeZipCode = frmCreateEmployee.EmployeeZipCode;
                string employeePlace = frmCreateEmployee.EmployeePlace;

                string employeeSocialSecurityNumber = frmCreateEmployee.EmployeeSocialSecurityNumber;
                string employeeEmail = frmCreateEmployee.EmployeeEmail;

                string employeePhoneNumberPrivate = frmCreateEmployee.EmployeePhoneNumberPrivate;
                string employeePhoneNumberMobile = frmCreateEmployee.EmployeePhoneNumberMobile;
                string employeePhoneNumberBusiness = frmCreateEmployee.EmployeePhoneNumberBusiness;

                string employeeDepartement = frmCreateEmployee.EmployeeDepartment;
                string employeeStartDate = frmCreateEmployee.EmployeeStartDate;
                string employeeEndDate = frmCreateEmployee.EmployeeEndDate;
                string employeeEmployment = frmCreateEmployee.EmployeeEmployment;
                string employeeRole = frmCreateEmployee.EmployeeRole;
                string employeeCadreLevel = frmCreateEmployee.EmployeeCadreLevel;


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
