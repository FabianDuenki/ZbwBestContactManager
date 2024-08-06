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
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            home1.Show();
            administration1.Hide();
            customerContact1.Hide();
            search1.Hide();
            importExport1.Hide();
            history1.Hide();
        }

        private void btnAdministration_Click(object sender, EventArgs e)
        {
            home1.Hide();
            administration1.Show();
            customerContact1.Hide();
            search1.Hide();
            importExport1.Hide();
            history1.Hide();
        }

        private void btnCustomerContact_Click(object sender, EventArgs e)
        {
            home1.Hide();
            administration1.Hide();
            customerContact1.Show();
            search1.Hide();
            importExport1.Hide();
            history1.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            home1.Hide();
            administration1.Hide();
            customerContact1.Hide();
            search1.Show();
            importExport1.Hide();
            history1.Hide();
        }

        private void btnImportExport_Click(object sender, EventArgs e)
        {
            home1.Hide();
            administration1.Hide();
            customerContact1.Hide();
            search1.Hide();
            importExport1.Show();
            history1.Hide();
        }
        private void btnHistory_Click(object sender, EventArgs e)
        {
            home1.Hide();
            administration1.Hide();
            customerContact1.Hide();
            search1.Hide();
            importExport1.Hide();
            history1.Show();
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
        }

        private void btnAdministration_Click_1(object sender, EventArgs e)
        {

        }
    }
}
