using System;

namespace _07.FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenMenuQantity = int.Parse(Console.ReadLine());
            int fishMenuQantity = int.Parse(Console.ReadLine());
            int vegMenuQantity = int.Parse(Console.ReadLine());

            double chickenMenuPrice = chickenMenuQantity * 10.35;
            double fishMenuPrice = fishMenuQantity * 12.40;
            double vegiMenuPrice = vegMenuQantity * 8.15;
            
            double totalMenu = chickenMenuPrice + fishMenuPrice + vegiMenuPrice;
            double dessert = totalMenu * 0.20;
            double sum = totalMenu + dessert + 2.50;

            Console.WriteLine(sum);
        }
    }
}

