namespace hwC_Step.Models
{
    internal class Lector
    {
        private string name;
        private string surname;
    
    public Lector(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public void PrintInfoLector()
        {
            Console.WriteLine($"Name: {name}, Surname: {surname}");
        } 
    }
    }
