namespace Interface
{
    public interface IPerson
    {
        string Salutation { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime DateOfBirth { get; set; }
        bool Gender { get; set; }
        string Title { get; set; }
        string? SocialSecurityNumber { get; set; }
        string? PhoneNumberPrivate { get; set; }
        string? PhoneNumberMobile { get; set; }
        string? PhoneNumberBusiness { get; set; }
        string? Email { get; set; }
        bool? Status { get; set; }
        string? Nationality { get; set; }
        string? Street { get; set; }
        string? StreetNumber { get; set; }
        int? ZipCode { get; set; }
        string? Place { get; set; }
    }
}
