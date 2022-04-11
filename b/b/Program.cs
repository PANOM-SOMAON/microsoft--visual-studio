using System;
using System.Collections.Generic;
using System.Text;

namespace c_data
{
    class Program
    {
        static void Main(string[] args)

        {
            int[][] data = new int[3][];

            data[0] = new int[3] { 1,2,3 };
            data[1] = new int[3] { 4,5,6, };
            for (int i = 0; i < data.Length; ++i)
            {
                for (int k = 0; k < data[i].Length; ++k)
                {
                    Console.Write("     {0}\t", data[i][k]);
                }
               Console.WriteLine("\n");
            }
        }
    }
}