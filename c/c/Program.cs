using System;
using System.Collections.Generic;
using System.Text;

namespace data
{
    class Program
    {
        static void Main(string[] args)
        
        {
            double[,,] d_data04 = new double[2, 2, 2] { { { 1.5, 2.2 }, { 3.3, 4.4 } }, { { 5.5, 6.6 }, { 7.7, 8.9 } } };
            for (int a = 0; a < 2; ++a)
            {
                for (int b = 0; b < 2; ++b)
                {
                    for (int c = 0; c < 2; ++c)
                    {
                        Console.WriteLine("\n {0}", d_data04[a, b, c]);
                    }
                }
                
            }
        }
    }
}