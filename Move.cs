using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Move
    {
        public bool Run(string text, char character, bool odd = false)
        {
            if (odd)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else
            {
                Console.ResetColor();
            }
            Console.WriteLine(text);
            int column = int.Parse(Console.ReadLine());
            int row = int.Parse(Console.ReadLine());

            var valid = Validation(column, row);

            //kontrolka sprawdza czy input gracza miesci sie w przedziale kolumn i wierszy
            if (!valid)
            {
                Console.WriteLine("Zła wartość!!!");
                return false;
            }

            var isAvalible = Canvas.IsAvalible(column, row);

            //sprawdzenie czy ruch jest dostepny 
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

        //validacja przed podaniem złej wartosci row, column
        private bool Validation(int column, int row)
        {
            if (column > 3 || row > 3)
                return false;

            return true;
        }
    }
}