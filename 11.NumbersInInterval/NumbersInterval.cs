using System;

    class NumbersInterval
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write(i + " ");
                    count++;    
                }
                
            }
            Console.WriteLine();
            Console.WriteLine(count);
        }
    }

