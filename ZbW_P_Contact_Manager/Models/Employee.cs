using Interface;

namespace Model
{
    public class Employee(IEmployee employee) : IEmployee
    {
        public Guid EmployeeNumber { get; set; } = employee.EmployeeNumber;
        public string Departement { get; set; } = employee.Departement;
        public DateTime StartDate { get; set; } = employee.StartDate;
        public DateTime EndDate { get; set; } = employee.EndDate;
        public int Employment { get; set; } = employee.Employment;
        public string Role { get; set; } = employee.Role;
        public int CadreLevel { get; set; } = employee.CadreLevel;
    }
}
