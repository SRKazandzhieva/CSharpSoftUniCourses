using System;

namespace _07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double apartmentPrice = 0;
            double studioPrice = 0;

            // May, June, July, August, September или October

            if (month == "May" || month == "October")
            {
                apartmentPrice = 65.0 * nights;
                studioPrice = 50.0 * nights;
                  
            }
            else if (month == "June" || month == "September")
            {
                apartmentPrice = 68.70 * nights;
                studioPrice = 75.2 * nights; 
            }
            else
            {
                apartmentPrice = 77.0 * nights;
                studioPrice = 76.0 * nights;
            }

            if (nights > 14)
            {
                apartmentPrice *= 0.9;
                if (month == "May" || month == "October")
                {
                    studioPrice *= 0.7;
                }
                else if (month == "June" || month == "September")
                {
                    studioPrice *= 0.8;
                }
            }
            else if (nights > 7 && (month == "May" || month == "October"))
            {
                studioPrice *= 0.95;
            }

            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }       
    }
}

