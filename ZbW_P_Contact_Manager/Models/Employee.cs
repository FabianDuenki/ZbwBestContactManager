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
        public bool Contains(Employee other)
        {
            if (!base.Contains(other)) return false;
            if (other.EmployeeNumber != Guid.Empty && other.EmployeeNumber != this.EmployeeNumber) return false;
            if (other.Departement != null && other.Departement != this.Departement) return false;
            if (other.StartDate != null && other.StartDate != this.StartDate) return false;
            if (other.EndDate != null && other.EndDate != this.EndDate) return false;
            if (other.Employment != null && other.Employment != this.Employment) return false;
            if (other.Role != null && other.Role != this.Role) return false;
            if (other.CadreLevel != null && other.CadreLevel != this.CadreLevel) return false;
            return true;
        }
        public virtual Employee FromCsvString(string csvString)
        {
            string[] propertyValues = csvString.Split(',');

            Employee user = new Employee
            {
                Id = Guid.Parse(propertyValues[0]),
                Salutation = propertyValues[1],
                FirstName = propertyValues[2],
                LastName = propertyValues[3],
                DateOfBirth = DateTime.Parse(propertyValues[4]),
                Gender = propertyValues[5],
                Title = propertyValues[6],
                SocialSecurityNumber = propertyValues[7],
                PhoneNumberPrivate = propertyValues[8],
                PhoneNumberMobile = propertyValues[9],
                PhoneNumberBusiness = propertyValues[10],
                Email = propertyValues[11],
                Status = bool.Parse(propertyValues[12]),
                Nationality = propertyValues[13],
                Street = propertyValues[14],
                StreetNumber = propertyValues[15],
                ZipCode = int.Parse(propertyValues[16]),
                Place = propertyValues[17],
                EmployeeNumber = Guid.Parse(propertyValues[18]),
                Departement = propertyValues[19],
                StartDate = DateTime.Parse(propertyValues[20]),
                EndDate = DateTime.Parse(propertyValues[21]),
                Employment = int.Parse(propertyValues[22]),
                Role = propertyValues[23],
                CadreLevel = int.Parse(propertyValues[24])
            };

            return user;
        }
    }
}
