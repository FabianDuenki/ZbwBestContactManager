namespace Model
{
    public class Customer : Person
    {
        public string? CompanyName { get; set; }
        public char? CompanyType { get; set; }
        public string? CompanyContact { get; set; }
    }
}