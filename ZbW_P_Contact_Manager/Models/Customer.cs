namespace Model
{
    /// <summary>
    /// Customer class that inherits from Person class and adds company related properties
    /// </summary>
    public class Customer : Person
    {
        /// <summary>
        /// Company name of the customer
        /// </summary>
        public string? CompanyName { get; set; }

        /// <summary>
        /// Company type of the customer
        /// </summary>
        public string? CompanyType { get; set; }

        /// <summary>
        /// Company contact of the customer
        /// </summary>
        public string? CompanyContact { get; set; }

        /// <summary>
        /// Transforms the object to a CSV string
        /// </summary>
        /// <returns>The transformed string</returns>
        public override string ToCsvString()
        {
            return base.ToCsvString() +
                "," +
                $"{this.CompanyName}," +
                $"{this.CompanyName}," +
                $"{this.CompanyContact}";
        }

        /// <summary>
        /// Transforms the object to a CSV header
        /// </summary>
        /// <returns>The transformed string</returns>
        public override string ToCsvHeader()
        {
            return base.ToCsvHeader() +
                "," +
                "CompanyName," +
                "CompanyType," +
                "CompanyContact";
        }

        /// <summary>
        /// Checks whether the other object is contained in this object
        /// </summary>
        /// <param name="other"></param>
        /// <returns>Boolean</returns>
        public override bool Contains(Person p)
        {
            Customer other = p as Customer;
            if (!base.Contains(other)) return false;
            if (other.CompanyName != "" && other.CompanyName != null && other.CompanyName != this.CompanyName) return false;
            if (other.CompanyName != "" && other.CompanyType != null && other.CompanyType != this.CompanyType) return false;
            if (other.CompanyName != "" && other.CompanyContact != null && other.CompanyContact != this.CompanyContact) return false;
            return true;
        }

        /// <summary>
        /// Creates a new object from a CSV string
        /// </summary>
        /// <param name="csvString"></param>
        /// <returns>New created customer</returns>
        public override Customer FromCsvString(string csvString)
        {
            string[] propertyValues = csvString.Split(',');
            Customer user = new Customer();

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
            user.CompanyName = propertyValues[18];
            user.CompanyType = propertyValues[19];
            user.CompanyContact = propertyValues[20];

            return user;
        }
    }
}