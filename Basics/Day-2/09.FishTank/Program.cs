using System;

namespace _09.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            // length, width and height
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volumeInLitres = (lenght * width * height) * 0.001;
            double waterSpace = volumeInLitres - (volumeInLitres * (percent / 100));

            Console.WriteLine(waterSpace);


            //Console.WriteLine("{0:f5}", waterSpace);
            //- форматиране до 5-тия знак след десетичната запетая
        }
    }
}

