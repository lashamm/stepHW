using hwC_Step.Enums;
namespace hwC_Step.Models
{
    internal class Rectangle : shape
    {
        public NamesOfShape Name { get; set; }
        public RectangleTypes Type { get; set; }
        public double Area { get; set; }

        public Rectangle() { }
        public Rectangle(
            string color,
            NamesOfShape name,
            RectangleTypes type,
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
