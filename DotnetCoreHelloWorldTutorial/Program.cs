using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace DotnetCoreHelloWorldTutorial
{
    public delegate int calculation(int a, int b);
    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Student s = new Student();
            //s.LastName = "Truong";
            //s.FirstName = "David";
            //Console.WriteLine(s.FullName);

            //Func<string, string> convert = q => q.ToUpper();
            //string[] words = { "orange", "apple", "Article", "elephant" };
            //var words1 = words.Select(convert);

            ////foreach (var item in words1)
            ////{
            ////    Console.WriteLine(item);
            ////}
            //int[] bills = new int[] { 5, 5, 5, 10, 20 };
            //bool aa =  LemonadeChange(bills);

            //Console.WriteLine(aa);
            //calculation ca = new calculation(Add);
            //Console.WriteLine(ca(4, 5));
            //Console.WriteLine(calculate(1, 4, Add));

            //string str = "abcd";
            //string str1 = "";
            //for(int i=str.Length-1; i >=0; i--)
            //{
            //    str1 = str1 + str[i];
            //}

            //Console.WriteLine(str1);



            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //ResponseString responseString = new ResponseString { Success = true, StatusCode = 200, Data = "{ foo: \"bar\" }" };
            //ResponseDecimal responseDecimal = new ResponseDecimal { Success = true, StatusCode = 200, Data = 19.99M };
            //ResponseDateTime responseDateTime = new ResponseDateTime { Success = true, StatusCode = 200, Data = DateTime.Parse("4/13/2015 4:00PM") };

            //Response<String> responseString = new Response<string> { Success = true, StatusCode = 200, Data = "{ foo: \"bar\" }" };
            //Response<Decimal> responseDecimal = new Response<decimal> { Success = true, StatusCode = 200, Data = 19.99M };
            //Response<DateTime> responseDateTime = new Response<DateTime> { Success = true, StatusCode = 200, Data = DateTime.Parse("4/13/2015 4:00PM") };
            //Console.WriteLine("String Response: {0}", responseString.Data);
            //Console.WriteLine("Decimal Response: {0}", responseDecimal.Data);
            //Console.WriteLine("DateTime Response: {0}", responseDateTime.Data);

            //Version v = new Version("2.0.0.0");
            //Robot robot = new Sonny(v);
            //Console.WriteLine("Greeting: {0}", robot.Greeting());
            //Console.WriteLine("Robot Version: {0}", robot.Version);
            //List<string> laws = robot.GetLaws();
            //foreach (string law in laws)
            //{
            //    Console.WriteLine("Law #{0}: {1}", laws.IndexOf(law) + 1, law);
            //}
            //Console.ReadLine();

            ClockTower c = new ClockTower(1000);
            Thread.Sleep(3000);
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

        public static bool LemonadeChange(int[] bills)
        {
            if (bills[0] > 5)
            {
                return false;
            }
            List<int> b1 = new List<int>();
            for (int i = 0; i < bills.Length; i++)
            {
                if (bills[i] == 5)
                {
                    b1.Add(bills[i]);
                }
                else if (bills[i] > 5 && b1.Count > 0)
                {
                    foreach (var item in b1)
                    {
                        if (item == 5)
                        {
                            b1.Remove(item);
                            b1.Add(bills[i]);
                            break;
                        }
                    }
                }
            }
            return false;
        }
    }
}
