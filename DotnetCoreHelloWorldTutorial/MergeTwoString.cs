using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DotnetCoreHelloWorldTutorial
{
    class MergeTwoString
    {
        public void merge()
        {
            string first = "abc";
            string second = "def123456";

            var first1 = first.ToCharArray();
            var second1 = second.ToCharArray();

            var resultStr = "";
            var aaa = first1.Concat(second1).ToArray();
            int i = 0;
            int j = 0;
            while (i < first1.Length && j < second1.Length)
            {
                string str = first1[i] + second1[j].ToString();
                resultStr += str;
                i++;
                j++;
            }

            while (i < first1.Length)
            {
                string str = first1[j].ToString();
                resultStr += str;
                i++;
            }
            while (j < second1.Length)
            {
                string str = second1[j].ToString();
                resultStr += str;
                j++;
            }
        }
    }
}
