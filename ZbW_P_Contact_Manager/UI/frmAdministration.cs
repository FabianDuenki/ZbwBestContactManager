using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZbW_P_Contact_Manager.UI
{
    public partial class frmAdministration : Form
    {
        public frmAdministration()
        {
            InitializeComponent();

            pnlNavAdmin.Height = BtnCreateEmployee.Height;
            pnlNavAdmin.Top = BtnCreateEmployee.Top;
            pnlNavAdmin.Left = BtnCreateEmployee.Left;
            BtnCreateEmployee.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCreateEmployee_Click(object sender, EventArgs e)
        {
            pnlNavAdmin.Height = BtnCreateEmployee.Height;
            pnlNavAdmin.Top = BtnCreateEmployee.Top;
            pnlNavAdmin.Left = BtnCreateEmployee.Left;
            BtnCreateEmployee.BackColor = Color.FromArgb(46, 51, 73);

            lblAdminlTitle.Text = "Add Employee";
            this.pnlAdminFormLoader.Controls.Clear();
            frmCreateEmployee frmCreateEmployee_Vrb = new frmCreateEmployee() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmCreateEmployee_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlAdminFormLoader.Controls.Add(frmCreateEmployee_Vrb);
            frmCreateEmployee_Vrb.Show();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            pnlNavAdmin.Height = btnEditEmployee.Height;
            pnlNavAdmin.Top = btnEditEmployee.Top;
            btnEditEmployee.BackColor = Color.FromArgb(46, 51, 73);

            lblAdminlTitle.Text = "Edit Employee";
            this.pnlAdminFormLoader.Controls.Clear();
            frmEditEmployee frmCreateEmployee_Vrb = new frmEditEmployee() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmCreateEmployee_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlAdminFormLoader.Controls.Add(frmCreateEmployee_Vrb);
            frmCreateEmployee_Vrb.Show();
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            pnlNavAdmin.Height = btnCreateCustomer.Height;
            pnlNavAdmin.Top = btnCreateCustomer.Top;
            btnCreateCustomer.BackColor = Color.FromArgb(46, 51, 73);

            lblAdminlTitle.Text = "Add Customer";
            this.pnlAdminFormLoader.Controls.Clear();
            frmCreateCustomer frmCreateEmployee_Vrb = new frmCreateCustomer() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmCreateEmployee_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlAdminFormLoader.Controls.Add(frmCreateEmployee_Vrb);
            frmCreateEmployee_Vrb.Show();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            pnlNavAdmin.Height = btnEditCustomer.Height;
            pnlNavAdmin.Top = btnEditCustomer.Top;
            btnEditCustomer.BackColor = Color.FromArgb(46, 51, 73);

            lblAdminlTitle.Text = "Edit Customer";
            this.pnlAdminFormLoader.Controls.Clear();
            frmEditCustomer frmCreateEmployee_Vrb = new frmEditCustomer() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmCreateEmployee_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlAdminFormLoader.Controls.Add(frmCreateEmployee_Vrb);
            frmCreateEmployee_Vrb.Show();
        }

        private void BtnCreateEmployee_Leave(object sender, EventArgs e)
        {
            BtnCreateEmployee.BackColor = Color.FromArgb(24, 0, 54);
        }

        private void btnEditEmployee_Leave(object sender, EventArgs e)
        {
            btnEditEmployee.BackColor = Color.FromArgb(24, 0, 54);
        }

        private void btnCreateCustomer_Leave(object sender, EventArgs e)
        {
            btnCreateCustomer.BackColor = Color.FromArgb(24, 0, 54);
        }

        private void btnEditCustomer_Leave(object sender, EventArgs e)
        {
            btnEditCustomer.BackColor = Color.FromArgb(24, 0, 54);
        }
    }
}
