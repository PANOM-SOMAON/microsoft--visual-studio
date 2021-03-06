using System;
using System.Collections.Generic;
using System.Text;
namespace PassByOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius = 3;
            int height = 10;
            double surfaceCurve;
            double volume;
            Computes(radius, height, out surfaceCurve, out volume);
            Console.WriteLine("Radius and Height of cylinder is {0} and {1} respectively.", radius, height);
            Console.WriteLine("surface area is {0}", surfaceCurve);
            Console.WriteLine("Volume is {0}", volume);
        }
        static void Computes(int r, int h, out double sC, out double vol)
        {
            sC = 2 * 3.142857 * r * h;
            vol = 3.142857 * r * r * h;
        }
    }
}