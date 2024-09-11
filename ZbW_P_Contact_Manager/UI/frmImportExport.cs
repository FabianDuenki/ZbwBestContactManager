using Controller;
using External;
using Model;
using Model.Typing;
using UI.Localization;

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

        private void ImportModel(ModelType modelType)
        {
            Person modal = (Person)ModelController.GetModelByType(modelType);
            string header = modal.ToCsvHeader();
            string text = FileHandler.GetTextFromFilePath(FileHandler.GetFilePathFromPicker());
            bool isHeaderEqual = _csvController.IsHeaderEqual(header, text);

            if (isHeaderEqual)
            {
                object[] models = _csvController.Import(modelType, text);
            }
            else
            {
                MessageBox.Show(SystemMessage.GetMessage(Error.ModelMismatch));
            }
        }

        private void btnImportEmployee_Click(object sender, EventArgs e)
        {
            ImportModel(ModelType.Employee);
        }

        private void btnExportEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnImportCustomer_Click(object sender, EventArgs e)
        {
            ImportModel(ModelType.Customer);
        }

        private void btnExportCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}
