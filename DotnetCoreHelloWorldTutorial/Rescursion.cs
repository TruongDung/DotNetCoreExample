using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetCoreHelloWorldTutorial
{
    class Rescursion
    {
        public static string soulution(string str)
        {
            if (str.Length > 0)
            {
                return str.Substring(str.Length - 1, 1) + soulution(str.Substring(0, str.Length - 1));
            }
            return "";
        }
    }
}
