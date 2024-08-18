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
    }
}