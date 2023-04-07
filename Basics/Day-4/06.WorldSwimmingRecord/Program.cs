using System;

namespace _06.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double oldRecordInSec = double.Parse(Console.ReadLine());
            double distanceInM = double.Parse(Console.ReadLine());
            double seconsFor1M = double.Parse(Console.ReadLine());

            double delayInSec = Math.Floor(distanceInM / 15) * 12.5;
            double totalTime = distanceInM * seconsFor1M + delayInSec;

            if (totalTime < oldRecordInSec)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(totalTime - oldRecordInSec):f2} seconds slower.");
            }
        }
    }
}

