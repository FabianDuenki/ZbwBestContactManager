﻿using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ZbW_P_Contact_Manager.UI
{
    public partial class Main : Form
    {
        // Importing CreateRoundRectRgn function from Gdi32.dll to create rounded rectangle regions for the form
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse);

        // Constructor for the Main form
        public Main()
        {
            InitializeComponent();
            ApplyInitialStyles(); // Apply initial styles to the form
            LoadDashboard(); // Load the dashboard form on startup
        }

        // Method to apply initial styles to the form
        private void ApplyInitialStyles()
        {
            // Set the form's region to a rounded rectangle
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            SetNavigationStyle(BtnDashboard); // Set initial navigation style to Dashboard button
        }

        // Method to load the dashboard form
        private void LoadDashboard()
        {
            lblTitle.Text = "Dashboard"; // Set the title label text
            LoadForm(new FrmDashboard()); // Load the dashboard form
        }

        // General method to load any form into the pnlFormLoader panel
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

        // Method to set the navigation style for the selected button
        private void SetNavigationStyle(Button button)
        {
            pnlNav.Height = button.Height; // Set the navigation panel height to button height
            pnlNav.Top = button.Top; // Set the navigation panel top to button top
            pnlNav.Left = button.Left; // Set the navigation panel left to button left
            ResetButtonStyles(); // Reset styles of all buttons
            button.BackColor = Color.FromArgb(46, 51, 73); // Set selected button color
        }

        // Method to reset styles of all navigation buttons
        private void ResetButtonStyles()
        {
            BtnDashboard.BackColor = Color.FromArgb(24, 30, 54);
            btnAdministration.BackColor = Color.FromArgb(24, 30, 54);
            btnCustomerContact.BackColor = Color.FromArgb(24, 30, 54);
            btnSearch.BackColor = Color.FromArgb(24, 30, 54);
            btnImportExport.BackColor = Color.FromArgb(24, 30, 54);
            btnHistory.BackColor = Color.FromArgb(24, 30, 54);
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        // Event handler for form load event
        private void Main_Load(object sender, EventArgs e)
        {
            // This event handler is currently empty, add code here if needed when the form loads
        }

        // Event handler for Dashboard button click
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            SetNavigationStyle(BtnDashboard); // Set navigation style for Dashboard button
            lblTitle.Text = "Dashboard"; // Set the title label text
            LoadForm(new FrmDashboard()); // Load the dashboard form
        }

        // Event handler for Administration button click
        private void btnAdministration_Click(object sender, EventArgs e)
        {
            SetNavigationStyle(btnAdministration); // Set navigation style for Administration button
            lblTitle.Text = "Administration Tool"; // Set the title label text
            LoadForm(new frmAdministration()); // Load the administration form
        }

        // Event handler for Search button click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SetNavigationStyle(btnSearch); // Set navigation style for Search button
            lblTitle.Text = "Search Tool"; // Set the title label text
            LoadForm(new frmSearch()); // Load the search form
        }

        // Event handler for Import/Export button click
        private void btnImportExport_Click(object sender, EventArgs e)
        {
            SetNavigationStyle(btnImportExport); // Set navigation style for Import/Export button
            lblTitle.Text = "Import/Export Tool"; // Set the title label text
            LoadForm(new frmImportExport()); // Load the import/export form
        }

        // Event handler for History button click
        private void btnHistory_Click(object sender, EventArgs e)
        {
            SetNavigationStyle(btnHistory); // Set navigation style for History button
            lblTitle.Text = "History"; // Set the title label text
            LoadForm(new frmHistory()); // Load the history form
        }

        // Event handler for Settings button click
        private void btnSettings_Click(object sender, EventArgs e)
        {
            SetNavigationStyle(btnSettings); // Set navigation style for Settings button
            lblTitle.Text = "Settings"; // Set the title label text
            LoadForm(new frmSettings()); // Load the settings form
        }

        // Event handler for exit button click
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit the application
        }
    }
}
