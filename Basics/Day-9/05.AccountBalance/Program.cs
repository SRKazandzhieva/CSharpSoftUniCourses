using System;

namespace _05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalSum = 0.0;

            while (input != "NoMoreMoney")
            {
                double sum = double.Parse(input);
                if (sum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                totalSum += sum;
                Console.WriteLine($"Increase: {sum:f2}");
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {totalSum:f2}");
        }
    }
}