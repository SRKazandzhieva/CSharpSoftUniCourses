using System;

namespace _03.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int endSum = int.Parse(Console.ReadLine());
            int sum = 0;

            while (endSum > sum)
            {
                int currentSum = int.Parse(Console.ReadLine());
                sum += currentSum;
                  
            }
            Console.WriteLine(sum);
        }
    }
}

