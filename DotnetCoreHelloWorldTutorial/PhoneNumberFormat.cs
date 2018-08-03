using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DotnetCoreHelloWorldTutorial
{
    public class PhoneNumberFormat
    {
        public static string solution(string S)
        {

            Regex rgx = new Regex("[^a-zA-Z0-9]");
            string hello = rgx.Replace(S, "");

            rgx = new Regex("(?<=\\G\\d{3})(?!$)");

            hello = rgx.Replace(hello, "-");

            rgx = new Regex("\\b(\\d{2})(\\d+)-(\\d)$");

            return rgx.Replace(hello, "$1-$2$3");
        }
    }
}
