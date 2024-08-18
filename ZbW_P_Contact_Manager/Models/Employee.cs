namespace Model
{
    public class Employee : Person
    {
        public Guid? EmployeeNumber { get; set; }
        public string? Departement { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Employment { get; set; }
        public string? Role { get; set; }
        public int? CadreLevel { get; set; }

        public override string ToCsvString()
        {
            return base.ToCsvString() +
                "," +
                $"{this.EmployeeNumber.ToString()}," +
                $"{this.Departement}," +
                $"{this.StartDate.ToString()}," +
                $"{this.EndDate.ToString()}," +
                $"{this.Employment.ToString()}," +
                $"{this.Role}," +
                $"{this.CadreLevel.ToString()}";
        }
        public override string ToCsvHeader()
        {
            return base.ToCsvHeader() +
                "," +
                "EmployeeNumber," +
                "Departement," +
                "StartDate," +
                "EndDate," +
                "Employment," +
                "Role," +
                "CadreLevel";
        }
    }
}
