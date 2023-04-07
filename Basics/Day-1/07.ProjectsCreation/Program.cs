using System;

namespace _07.ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int countOfProjects = int.Parse(Console.ReadLine());

            int time = countOfProjects * 3;

            Console.WriteLine($"The architect {name} will need {time} hours to complete {countOfProjects} project/s.");
        }
    }
}
