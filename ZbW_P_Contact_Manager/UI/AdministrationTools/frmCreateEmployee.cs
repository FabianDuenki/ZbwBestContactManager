using Model;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ZbW_P_Contact_Manager.UI
{
    public partial class frmCreateEmployee : Form
    {
        public string EmployeeStatus { get; private set; }
        public string EmployeeSalutation { get; private set; }
        public string EmployeeTitle { get; private set; }
        public string EmployeeFirstName { get; private set; }
        public string EmployeeLastName { get; private set; }

        public string EmployeeGender { get; private set; }
        public string EmployeeDateOfBirth { get; private set; }
        public string EmployeeNationality { get; private set; }

        public string EmployeeStreet { get; private set; }
        public string EmployeeStreetNumber { get; private set; }
        public string EmployeeZipCode { get; private set; }
        public string EmployeePlace { get; private set; }

        public string EmployeeSocialSecurityNumber { get; private set; }
        public string EmployeeEmail { get; private set; }

        public string EmployeePhoneNumberPrivate { get; private set; }
        public string EmployeePhoneNumberMobile { get; private set; }
        public string EmployeePhoneNumberBusiness { get; private set; }

        public string EmployeeDepartment { get; private set; }
        public string EmployeeStartDate { get; private set; }
        public string EmployeeEndDate { get; private set; }
        public string EmployeeEmployment { get; private set; }
        public string EmployeeRole { get; private set; }
        public string EmployeeCadreLevel { get; private set; }

        // Constructor for the Create Employee form
        public frmCreateEmployee()
        {
            InitializeComponent(); // Initialize the form components
        }

        // Event handler for key press event on Social Security Number text box
        private void txtSocialSecurityNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, the dot character, and control characters (like backspace)
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar);
        }

        // Event handler for text changed event on Social Security Number text box
        private void txtSocialSecurityNumber_TextChanged(object sender, EventArgs e)
        {
            // Validate the input format of the Social Security Number
            ValidateInput(txtSocialSecurityNumber, @"^\d{3}\.\d{4}\.\d{4}\.\d{2}$");
        }

        // Event handler for key press event on Phone Number text box
        private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, control characters (like backspace), and '+' character for international numbers
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '+';
        }

        // Event handler for text changed event on Phone Number text box
        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            // Validate the input format of the phone number
            ValidateInput(sender as TextBox, @"^\+?\d{0,15}$");
        }

        // Event handler for text changed event on Email text box
        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            // Validate the input format of the email address
            ValidateInput(sender as TextBox, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        // Event handler for key press event on Number text box
        private void NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (like backspace)
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        // Event handler for text changed event on Number text box
        private void NumberTextBox_TextChanged(object sender, EventArgs e)
        {
            // Validate the input format of the number
            ValidateInput(sender as TextBox, @"^\d+$");
        }

        // General method to validate input against a regular expression pattern
        private void ValidateInput(TextBox textBox, string pattern)
        {
            // Create a regex object with the provided pattern
            Regex regex = new Regex(pattern);

            // Validate the input format and set the background color based on the validation result
            textBox.BackColor = regex.IsMatch(textBox.Text) ? Color.White : Color.Red;
        }

        // Method to set the style of a DateTimePicker control
        private void SetDatePickerStyle(DateTimePicker dateTimePicker)
        {
            // Set the calendar background color
            dateTimePicker.CalendarMonthBackground = Color.FromArgb(74, 79, 99);

            // Set the calendar foreground color
            dateTimePicker.CalendarForeColor = SystemColors.ScrollBar;
        }

        private void btnCreateNewEmployee_Click(object sender, EventArgs e)
        {
            // Collect data from text boxes
            EmployeeStatus = txtStatus.Text;
            EmployeeSalutation = txtSalutation.Text;
            EmployeeTitle = txtTitle.Text;
            EmployeeFirstName = txtFirstName.Text;
            EmployeeLastName = txtLastName.Text;

            EmployeeGender = txtSex.Text;
            EmployeeDateOfBirth = txtDateOfBirth.Text;
            EmployeeNationality = txtNationality.Text;

            EmployeeStreet = txtStreet.Text;
            EmployeeStreetNumber = txtStreetNumber.Text;
            EmployeeZipCode = txtZipCode.Text;
            EmployeePlace = txtPlace.Text;

            EmployeeSocialSecurityNumber = txtSocialSecurityNumber.Text;
            EmployeeEmail = txtEmail.Text;

            EmployeePhoneNumberPrivate = txtPhoneNumberPrivate.Text;
            EmployeePhoneNumberMobile = txtPhoneNumberMobile.Text;
            EmployeePhoneNumberBusiness = txtPhoneNumberBusiness.Text;

            EmployeeDepartment = txtDepartment.Text;
            EmployeeStartDate = txtStartDate.Text;
            EmployeeEndDate = txtEndDate.Text;
            EmployeeEmployment = txtEmployment.Text;
            EmployeeRole = txtRole.Text;
            EmployeeCadreLevel = txtCadreLevel.Text;

            // Optionally validate the data here

            // Set DialogResult to OK to indicate success
            this.DialogResult = DialogResult.OK;

            // Close the form
            this.Close();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
