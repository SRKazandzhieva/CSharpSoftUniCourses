using System;

namespace _04.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int ages = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int toys = 0;
            int savedMoney = 0;
            int currentMoney = 10;

            for (int i = 1; i <= ages; i++)
            {
                if (i % 2 != 0)
                {
                    toys++;
                }
                else
                {
                    savedMoney += currentMoney - 1;
                    currentMoney += 10;
                }
            }
            savedMoney += toys * toyPrice;
            if (savedMoney >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {savedMoney - washingMachinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachinePrice - savedMoney:f2}");
            }
        }
    }
}

