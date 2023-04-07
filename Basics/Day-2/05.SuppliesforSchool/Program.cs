using System;

namespace _05.SuppliesforSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int pensQuantity = int.Parse(Console.ReadLine());
            int markersQuantity = int.Parse(Console.ReadLine());
            int abstergentLitres = int.Parse(Console.ReadLine());
            int percentDiscount = int.Parse(Console.ReadLine());

            double pensPrice = 5.80 * pensQuantity;
            double markersPrice = 7.20 * markersQuantity;
            double abstergentPrice = 1.20 * abstergentLitres;

            double sum = pensPrice + markersPrice + abstergentPrice;
            double sumWithDiscount = sum - sum *(percentDiscount / 100.0);

            Console.WriteLine(sumWithDiscount);
        } 
    }
}

