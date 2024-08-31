using Model;
using ZbW_P_Contact_Manager.UI.AdministrationTools;

namespace ZbW_P_Contact_Manager.UI
{
    public partial class frmAdministration : Form
    {
        // Constructor for the Administration form
        public frmAdministration()
        {
            InitializeComponent();
        }


        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            frmCreateEmployee frmCreateEmployee = new frmCreateEmployee();

            // Show the frmCreateEmployee as a modal dialog
            if (frmCreateEmployee.ShowDialog() == DialogResult.OK)
            {
                Employee employee = (Employee)frmCreateEmployee.model!;

                // Upload employee to a db or save internally
            }
        }

        private void btnCreateNewCustomer_Click(object sender, EventArgs e)
        {
            frmCreateCustomer frmCreateCustomer = new frmCreateCustomer();

            // Show the frmCreatecustomer as a modal dialog
            if (frmCreateCustomer.ShowDialog() == DialogResult.OK)
            {
                Customer customer = (Customer)frmCreateCustomer.model!;

                // Upload customer to a db or save internally
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            frmEditUser frmEditUser = new frmEditUser();
            if (frmEditUser.ShowDialog() == DialogResult.OK)
            {

            }

        }
    }
}
