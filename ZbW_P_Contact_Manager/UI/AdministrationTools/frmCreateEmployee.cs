using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ZbW_P_Contact_Manager.UI
{
    public partial class frmCreateEmployee : Form
    {
        public frmCreateEmployee()
        {
            InitializeComponent();
            // Hook up event handlers if not done in designer
            this.txtSocialSecurityNumber.KeyPress += new KeyPressEventHandler(this.txtSocialSecurityNumber_KeyPress);
            this.txtSocialSecurityNumber.TextChanged += new EventHandler(this.txtSocialSecurityNumber_TextChanged);
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
            ValidateInput();
        }

        private void ValidateInput()
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
    }
}
