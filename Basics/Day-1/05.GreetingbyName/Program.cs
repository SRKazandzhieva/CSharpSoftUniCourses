using System;

namespace _05.GreetingbyName
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 25;
            //int b = a / 4;
            //double c = a / 4.0;

            //int left = a % b;  // 25 % 4 == ( 6*4 ) +1 == 1 - ostatak

            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(left);

            string name = Console.ReadLine();

            // Console.WriteLine("Hello, " + name + "!");
            Console.WriteLine($"Hello, {name}!");
        }
    }
}

