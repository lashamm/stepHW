using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwC_Step.Models
{
    internal class shape
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public double Area { get; set; }

        public shape() { }
        public shape(string name, string color, double area)
        {
            Name = name;
            Color = color;
            Area = area;
        }

        public void area()
        {
            Console.WriteLine($"Area of {Name} is {Area}");
        }
    }
}
