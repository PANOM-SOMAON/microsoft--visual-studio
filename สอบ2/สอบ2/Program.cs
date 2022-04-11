using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userid
{
    class program
    {
        static void Main(string[] args)
        {
            char[] Messenger = new char[5]; 
            Console.WriteLine("Enter your Messenger: ");
            string Messenger1 = Console.ReadLine();
            Console.WriteLine("Enter your Messenger: ");
            string Messenger2 = Console.ReadLine();
            Console.WriteLine("Enter your Messenger: ");
            string Messenger3 = Console.ReadLine();
            Console.WriteLine("Enter your Messenger: ");
            string Messenger4 = Console.ReadLine();
            Console.WriteLine("Enter your Messenger: ");
            string Messenger5 = Console.ReadLine();

            int vc = 0, cc = 0;
            foreach(char D in Messenger)
            {
                if(D>= 'a' && D <= 'z')
                {
                    if (D == 'a' || D == 'e' || D == 'i' || D == 'o' || D == 'u')
                        vc++;
                    else cc++;}
                 }
            Console.WriteLine("vc: {0} \ncc: {1}",vc,cc);

        }
    }
}