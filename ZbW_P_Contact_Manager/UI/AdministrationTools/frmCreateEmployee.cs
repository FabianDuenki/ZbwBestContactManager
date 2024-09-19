using Model;
using System.Text.RegularExpressions;
using UI.AdministrationTools.Classes;
using UI.Helpers;

namespace ZbW_P_Contact_Manager.UI
{
    /// <summary>
    /// Form for creating a new employee
    /// </summary>
    public partial class FrmCreateEmployee : CreateForm
    {

        /// <summary>
        /// Constructor for the Create Employee form
        /// </summary>
        public FrmCreateEmployee()
        {
            InitializeComponent();
            AddRequiredControls([
                ckbStatus,
                txtSalutation,
                txtFirstName,
                txtLastName,
                txtSex,
                txtNationality,
                txtSocialSecurityNumber,
                txtStreet,
                txtPlace,
                txtZipCode,
                txtPhoneNumberMobile,
                txtPhoneNumberPrivate,
                txtEmail,
                txtEmployment,
                txtDepartment,
                txtRole,
                txtCadreLevel
            ]);
        }

        /// <summary>
        /// Create a new employee when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCreateNewEmployee_Click(object sender, EventArgs e)
        {
            if (!IsFormValid()) return;

            Employee employee = new()
            {
                Status = ckbStatus.Checked,
                Salutation = txtSalutation.Text,
                Title = txtTitle.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Gender = txtSex.Text,
                Nationality = txtNationality.Text,
                SocialSecurityNumber = txtSocialSecurityNumber.Text,
                DateOfBirth = DateTime.Parse(txtDateOfBirth.Text),
                Street = txtStreet.Text,
                StreetNumber = txtStreetNumber.Text,
                Place = txtPlace.Text,
                ZipCode = DataParser.StringToSafeInt(txtZipCode.Text),
                PhoneNumberMobile = txtPhoneNumberMobile.Text,
                PhoneNumberPrivate = txtPhoneNumberPrivate.Text,
                PhoneNumberBusiness = txtPhoneNumberBusiness.Text,
                Email = txtEmail.Text,
                StartDate = DateTime.Parse(txtStartDate.Text),
                EndDate = DateTime.Parse(txtEndDate.Text),
                Employment = DataParser.StringToSafeInt(txtEmployment.Text),
                Departement = txtDepartment.Text,
                Role = txtRole.Text,
                CadreLevel = DataParser.StringToSafeInt(txtCadreLevel.Text),
            };

            if (ckbTrainee.Checked)
            {
                Trainee trainee = new();
                Array.ForEach(employee.GetType().GetProperties(), property =>
                    trainee.GetType().GetProperty(property.Name)
                    !.SetValue(trainee, property.GetValue(employee)
                ));
                trainee.TraineeYears = DataParser.StringToSafeInt(txtTraineeYears.Text);
                trainee.ActualTraineeYear = DataParser.StringToSafeInt(txtActualTraineeYears.Text);
                model = trainee;
            }
            else
            {
                model = employee;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Validate the input against a regular expression pattern
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="pattern"></param>
        private void ValidateInput(TextBox textBox, string pattern)
        {
            Regex regex = new Regex(pattern);
            textBox.BackColor = regex.IsMatch(textBox.Text) ? Color.White : Color.Red;
        }

        /// <summary>
        /// Set the style of a DateTimePicker control
        /// </summary>
        /// <param name="dateTimePicker"></param>
        private void SetDatePickerStyle(DateTimePicker dateTimePicker)
        {
            dateTimePicker.CalendarMonthBackground = Color.FromArgb(74, 79, 99);
            dateTimePicker.CalendarForeColor = SystemColors.ScrollBar;
        }

        /// <summary>
        /// Enable or disable the trainee year text boxes based on the checkbox state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CkbTrainee_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = ckbTrainee.Checked;
            txtTraineeYears.Enabled = isChecked;
            txtActualTraineeYears.Enabled = isChecked;
        }

        /// <summary>
        /// Validate the social security number input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtSocialSecurityNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar);
        }

        /// <summary>
        /// Validate the social security number input when the text changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtSocialSecurityNumber_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(txtSocialSecurityNumber, @"^\d{3}\.\d{4}\.\d{4}\.\d{2}$");
        }

        /// <summary>
        /// Validate the phone number input when a key is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '+';
        }

        /// <summary>
        /// Validate the phone number input when the text changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(sender as TextBox, @"^\+?\d{0,15}$");
        }

        /// <summary>
        /// Validate the email input when the text changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(sender as TextBox, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        /// <summary>
        /// Validate the number input when a key is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        /// <summary>
        /// Validate the number input when the text changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(sender as TextBox, @"^\d+$");
        }
    }
}
