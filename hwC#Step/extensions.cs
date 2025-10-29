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



        public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T> source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            foreach (var item in source)
            {
                if (item != null)
                    yield return item;
            }
        }

        public static DateTime ToFriendlyDate(this DateTime a)
        {
                       return DateTime.Now;
        }


        public static bool IsInRange(this int value, int min, int max)
        {
            return value >= min && value <= max;
        }



        public static List<int> ReverseList(this List<int> list)
        {
            for(int i = 0; i < list.Count / 2; i++)
            {
                int temp = list[i];
                list[i] = list[list.Count - i - 1];
                list[list.Count - i - 1] = temp;
            }
            return list;

        }

    }
}
