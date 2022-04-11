using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number1 : ");
            int A =int.Parse(Console.ReadLine());
            Console.WriteLine("Number1 = {0}:", A);
            Console.WriteLine("Enter Number2 : ");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Number2 = {0}:", B);
            if (A < B)
            {
                Console.WriteLine("Number1 is more than number2");
            }
            else
            {
                Console.WriteLine("Number1 is less than number2");
            }


        }
    }
}