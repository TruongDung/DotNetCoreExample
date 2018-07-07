using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetCoreHelloWorldTutorial
{
    class DelegateEvent
    {

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Sub(int a, int b)
        {
            return a - b;
        }

        static int calculate(int a, int b, calculation ca)
        {
            return ca(a, b);
        }
    }
}
