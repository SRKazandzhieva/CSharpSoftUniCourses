using System;

namespace _07.Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCardsQuantity = int.Parse(Console.ReadLine());
            int processorsQuantity = int.Parse(Console.ReadLine());
            int ramQuantity = int.Parse(Console.ReadLine());

            double vPrice = videoCardsQuantity * 250;
            double pPrice = vPrice * 0.35 * processorsQuantity;
            double ramPrice = vPrice * 0.10 * ramQuantity;
            double totalSum = vPrice + pPrice + ramPrice;

            if (videoCardsQuantity > processorsQuantity)
            {
                totalSum *= 0.85;
            }
            if (budget >= totalSum)
            {
                Console.WriteLine($"You have {(budget - totalSum):f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(totalSum - budget):f2} leva more!");
            }
            //Console.WriteLine(totalSum);
        }
        
    }
}

