using System;
using System.Collections.Generic;
using System.Text;

namespace c_data
{
    class Program
    {
        static void Main(string[] args)
       
        {
            char[][] data03 = new char[3][];
            
            data03[0] = new char[2] { '1', '2' };
            data03[1] = new char[2] { '3', '4' };
            data03[2] = new char[2] { '5', '6' };
            for (int i = 0; i < data03.Length; ++i)
            {
                for (int j = 0; j < data03[i].Length; ++j)
                {
                    Console.Write("     {0}\t", data03[i][j]);
                }
                Console.WriteLine("\n");
            }
        }
    }
}