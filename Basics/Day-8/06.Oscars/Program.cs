using System;

namespace _06.Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double startPoints = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            double points = 0;
            double totalPoints = startPoints + points;

            for (int i = 0; i < n; i++)
            {
                string juruName = Console.ReadLine();
                double juryPoints = double.Parse(Console.ReadLine());

                points = (juruName.Length * juryPoints) / 2.00;
                totalPoints += points;

                if (totalPoints > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {totalPoints:f1}!");
                    break;
                }
            }
            if (totalPoints <= 1250.5)
            {
                Console.WriteLine($"Sorry, {actor} you need {1250.5 - totalPoints:f1} more!");
            }
        }
    }
}

