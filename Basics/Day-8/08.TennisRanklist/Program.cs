using System;

namespace _08.TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int allTournaments = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());

            int newPoints = 0;
            int wins = 0;

            for (int i = 0; i < allTournaments; i++)
            {
                string currentResult = Console.ReadLine();
                if (currentResult == "W")
                {
                    newPoints += 2000;
                    wins++;
                }
                else if (currentResult == "F")
                {
                    newPoints += 1200;
                }
                else if (currentResult == "SF")
                {
                    newPoints += 720;
                }
            }
            Console.WriteLine($"Final points: {startPoints + newPoints}");
            Console.WriteLine($"Average points: {newPoints / allTournaments}");
            Console.WriteLine($"{(double) wins / allTournaments * 100:f2}%");
        }
    }
}

