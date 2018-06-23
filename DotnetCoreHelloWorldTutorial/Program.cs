using System;

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
            Console.ReadLine();
        }
    }
}
