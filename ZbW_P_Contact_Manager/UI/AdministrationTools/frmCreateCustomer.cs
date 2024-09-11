using Model;
using System.Text.RegularExpressions;
using UI.AdministrationTools.Classes;
using UI.Helpers;

namespace ZbW_P_Contact_Manager.UI
{
    /// <summary>
    /// Form to create a new customer
    /// </summary>
    public partial class frmCreateCustomer : CreateForm
    {
        /// <summary>
        /// Constructor for the Create Customer form
        /// </summary>
        public frmCreateCustomer()
        {
            InitializeComponent();
            AddRequiredControls([
                ckbStatus,
                txtSalutation,
                txtFirstName,
                txtLastName,
                txtSex,
                txtNationality,
                txtStreet,
                txtStreetNumber,
                txtPlace,
                txtZipCode,
                txtPhoneNumberBusiness,
                txtEmail,
                txtCompanyName,
                txtCompanyType,
                txtCompanyContact
            ]);
        }

        /// <summary>
        /// Event handler for key press event on Social Security Number text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSocialSecurityNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, the dot character, and control characters (like backspace)
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar);
        }

        /// <summary>
        /// Event handler for key press event on Phone Number text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, control characters (like backspace), and '+' character for international numbers
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '+';
        }

        /// <summary>
        /// Event handler for text changed event on Phone Number text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            // Validate the input format of the phone number
            ValidateInput(sender as TextBox, @"^\+?\d{0,15}$");
        }

        /// <summary>
        /// Event handler for text changed event on Email text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            // Validate the input format of the email address
            ValidateInput(sender as TextBox, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        /// <summary>
        /// Event handler for key press event on Number text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (like backspace)
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        /// <summary>
        /// Event handler for text changed event on Number text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberTextBox_TextChanged(object sender, EventArgs e)
        {
            // Validate the input format of the number
            ValidateInput(sender as TextBox, @"^\d+$");
        }

        /// <summary>
        /// General method to validate input against a regular expression pattern
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="pattern"></param>
        private void ValidateInput(TextBox textBox, string pattern)
        {
            // Create a regex object with the provided pattern
            Regex regex = new Regex(pattern);

            // Validate the input format and set the background color based on the validation result
            textBox.BackColor = regex.IsMatch(textBox.Text) ? Color.White : Color.Red;
        }

        /// <summary>
        /// Method to set the style of a DateTimePicker control
        /// </summary>
        /// <param name="dateTimePicker"></param>
        private void SetDatePickerStyle(DateTimePicker dateTimePicker)
        {
            // Set the calendar background color
            dateTimePicker.CalendarMonthBackground = Color.FromArgb(74, 79, 99);

            // Set the calendar foreground color
            dateTimePicker.CalendarForeColor = SystemColors.ScrollBar;
        }

        /// <summary>
        /// Button click event to create a new customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateNewCustomer_Click(object sender, EventArgs e)
        {
            if (!IsFormValid()) return;

            model = new Customer()
            {
                Status = ckbStatus.Checked,
                Salutation = txtSalutation.Text,
                Title = txtTitle.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Gender = txtSex.Text,
                Nationality = txtNationality.Text,
                DateOfBirth = DateTime.Parse(txtDateOfBirth.Text),
                Street = txtStreet.Text,
                StreetNumber = txtStreetNumber.Text,
                Place = txtPlace.Text,
                ZipCode = DataParser.StringToSafeInt(txtZipCode.Text),
                PhoneNumberMobile = txtPhoneNumberMobile.Text,
                PhoneNumberBusiness = txtPhoneNumberBusiness.Text,
                PhoneNumberPrivate = txtPhoneNumberPrivate.Text,
                Email = txtEmail.Text,
                CompanyName = txtCompanyName.Text,
                CompanyType = txtCompanyType.Text,
                CompanyContact = txtCompanyContact.Text,
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
