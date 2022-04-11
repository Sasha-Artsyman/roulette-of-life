using System;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            // ввод числа игроков
            Console.WriteLine("--- Welcome to the Roulette of life ---");
            Console.Write("Enter number of players: ");
            int playersNum = Convert.ToInt32(Console.ReadLine());

            // выстрелы
            string[] shots = { "survived", "survived", "survived", "survived", "survived", "dead !!!" };
          
            // переменные для цикла
            int playerNum = 1;
            bool gameEnd = false;

            // цикл игры
            do
            {
                Console.Write("\nPlayer {0}: ", playerNum);
                if (playerNum == playersNum)
                    playerNum = 1;
                else
                    playerNum++;

                string shot = shots[new Random().Next(0, shots.Length)];

                if (shot == "dead !!!")
                    Console.ForegroundColor = ConsoleColor.Red;

                Console.Write(shot);
                Console.ResetColor();

                if (shot == "dead !!!")
                {
                    gameEnd = true;
                }
            }
            while (!gameEnd);

            Console.WriteLine("\n\n--- Thanks for playing! ---");

            Console.ReadLine();
        }
    }
}
