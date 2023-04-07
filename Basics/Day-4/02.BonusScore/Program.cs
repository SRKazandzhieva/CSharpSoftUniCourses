using System;

namespace _02.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int startsPoint = int.Parse(Console.ReadLine());
            double bonusPoint = 0;

            if (startsPoint <= 100)
            {
                bonusPoint += 5;
            }
            else if (startsPoint <= 1000)
            {
                bonusPoint = startsPoint * 0.20;
            }
            else
            {
                bonusPoint = startsPoint * 0.10;
            }

            if (startsPoint % 2 == 0)
            {
                bonusPoint += 1;
            }
            if (startsPoint % 10 == 5)
            {
                bonusPoint += 2;
            }

            Console.WriteLine(bonusPoint);
            Console.WriteLine(bonusPoint + startsPoint);


        }
    }
}

