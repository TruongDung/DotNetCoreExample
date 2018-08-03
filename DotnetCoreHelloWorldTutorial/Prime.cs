using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DotnetCoreHelloWorldTutorial
{
    public class Prime
    {
        public static bool checkIsPrime(int x)
        {
            bool flag = true;
            for (int i = 2; i < Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                {
                    flag = false;
                }
            }
            return flag;
        }

        public static List<int> breakNumber(int x)
        {
            List<int> lst = new List<int>();
            int n = x;
            for (int i = 2; i < x/2; i++)
            {
                if (checkIsPrime(i))
                {
                    if (n % i == 0)
                    {
                        lst.Add(i);
                        n = n / i;
                        var multi = lst.Aggregate(1, (p, m) => p * m);
                        if (multi == x)
                            break;
                    }
                }
            }
            return lst;
        }
    }
}
