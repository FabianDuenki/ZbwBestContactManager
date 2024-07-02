using Controller;
using Model;

namespace ZbW_P_Contact_Manager
{
    public partial class Notes : Form
    {
        Person _person;
        NotesController _notesController;

        public Notes(Person person)
        {
            InitializeComponent();
            
            _person = person;
            _notesController = new NotesController();

            InitializeListView();
            LoadNotesInListView();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // TODO: get created by user from logged in user => missing right now
            _notesController.CreateNote(_person.Id, TxtBoxComment.Text, "PersonXY");

            LoadNotesInListView();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        public void LoadNotesInListView()
        {
            ListViewHistory.Items.Clear();
            
            var notes = _notesController.LoadNotes(_person.Id);
            
            foreach (var note in notes)
            {
                // TODO: check nullable values
                string[] row = { note.Id.ToString(), note.Comment, note.CreatedAt.ToString(), note.CreatedBy };
                ListViewHistory.Items.Add(new ListViewItem(row));
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            // TODO: do we need update functionality?
            // if yes: new window for edits
            // if not: remove notes model update fields
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var selectedItem = ListViewHistory.SelectedItems[0];
            string id = selectedItem.SubItems[0].Text;

            _notesController.DeleteNote(_person.Id, Guid.Parse(id));
            LoadNotesInListView();
        }
    }
}
