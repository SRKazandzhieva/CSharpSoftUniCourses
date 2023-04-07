using System;

namespace _08.BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int annualFee = int.Parse(Console.ReadLine());

            double shoes = annualFee - (annualFee * 0.40); // == annualFee * 0.60
            double outfit = shoes - (shoes * 0.20); // == shoes * 0.80
            double ball = outfit / 4;
            double accsessories = ball / 5;
            double totalSum = annualFee + shoes + outfit + ball + accsessories;


            Console.WriteLine(totalSum);
        }
    }
}

