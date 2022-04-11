using System;
using System.Collections.Generic;
using System.Text;
namespace FunctionTest
{
    class Program
    {
        private static int id;
        private static string name;
        static void Main (string[] args)
        {
            ShowData(101, "Miss Thailand", "5 thai Rd.");
            changeid();
            changename();
        }
        public static void ShowData(int id, string name, string address)
        {
            Console.WriteLine("Customer ID is {0}", id);
            Console.WriteLine("Customer name is {0}", name);
            Console.WriteLine("Customer address is {0}", address);
            Console.WriteLine();
        }
        public static void changeid()
        {
            Console.Write("Plese Enter Customer id: ");
            id = int.Parse(Console.ReadLine());
        }
        public static void changename()
        {
            Console.Write("Please Enter Customer name: ");
            name = Console.ReadLine();
            Console.WriteLine("Customer id is {0}",id);
            Console.WriteLine("Customer name is {0}", name);
            Console.WriteLine();
        }
    }
}