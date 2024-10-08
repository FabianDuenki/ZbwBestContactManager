﻿namespace Model
{
    /// <summary>
    /// Employee class that extends the Person class with additional properties
    /// </summary>
    public class Employee : Person
    {
        /// <summary>
        /// Employee number
        /// </summary>
        public Guid? EmployeeNumber { get; set; }

        /// <summary>
        /// Departement
        /// </summary>
        public string? Departement { get; set; }

        /// <summary>
        /// Start date of employment
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// End date of employment
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Employment percentage
        /// </summary>
        public int? Employment { get; set; }

        /// <summary>
        /// Role
        /// </summary>
        public string? Role { get; set; }

        /// <summary>
        /// Cadre level
        /// </summary>
        public int? CadreLevel { get; set; }

        /// <summary>
        /// The CSV string representation of the object
        /// </summary>
        /// <returns>CSV string</returns>
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

        /// <summary>
        /// Transforms the object into a CSV header
        /// </summary>
        /// <returns>CSV header</returns>
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
        public override bool Contains(Person p)
        {
            Employee other = p as Employee;
            if (!base.Contains(other)) return false;
            if (other.EmployeeNumber != Guid.Empty && other.EmployeeNumber != this.EmployeeNumber) return false;
            if (other.Departement != "" && other.Departement != null && other.Departement != this.Departement) return false;
            if (other.StartDate != new DateTime(1900, 1, 1) && other.StartDate != null && other.StartDate != this.StartDate) return false;
            if (other.EndDate != new DateTime(1900, 1, 1) && other.EndDate != null && other.EndDate != this.EndDate) return false;
            if (other.Employment != 0 && other.Employment != null && other.Employment != this.Employment) return false;
            if (other.Role != "" && other.Role != null && other.Role != this.Role) return false;
            if (other.Salutation != "" && other.CadreLevel != 0 && other.CadreLevel != null && other.CadreLevel != this.CadreLevel) return false;
            return true;
        }

        /// <summary>
        /// Transforms a CSV string into an object
        /// </summary>
        /// <param name="csvString"></param>
        /// <returns>Employee object</returns>
        public override Employee FromCsvString(string csvString)
        {
            string[] propertyValues = csvString.Split(',');
            Employee user = new Employee();

            user.Id = Guid.Parse(propertyValues[0]);
            user.Salutation = propertyValues[1];
            user.FirstName = propertyValues[2];
            user.LastName = propertyValues[3];
            if (!String.IsNullOrEmpty(propertyValues[4])) user.DateOfBirth = DateTime.Parse(propertyValues[4]);
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
