using System;

namespace _04.Sequence2kPlus1
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int currentNum = 1;

            while (currentNum <= startNum)
            {
                Console.WriteLine(currentNum);
                currentNum = currentNum * 2 + 1;
            }
        }
    }
}

