using Model;

namespace Controller
{
    public class NotesController
    {
        CSVController _csvController;

        public NotesController()
        {
            _csvController = new();
        }

        public void Create(Guid personId, string comment, string createdBy)
        {
            var note = new Note()
            {
                Id = Guid.NewGuid(),
                Comment = comment,
                PersonId = personId,
                CreatedBy = createdBy,
                CreatedAt = DateTime.Now
            };

            _csvController.AddNote(note);
        }

        public List<Note> Read(Guid personId)
        {
            List<Note> notes = _csvController.ReadNotes();
            List<Note> filteredNotes = new();

            foreach (Note note in notes)
            {
                if (note.PersonId == personId)
                {
                    filteredNotes.Add(note);
                }
            }

            return filteredNotes;
        }
    }
}
