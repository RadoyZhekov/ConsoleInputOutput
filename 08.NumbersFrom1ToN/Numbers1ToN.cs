using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.NumbersFrom1ToN
{
    class Numbers1ToN
    {
        static void Main()
        {
            Console.Write("input:");
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
