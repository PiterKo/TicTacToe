using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Greetings
    {
        public void StartGame()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("|     TicTacToe      |");
            Console.WriteLine("|      v 1.0.0       |");
            Console.WriteLine("----------------------");

            Console.WriteLine("");
            Console.WriteLine("Naciśnij przycisk by zacząć grę.");

            Console.ReadKey();
        }

        public string GetName()
        {
            Console.WriteLine("Podaj imię pierwszego gracza: ");
            var playerName = Console.ReadLine();
            Console.WriteLine($"Cześć {playerName}!");

            return playerName;
        }
    }
}