using Controller;
using ZbW_P_Contact_Manager.Controller;

namespace ZbW_P_Contact_Manager
{
    /// <summary>
    /// Form to display and manage notes for a person
    /// </summary>
    public partial class FrmNotes : Form
    {
        Guid _personId;
        NotesController _notesController = new NotesController();

        /// <summary>
        /// Notes form constructor
        /// </summary>
        /// <param name="personId"></param>
        public FrmNotes(Guid personId)
        {
            _personId = personId;

            InitializeComponent();
            InitializeListView();
            LoadNotesInListView();
        }

        /// <summary>
        /// Button to save a note
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            var currentUser = "undefined";

            if (AuthController.User != null)
            {
                currentUser = AuthController.User.GetFullName();
            }

            _notesController.Create(_personId, TxtBoxComment.Text, currentUser);
            LoadNotesInListView();
        }

        /// <summary>
        /// Initialize the list view
        /// </summary>
        private void InitializeListView()
        {
            ListViewHistory.Columns.Clear();
            ListViewHistory.Items.Clear();

            var columnNames = new List<string>() { "Id", "Notiz", "Erstellt am", "Erstellt von" };

            foreach (var column in columnNames)
            {
                ListViewHistory.Columns.Add(column);
            }

            ListViewHistory.Columns[0].Width = 0;
            ListViewHistory.Columns[1].Width = 300;
            ListViewHistory.Columns[2].Width = 200;
            ListViewHistory.Columns[3].Width = 200;
        }

        /// <summary>
        /// Load notes in list view
        /// </summary>
        public void LoadNotesInListView()
        {
            ListViewHistory.Items.Clear();
            TxtBoxComment.Clear();

            var notes = _notesController.Read(_personId);

            foreach (var note in notes)
            {
                string[] row = { note.Id.ToString(), note.Comment, note.CreatedAt.ToString(), note.CreatedBy };
                ListViewHistory.Items.Add(new ListViewItem(row));
            }
        }

        /// <summary>
        /// Button to edit a note
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (ListViewHistory.SelectedItems.Count == 1)
            {
                TxtBoxComment.Text = ListViewHistory.SelectedItems[0].SubItems[1].Text;
                ChangeButtonStates(false, false, false, true);
            }
        }

        /// <summary>
        /// Changes button states
        /// </summary>
        /// <param name="btnSave"></param>
        /// <param name="btnEdit"></param>
        /// <param name="btnDelete"></param>
        /// <param name="btnEditComment"></param>
        private void ChangeButtonStates(bool btnSave, bool btnEdit, bool btnDelete, bool btnEditComment)
        {
            BtnSave.Visible = btnSave;
        }
    }
}
