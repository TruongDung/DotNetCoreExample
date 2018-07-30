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
