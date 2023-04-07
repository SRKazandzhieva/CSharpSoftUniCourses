using System;

namespace _04.InchestoCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            //double num = double.Parse(Console.ReadLine());
            //Console.WriteLine(num);

            double inches = double.Parse(Console.ReadLine());
            double result = inches * 2.54;
            Console.WriteLine(result);
        }
    }
}

