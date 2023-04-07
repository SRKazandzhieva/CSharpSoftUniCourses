using System;

namespace _01.SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int timing1 = int.Parse(Console.ReadLine());
            int timing2 = int.Parse(Console.ReadLine());
            int timing3 = int.Parse(Console.ReadLine());

            // sum them and transfer to = min:seconds in format wit 2 simbol for seconds
            int totalSec = timing1 + timing2 + timing3;
            int minutes = 0;
            int seconds = 0;

            if (totalSec >= 60)
            {
                minutes = totalSec / 60;
                seconds = totalSec % 60;
            }
            else
            { 
                seconds = totalSec;
            }

            if (seconds >= 10)
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }

        }
    }
}

