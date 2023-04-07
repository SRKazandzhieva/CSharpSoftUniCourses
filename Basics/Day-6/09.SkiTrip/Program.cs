using System;

namespace _09.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string rate = Console.ReadLine();

            int nights = days - 1;
            double priceForAllNights = 0;

            if (days < 10)
            {
                if (roomType == "room for one person")
                {
                    priceForAllNights = 18.00 * nights;
                }
                else if (roomType == "apartment")
                {
                    priceForAllNights = (25.00 * nights) * 0.70;
                }
                else
                {
                    priceForAllNights = (35.00 * nights) * 0.90;
                }
            }
            else if (days < 15)
            {
                if (roomType == "room for one person")
                {
                    priceForAllNights = 18.00 * nights;
                }
                else if (roomType == "apartment")
                {
                    priceForAllNights = (25.00 * nights) * 0.65;
                }
                else
                {
                    priceForAllNights = (35.00 * nights) * 0.85;
                }
            }
            else
            {
                if (roomType == "room for one person")
                {
                    priceForAllNights = 18.00 * nights;
                }
                else if (roomType == "apartment")
                {
                    priceForAllNights = (25.00 * nights) * 0.50;
                }
                else
                {
                    priceForAllNights = (35.00 * nights) * 0.80;
                }
            }
            if (rate == "positive")
            {
                priceForAllNights *= 1.25;
            }
            else
            {
                priceForAllNights *= 0.90;
            }

            Console.WriteLine($"{priceForAllNights:f2}");
        }
    }
}

