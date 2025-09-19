using hwC_Step.Enums;

namespace hwC_Step.Models
{
    internal class Triangle : shape
    {
        public NamesOfShape Name { get; set; }
        public TriangleType Type { get; set; }
        public double Area { get; set; }

        public Triangle() { }
        public Triangle(
            string color,
            NamesOfShape name,
            TriangleType type, 
            double area
            ) : base(color)
        {
            this.Name = name;
            this.Type = type;
            this.Area = area;
        }

        public void area()
        {
            Console.WriteLine($"Area of {Color} {Type} {Name} is {Area}");
        }
    }
}
