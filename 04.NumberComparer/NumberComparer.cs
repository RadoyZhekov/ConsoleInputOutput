﻿using System;

    class NumberComparer
    {
        static void Main(string[] args)
        {
            Console.Write("a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b:");
            double b = double.Parse(Console.ReadLine());
            //Console.WriteLine(a>b ? a:b);
            double greater = Math.Max(a, b);
            Console.WriteLine("greater:" + greater);
        }
    }

