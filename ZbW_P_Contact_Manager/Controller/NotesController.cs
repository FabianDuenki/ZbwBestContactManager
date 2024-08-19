using Model;
using Model.Typing;

namespace Controller
{
    public class NotesController
    {
        CRUDController _crudController;
        
        public NotesController()
        {
            _crudController = new();
        }

        public void CreateNote(Guid personId, string comment, string createdBy)
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

            _crudController.Create(note);
        }

        public List<Note> LoadNotes(Guid personId)
        {
            return _crudController.Read(personId);
        }

        public void UpdateNote(Guid personId, Guid noteId, string newComment, string updatedBy)
        {
            //var notes = LoadNotes(personId);
            //var noteToUpdate = notes.First(n => n.PersonId == personId && n.Id == noteId);

            //var newNote = new Note()
            //{
            //    Id = noteId,
            //    Comment = newComment,
            //    CreatedAt = noteToUpdate.CreatedAt,
            //    CreatedBy = noteToUpdate.CreatedBy,
            //    UpdatedBy = updatedBy,
            //    UpdatedAt = DateTime.Now,
            //    PersonId = personId,
            //};

            //File.Delete(_filePath);

            //foreach (dynamic note in notes)
            //{
            //    if (note.Id == noteId && note.PersonId == personId)
            //    {
            //        SaveNote(newNote);
            //    }
            //    else
            //    {
            //        SaveNote(note);
            //    }
            //}
        }

        public void DeleteNote(Guid personId, Guid noteId)
        {
            //var notes = LoadNotes(personId);

            //File.Delete(_filePath);

            //foreach (dynamic note in notes)
            //{
            //    if (!(note.Id == noteId && note.PersonId == personId))
            //    {
            //        SaveNote(note);
            //    }
            //}
        }
    }
}
