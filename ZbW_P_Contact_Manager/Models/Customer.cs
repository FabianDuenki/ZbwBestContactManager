using Interface;

namespace Model
{
    public class Customer(ICustomer customer) : ICustomer
    {
        public string CompanyName { get; set; } = customer.CompanyName;
        public char CompanyType { get; set; } = customer.CompanyType;
        public string CompanyContact { get; set; } = customer.CompanyContact;
    }
}
