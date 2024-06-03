using Model;

namespace Controller
{
    public class NotesController
    {
        List<Note> notes = new List<Note>();

        public NotesController() { }

        public NotesController(List<Note> notes)
        {
            this.notes = notes;
        }

        public void CreateNote(long personId, string comment, string createdBy)
        {
            var note = new Note()
            {
                Id = Guid.NewGuid(),
                Comment = comment,
                PersonId = personId,
                CreatedBy = createdBy,
                CreatedAt = DateTime.Now
            };
            notes.Add(note);
        }

        public void UpdateNote(long personId, Guid noteId, string newComment, string updatedBy)
        {
            var note = notes.Find(n => n.PersonId == personId && n.Id == noteId);

            if (note != null)
            {
                note.Comment = newComment;
                note.UpdatedBy = updatedBy;
                note.UpdatedAt = DateTime.Now;
            }
        }

        public void DeleteAllNotes(long personId)
        {
            var persNotes = notes.FindAll(n => n.PersonId == personId);

            foreach (var note in persNotes)
            {
                notes.Remove(note);
            }
        }

        public void DeleteNote(long personId, Guid noteId)
        {
            var persNote = notes.Find(n => n.PersonId == personId && n.Id == noteId);

            if(persNote != null)
            {
                notes.Remove(persNote);
            }
        }

        public List<Note> LoadNotes(long personId)
        {
            return notes.FindAll(n => n.PersonId == personId);
        }
    }
}
