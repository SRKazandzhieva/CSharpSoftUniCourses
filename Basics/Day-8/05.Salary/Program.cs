using System;

namespace _05.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int openTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            int fee = 0;

            for (int i = 0; i < openTabs; i++)
            {
                string currentTab = Console.ReadLine();
                if (currentTab == "Facebook")
                {
                    fee += 150;
                }
                else if (currentTab == "Instagram")
                {
                    fee += 100;
                }
                else if (currentTab == "Reddit")
                {
                    fee += 50;
                }
                if (fee >= salary)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (salary > fee)
            {
                Console.WriteLine(salary - fee);
            }
        }
    }
}

