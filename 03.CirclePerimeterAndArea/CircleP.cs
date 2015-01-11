using System;

    class CircleP
    {
        static void Main()
        {
            Console.Write("r : ");
            double r = double.Parse(Console.ReadLine());
            double P = 2 * Math.PI * r;
            Console.WriteLine("P: {0:N2}", P);
            double S = Math.PI * r * r;
            Console.WriteLine("S: {0:N2}", S);
        }
    }

