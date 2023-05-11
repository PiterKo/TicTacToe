using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe
{
    public static class ShowCanvas
    {
        public static void Execute(char[,] startArray, int columns = 3, int rows = 3)
        {
            Console.WriteLine();

            Console.WriteLine("_____________");
            for (int y = 0; y < columns; y++)
            {
                for (int i = 0; i < rows; i++)
                {
                    Console.Write($"| {startArray[y, i]} ");
                }

                Console.Write("|");
                Console.WriteLine();
                Console.WriteLine("_____________");
            }

            Console.WriteLine();
        }
    }
}