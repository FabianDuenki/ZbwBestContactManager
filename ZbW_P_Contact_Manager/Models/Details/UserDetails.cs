namespace Model.Detail
{
    /// <summary>
    /// User Details
    /// </summary>
    public struct UserDetails
    {
        /// <summary>
        /// User ID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Salutation
        /// </summary>
        public string? Salutation { get; set; }

        /// <summary>
        /// First Name
        /// </summary>
        public string? FirstName { get; set; }

        /// <summary>
        /// Last Name
        /// </summary>
        public string? LastName { get; set; }

        /// <summary>
        /// Date of Birth
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Gender
        /// </summary>
        public string? Gender { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Social Security Number
        /// </summary>
        public string? SocialSecurityNumber { get; set; }

        /// <summary>
        /// Phone Number Private
        /// </summary>
        public string? PhoneNumberPrivate { get; set; }

        /// <summary>
        /// Phone Number Mobile
        /// </summary>
        public string? PhoneNumberMobile { get; set; }

        /// <summary>
        /// Phone Number Business
        /// </summary>
        public string? PhoneNumberBusiness { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        public bool? Status { get; set; }

        /// <summary>
        /// Nationality
        /// </summary>
        public string? Nationality { get; set; }

        /// <summary>
        /// Street
        /// </summary>
        public string? Street { get; set; }

        /// <summary>
        /// Street Number
        /// </summary>
        public string? StreetNumber { get; set; }

        /// <summary>
        /// Zip Code
        /// </summary>
        public int? ZipCode { get; set; }

        /// <summary>
        /// Place
        /// </summary>
        public string? Place { get; set; }

        /// <summary>
        /// Company Name
        /// </summary>
        public string? CompanyName { get; set; }

        /// <summary>
        /// Company Type
        /// </summary>
        public char? CompanyType { get; set; }

        /// <summary>
        /// Company Contact
        /// </summary>
        public string? CompanyContact { get; set; }

        /// <summary>
        /// Employee Number
        /// </summary>
        public Guid? EmployeeNumber { get; set; }

        /// <summary>
        /// Department
        /// </summary>
        public string? Departement { get; set; }

        /// <summary>
        /// Start Date
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// End Date
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Employment
        /// </summary>
        public int? Employment { get; set; }

        /// <summary>
        /// Role
        /// </summary>
        public string? Role { get; set; }

        /// <summary>
        /// Cadre Level
        /// </summary>
        public int? CadreLevel { get; set; }

        /// <summary>
        /// Trainee Years
        /// </summary>
        public int? TraineeYears { get; set; }

        /// <summary>
        /// Actual Trainee Year
        /// </summary>
        public int? ActualTraineeYear { get; set; }
    }
}
