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

            string input = "Hello   World   ";

            // get all characters Xs that is contain more than one whitespace character
            string pattern = "\\s+";
            // then replace that character to only one whitespace character " "
            string replacement = " ";

            Regex rgx0 = new Regex(pattern);
            string result0 = rgx0.Replace(input, replacement);


            // match all character Xs that NOT is from a-z, A-Z, 0-9
            Regex rgx = new Regex("[^a-zA-Z0-9]");

            // then replace Xs to empty
            string hello = rgx.Replace(S, "");

            rgx = new Regex("(?<=\\G\\d{3})(?!$)");

            hello = rgx.Replace(hello, "-");

            rgx = new Regex("\\b(\\d{2})(\\d+)-(\\d)$");

            var result = rgx.Replace(hello, "$1-$2$3");
            return result;
        }

        public static string FormatString1(string input)
        {
            // remove the white space
            Regex reg = new Regex("\\s+");
            string result = reg.Replace(input, " ");
            return result;
        }

        public static string FormatString2(string intput)
        {
            string newString = intput.Replace(" ", "").Replace("-", "");
            int length = newString.Length;
            string result = string.Empty;
            int sig = length / 3;

            int offset = 0;
            int next = 0;
            //if (length % 3 == 2 || length % 3 == 0)
            //{
            //    b = 3;
            //    for (int i = 0; i < sig; i++)
            //    {
            //        result += newString.Substring(offset, b) + "-";
            //        offset = offset + b;
            //    }
            //}

            //if(length % 3 == 1)
            //{
            next = 3;
            for (int i = 0; i < sig; i++)
            {
                if ((length - offset) / 3 == 1 && length % 3 == 1)
                    next = 2;
                result += newString.Substring(offset, next) + "-";
                offset = offset + next;
            }
            //}

            result = result + newString.Substring(offset, (length - offset));

            if (result[result.Length - 1] == '-')
            {
                result = result.Remove(result.Length - 1, 1);
            }

            return result;
        }
    }
}
