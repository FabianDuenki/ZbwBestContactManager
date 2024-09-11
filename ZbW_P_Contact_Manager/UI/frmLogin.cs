using External;
using ZbW_P_Contact_Manager.Controller;

namespace ZbW_P_Contact_Manager.UI
{
    /// <summary>
    /// Form for the login screen
    /// </summary>
    public partial class FrmLogin : Form
    {

        /// <summary>
        /// Login form constructor
        /// </summary>
        public FrmLogin()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// On login button click, check if the user is valid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// On mouse down, move the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Hooks.ReleaseCapture();
                Hooks.SendMessage(Handle, Hooks.WM_NCLBUTTONDOWN, Hooks.HT_CAPTION, 0);
            }
        }

        /// <summary>
        /// On key down, intercept the enter key and call the login click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// On close, set the dialog result to cancel and close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClose(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
