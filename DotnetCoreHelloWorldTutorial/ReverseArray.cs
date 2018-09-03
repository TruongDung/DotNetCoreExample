using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetCoreHelloWorldTutorial
{
    public class ReverseArray
    {
        public static string solution(string input = "a*b!c")
        {
            var ar = input.ToCharArray();
            int a = 0;
            int b = ar.Length-1;
            while(a < b)
            {

                if (!Char.IsLetter(ar[a]))
                    a++;
                else if (!Char.IsLetter(ar[b]))
                    b--;
                else
                {
                    char temp = ar[a];
                    ar[a] = ar[b];
                    ar[b] = temp;
                    a++;
                    b--;
                }
            }


            return string.Join("", ar);
        }
    }
}
