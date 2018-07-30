using System;
using System.Collections.Generic;
using System.Linq;

namespace DotnetCoreHelloWorldTutorial
{
    public delegate int calculation(int a, int b);

    class Program
    {
        static String location;
        static DateTime time;

        public static void Main(string[] args)
        {


            Console.WriteLine(time.ToString());

            List<string> dates = new List<string>();

            //dates[0]
            //lst.Add("10");
            //lst.Add("20th Oct 2052");
            //lst.Add("6th Jun 1933");
            //lst.Add("26th May 1960");
            //lst.Add("20th Sep 1958");

            //lst.RemoveAt(0);
            List<string> newLst = new List<string>();
            foreach (var item in dates)
            {
                var data = item.Split(" ");
                var month = "";
                switch (data[1])
                {
                    case "Jan":month = "1";break;
                    case "Feb":month = "2";break;
                    case "Mar":month = "3";break;
                    case "Apr":month = "4";break;
                    case "May":month = "5";break;
                    case "Jun":month = "6";break;
                    case "Jul":month = "7";break;
                    case "Aug":month = "8";break;
                    case "Sep":month = "9";break;
                    case "Oct":month = "10";break;
                    case "Nov":month = "11";break;
                    case "Dec":month = "12"; break;
                }

                var dateString = data[0];

                var length = dateString.Length - 2;
                var newDateString = dateString.Substring(0, length);

         
                newLst.Add(string.Format("{0}-{1}-{2}", data[2], month, newDateString));
            }



            //Console.WriteLine(location == null ? "location is null" : location);
            //Console.WriteLine(time == null ? "time is null" : time.ToString());
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

            //int[][] x = new int[5][];
            //x[0] = new int[3] { 1, 2, 3 };
            //x[1] = new int[3] { 4, 5, 6 };

            //int a = x[0].Length;
            //Transpose(x);
            //Console.ReadLine();

            //ClockTower c = new ClockTower(1000);
            //Thread.Sleep(3000);

            //int i= 10;
            //string str = i.ToString();
            //char a[i] = str.ToCharArray();
            //var a = str.ToCharArray();
            //LinqExample le = new LinqExample();
            //le.test();

            //var t = new List<int>();
            //t.Add(1);
            //t.Add(2);
            //var a = t.Where(x => x % 2 == 0).Distinct();

            //string value = "dot net perls";
            //value = value.UppercaseFirstLetter();
            merge();
            Console.ReadLine();
        }

        public static void merge()
        {
            string first = "abc";
            string second = "def123456";

            var first1 = first.ToCharArray();
            var second1 = second.ToCharArray();

            var resultStr = "";
            var aaa = first1.Concat(second1).ToArray();
            int i = 0;
            int j = 0;
            while(i < first1.Length && j < second1.Length)
            {
                string str = first1[i] + second1[j].ToString();
                resultStr += str;
                i++;
                j++;
            }

            while(i < first1.Length)
            {
                string str = first1[j].ToString();
                resultStr += str;
                i++;
            }
            while(j < second1.Length)
            {
                string str = second1[j].ToString();
                resultStr += str;
                j++;
            }
        }

        public static int[][] Transpose(int[][] A)
        {
            int w = A[0].Length;
            int h = A[1].Length;

            int[][] B = new int [w][];
            for (int i = 0; i < h; i++)
            {
                B[i] = new int[h];
            }
            for (int i = 0; i < w; i++)
                for (int j = 0; j < h; j++)
                {
                    B[i][j] = A[i][j];
                }

            return B;
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
