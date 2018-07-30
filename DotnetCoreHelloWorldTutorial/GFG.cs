using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetCoreHelloWorldTutorial
{
    public class GFG
    {
        static int ASCII_SIZE = 256;
        public static char getMaxOccuringChar(String str)
        {
            // Create array to keep the count of
            // individual characters and 
            // initialize the array as 0
            int[] count = new int[ASCII_SIZE];

            // Construct character count array
            // from the input string.
            int len = str.Length;
            for (int i = 0; i < len; i++)
                count[str[i]]++;

            int max = -1; // Initialize max count
            char result = ' '; // Initialize result

            // Traversing through the string and 
            // maintaining the count of each character
            for (int i = 0; i < len; i++)
            {
                if (max < count[str[i]])
                {
                    max = count[str[i]];
                    result = str[i];
                }
            }

            return result;
        }
    }
}