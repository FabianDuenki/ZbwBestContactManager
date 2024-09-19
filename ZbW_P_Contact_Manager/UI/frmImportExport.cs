using Controller;
using External;
using Model;
using Model.Typing;
using UI.Localization;

namespace ZbW_P_Contact_Manager.UI
{
    /// <summary>
    /// Form for importing and exporting data
    /// </summary>
    public partial class FrmImportExport : Form
    {
        UserController _userController;
        CSVController _csvController;

        /// <summary>
        /// Form for importing and exporting data
        /// </summary>
        public FrmImportExport()
        {
            InitializeComponent();
            _userController = new UserController();
            _csvController = new CSVController();
        }

        /// <summary>
        /// Import model from model type
        /// </summary>
        /// <param name="modelType"></param>
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

        /// <summary>
        /// Export model
        /// </summary>
        /// <param name="modelType">Type to export</param>
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

        /// <summary>
        /// Get the CSV path to an existing model by its type
        /// </summary>
        /// <param name="modelType">Type of the model</param>
        private string GetModelPathByType(ModelType modelType)
        {
            return modelType switch
            {
                ModelType.Employee => _csvController.GetPathByModelType(typeof(Employee)),
                ModelType.Trainee => _csvController.GetPathByModelType(typeof(Trainee)),
                ModelType.Customer or _ => _csvController.GetPathByModelType(typeof(Customer)),
            };
        }

        /// <summary>
        /// Get the path to a selected folder
        /// </summary>
        /// <returns>The path to the folder selected</returns>
        private string GetFolderPathViaDialog()
        {
            using (var dialog = new System.Windows.Forms.FolderBrowserDialog())
            {
                System.Windows.Forms.DialogResult result = dialog.ShowDialog();
                return dialog.SelectedPath;
            }
        }

        /// <summary>
        /// Import employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnImportEmployee_Click(object sender, EventArgs e)
        {
            ImportModel(ModelType.Employee);
        }

        /// <summary>
        /// Import customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExportEmployee_Click(object sender, EventArgs e)
        {
            ImportModel(ModelType.Customer);
        }

        /// <summary>
        /// Export employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnImportCustomer_Click(object sender, EventArgs e)
        {
            ExportModel(ModelType.Employee);
        }

        /// <summary>
        /// Export customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExportCustomer_Click(object sender, EventArgs e)
        {
            ExportModel(ModelType.Customer);
        }

        /// <summary>
        /// Export trainee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportTrainee_Click(object sender, EventArgs e)
        {
            ExportModel(ModelType.Trainee);
        }
    }
}
