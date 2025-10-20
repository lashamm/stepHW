using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwC_Step
{
    class Student
    {
        public string Name { get; set; } = string.Empty;
        public uint Age { get; set; }
        public uint Grade { get; set; }
        public string City { get; set; } = string.Empty;

        public override string ToString()
        {
            var result = $"{Name}, {Age}, {Grade}, {City}";
            return result;
        }
    }
}
