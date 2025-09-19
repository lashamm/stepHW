using hwC_Step.Enums;

namespace hwC_Step.Models
{
    internal class Circle : shape
    {
        public NamesOfShape Name { get; set; }
        public CircleTypes Type { get; set; }
        public double Area { get; set; }

        public Circle() { }
        public Circle(
            string color,
            NamesOfShape name,
            CircleTypes type,
            double area
            ) : base(color)
        {
            this.Name = name;
            this.Type = type;
            this.Area = area;
        }

        public void area()
        {
            Console.WriteLine($"Area of {Color} {Type} {Name} is {Area}"); ;
        }
    
    }
}
