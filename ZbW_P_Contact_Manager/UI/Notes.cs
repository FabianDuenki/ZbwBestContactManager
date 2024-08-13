﻿using Controller;

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
            _notesController.CreateNote(_personId, TxtBoxComment.Text, "PersonXY"); // TODO: get person name from logged in user => function yet missing

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

            var notes = _notesController.LoadNotes(_personId);

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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(ListViewHistory.SelectedItems.Count == 1)
            {
                string noteId = ListViewHistory.SelectedItems[0].SubItems[0].Text;
                _notesController.DeleteNote(_personId, Guid.Parse(noteId));

                LoadNotesInListView();
            }
        }

        private void BtnEditCommand_Click(object sender, EventArgs e)
        {
            var noteId = ListViewHistory.SelectedItems[0].SubItems[0].Text;
            _notesController.UpdateNote(_personId, Guid.Parse(noteId), TxtBoxComment.Text, "NewPersonXY"); // TODO: get logged in edit person

            LoadNotesInListView();
            ChangeButtonStates(true, true, true, false);
        }

        private void ChangeButtonStates(bool btnSave, bool btnEdit, bool btnDelete, bool btnEditComment)
        {
            BtnSave.Visible = btnSave;
            BtnEdit.Enabled = btnEdit;
            BtnDelete.Enabled = btnDelete;
            BtnEditComment.Visible = btnEditComment;
        }
    }
}