
namespace hwC_Step
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public Student(string name,
            int age, 
            string surname,
            int studentId,
            int ClassId
            )
        {
            Name = name;
            Age = age;
            Surname = surname;
            StudentId = studentId;
            ClassId = ClassId;
        }
        
    }
}
