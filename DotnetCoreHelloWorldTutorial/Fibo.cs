using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetCoreHelloWorldTutorial
{
    class Fibo
    {
        public static int solution(int x)
        {
            int a = 0;
            int b = 1;
            int c = 0;
            var ar = new int[x];
            for (int i = 2; i < x; i++)
            {
                c = a + b;
                ar[i] = c;
                a = b;
                b = c;
            }
            return 0;
        }
    }
}
