using System;

namespace _03.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFlower = Console.ReadLine();
            int quantityFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            if (typeFlower == "Roses")
            {
                if (quantityFlowers > 80)
                {
                    totalPrice = (5.00 * quantityFlowers) * 0.90;
                }
                else
                {
                    totalPrice = 5.00 * quantityFlowers;
                }
            }
            else if (typeFlower == "Dahlias")
            {
                if (quantityFlowers > 90)
                {
                    totalPrice = (3.80 * quantityFlowers) * 0.85;
                }
                else
                {
                    totalPrice = 3.80 * quantityFlowers;
                }
            }
            else if (typeFlower == "Tulips")
            {
                if (quantityFlowers > 80)
                {
                    totalPrice = (2.80 * quantityFlowers) * 0.85;
                }
                else
                {
                    totalPrice = 2.80 * quantityFlowers;
                }
            }
            else if (typeFlower == "Narcissus")
            {
                if (quantityFlowers < 120)
                {
                    totalPrice = (3.00 * quantityFlowers) * 1.15;
                }
                else
                {
                    totalPrice = 3.00 * quantityFlowers;
                }
            }
            else if (typeFlower == "Gladiolus")
            {
                if (quantityFlowers < 80)
                {
                    totalPrice = (2.50 * quantityFlowers ) * 1.20;
                }
                else
                {
                    totalPrice = 2.50 * quantityFlowers;
                }
            }

            double rest = budget - totalPrice;

            if (budget >= totalPrice)
            { 
                Console.WriteLine($"Hey, you have a great garden with {quantityFlowers} {typeFlower} and {rest:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(rest):f2} leva more.");
            }
        }

    }
}

