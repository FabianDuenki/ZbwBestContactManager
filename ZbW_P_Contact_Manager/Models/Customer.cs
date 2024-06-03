using Interface;

namespace Model
{
    public class Customer : ICustomer
    {
        public string? CompanyName { get; set; }
        public char? CompanyType { get; set; }
        public string? CompanyContact { get; set; }
    }
}