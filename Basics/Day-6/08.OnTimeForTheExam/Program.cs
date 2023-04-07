using System;

namespace _08.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examH = int.Parse(Console.ReadLine());
            int examMins = int.Parse(Console.ReadLine());
            int comingH = int.Parse(Console.ReadLine());
            int comingMins = int.Parse(Console.ReadLine());

            int examTime = examH * 60 + examMins;
            int comingTime = comingH * 60 + comingMins;
            int difference = 0;
            int hours = 0;
            int mins = 0;


            if (examTime < comingTime)
            {
                
                difference = comingTime - examTime;
                if (difference > 59)
                {
                    hours = difference / 60;
                    mins = difference % 60;
                    if (mins < 10)
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{hours}:0{mins} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{hours}:{mins} hours after the start");
                    }
                }
                else
                {

                    Console.WriteLine($"late {difference} minutes after the start");
                }
            }
            else if ((examTime - comingTime) <= 30)
            {
                // on time
                if (examTime == comingTime)
                {
                    Console.WriteLine("On time");
                }
                else
                {
                    difference = examTime - comingTime;
                    Console.WriteLine("On time");
                    Console.WriteLine($"{difference} minutes before the start");
                }
            }
            else
            {
                //early
                difference = examTime - comingTime;

                if (difference > 59)
                {
                    hours = difference / 60;
                    mins = difference % 60;
                    if (mins < 10)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{hours}:0{mins} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{hours}:{mins} hours before the start");
                    }
                }
                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{difference} minutes before the start");
                }
            }
        }
    }
}

