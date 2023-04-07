using System;

namespace _03.DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int period = int.Parse(Console.ReadLine());
            double ratePerYear = double.Parse(Console.ReadLine());

            //сума = депозирана сума  + срок на депозита *
            //((депозирана сума * годишен лихвен процент ) / 12)

            double dividend = (depositSum * (ratePerYear / 100)) /12;
            double sum = depositSum + dividend * period;
            Console.WriteLine(sum);
        }
    }
}

