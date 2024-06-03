namespace Interface
{
    public interface IEmployee
    {
        Guid? EmployeeNumber { get; set; }
        string? Departement { get; set; }
        DateTime? StartDate { get; set; }
        DateTime? EndDate { get; set; }
        int? Employment { get; set; }
        string? Role { get; set; }
        int? CadreLevel { get; set; }
    }
}