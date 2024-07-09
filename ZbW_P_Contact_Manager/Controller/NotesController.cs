using Model;
using Model.Typing;

namespace Controller
{
    public class NotesController
    {
        CSVController _csvController;
        ModelType _modelType;
        string _filePath;
        
        public NotesController()
        {
            _csvController = new CSVController();
            _modelType = ModelType.Note;
            _filePath = _csvController.GetPathByModelType(_modelType);
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

            SaveNote(note);
        }

        public void SaveNote(Note note)
        {
            string csvUser = _csvController.ConvertUserToCsvString(note);
            string filePath = _csvController.GetPathByModelType(_modelType);

            if (!Path.Exists(filePath))
            {
                _csvController.CreateFile(filePath, note);
            }

            File.AppendAllText(filePath, Environment.NewLine);
            File.AppendAllText(filePath, csvUser);
        }

        public List<dynamic> LoadNotes(Guid personId)
        {
            if (!Path.Exists(_filePath))
            {
                return new List<dynamic>();
            }
            string[] csvLines = File.ReadAllLines(_filePath);

            return _csvController.ConvertCsvStringToUsers(_modelType, csvLines);
        }

        public void UpdateNote(Guid personId, Guid noteId, string newComment, string updatedBy)
        {
            var notes = LoadNotes(personId);
            var noteToUpdate = notes.First(n => n.PersonId == personId && n.Id == noteId);

            var newNote = new Note()
            {
                Id = noteId,
                Comment = newComment,
                CreatedAt = noteToUpdate.CreatedAt,
                CreatedBy = noteToUpdate.CreatedBy,
                UpdatedBy = updatedBy,
                UpdatedAt = DateTime.Now,
                PersonId = personId,
            };

            File.Delete(_filePath);

            foreach (dynamic note in notes)
            {
                if (note.Id == noteId && note.PersonId == personId)
                {
                    SaveNote(newNote);
                }
                else
                {
                    SaveNote(note);
                }
            }
        }

        public void DeleteNote(Guid personId, Guid noteId)
        {
            var notes = LoadNotes(personId);

            File.Delete(_filePath);

            foreach (dynamic note in notes)
            {
                if (!(note.Id == noteId && note.PersonId == personId))
                {
                    SaveNote(note);
                }
            }
        }
    }
}
