using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.FormmatingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            if (a>=0 && a<=500);
            {
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            double c = double.Parse(Console.ReadLine());
            string aBin = Convert.ToString(a, 2).PadLeft(10, '0');

            Console.WriteLine("|{0,-10:X}|{3}|{1,10:N2}|{2,-10:F3}|", a, b, c, aBin);
            }
        }
    }
}
