using Controller;
using Model;

namespace ZbW_P_Contact_Manager
{
    public partial class Notes : Form
    {
        Guid _personId;
        NotesController _notesController = new NotesController();

        public Notes(Guid personId)
        {
            _personId = personId;

            InitializeComponent();
            InitializeListView();
            LoadNotesInListView();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // TODO: get person name from logged in user => function yet missing
            _notesController.Create(_personId, TxtBoxComment.Text, "PersonXY");

            LoadNotesInListView();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
        }

        private void InitializeListView()
        {
            ListViewHistory.Columns.Clear();
            ListViewHistory.Items.Clear();
            BtnEditComment.Visible = false;

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

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (ListViewHistory.SelectedItems.Count == 1)
            {
                TxtBoxComment.Text = ListViewHistory.SelectedItems[0].SubItems[1].Text;
                ChangeButtonStates(false, false, false, true);
            }
        }

        private void ChangeButtonStates(bool btnSave, bool btnEdit, bool btnDelete, bool btnEditComment)
        {
            BtnSave.Visible = btnSave;
            BtnEditComment.Visible = btnEditComment;
        }
    }
}
