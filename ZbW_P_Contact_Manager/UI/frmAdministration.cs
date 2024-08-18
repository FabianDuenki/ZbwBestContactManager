using System;
using System.Drawing;
using System.Windows.Forms;
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
    }
}
