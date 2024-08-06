using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ZbW_P_Contact_Manager.UI
{
    public partial class Main : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

            );

        public Main()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = BtnDashboard.Height;
            pnlNav.Top = BtnDashboard.Top;
            pnlNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Dashboard";
            this.PnlFormLoader.Controls.Clear();
            frmDashboard frmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = BtnDashboard.Height;
            pnlNav.Top = BtnDashboard.Top;
            pnlNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Dashboard";
            this.PnlFormLoader.Controls.Clear();
            frmDashboard frmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }


        private void btnAdministration_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAdministration.Height;
            pnlNav.Top = btnAdministration.Top;
            btnAdministration.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Administration Tool";
            this.PnlFormLoader.Controls.Clear();
            frmAdministration frmDashboard_Vrb = new frmAdministration() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void btnCustomerContact_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCustomerContact.Height;
            pnlNav.Top = btnCustomerContact.Top;
            btnCustomerContact.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Customer Contact Tool";
            this.PnlFormLoader.Controls.Clear();
            frmCustomerContact frmDashboard_Vrb = new frmCustomerContact() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSearch.Height;
            pnlNav.Top = btnSearch.Top;
            btnSearch.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Search Tool";
            this.PnlFormLoader.Controls.Clear();
            frmSearch frmDashboard_Vrb = new frmSearch() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void btnImportExport_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnImportExport.Height;
            pnlNav.Top = btnImportExport.Top;
            btnImportExport.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Import/Export Tool";
            this.PnlFormLoader.Controls.Clear();
            frmImportExport frmDashboard_Vrb = new frmImportExport() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnHistory.Height;
            pnlNav.Top = btnHistory.Top;
            btnHistory.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "History";
            this.PnlFormLoader.Controls.Clear();
            frmHistory frmDashboard_Vrb = new frmHistory() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Settings";
            this.PnlFormLoader.Controls.Clear();
            frmSettings frmDashboard_Vrb = new frmSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void BtnDashboard_Leave(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAdministration_Leave(object sender, EventArgs e)
        {
            btnAdministration.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCustomerContact_Leave(object sender, EventArgs e)
        {
            btnCustomerContact.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSearch_Leave(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnImportExport_Leave(object sender, EventArgs e)
        {
            btnImportExport.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnHistory_Leave(object sender, EventArgs e)
        {
            btnHistory.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
