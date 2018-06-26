using System;
using System.Linq;

namespace DotnetCoreHelloWorldTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Student s = new Student();
            s.LastName = "Truong";
            s.FirstName = "David";
            Console.WriteLine(s.FullName);

            Func<string, string> convert = q => q.ToUpper();
            string[] words = { "orange", "apple", "Article", "elephant" };
            var words1 = words.Select(convert);

            foreach (var item in words1)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public static Boolean isPalindrome(int x)
        {
            if (x < 0)
                return false;
            int currentNumber = x;
            int newNumber = 0;

            while (x != 0)
            {
                int nextNo = newNumber * 10 + x % 10;
                newNumber = nextNo;
                x = x / 10;
            }

            if (currentNumber != newNumber)
                return false;
            return true;
        }
    }
}
