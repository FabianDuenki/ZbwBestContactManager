using Interface;

namespace Model.Detail
{
    public struct UserDetails : IPerson, ICustomer, IEmployee, ITrainee
    {
        public Guid Id { get; set; }
        public string? Salutation { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string? Title { get; set; }
        public string? SocialSecurityNumber { get; set; }
        public string? PhoneNumberPrivate { get; set; }
        public string? PhoneNumberMobile { get; set; }
        public string? PhoneNumberBusiness { get; set; }
        public string? Email { get; set; }
        public bool? Status { get; set; }
        public string? Nationality { get; set; }
        public string? Street { get; set; }
        public string? StreetNumber { get; set; }
        public int? ZipCode { get; set; }
        public string? Place { get; set; }
        public string? CompanyName { get; set; }
        public char? CompanyType { get; set; }
        public string? CompanyContact { get; set; }
        public Guid? EmployeeNumber { get; set; }
        public string? Departement { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Employment { get; set; }
        public string? Role { get; set; }
        public int? CadreLevel { get; set; }
        public int? TraineeYears { get; set; }
        public int? ActualTraineeYear { get; set; }
    }
}
