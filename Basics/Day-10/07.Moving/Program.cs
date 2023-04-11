using System;

namespace _07.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            int newHomeSpace = w * l * h;
            int TotalBaggage = 0;
            string command = Console.ReadLine();

            while ((command != "Done") && (newHomeSpace > TotalBaggage))
            {
                int cartons = int.Parse(command);
                TotalBaggage += cartons;
                command = Console.ReadLine();
            }
            if (command == "Done")
            {
                Console.WriteLine($"{newHomeSpace - TotalBaggage} Cubic meters left.");
            }
            if (newHomeSpace < TotalBaggage)
            {
                Console.WriteLine($"No more free space! You need {TotalBaggage - newHomeSpace} Cubic meters more.");
            }
        }
    }
}

