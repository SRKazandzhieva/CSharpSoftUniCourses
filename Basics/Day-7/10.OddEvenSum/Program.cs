﻿using System;

namespace _10.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNums = int.Parse(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 1; i <= numberOfNums; i++)
            {
                if (i % 2 != 0)
                {
                    oddSum += int.Parse(Console.ReadLine());
                }
                else
                {
                    evenSum += int.Parse(Console.ReadLine());
                }

            }
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else
            {
                int diff = Math.Abs(evenSum - oddSum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}

