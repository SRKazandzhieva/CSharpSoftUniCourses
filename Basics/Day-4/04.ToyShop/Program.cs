using System;

namespace _04.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double travelPrice = double.Parse(Console.ReadLine());
            int puzzlesQuantity = int.Parse(Console.ReadLine());
            int dollsQuantity = int.Parse(Console.ReadLine());
            int bearsQuantity = int.Parse(Console.ReadLine());
            int minionsQuantity = int.Parse(Console.ReadLine());
            int trucksQuantity = int.Parse(Console.ReadLine());

            double orderPrice = puzzlesQuantity * 2.60 + dollsQuantity * 3.00 + bearsQuantity * 4.10 + minionsQuantity * 8.20 + trucksQuantity * 2.00;
            int orderQuantity = puzzlesQuantity + dollsQuantity + bearsQuantity + minionsQuantity + trucksQuantity;
            double moneyLeft = 0;
            if (orderQuantity >= 50)
            {
                moneyLeft = orderPrice * 0.75;
            }
            else
            {   
                moneyLeft = orderPrice;
            }
            moneyLeft *= 0.90;

            if (moneyLeft >= travelPrice)
            {
                moneyLeft -= travelPrice;
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else
            {
                double neededMoney = travelPrice - moneyLeft;
                Console.WriteLine($"Not enough money! {neededMoney:f2} lv needed.");
            }
        }
    }
}

