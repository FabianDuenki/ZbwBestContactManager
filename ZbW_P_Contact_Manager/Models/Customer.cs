using Struct;

namespace Model
{
    public class Customer(CustomerDetails customer)
    {
        public string CompanyName { get; set; } = customer.CompanyName;
        public char CompanyType { get; set; } = customer.CompanyType;
        public string CompanyContact { get; set; } = customer.CompanyContact;
    }
}
