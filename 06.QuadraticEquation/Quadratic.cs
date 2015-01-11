using System;

    class Quadratic
    {
        static void Main()
        {
            Console.Write("a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c:");
            double c = double.Parse(Console.ReadLine());

            double D = Math.Pow(b, 2) - 4 * a * c;
            if (a != 0)
            {
                D = Math.Pow(b, 2) - 4 * a * c;
            }
            else
            {
                Console.WriteLine(" nqma reshenie ");
            }

            if (D < 0)
            {
                Console.WriteLine("No real roots");
            }
            if (D == 0)
            {
                double x = (-b) / (2 * a);
                Console.WriteLine("x1=x2=:" +x);
            }
            if (D > 0)
            {
                double x1 = (-b - (Math.Sqrt(D))) / (2 * a);
                Console.WriteLine("x1=:" + x1);
                double x2 = (-b + (Math.Sqrt(D))) / (2 * a);
                Console.WriteLine("x2=:"+x2);

            }
        }
    }

