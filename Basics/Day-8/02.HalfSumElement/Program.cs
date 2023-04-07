using System;

namespace _02.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int bigest = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                totalSum += num;
                if (num > bigest)
                {
                    bigest = num;
                }
            }

            if (bigest == (totalSum - bigest))
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {bigest}");
            }
            else
            {
                int diff = Math.Abs(bigest * 2 - totalSum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}

