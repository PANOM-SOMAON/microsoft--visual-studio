using System;
using System.Collections.Generic;
using System.Text;

namespace e_data
{
    class Program
    {
        static void Main(string[] args)
          
        {
            string[] e_data05 = new string[] { "abc", "def", "ghi" };
            for (int a = 0; a < 3; ++a)
            {
                Console.WriteLine("\t {0}", e_data05[a]);
            }
            
        }
    }
}