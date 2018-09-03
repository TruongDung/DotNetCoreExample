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
            //Prime.breakNumber(156897);
            //PhoneNumberFormat.FormatString1("aaa    bbb   ");
            //string aaa = ReverseArray.solution();

            //var result = StraightLineArray.check(3, new int[] { 2, 3, 5, 5,4,7,8,9 });


            //LinkedList lk = new LinkedList();
            //lk.Add("A");
            //lk.Add("B");
            //lk.printAllNodes();
            //Console.WriteLine();
            //Fibo.solution(9);

            //int result = 0;
            //var arr = new int[] { 10, 7, 4, 8, 12, 9 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] + arr[i + 1] == arr[i + 2])
            //    {
            //        result = arr[i + 1];
            //    }
            //    if (i + 2 == arr.Length)
            //        break;
            //}

            Console.Read();

        }

       

         public static int stock_prices_yesterday(int [] arr)
         {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] + arr[i + 1] == arr[i + 2])
                {
                    result = arr[i + 1];
                }
                if (i + 2 == arr.Length)
                    break;
            }
            return result;
         }

        public static int getTheNthElement(int n, int[] arr1, int[] arr2)
        {

            int i = 0, j = 0, k = 0;
            int n1 = arr1.Length;
            int n2 = arr2.Length;
            int[] arr3 = new int[n1 + n2];
            while (i < n1 && j < n2)
            {
                if (arr1[i] < arr2[j])
                    arr3[k++] = arr1[i++];
                else
                    arr3[k++] = arr2[j++];
            }
            while (i < n1)
                arr3[k++] = arr1[i++];

            while (j < n2)
                arr3[k++] = arr2[j++];


            for (int m = 0; m < arr3.Length; m++)
            {
                if (m == n)
                    return arr3[m];
            }
            return 0;
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


public class Node
{
    public Node next;
    public Object data;
}

public class LinkedList
{
    public class Node
    {
        // link to next Node in list
        public Node next = null;
        // value of this Node
        public object data;
    }

    private Node root = null;

    public Node First { get { return root; } }

    public Node Last
    {
        get
        {
            Node curr = root;
            if (curr == null)
                return null;
            while (curr.next != null)
                curr = curr.next;
            return curr;
        }
    }

    public void Add(Object value)
    {
        Node n = new Node { data = value };
        if (root == null)
            root = n;
        else
            Last.next = n;
    }

}