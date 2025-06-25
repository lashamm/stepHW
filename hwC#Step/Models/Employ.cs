using hwC_Step.Enums;

namespace hwC_Step.Models
{
    internal class Employ
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Age { get; set; }
        public string JobTitle { get; set; }
        public int Salary { get; set; }
        public string Country { get; set; }
        
        public Employ() { }

        public Employ(
            EmployName name,
            DateTime age, 
            EmploySurname surname,
            EmployJobTitle jobTitle,
            EmploySalary salary,
            Country country
            )
        {
            Name = name.ToString();
            Surname = surname.ToString();
            Age = age;
            JobTitle = jobTitle.ToString();
            Salary = (int)salary;
            Country = country.ToString();
        }
        public int GetAge()
        {
            int result = DateTime.Now.Year - Age.Year;
            if (DateTime.Now.DayOfYear < Age.DayOfYear)
            {
                result--;
            }
            return result;
        }
        public void PrintEmoployInfo()
        {
            Console.WriteLine($"Name: {Name}, " +
                $"\nSurname: {Surname}, " +
                $"\nAge: {GetAge()}, " +
                $"\nJob: {JobTitle}, " +
                $"\nsalary: {Salary}, " +
                $"\nCountry : {Country}" +
                $"\n");

        }
    }
}
