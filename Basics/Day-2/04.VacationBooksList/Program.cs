using System;

namespace _04.VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int pageCount = int.Parse(Console.ReadLine());
            int pagesReadPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int result = ((pageCount / pagesReadPerHour) / days);
            Console.WriteLine(result);
        }
    }
}

