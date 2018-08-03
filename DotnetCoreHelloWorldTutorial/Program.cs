using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace DotnetCoreHelloWorldTutorial
{
    public delegate int calculation(int a, int b);

    class Program
    {
        static DateTime time;

        public static void Main(string[] args)
        {
            //TwoSumArray.solution();
            //Graph g 
            //var a = 10 << 32;
            //EncryptString("aaa");
            //GetFileStream();
            //var aaa = Prime.checkIsPrime(15);
            Prime.breakNumber(156897);
            Console.WriteLine();

        }

        public static string removeOccur(string input)
        {
            var ht = new Hashtable();
            var data = removeOccur("ABCADEAFBAGHB");
            //string  = "ABCADEAFBAGHB";
            // output: ABCDEAFGHB

            var dic = new Dictionary<char, char>();
            foreach (char item in input)
            {
                if (!dic.ContainsValue(item))
                {
                    dic.Add(item, item);
                }
            }

            string result = string.Empty;
            foreach (var item in dic)
            {
                result += item.Value;
            }
            return result;
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

        private static string EncryptString(string clearText, string Key = "XXXXX")
        {
            if (String.IsNullOrEmpty(clearText))
            {
                throw new ArgumentNullException("String to be encrypted cannot be null.");
            }

            byte[] keyBytes = ASCIIEncoding.ASCII.GetBytes(Key);

            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoProvider.CreateEncryptor(keyBytes, keyBytes), CryptoStreamMode.Write);
            StreamWriter writer = new StreamWriter(cryptoStream);
            writer.Write(clearText);
            writer.Flush();
            cryptoStream.FlushFinalBlock();
            writer.Flush();

            var encrypted = Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);

            return encrypted;
        }

        private static FileStream GetFileStream()
        {
            const int maxRetries = 5;
            string fileName = "FILE_NAM1E.txt";

            int attempts = maxRetries;
            FileStream fileStream = null;

            try
            {
                fileStream = File.Open(fileName, System.IO.FileMode.Open);
            }
            catch (Exception)
            {
                attempts--;
                if (attempts == 0)
                    throw;
            }

            return fileStream;
        }
    }

}
