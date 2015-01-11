using System;

    class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.Write("n:");
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int c;

            if (n >= 3)
            {
                Console.Write(a + " " + b + " ");
                for (int i = 2; i < n; i++)
                {
                    c = a;
                    a = b;
                    b = c + a;
                    Console.Write(b + " ");
                }
                Console.WriteLine();
            }
            else if (n == 2)
            {
                Console.WriteLine(a + " " + b);
            }
            else if (n == 1)
            {
                Console.WriteLine(a + " ");
            }
        }
    }

