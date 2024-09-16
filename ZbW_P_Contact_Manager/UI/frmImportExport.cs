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
        CSVController _csvController;

        /// <summary>
        /// Form for importing and exporting data
        /// </summary>
        public FrmImportExport()
        {
            InitializeComponent();
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
        /// Import employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnImportEmployee_Click(object sender, EventArgs e)
        {
            ImportModel(ModelType.Employee);
        }

        /// <summary>
        /// Export employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExportEmployee_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Import customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnImportCustomer_Click(object sender, EventArgs e)
        {
            ImportModel(ModelType.Customer);
        }

        /// <summary>
        /// Export customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExportCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}
