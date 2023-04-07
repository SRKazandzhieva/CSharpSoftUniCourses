using System;

namespace _08.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double sumOfGrades = 0.0;
            int level = 1;
            int badGrades = 0;

            while (level <= 12)
            {
                double currentGrade = double.Parse(Console.ReadLine());

                if (currentGrade < 4)
                {
                    badGrades++;
                    if (badGrades == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {level} grade");
                        return;       
                    }
                    continue;
                }
                level++;
                sumOfGrades += currentGrade;
            }
            double averageGrade = sumOfGrades / 12.0;
            Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
        }
    }
}

