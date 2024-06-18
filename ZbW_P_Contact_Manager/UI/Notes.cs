using Controller;
using Model;

namespace ZbW_P_Contact_Manager
{
    public partial class Notes : Form
    {
        Person _person;

        public Notes(Person person)
        {
            InitializeComponent();
            InitializeListView();

            _person = person;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // TODO: get created by user from logged in user => person.Id field yet missing
            // TODO: create note for specific person from handed over person

            NotesController notesController = new NotesController();
            notesController.CreateNote(1, TxtBoxComment.Text, "Jana");

            LoadNotesListView(notesController.LoadNotes(1));
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeListView()
        {
            ListViewHistory.Columns.Clear();
            ListViewHistory.Items.Clear();

            ListViewHistory.Columns.Add("Notiz");
            ListViewHistory.Columns.Add("Erstellt am");
            ListViewHistory.Columns.Add("Erstellt von");

            ListViewHistory.Columns[0].Width = 400;
            ListViewHistory.Columns[1].Width = 200;
            ListViewHistory.Columns[2].Width = 220;

            // TODO: load items from stored data csv using notes controller
        }

        public void LoadNotesListView(List<Note> notes)
        {
            foreach (var note in notes)
            {
                string[] row = { note.Comment, note.CreatedAt.ToString(), note.CreatedBy };
                ListViewHistory.Items.Add(new ListViewItem(row));
            }
        }
    }
}
