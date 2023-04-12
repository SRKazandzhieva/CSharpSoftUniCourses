using System;

namespace _04.SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magiNum = int.Parse(Console.ReadLine());
            int combinationNum = 0;
            bool isFind = false;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    combinationNum++;
                    if (i + j == magiNum)
                    {
                        Console.WriteLine($"Combination N:{combinationNum} ({i} + {j} = {i + j})");
                        isFind = true;
                        break;
                    }
                    
                }
                if (isFind)
                {
                    break;
                }
            }
            if (!isFind)
            {
                Console.WriteLine($"{combinationNum} combinations - neither equals {magiNum}");
            }
        }
    }
}

