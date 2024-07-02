using Model;
using Services;

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
            notes.Add(note);

            SaveNote(note);
        }

        public void UpdateNote(Guid personId, Guid noteId, string newComment, string updatedBy)
        {
            var note = notes.Find(n => n.PersonId == personId && n.Id == noteId);

            if (note != null)
            {
                note.Comment = newComment;
                note.UpdatedBy = updatedBy;
                note.UpdatedAt = DateTime.Now;
            }
        }

        public void DeleteAllNotes(Guid personId)
        {
            var persNotes = notes.FindAll(n => n.PersonId == personId);

            foreach (var note in persNotes)
            {
                notes.Remove(note);
            }
        }

        public void DeleteNote(Guid personId, Guid noteId)
        {
            var persNote = notes.Find(n => n.PersonId == personId && n.Id == noteId);

            if(persNote != null)
            {
                notes.Remove(persNote);
            }
        }

        public List<Note> LoadNotes(Guid personId)
        {
            // TODO: get notes from csv
            return notes.FindAll(n => n.PersonId == personId);
        }

        public Note LoadNote(Guid noteId)
        {
            return notes.First(n => n.Id == noteId);
        }

        public void SaveNote(Note note)
        {
            var fileName = GetFileName(note);

            if (!File.Exists(fileName) || File.ReadAllText(fileName) == "")
            {
                File.WriteAllText(fileName, CsvHeader(note));
            }

            File.AppendAllText(fileName, NoteToCsvString(note) + Environment.NewLine);


            Exporter<Note> exporter = new Exporter<Note>(new Note[] { note });
            exporter.Export(Exporter<Note>.ExportType.CSV);
        }

        public void SaveNotes(List<Note> notes)
        {
            Exporter<Note> exporter = new Exporter<Note>(notes.ToArray());
            exporter.Export(Exporter<Note>.ExportType.CSV);
        }

        private string GetFileName(Note note)
        {
            return note.GetType().Name + ".csv";
        }

        private string NoteToCsvString(Note note)
        {
            return
                string.Join(",", note.GetType()
                    .GetProperties()
                    .Select(propertyInfo => $"\"{propertyInfo.GetValue(note)}\""));
        }

        private string CsvHeader(Note note)
        {
            return
                string.Join(",", note.GetType()
                .GetProperties()
                .Select(propertyInfo => $"\"{propertyInfo.Name}\"")) +
                Environment.NewLine;
        }
    }
}
