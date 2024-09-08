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
        public override Employee FromCsvString(string csvString)
        {
            string[] propertyValues = csvString.Split(',');

            Employee user = new Employee();
            user.Id = Guid.Parse(propertyValues[0]);
            user.Salutation = propertyValues[1];
            user.FirstName = propertyValues[2];
            user.LastName = propertyValues[3];
            user.DateOfBirth = DateTime.Parse(propertyValues[4]);
            user.Gender = propertyValues[5];
            user.Title = propertyValues[6];
            user.SocialSecurityNumber = propertyValues[7];
            user.PhoneNumberPrivate = propertyValues[8];
            user.PhoneNumberMobile = propertyValues[9];
            user.PhoneNumberBusiness = propertyValues[10];
            user.Email = propertyValues[11];
            user.Status = bool.Parse(propertyValues[12]);
            user.Nationality = propertyValues[13];
            user.Street = propertyValues[14];
            user.StreetNumber = propertyValues[15];
            user.ZipCode = int.Parse(propertyValues[16]);
            user.Place = propertyValues[17];
            user.EmployeeNumber = Guid.Parse(propertyValues[18]);
            user.Departement = propertyValues[19];
            if (!String.IsNullOrEmpty(propertyValues[20])) user.StartDate = DateTime.Parse(propertyValues[20]);
            if (!String.IsNullOrEmpty(propertyValues[21])) user.EndDate = DateTime.Parse(propertyValues[21]);
            user.Employment = int.Parse(propertyValues[22]);
            user.Role = propertyValues[23];
            user.CadreLevel = int.Parse(propertyValues[24]);

            return user;
        }
    }
}
