using System;

namespace _06.Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int naylonQuantity = int.Parse(Console.ReadLine());
            int paintQuantity = int.Parse(Console.ReadLine());
            int separatorQuantity = int.Parse(Console.ReadLine());
            int timeForWork = int.Parse(Console.ReadLine());

            double naylonPrice = (naylonQuantity + 2.0) * 1.50;
            double paintPrice = (paintQuantity + (paintQuantity * 0.10)) * 14.50;
            double separatorPrice = separatorQuantity * 5.00;

            double totalMatsCost = naylonPrice + paintPrice + separatorPrice + 0.40;
            double workerPrice = (totalMatsCost * 0.30) * timeForWork;
            double costs = totalMatsCost + workerPrice;

            Console.WriteLine(costs);

        }
    }
}

