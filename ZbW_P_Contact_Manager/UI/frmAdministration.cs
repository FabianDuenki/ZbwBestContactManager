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
            SetInitialNavigationStyle(BtnCreateEmployee); // Set initial navigation style to the Create Employee button
        }

        // Method to set the initial navigation style for a button
        private void SetInitialNavigationStyle(Button button)
        {
            SetNavigationStyle(button); // Set the navigation style for the specified button
            button.BackColor = Color.FromArgb(46, 51, 73); // Set the background color of the button
        }

        // Method to set the navigation style for a selected button
        private void SetNavigationStyle(Button button)
        {
            pnlNavAdmin.Height = button.Height; // Set the navigation panel height to button height
            pnlNavAdmin.Top = button.Top; // Set the navigation panel top to button top
            pnlNavAdmin.Left = button.Left; // Set the navigation panel left to button left
            ResetButtonStyles(); // Reset styles of all buttons
            button.BackColor = Color.FromArgb(46, 51, 73); // Set selected button color
        }

        // Method to reset styles of all navigation buttons
        private void ResetButtonStyles()
        {
            BtnCreateEmployee.BackColor = Color.FromArgb(24, 30, 54);
            btnEditEmployee.BackColor = Color.FromArgb(24, 30, 54);
            btnCreateCustomer.BackColor = Color.FromArgb(24, 30, 54);
            btnEditCustomer.BackColor = Color.FromArgb(24, 30, 54);
        }

        // Method to load a form into the pnlAdminFormLoader panel and set the title
        private void LoadForm(Form form, string title)
        {
            lblAdminlTitle.Text = title; // Set the title label text
            pnlAdminFormLoader.Controls.Clear(); // Clear any existing controls
            form.Dock = DockStyle.Fill; // Set form to fill the panel
            form.TopLevel = false; // Set form as non-top-level
            form.TopMost = true; // Set form as topmost
            form.FormBorderStyle = FormBorderStyle.None; // Remove form border
            pnlAdminFormLoader.Controls.Add(form); // Add form to the panel
            form.Show(); // Show the form
        }

        // Event handler for Create Employee button click
        private void BtnCreateEmployee_Click(object sender, EventArgs e)
        {
            SetNavigationStyle(BtnCreateEmployee); // Set navigation style for Create Employee button
            LoadForm(new frmCreateEmployee(), "Add Employee"); // Load the Create Employee form and set the title
        }

        // Event handler for Edit Employee button click
        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            SetNavigationStyle(btnEditEmployee); // Set navigation style for Edit Employee button
            LoadForm(new frmEditEmployee(), "Edit Employee"); // Load the Edit Employee form and set the title
        }

        // Event handler for Create Customer button click
        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            SetNavigationStyle(btnCreateCustomer); // Set navigation style for Create Customer button
            LoadForm(new frmCreateCustomer(), "Add Customer"); // Load the Create Customer form and set the title
        }

        // Event handler for Edit Customer button click
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            SetNavigationStyle(btnEditCustomer); // Set navigation style for Edit Customer button
            LoadForm(new frmEditCustomer(), "Edit Customer"); // Load the Edit Customer form and set the title
        }

        // Event handler for Create Employee button leave
        private void BtnCreateEmployee_Leave(object sender, EventArgs e)
        {
            BtnCreateEmployee.BackColor = Color.FromArgb(24, 30, 54); // Reset the background color of the Create Employee button
        }

        // Event handler for Edit Employee button leave
        private void btnEditEmployee_Leave(object sender, EventArgs e)
        {
            btnEditEmployee.BackColor = Color.FromArgb(24, 30, 54); // Reset the background color of the Edit Employee button
        }

        // Event handler for Create Customer button leave
        private void btnCreateCustomer_Leave(object sender, EventArgs e)
        {
            btnCreateCustomer.BackColor = Color.FromArgb(24, 30, 54); // Reset the background color of the Create Customer button
        }

        // Event handler for Edit Customer button leave
        private void btnEditCustomer_Leave(object sender, EventArgs e)
        {
            btnEditCustomer.BackColor = Color.FromArgb(24, 30, 54); // Reset the background color of the Edit Customer button
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
