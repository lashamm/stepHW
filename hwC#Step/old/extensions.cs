using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace hwC_Step.old
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

        public static int Factorial(this int x)
        {
            if (x < 0)
            {
                throw new ArgumentException("Negative numbers do not have a factorial.");
            }
            int result = 1;
            for (int i = 1; i <= x; i++)
            {
                 result *= i;
            }
            return result;
        }

        public static List<T> RemoveDublicate<T>(this List<T> x)
        {
            return x.Distinct().ToList();
        }

        public static IEnumerable<T> average<T>(this IEnumerable<T> source, Func<T, double> selector)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));
            double sum = 0;
            int count = 0;
            foreach (var item in source)
            {
                sum += selector(item);
                count++;
            }
            if (count == 0)
                throw new InvalidOperationException("Sequence contains no elements");
            yield return (T)(object)(sum / count);
        }
    }
}
