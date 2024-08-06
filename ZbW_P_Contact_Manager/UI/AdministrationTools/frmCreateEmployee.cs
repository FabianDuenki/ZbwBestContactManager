using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ZbW_P_Contact_Manager.UI
{
    public partial class frmCreateEmployee : Form
    {
        public frmCreateEmployee()
        {
            InitializeComponent();
        }

        private void txtSocialSecurityNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, the dot character, and control characters (like backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSocialSecurityNumber_TextChanged(object sender, EventArgs e)
        {
            ValidateSocialSecurityNumber();
        }

        private void ValidateSocialSecurityNumber()
        {
            // Regular expression to match the required format
            string pattern = @"^\d{3}\.\d{4}\.\d{4}\.\d{2}$";
            Regex regex = new Regex(pattern);

            // Validate the input format
            if (!regex.IsMatch(txtSocialSecurityNumber.Text))
            {
                txtSocialSecurityNumber.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                txtSocialSecurityNumber.BackColor = System.Drawing.Color.White;
            }
        }

        private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, control characters (like backspace), and '+' character for international numbers
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '+')
            {
                e.Handled = true;
            }
        }

        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidatePhoneNumber(sender as TextBox);
        }

        private void ValidatePhoneNumber(TextBox textBox)
        {
            // Regular expression to match phone numbers (basic format, can be adjusted)
            string pattern = @"^\+?\d{0,15}$";
            Regex regex = new Regex(pattern);

            // Validate the input format
            if (!regex.IsMatch(textBox.Text))
            {
                textBox.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                textBox.BackColor = System.Drawing.Color.White;
            }
        }

        private void EmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow all characters for email input, we'll validate on TextChanged
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateEmail(sender as TextBox);
        }

        private void ValidateEmail(TextBox textBox)
        {
            // Regular expression to match email addresses
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(pattern);

            // Validate the input format
            if (!regex.IsMatch(textBox.Text))
            {
                textBox.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                textBox.BackColor = System.Drawing.Color.White;
            }
        }

        private void NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (like backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NumberTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateNumber(sender as TextBox);
        }

        private void ValidateNumber(TextBox textBox)
        {
            // Regular expression to match only numbers
            string pattern = @"^\d+$";
            Regex regex = new Regex(pattern);

            // Validate the input format
            if (!regex.IsMatch(textBox.Text))
            {
                textBox.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                textBox.BackColor = System.Drawing.Color.White;
            }
        }

        private void SetDatePickerStyle(DateTimePicker dateTimePicker)
        {
            dateTimePicker.CalendarMonthBackground = Color.FromArgb(74, 79, 99);
            dateTimePicker.CalendarForeColor = SystemColors.ScrollBar;
        }

        private void frmCreateEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
