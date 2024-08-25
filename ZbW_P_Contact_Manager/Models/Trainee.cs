namespace Model
{
    public class Trainee : Employee
    {
        public int? TraineeYears { get; set; }
        public int? ActualTraineeYear { get; set; }
        public override string ToCsvString()
        {
            return base.ToCsvString() +
                "," +
                $"{this.TraineeYears.ToString()}," +
                $"{this.ActualTraineeYear.ToString()}";
        }
        public override string ToCsvHeader()
        {
            return base.ToCsvHeader() +
                "," +
                "TraineeYears," +
                "ActualTraineeYear";
        }
        public bool Contains(Trainee other)
        {
            if (!base.Contains(other)) return false;
            if (other.TraineeYears != null && other.TraineeYears != this.TraineeYears) return false;
            if (other.ActualTraineeYear != null && other.ActualTraineeYear != this.ActualTraineeYear) return false;
            return true;
        }
        public override Trainee FromCsvString(string csvString)
        {
            string[] propertyValues = csvString.Split(',');

            Trainee user = new Trainee
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
                CadreLevel = int.Parse(propertyValues[24]),
                TraineeYears = int.Parse(propertyValues[25]),
                ActualTraineeYear = int.Parse(propertyValues[26])
            };

            return user;
        }
    }
}
