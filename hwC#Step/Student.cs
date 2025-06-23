
namespace hwC_Step
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Age { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public Student(string name,
            DateTime age, 
            string surname,
            int studentId,
            int classId
            )
        {
            Name = name;
            Age = age;
            Surname = surname;
            StudentId = studentId;
            ClassId = classId;
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
        public void printInfo()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {GetAge()}, StudentId: {StudentId}, ClassId: {ClassId}");
            
        }

    }
}
