using System;

namespace _06.ConcatenateData
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int countOfProjects = int.Parse(Console.ReadLine());

            int timeForProjects = countOfProjects * 3;

            Console.WriteLine($"The architect {name} will need {timeForProjects} hours to complete {countOfProjects} project/s.");
        }
    }
}