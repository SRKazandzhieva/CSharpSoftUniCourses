using System;

namespace _08.LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string filmTitle = Console.ReadLine();
            int filmDuration = int.Parse(Console.ReadLine());
            int freeTime = int.Parse(Console.ReadLine());

            double lunch = freeTime / 8.0;
            double rest = freeTime / 4.0;
            double sum = lunch + rest + filmDuration;

            if (freeTime >= sum)
            {
                double leftTime = freeTime - sum;
                Console.WriteLine($"You have enough time to watch {filmTitle} and left with {Math.Ceiling(leftTime)} minutes free time.");
            }
            else
            {
                double leftTime = sum - freeTime;
                Console.WriteLine($"You don't have enough time to watch {filmTitle}, you need {Math.Ceiling(leftTime)} more minutes.");
            }

        }
    }
}

