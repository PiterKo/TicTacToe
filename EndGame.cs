using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class EndGame
    {
        public void End()
        {
            var array = Canvas.StartCanvas;

            ShowCanvas.Execute(array);
            Console.WriteLine("Koniec gry!");
            Console.ReadKey();
        }

        public void Win(string name = "Piotr")
        {
            var array = Canvas.StartCanvas;

            ShowCanvas.Execute(array);

            Console.WriteLine($"Gratulacje {name}! Wygrana!");
            Console.WriteLine("Koniec gry!");
            Console.ReadKey();
        }
    }
}