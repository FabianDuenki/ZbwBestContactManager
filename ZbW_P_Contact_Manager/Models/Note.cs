using Interface;

namespace Model
{
    public class Note : INote
    {
        public Guid Id { get; set; }

        public string? Comment { get; set; } = string.Empty;

        public Guid? PersonId { get; set; }

        public DateTime? CreatedAt { get; set; }
               
        public string? CreatedBy { get; set; } = "unknown";

        public DateTime? UpdatedAt { get; set; }

        public string? UpdatedBy { get; set; } = "unknown";
    }
}
