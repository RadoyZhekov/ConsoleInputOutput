using System;

    class SumFiveNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers: ");
            string numbers = Console.ReadLine();
            string[] fiveNumbers = numbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            for (int i = 0; i < fiveNumbers.Length; i++)
            {
                sum += double.Parse(fiveNumbers[i]);
            }

            Console.WriteLine("Sum = " + sum);
        }
    }

