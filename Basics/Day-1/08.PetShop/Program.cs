using System;

namespace _08.PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityDog = int.Parse(Console.ReadLine());
            int quantityCat = int.Parse(Console.ReadLine());
            double dogFoodPrice = 2.5;
            double catFoodPrice = 4;

            double sum = (quantityDog * dogFoodPrice) + (quantityCat * catFoodPrice);

            Console.WriteLine(sum + " lv.");
        }
    }
}

