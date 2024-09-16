using External;
using Controller;
using Model.Typing;
using Model;
using UI.Localization;

namespace ZbW_P_Contact_Manager.UI
{
    public partial class frmImportExport : Form
    {
        UserController _userController;
        CSVController _csvController;

        public frmImportExport()
        {
            InitializeComponent();
            _userController = new UserController();
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

        private void ExportModel(ModelType modelType)
        {
            string filePath = GetModelPathByType(modelType);
            if (!File.Exists(filePath))
                MessageBox.Show(SystemMessage.GetMessage(Error.ModelFileMissing));
            else
            {
                string folderPath = GetFolderPathViaDialog();
                File.Copy(filePath, $"{folderPath}\\{modelType}.csv");
            }
        }

        private string GetModelPathByType(ModelType modelType)
        {
            return modelType switch
            {
                ModelType.Employee => _csvController.GetPathByModelType(typeof(Employee)),
                ModelType.Trainee => _csvController.GetPathByModelType(typeof(Trainee)),
                ModelType.Customer or _ => _csvController.GetPathByModelType(typeof(Customer)),
            };
        }

        private string GetFolderPathViaDialog()
        {
            using (var dialog = new System.Windows.Forms.FolderBrowserDialog())
            {
                System.Windows.Forms.DialogResult result = dialog.ShowDialog();
                return dialog.SelectedPath;
            }
        }

        private void btnImportEmployee_Click(object sender, EventArgs e)
        {
            ImportModel(ModelType.Employee);
        }

        private void btnImportCustomer_Click(object sender, EventArgs e)
        {
            ImportModel(ModelType.Customer);
        }

        private void btnExportEmployee_Click(object sender, EventArgs e)
        {
            ExportModel(ModelType.Employee);
        }

        private void btnExportCustomer_Click(object sender, EventArgs e)
        {
            ExportModel(ModelType.Customer);
        }

        private void btnExportTrainee_Click(object sender, EventArgs e)
        {
            ExportModel(ModelType.Trainee);
        }
    }
}
