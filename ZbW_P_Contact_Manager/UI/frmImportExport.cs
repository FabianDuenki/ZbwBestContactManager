using External;
using Controller;
using Model.Typing;

namespace ZbW_P_Contact_Manager.UI
{
    public partial class frmImportExport : Form
    {
        CSVController _csvController;

        public frmImportExport()
        {
            InitializeComponent();
            _csvController = new CSVController();
        }

        private void btnImportEmployee_Click(object sender, EventArgs e)
        {
            string text = FileHandler.GetTextFromFilePath(FileHandler.GetFilePathFromPicker());
            object[] employees = _csvController.Import(ModelType.Employee, text);
        }

        private void btnExportEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnImportCustomer_Click(object sender, EventArgs e)
        {
            string text = FileHandler.GetTextFromFilePath(FileHandler.GetFilePathFromPicker());
            object[] customers = _csvController.Import(ModelType.Customer, text);
        }

        private void btnExportCustomer_Click(object sender, EventArgs e)
        {
               
        }
    }
}
