using Model;
using System.Text.RegularExpressions;
using UI.Helpers;

namespace ZbW_P_Contact_Manager.UI
{
    public partial class frmCreateEmployee : Form
    {
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


         /// <summary>
         /// Method to create a new Employee
         /// </summary>
         /// <param name="sender">Sender object</param>
         /// <param name="e">Event arguments</param>
        private void btnCreateNewEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee
            {
                Salutation = txtSalutation.Text,
                Title = txtTitle.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Nationality = txtNationality.Text,
                SocialSecurityNumber = txtSocialSecurityNumber.Text,
                Email = txtEmail.Text,
                Street = txtStreet.Text,
                StreetNumber = txtStreetNumber.Text,
                ZipCode = Sanitizer.StringToInt(txtZipCode.Text),
                Place = txtPlace.Text,
                PhoneNumberPrivate = txtPhoneNumberPrivate.Text,
                PhoneNumberMobile = txtPhoneNumberMobile.Text,
                PhoneNumberBusiness = txtPhoneNumberBusiness.Text,
                StartDate = DateTime.Parse(txtStartDate.Text),
                EndDate = DateTime.Parse(txtEndDate.Text),
                Employment = Sanitizer.StringToInt(txtEmployment.Text),
                Departement = txtDepartment.Text,
                Role = txtRole.Text,
                CadreLevel = Sanitizer.StringToInt(txtCadreLevel.Text)
            };
        }
    }
}
