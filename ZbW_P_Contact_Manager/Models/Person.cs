using Interface;

namespace Model
{
    public class Person(IPerson person) : IPerson
    {
        public string Salutation { get; set; } = person.Salutation;
        public string FirstName { get; set; } = person.FirstName;
        public string LastName { get; set; } = person.LastName;
        public DateTime DateOfBirth { get; set; } = person.DateOfBirth;
        public bool Gender { get; set; } = person.Gender;
        public string Title { get; set; } = person.Title;
        public string? SocialSecurityNumber { get; set; } = person.SocialSecurityNumber;
        public string? PhoneNumberPrivate { get; set; } = person.PhoneNumberPrivate;
        public string? PhoneNumberMobile { get; set; } = person.PhoneNumberMobile;
        public string? PhoneNumberBusiness { get; set; } = person.PhoneNumberBusiness;
        public string? Email { get; set; } = person.Email;
        public bool? Status { get; set; } = person.Status;
        public string? Nationality { get; set; } = person.Nationality;
        public string? Street { get; set; } = person.Street;
        public string? StreetNumber { get; set; } = person.StreetNumber;
        public int? ZipCode { get; set; } = person.ZipCode;
        public string? Place { get; set; } = person.Place;
    }
}
