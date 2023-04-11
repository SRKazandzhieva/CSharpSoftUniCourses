using System;

namespace _04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSpeps = 0;
            bool isNotEnough = true;

            while (isNotEnough)
            {
                string input = Console.ReadLine();
                if (input != "Going home")
                {
                    totalSpeps += int.Parse(input);
                    if (totalSpeps >= 10000)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine($"{totalSpeps - 10000} steps over the goal!");
                        break;
                    }
                }
                else
                {
                    int lastSteps = int.Parse(Console.ReadLine());
                    totalSpeps += lastSteps;
                    if (totalSpeps >= 10000)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine($"{totalSpeps - 10000} steps over the goal!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{10000 - totalSpeps} more steps to reach goal.");
                        isNotEnough = false;
                    }
   
                }
                
            }
           
        }
    }
}

