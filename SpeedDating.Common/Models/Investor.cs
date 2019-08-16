namespace SpeedDating.Common.Models
{
    public class Investor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }

        public Investor()
        {

        }

        public Investor(string firstName, string lastName, string company)
        {
            FirstName = firstName;
            LastName = lastName;
            Company = company;
        }
    }
}
