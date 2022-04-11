using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("HelloWorld {0}, I hope you are feeling well.",name);
            Console.WriteLine();
            Console.WriteLine("Enter your age (I promise not to tell anyone):");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("If your birthday is after {0} then", DateTime.Now);
            Console.WriteLine("you will be {0} later this yeat.", age + 1);
            Console.WriteLine("or still be {0} until next year.", age);

        }
    }
}