using System;
 class SumOfN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers:");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += double.Parse(Console.ReadLine());

            }

            Console.WriteLine("result:" + sum);
        }
    }

