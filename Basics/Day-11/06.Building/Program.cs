﻿using System;

namespace _06.Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int f = floors ; f > 0; f--)
            {
                for (int r = 0; r < rooms; r++)
                {
                    if (f == floors)
                    {
                        Console.Write($"L{f}{r} ");
                    }
                    else if (f % 2 == 0)
                    {
                        Console.Write($"O{f}{r} ");
                    }
                    else if (f % 2 != 0)
                    {
                        Console.Write($"A{f}{r} ");
                    }
                    
                }
                Console.WriteLine();
            }
            
        }
    }
}

