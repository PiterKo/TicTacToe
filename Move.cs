using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Move
    {
        public bool Run(string text, char character)
        {
            Console.WriteLine(text);
            int column = int.Parse(Console.ReadLine());
            int row = int.Parse(Console.ReadLine());

            var isAvalible = Canvas.IsAvalible(column, row);

            if (isAvalible)
            {
                Canvas.InsertChar(character, column, row);
                return true;
            }
            else
            {
                Console.WriteLine("Zły ruch! Spróbuj jescze raz.");
                return false;
            }

        }

    }
}