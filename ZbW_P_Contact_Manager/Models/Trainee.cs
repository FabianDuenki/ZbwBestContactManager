﻿namespace Model
{
    /// <summary>
    /// Trainee class that inherits from Employee
    /// </summary>
    public class Trainee : Employee
    {
        /// <summary>
        /// TraineeYears property
        /// </summary>
        public int? TraineeYears { get; set; }

        /// <summary>
        /// ActualTraineeYear property
        /// </summary>
        public int? ActualTraineeYear { get; set; }

        /// <summary>
        /// Transforms the object to a csv string
        /// </summary>
        /// <returns>The transformed string</returns>
        public override string ToCsvString()
        {
            return base.ToCsvString() +
                "," +
                $"{this.TraineeYears.ToString()}," +
                $"{this.ActualTraineeYear.ToString()}";
        }

        /// <summary>
        /// Transforms the object to a csv header
        /// </summary>
        /// <returns>The transformed string</returns>
        public override string ToCsvHeader()
        {
            return base.ToCsvHeader() +
                "," +
                "TraineeYears," +
                "ActualTraineeYear";
        }

        /// <summary>
        /// Checks if the object contains another object
        /// </summary>
        /// <param name="other"></param>
        /// <returns>Boolean</returns>
        public override bool Contains(Person p)
        {
            Trainee other = p as Trainee;
            if (!base.Contains(other)) return false;
            if (other.TraineeYears != 0 && other.TraineeYears != null && other.TraineeYears != this.TraineeYears) return false;
            if (other.ActualTraineeYear != 0 && other.ActualTraineeYear != null && other.ActualTraineeYear != this.ActualTraineeYear) return false;
            return true;
        }

        /// <summary>
        /// Transforms a csv string to an object
        /// </summary>
        /// <param name="csvString"></param>
        /// <returns>The transformed trainee</returns>
        public override Trainee FromCsvString(string csvString)
        {
            string[] propertyValues = csvString.Split(',');
            Trainee user = new Trainee();

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
            user.TraineeYears = int.Parse(propertyValues[25]);
            user.ActualTraineeYear = int.Parse(propertyValues[26]);

            return user;
        }
    }
}
