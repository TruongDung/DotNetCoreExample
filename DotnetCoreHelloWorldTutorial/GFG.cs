using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DotnetCoreHelloWorldTutorial
{
    public class GFG
    {
        static int ASCII_SIZE = 256;
        public static char getMaxOccuringChar(String str)
        {
            var ht = new Dictionary<Char, int>();
            foreach (char item in str)
            {
                if (ht.ContainsKey(item))
                {
                    int cnt = (int)ht[item];
                    ht[item] = cnt + 1;
                }
                else
                {
                    ht.Add(item, 1);
                }
            }
            return ht.OrderByDescending(x => x.Value).First().Key;
        }
        public static char getMaxOccuringChar1(String str)
        {
            var result = ' ';

            var count = new int[256];
            for (int i = 0; i < str.Length; i++)
            {
                count[str[i]]++;
            }

            int max = -1;
            for (int i = 0; i < str.Length; i++)
            {
                if(max < count[str[i]])
                {
                    max = count[str[i]];
                    result = str[i];
                }
            }

            return result;
        }
    }
}