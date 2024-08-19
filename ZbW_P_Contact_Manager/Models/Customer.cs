namespace Model
{
    public class Customer : Person
    {
        public string? CompanyName { get; set; }
        public string? CompanyType { get; set; }
        public string? CompanyContact { get; set; }
        public override string ToCsvString()
        {
            return base.ToCsvString() +
                "," +
                $"{this.CompanyName}," +
                $"{this.CompanyName}," +
                $"{this.CompanyContact}";
        }
        public override string ToCsvHeader()
        {
            return base.ToCsvHeader() +
                "," +
                "CompanyName," +
                "CompanyType," +
                "CompanyContact";
        }
        public bool Contains(Customer other)
        {
            if(!base.Contains(other)) return false;
            if (other.CompanyName != null && other.CompanyName != this.CompanyName) return false;
            if (other.CompanyType != null && other.CompanyType != this.CompanyType) return false;
            if (other.CompanyContact != null && other.CompanyContact != this.CompanyContact) return false;
            return true;
        }
        public override Customer FromCsvString(string csvString)
        {
            string[] propertyValues = csvString.Split(',');

            Customer user = new Customer
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
                CompanyName = propertyValues[18],
                CompanyType = propertyValues[19],
                CompanyContact = propertyValues[20]
            };

            return user;
        }
    }
}