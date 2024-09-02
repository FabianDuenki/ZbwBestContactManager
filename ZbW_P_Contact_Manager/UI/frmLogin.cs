using ZbW_P_Contact_Manager.Controller;
using External;

namespace ZbW_P_Contact_Manager.UI
{
    public partial class frmLogin : Form
    {
        private AuthController _authController;

        public frmLogin()
        {
            InitializeComponent();
            _authController = new AuthController();
        }

        private void OnLoginClick(object sender, EventArgs e)
        {
            if (!_authController.IsUserValid(txtUsername.Text, txtPassword.Text))
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
        }
    }
}
