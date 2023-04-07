using System;

namespace _06.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNum = int.MaxValue;
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Stop")
            {
                int currentNum = int.Parse(input);
                if (currentNum < minNum)
                {
                    minNum = currentNum;
                }
            }
            Console.WriteLine(minNum);
        }
    }
}