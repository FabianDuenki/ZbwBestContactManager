using Model;
using Model.Typing;

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
                CreatedAt = DateTime.Now,
                UpdatedBy = createdBy,
                UpdatedAt = DateTime.Now,
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

        public void Update(Guid personId, Guid noteId, string newComment, string updatedBy)
        {
            Note note = new Note
            {
                Id = noteId,
                Comment = newComment,
                UpdatedBy = updatedBy,
                UpdatedAt = DateTime.Now
            };

            _csvController.UpdateNote(note);
        }

        public void Delete(Note note)
        {
            _csvController.DeleteNote(note);
        }
    }
}
