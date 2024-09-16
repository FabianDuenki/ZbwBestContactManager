namespace ZbW_P_Contact_Manager.UI
{
    /// <summary>
    /// Main form class for the application sizeable version
    /// </summary>
    public partial class MainSizeable : Form
    {
        /// <summary>
        /// Constructor for the Main form
        /// </summary>
        public MainSizeable()
        {
            InitializeComponent();
            ApplyInitialStyles(); // Apply initial styles to the form
            OpenLoginMenu(); // Open Login Menu
            LoadDashboard(); // Load the dashboard form on startup
        }

        /// <summary>
        /// Method to apply initial styles to the form
        /// </summary>
        private void ApplyInitialStyles()
        {
            // Set the form's region to a rounded rectangle
            SetNavigationStyle(BtnDashboard); // Set initial navigation style to Dashboard button
        }

        /// <summary>
        /// Method to load the dashboard form
        /// </summary>
        private void LoadDashboard()
        {
            lblTitle.Text = "Dashboard"; // Set the title label text
            LoadForm(new FrmDashboard()); // Load the dashboard form
        }

        /// <summary>
        /// General method to load any form into the pnlFormLoader panel
        /// </summary>
        /// <param name="form"></param>
        private void LoadForm(Form form)
        {
            this.pnlFormLoader.Controls.Clear(); // Clear any existing controls
            form.Dock = DockStyle.Fill; // Set form to fill the panel
            form.TopLevel = false; // Set form as non-top-level
            form.TopMost = true; // Set form as topmost
            form.FormBorderStyle = FormBorderStyle.None; // Remove form border
            this.pnlFormLoader.Controls.Add(form); // Add form to the panel
            form.Show(); // Show the form
        }

        /// <summary>
        /// Method to set the navigation style for the selected button
        /// </summary>
        /// <param name="button"></param>
        private void SetNavigationStyle(Button button)
        {
            pnlNav.Height = button.Height; // Set the navigation panel height to button height
            pnlNav.Top = button.Top; // Set the navigation panel top to button top
            pnlNav.Left = button.Left; // Set the navigation panel left to button left
            ResetButtonStyles(); // Reset styles of all buttons
            button.BackColor = Color.FromArgb(12, 6, 172); // Set selected button color
        }

        /// <summary>
        /// Method to reset styles of all navigation buttons
        /// </summary>
        private void ResetButtonStyles()
        {
            BtnDashboard.BackColor = Color.FromArgb(0, 0, 77);
            btnAdministration.BackColor = Color.FromArgb(0, 0, 77);
            btnImportExport.BackColor = Color.FromArgb(0, 0, 77);
        }

        /// <summary>
        /// Opens the Login menu
        /// </summary>
        private void OpenLoginMenu()
        {
            FrmLogin frmLogin = new FrmLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK) return;
            Environment.Exit(0);
        }

        /// <summary>
        /// Event handler for form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            // This event handler is currently empty, add code here if needed when the form loads
        }

        /// <summary>
        /// Event handler for Dashboard button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            SetNavigationStyle(BtnDashboard); // Set navigation style for Dashboard button
            lblTitle.Text = "Dashboard"; // Set the title label text
            LoadForm(new FrmDashboard()); // Load the dashboard form
        }

        /// <summary>
        /// Event handler for Administration button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdministration_Click(object sender, EventArgs e)
        {
            SetNavigationStyle(btnAdministration); // Set navigation style for Administration button
            lblTitle.Text = "Administration Tool"; // Set the title label text
            LoadForm(new FrmAdministration()); // Load the administration form
        }

        /// <summary>
        /// Event handler for Search button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Search Tool"; // Set the title label text
            LoadForm(new FrmSearch()); // Load the search form
        }

        /// <summary>
        ///  Event handler for Import/Export button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImportExport_Click(object sender, EventArgs e)
        {
            SetNavigationStyle(btnImportExport); // Set navigation style for Import/Export button
            lblTitle.Text = "Import/Export Tool"; // Set the title label text
            LoadForm(new FrmImportExport()); // Load the import/export form
        }

        /// <summary>
        /// Event handler for History button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHistory_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "History"; // Set the title label text
            LoadForm(new FrmHistory()); // Load the history form
        }

        /// <summary>
        /// Event handler for exit button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit the application
        }
    }
}
