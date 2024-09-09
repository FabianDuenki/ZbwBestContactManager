using Controller;
using Model;
using Model.Typing;
using ZbW_P_Contact_Manager.UI.AdministrationTools;

namespace ZbW_P_Contact_Manager.UI
{
    public partial class frmAdministration : Form
    {
        private UserController _userController;

        // Constructor for the Administration form
        public frmAdministration()
        {
            _userController = new UserController();
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            frmCreateEmployee frmCreateEmployee = new frmCreateEmployee();
            if (frmCreateEmployee.ShowDialog() == DialogResult.OK)
                _userController.Create(
                    frmCreateEmployee.model!.GetType().Name == "Employee" 
                    ? (Employee)frmCreateEmployee.model! 
                    : (Trainee)frmCreateEmployee.model!
                );
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmCreateCustomer frmCreateCustomer = new frmCreateCustomer();
            if (frmCreateCustomer.ShowDialog() == DialogResult.OK)
                _userController.Create((Customer)frmCreateCustomer.model!);
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
