using System;

namespace _02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int possibleBadGrades = int.Parse(Console.ReadLine());
            string currentTask = "";
            int countTassks = 0;
            double sumOfTheAllGrades = 0.0;
            string lastTaskName = "";
            int countOfBadGrede = 0;
            

            while ((currentTask = Console.ReadLine()) != "Enough")
            {
                countTassks++;
                lastTaskName = currentTask;

                int grade = int.Parse(Console.ReadLine());
                sumOfTheAllGrades += grade;

                if (grade <= 4)
                {
                    countOfBadGrede++;

                    if (countOfBadGrede == possibleBadGrades)
                    {
                        Console.WriteLine($"You need a break, {countOfBadGrede} poor grades.");
                        break;
                    }
                    continue;
                }
            }
            if (currentTask == "Enough")
            {
                Console.WriteLine($"Average score: {sumOfTheAllGrades / countTassks:f2}");
                Console.WriteLine($"Number of problems: {countTassks}");
                Console.WriteLine($"Last problem: {lastTaskName}");
            }
        }
    }
}

