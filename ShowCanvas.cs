using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe
{
    public static class ShowCanvas
    {
        /// <summary>
        /// funkcja wyświetla podana w parametrze tablice
        /// </summary>
        /// <param name="startArray"></param>
        /// <param name="columns"></param>
        /// <param name="rows"></param>
        public static void Execute(char[,] startArray, int columns = 3, int rows = 3)
        {
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("_____________");
            for (int y = 0; y < columns; y++)
            {
                for (int i = 0; i < rows; i++)
                {
                    Console.Write($"| ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{startArray[y, i]} ");
                    Console.ResetColor();
                }

                Console.Write("|");
                Console.WriteLine();
                Console.WriteLine("_____________");
            }
            Console.WriteLine();
        }
    }
}