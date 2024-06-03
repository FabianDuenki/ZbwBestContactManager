namespace Interface
{
    public interface INote
    {
        public Guid? Id { get; set; }

        public string? Comment { get; set; }

        public long? PersonId { get; set; }

        public DateTime? CreatedAt { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public string? UpdatedBy { get; set; }
    }
}
