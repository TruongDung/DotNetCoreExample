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

            //var result = Fruits.Where(w => !w.Contains(" ") && !String.IsNullOrEmpty(w.ToString()))
            //    .OrderByDescending(w=>w.ToString().Length)
            //    .ToList();

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

        public sealed class ClockTower
        {
            private readonly Stopwatch _stopWatch = new Stopwatch();
            private readonly int _delayMilliseconds;

            public ClockTower(int delayMilliseconds)
            {
                _stopWatch.Start();
                _delayMilliseconds = delayMilliseconds;
                DelayedChime();
            }

            public delegate void ChimeEventHandler(object sender, ChimeEventArgs e);
            public event ChimeEventHandler OnChime;
            public async void DelayedChime()
            {
                //await Task.Delay(_delayMilliseconds);
                //ChimeEventArgs e = new ChimeEventArgs(_stopWatch.ElapsedMilliseconds);
                OnChime += new ChimeEventHandler(HeardIt);
                //HeardIt(this, e);

                //await Task.Delay(_delayMilliseconds);
                //HeardIt(this, e);

                await Task.Delay(_delayMilliseconds);
                OnChime(this, new ChimeEventArgs(_stopWatch.ElapsedMilliseconds));

                await Task.Delay(_delayMilliseconds);
                OnChime(this, new ChimeEventArgs(_stopWatch.ElapsedMilliseconds));

            }
            private void HeardIt(object sender, ChimeEventArgs e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public class ChimeEventArgs
        {
            public ChimeEventArgs(long milliseconds)
            {
                Message = String.Format("The clock chimed after {0} seconds", milliseconds / 1000M);
            }

            public string Message { get; set; }
        }

        public abstract class Robot
        {
            private readonly List<string> _laws = new List<string>
            {
                "A robot may not injure a human being or, through inaction, allow a human being to come to harm.",
                "A robot must obey the orders given it by human beings, except where such orders would conflict with the First Law.",
                "A robot must protect its own existence as long as such protection does not conflict with the First or Second Law."
            };

            protected Robot(Version version)
            {
                Version = version;
            }

            public abstract string Greeting();

            public Version Version { get; set; }

            public virtual List<string> GetLaws()
            {
                return _laws;
            }
        }

        public class Sonny : Robot
        {
            public Sonny(Version v):base(v)
            {

            }
            public override string Greeting()
            {
                return "Hello, my name is Sonny";
            }
        }

        static readonly string[] Fruits = new[]
        {
            "Acai",
            "Apple",
            "Apricots",
            "Banana",
            "Blackberry",
            "",
            "Blueberry",
            "Cherries",
            "Coconut",
            "Cranberry ",
            "Cucumber",
            "Currents",
            "Dates",
            "Durian",
            "Fig",
            "Goji berries",
            "Gooseberry",
            "Grapefruit",
            "Grapes",
            "Jackfruit",
            "Kiwi",
            "Kumquat",
            "Lemon",
            "Lime",
            "Lucuma",
            " Lychee",
            "Mango",
            "Mangosteen",
            "Melon",
            "",
            "Mulberry",
            "Nectarine",
            "Orange",
            "Papaya",
            "Passion Fruit",
            "Peach",
            "Pear",
            "Pineapple ",
            "Plum",
            "Pomegranate",
            "Pomelo",
            "Prickly Pear",
            "Prunes",
            "Raspberries",
            "Strawberries",
            "Tangerine",
            "Watermelon"
        };

        public class Response<T>
        {
            public bool Success { get; set; }
            public int StatusCode { get; set; }
            public T Data { get; set; }
        }

        public class ResponseString
        {
            public bool Success { get; set; }
            public int StatusCode { get; set; }
            public string Data { get; set; }
        }

        public class ResponseDecimal
        {
            public bool Success { get; set; }
            public int StatusCode { get; set; }
            public decimal? Data { get; set; }
        }

        public class ResponseDateTime
        {
            public bool Success { get; set; }
            public int StatusCode { get; set; }
            public DateTime Data { get; set; }
        }


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
            return ca(a,b);
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
                else if (bills[i] > 5 && b1.Count>0)
                {
                    foreach (var item in b1)
                    {
                        if(item == 5)
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
