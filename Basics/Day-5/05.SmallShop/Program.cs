using System;

namespace _05.SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            //град / продукт  coffee water   beer    sweets  peanuts
            //Sofia           0.50    0.80    1.20    1.45    1.60
            //Plovdiv         0.40    0.70    1.15    1.30    1.50
            //Varna           0.45    0.70    1.10    1.35    1.55
            double price = 0;

            switch (product)
            {
                case "coffee":
                    switch (city)
                    {
                        case "Sofia":
                            price = quantity * 0.5;
                            break;
                        case "Plovdiv":
                            price = quantity * 0.4;
                            break;
                        case "Varna":
                            price = quantity * 0.45;
                            break;
                    }
                    break;

                case "water":
                    switch (city)
                    {
                        case "Sofia":
                            price = quantity * 0.8;
                            break;
                        case "Plovdiv":
                            price = quantity * 0.7;
                            break;
                        case "Varna":
                            price = quantity * 0.7;
                            break;
                    }

                     break;
                case "beer":
                    switch (city)
                    {
                        case "Sofia":
                            price = quantity * 1.2;
                            break;
                        case "Plovdiv":
                            price = quantity * 1.15;
                            break;
                        case "Varna":
                            price = quantity * 1.1;
                            break;
                    }
                     break;
                case "sweets":
                    switch (city)
                    {
                        case "Sofia":
                            price = quantity * 1.45;
                            break;
                        case "Plovdiv":
                            price = quantity * 1.30;
                            break;
                        case "Varna":
                            price = quantity * 1.35;
                            break;
                    }
                    break;
                case "peanuts":
                    switch (city)
                    {
                        case "Sofia":
                            price = quantity * 1.6;
                            break;
                        case "Plovdiv":
                            price = quantity * 1.5;
                            break;
                        case "Varna":
                            price = quantity * 1.55;
                            break;
                    }
                    break;
            }
            Console.WriteLine(price);
        }
    }
}

