﻿using System;

namespace _06.NumberInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            bool isValid = (num >= -100) && (num <= 100) && (num != 0);

            if (!isValid)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }
    }
}

