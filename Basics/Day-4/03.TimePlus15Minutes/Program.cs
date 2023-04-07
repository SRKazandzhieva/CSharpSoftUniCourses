using System;

namespace _03.TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            //read two line: hours(24) and minutes
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            // sum time plus 15min
            minutes += 15;
            if (minutes >= 60)
            {
                minutes -= 60;
                hours++;
            }
            if (hours >= 24)
            {
                hours = 0;
            }

            if (minutes >= 10)
            {
                Console.WriteLine($"{hours}:{minutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
        }
    }
}

