using External;
using ZbW_P_Contact_Manager.Controller;

namespace ZbW_P_Contact_Manager.UI
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }
        
        private void OnLoginClick(object sender, EventArgs e)
        {
            if (!AuthController.IsUserValid(txtUsername.Text, txtPassword.Text))
            {
                lblError.Visible = true;
                return;
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Hooks.ReleaseCapture();
                Hooks.SendMessage(Handle, Hooks.WM_NCLBUTTONDOWN, Hooks.HT_CAPTION, 0);
            }
        }

        private void OnKeydownInterceptor(object sender, KeyEventArgs e)
        {
            TextBox? textBox = sender as TextBox;
            textBox!.Text = textBox!.Text.Replace(System.Environment.NewLine, "");
            if (e.KeyCode == Keys.Enter)
            {
                OnLoginClick(sender, e);
                return;
            }
        }

        private void OnClose(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
