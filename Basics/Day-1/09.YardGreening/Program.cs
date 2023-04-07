using System;

namespace _09.YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double price = 7.61 * area;
            double discount = price * 0.18;
            double total = price - discount;

            Console.WriteLine($"The final price is: {total} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
          
        }
    }
}

