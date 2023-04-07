using System;

namespace _09.LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNums = int.Parse(Console.ReadLine());
            int left = 0;
            int right = 0;

            for (int i = 1; i <= numberOfNums; i++)
            {
                left += int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= numberOfNums; i++)
            {
                right += int.Parse(Console.ReadLine());
            }

            if (left == right)
            {
                Console.WriteLine($"Yes, sum = {left}");
            }
            else
            {
                int sum = Math.Abs(left - right);
                Console.WriteLine($"No, diff = {sum}");
            }
        }
    }
}

