using System;

namespace _04.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishers = int.Parse(Console.ReadLine());

            double boatPrice = 0;
            // Цената за наем на кораба през пролетта е  3000 лв.
            // Цената за наем на кораба през лятото и есента е  4200 лв.
            // Цената за наем на кораба през зимата е  2600 лв.
            if (season == "Spring")
            {
                boatPrice = 3000;
            }
            else if (season == "Summer" || season =="Autumn")
            {
                boatPrice = 4200;
            }
            else
            {
                boatPrice = 2600;
            }

            // В зависимост от броя си групата ползва отстъпка:
            // Ако групата е до 6 човека включително  –  отстъпка от 10 %.
            // Ако групата е от 7 до 11 човека включително  –  отстъпка от 15 %.
            // Ако групата е от 12 нагоре  –  отстъпка от 25 %.
            if (fishers <= 6)
            {
                boatPrice = boatPrice * 0.90;
            }
            else if (fishers <= 11)
            {
                boatPrice = boatPrice * 0.85;
            }
            else
            {
                boatPrice = boatPrice * 0.75;
            }
            // 5% отстъпка, ако са четен брой освен ако не е есен - тогава нямат допълнителна отстъпка
            if (fishers % 2 == 0 && season != "Autumn")
            {
                boatPrice = boatPrice * 0.95;
            }

            double sum = 0;
            if (budget >= boatPrice )
            {
                sum = budget - boatPrice;
                Console.WriteLine($"Yes! You have {sum:f2} leva left.");
            }
            else
            {
                sum = boatPrice - budget;
                Console.WriteLine($"Not enough money! You need {sum:f2} leva.");
            }
        }
    }
}


