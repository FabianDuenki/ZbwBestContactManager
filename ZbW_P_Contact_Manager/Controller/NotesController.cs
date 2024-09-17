using Model;

namespace Controller
{
    /// <summary>
    /// Notes controller to manage the notes of a person
    /// </summary>
    public class NotesController
    {
        CSVController _csvController;

        /// <summary>
        /// Notes controller constructor
        /// </summary>
        public NotesController()
        {
            _csvController = new();
        }

        /// <summary>
        /// Note creation method
        /// </summary>
        /// <param name="personId"></param>
        /// <param name="comment"></param>
        /// <param name="createdBy"></param>
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

        /// <summary>
        /// Read notes of a person
        /// </summary>
        /// <param name="personId"></param>
        /// <returns>Note</returns>
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
