using System;

namespace _05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double moneySpent = 0;
            string destination = "";
            string type = "";

            
            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    moneySpent = budget * 0.3;
                    type = "Camp";
                }
                else
                {
                    moneySpent = budget * 0.7;
                    type = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    moneySpent = budget * 0.4;
                    type = "Camp";
                }
                else
                {
                    moneySpent = budget * 0.8;
                    type = "Hotel";
                }
            }
            else
            {
                destination = "Europe";
                moneySpent = budget * 0.9;
                type = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{type} - {moneySpent:f2}");
        }
    }
}

