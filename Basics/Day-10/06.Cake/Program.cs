using System;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int pieceOfCake = width * length;
            int takenPieces = 0;
            string action = Console.ReadLine();

            while (action != "STOP" && pieceOfCake > takenPieces)
            {
                int currentPieces = int.Parse(action);
                takenPieces += currentPieces;
                action = Console.ReadLine();
              
            }
            if (takenPieces >= pieceOfCake)
            {
                Console.WriteLine($"No more cake left! You need {takenPieces - pieceOfCake} pieces more.");
            }
            if (action == "STOP")
            {
                Console.WriteLine($"{pieceOfCake - takenPieces} pieces are left.");
            }

        }
    }
}

