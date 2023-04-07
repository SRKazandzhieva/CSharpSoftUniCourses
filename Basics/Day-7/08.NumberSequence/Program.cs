using System;

namespace _08.NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = int.Parse(Console.ReadLine());

            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 1; i <= nums; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum > max)
                {
                    max = currentNum;
                }
                if (currentNum < min)
                {
                    min = currentNum;
                }
            }
            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}

