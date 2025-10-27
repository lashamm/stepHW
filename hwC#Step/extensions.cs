using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace hwC_Step
{
    internal static class extensions
    {
        public static int wordcount (this string x)
        {
            if(string.IsNullOrWhiteSpace(x))
            {
                return 0;
            }
            return x.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
