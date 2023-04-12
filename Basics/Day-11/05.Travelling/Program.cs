using System;

namespace _05.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            
            while (destination != "End")
            {
                double priceForVacation = double.Parse(Console.ReadLine());
                double currentMoney = 0;

                while (currentMoney < priceForVacation)
                {
                    currentMoney += double.Parse(Console.ReadLine());
                    
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}

