using System;

namespace _05.GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfPeople = int.Parse(Console.ReadLine());
            double outfitPricePerOnePerson = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            double TotalOutfitPrice = numberOfPeople * outfitPricePerOnePerson;

            if (numberOfPeople > 150)
            {
                TotalOutfitPrice *= 0.90;
            }

            double costs = decor + TotalOutfitPrice;

            if (costs <= budget)
            {
                double leftMoney = budget - costs;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {leftMoney:f2} leva left.");
            }
            else
            {
                double neededMoney = costs - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {neededMoney:f2} leva more.");
            }

        }
    }
}

