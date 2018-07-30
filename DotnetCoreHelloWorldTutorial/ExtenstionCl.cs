using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetCoreHelloWorldTutorial
{
    public static class ExtenstionCl
    {
        public static bool isEven(this int i)
        {
            return i % 2 == 0;
        }

        public static IEnumerable<T> Where<T>(this IEnumerable<T> items, Predicate<T> predicate)
        {
            var result = new List<T>();
            return result;
        }

        public static IEnumerable<T> Distinct<T>(this IEnumerable<T> items)
        {
            return null;
        }

        public static string UppercaseFirstLetter(this string value)
        {
            // Uppercase the first letter in the string.
            if (value.Length > 0)
            {
                char[] array = value.ToCharArray();
                array[0] = char.ToUpper(array[0]);
                return new string(array);
            }
            return value;
        }
    }
}
