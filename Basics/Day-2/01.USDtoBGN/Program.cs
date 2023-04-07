using System;

namespace _01.USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double usdIn = double.Parse(Console.ReadLine());
            double bgnForOneUsd = 1.79549;

            double convert = usdIn * bgnForOneUsd;
            Console.WriteLine(convert);
        }
    }
}

