using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class EndGame
    {
        /// <summary>
        /// Konie gry
        /// </summary>
        public void End()
        {
            var array = Canvas.StartCanvas;

            ShowCanvas.Execute(array);
            Console.WriteLine("Koniec gry!");
            Console.ReadKey();
        }

        /// <summary>
        /// koniec gry wygrana!
        /// </summary>
        /// <param name="name"></param>
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