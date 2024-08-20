using Model;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ZbW_P_Contact_Manager.UI
{
    public partial class frmCreateEmployee : Form
    {
        public string Status { get; private set; }
        public string Salutation { get; private set; }
        public string Title { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Gender { get; private set; }
        public string DateOfBirth { get; private set; }
        public string Nationality { get; private set; }
        public string Street { get; private set; }
        public string StreetNumber { get; private set; }
        public string ZipCode { get; private set; }
        public string Place { get; private set; }
        public string SocialSecurityNumber { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumberPrivate { get; private set; }
        public string PhoneNumberMobile { get; private set; }
        public string PhoneNumberBusiness { get; private set; }
        public string Department { get; private set; }
        public string StartDate { get; private set; }
        public string EndDate { get; private set; }
        public string Employment { get; private set; }
        public string Role { get; private set; }
        public string CadreLevel { get; private set; }

        public frmCreateEmployee()
        {
            InitializeComponent();
        }

        private void btnCreateNewEmployee_Click(object sender, EventArgs e)
        {
            // Collect data from text boxes
            Salutation = txtSalutation.Text;
            Title = txtTitle.Text;
            FirstName = txtFirstName.Text;
            LastName = txtLastName.Text;
            Gender = txtSex.Text;
            DateOfBirth = txtDateOfBirth.Text;
            Nationality = txtNationality.Text;
            Street = txtStreet.Text;
            StreetNumber = txtStreetNumber.Text;
            ZipCode = txtZipCode.Text;
            Place = txtPlace.Text;
            SocialSecurityNumber = txtSocialSecurityNumber.Text;
            Email = txtEmail.Text;
            PhoneNumberPrivate = txtPhoneNumberPrivate.Text;
            PhoneNumberMobile = txtPhoneNumberMobile.Text;
            PhoneNumberBusiness = txtPhoneNumberBusiness.Text;
            Department = txtDepartment.Text;
            StartDate = txtStartDate.Text;
            EndDate = txtEndDate.Text;
            Employment = txtEmployment.Text;
            Role = txtRole.Text;
            CadreLevel = txtCadreLevel.Text;

            // Optionally validate the data here

            // Indicate success and close the form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ValidateInput(TextBox textBox, string pattern)
        {
            Regex regex = new Regex(pattern);
            textBox.BackColor = regex.IsMatch(textBox.Text) ? Color.White : Color.Red;
        }

        private void SetDatePickerStyle(DateTimePicker dateTimePicker)
        {
            dateTimePicker.CalendarMonthBackground = Color.FromArgb(74, 79, 99);
            dateTimePicker.CalendarForeColor = SystemColors.ScrollBar;
        }

        private void ckbTrainee_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = ckbTrainee.Checked;
            numActualTraineeYear.Enabled = isChecked;
            numTraineeYears.Enabled = isChecked;
        }

        private void txtSocialSecurityNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar);
        }

        private void txtSocialSecurityNumber_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(txtSocialSecurityNumber, @"^\d{3}\.\d{4}\.\d{4}\.\d{2}$");
        }

        private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '+';
        }

        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(sender as TextBox, @"^\+?\d{0,15}$");
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(sender as TextBox, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private void NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void NumberTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(sender as TextBox, @"^\d+$");
        }
    }
}
