using System;

namespace _05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sum = decimal.Parse(Console.ReadLine());
            int coins = 0;

            while (sum > 0)
            {
                if (sum >= 2.00m)
                {
                    sum -= 2.0m;
                }
                else if (sum >= 1.00m)
                {
                    sum -= 1.00m;
                }
                else if (sum >= 0.50m)
                {
                    sum -= 0.50m;
                }
                else if (sum >= 0.20m)
                {
                    sum -= 0.20m;
                }
                else if (sum >= 0.10m)
                {
                    sum -= 0.10m;
                }
                else if (sum >= 0.05m)
                {
                    sum -= 0.05m;
                }
                else if (sum >= 0.02m)
                {
                    sum -= 0.02m;
                }
                else
                {
                    sum -= 0.01m;
                }
                coins++;


                //if (sum >= 2) sum -= 2;
                //else if (sum >= 1) sum -= 1;
                //else if (sum >= 0.5m) sum -= 0.5m;
                //else if (sum >= 0.2m) sum -= 0.2m;
                //else if (sum >= 0.1m) sum -= 0.1m;
                //else if (sum >= 0.05m) sum -= 0.05m;
                //else if (sum >= 0.02m) sum -= 0.02m;
                //else sum -= 0.01m;
                //coins++;
            }
            Console.WriteLine(coins);
        }
    }
}

