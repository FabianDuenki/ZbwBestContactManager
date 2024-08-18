using External;
using Controller;
using Model.Typing;

namespace ZbW_P_Contact_Manager.UI
{
    public partial class frmImportExport : Form
    {
        private readonly CSVController csvController = new CSVController();

        public frmImportExport()
        {
            InitializeComponent();
        }

        private void btnImportEmployee_Click(object sender, EventArgs e)
        {
            string text = FileHandler.GetTextFromFilePath(FileHandler.GetFilePathFromPicker());
            object[] employees = csvController.Import(ModelType.Employee, text);
        }

        private void btnExportEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnImportCustomer_Click(object sender, EventArgs e)
        {
            string text = FileHandler.GetTextFromFilePath(FileHandler.GetFilePathFromPicker());
            object[] customers = csvController.Import(ModelType.Customer, text);
        }

        private void btnExportCustomer_Click(object sender, EventArgs e)
        {
               
        }
    }
}
