using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double readyMoney = double.Parse(Console.ReadLine());
            int totalDays = 0;
            int serialBadDay = 0;
            

            while (readyMoney < neededMoney && serialBadDay < 5)
            {
                string action = Console.ReadLine();
                double dailyMoney = double.Parse(Console.ReadLine());
                totalDays++;

                if (action == "spend")
                {
                    serialBadDay++;
                    if (serialBadDay == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(totalDays);
                        return;
                    }
                    if (dailyMoney > readyMoney)
                    {
                        readyMoney = 0;
                    }
                    else
                    {
                        readyMoney -= dailyMoney;
                    }
                }
                else
                {
                    serialBadDay = 0;
                    readyMoney += dailyMoney;
                }
            }
            if (readyMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {totalDays} days.");
            }
            
        }
    }
}

