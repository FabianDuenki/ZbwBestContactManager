using Interface;

namespace Model
{
    public class Employee : IEmployee
    {
        public Guid? EmployeeNumber { get; set; }
        public string? Departement { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Employment { get; set; }
        public string? Role { get; set; }
        public int? CadreLevel { get; set; }
    }
}
