using System;

namespace _07.TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            int g1 = 0, g2 = 0, g3 = 0, g4 = 0, g5 = 0;


            for (int i = 0; i < groups; i++)
            {
                int peopleInGroup = int.Parse(Console.ReadLine());
                if (peopleInGroup < 6)
                {
                    g1 += peopleInGroup;
                }
                else if (peopleInGroup < 13)
                {
                    g2 += peopleInGroup;
                }
                else if (peopleInGroup < 26)
                {
                    g3 += peopleInGroup;
                }
                else if (peopleInGroup < 41)
                {
                    g4 += peopleInGroup;
                }
                else
                {
                    g5 += peopleInGroup;
                }
            }
            int totalPpl = g1 + g2 + g3 + g4 + g5;

            Console.WriteLine($"{(double) g1 / totalPpl * 100:f2}%");
            Console.WriteLine($"{(double) g2 / totalPpl * 100:f2}%");
            Console.WriteLine($"{(double) g3 / totalPpl * 100:f2}%");
            Console.WriteLine($"{(double) g4 / totalPpl * 100:f2}%");
            Console.WriteLine($"{(double) g5 / totalPpl * 100:f2}%");
        }
    }
}

