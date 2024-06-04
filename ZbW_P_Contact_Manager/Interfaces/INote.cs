namespace Interface
{
    public interface INote
    {
        Guid? Id { get; set; }

        string? Comment { get; set; }

        long? PersonId { get; set; }

        DateTime? CreatedAt { get; set; }

        string? CreatedBy { get; set; }

        DateTime? UpdatedAt { get; set; }

        string? UpdatedBy { get; set; }
    }
}
