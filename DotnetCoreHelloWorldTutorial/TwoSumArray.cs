using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace DotnetCoreHelloWorldTutorial
{
    public class TwoSumArray
    {
        public static void solution()
        {
            int num = 6;
            var arr = new int[] { 4, 5, 1, 8 };
            var ht = new Hashtable();
            //ht.Add(1, 11);
            for (int i = 0; i < arr.Length; i++)
            {
                var data = num - arr[i];
                if (ht.ContainsValue(data))
                {
                    // retrurn value of index 
                } else
                {
                    ht.Add(i, arr[i]);
                }
            }


        }

        static bool AreAnyTrue<T>(T[] values, Func<T, bool> predicate)
        {
            //var hasMatch = false;

            //for (var i = 0; i < values.Length; i++)
            //{
            //    if (predicate(values[i]))
            //    {
            //        hasMatch = true;
            //        break;
            //    }
            //}

            var data = values.Where(w => predicate(w) == true);
            return data.Count() == values.Length;
            //return hasMatch;
        }

        static T[] FindMatchingValues<T>(T[] values, Func<T, bool> predicate)
        {
            List<T> matches = new List<T>();

            for (var i = 0; i < values.Length; i++)
            {
                if (predicate(values[i]))
                {
                    matches.Add(values[i]);
                }
            }


            return matches.ToArray();
        }

        static int CalculateSumOfProducts(int[] values1, int[] values2)
        {
            var sum = 0;

            for (var i = 0; i < values1.Length; i++)
            {
                for (var j = 0; j < values2.Length; j++)
                {
                    var product = values1[i] * values2[j];
                    sum += product;
                }
            }

            return sum;
        }
    }
}
