using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe
{
    public static class Canvas
    {
        public static char[,] StartCanvas { get; set; }

        static Canvas()
        {
            // StartCanvas = new char[3, 3]
            // {
            //     {'1', '2', '3'},
            //     {'4', '5', '6'},
            //     {'7', '8', '9'}
            // };

            // StartCanvas = new char[3, 3]
            // {
            //     {'-', '-', '-'},
            //     {'-', '-', '-'},
            //     {'-', '-', '-'}
            // };

            StartCanvas = new char[3, 3]
            {
                {' ', ' ', ' '},
                {' ', ' ', ' '},
                {' ', ' ', ' '}
            };
        }

        public static void InsertChar(char character, int column, int row)
        {
            StartCanvas[row, column] = character;
        }

        //funkcja sprawdz czy pole nie jest juz zajete
        public static bool IsAvalible(int column, int row)
        {
            var character = StartCanvas[row, column];

            if (character == ' ')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //funkcja sprawdza czy tablica jest juz zapełniona
        public static bool IsEnd()
        {
            foreach (var item in StartCanvas)
            {
                if (item == ' ')
                    return false;

            }

            return true;
        }

        public static bool CheckWin()
        {
            //srawdza znaki z wierszy
            for (var i = 0; i < 3; i++)
            {
                var row = GetCharactersFromRow(i);
                if (CheckChars(row))
                    return true;
            }

            //sprawdza znaki z kolumn
            for (var i = 0; i < 3; i++)
            {
                var column = GetCharactersFromColumn(i);
                if (CheckChars(column))
                    return true;
            }

            var isCross = CheckChars(GetCharactersFromCross());

            if (isCross)
                return true;

            isCross = CheckChars(GetCharactersFromCross(true));

            if (isCross)
                return true;

            return false;
        }

        //sprawdza czy podane trzy znaki są takie same
        private static bool CheckChars(char[] characters)
        {

            foreach (var character in characters)
            {
                if (character == ' ')
                    return false;

                if (characters[0] == characters[1] && characters[1] == characters[2])
                {
                    return true;
                }
            }

            return false;
        }

        //pobiera znaki z podanego w parametrze wiersza
        private static char[] GetCharactersFromRow(int row)
        {
            var characters = new char[3];

            for (var i = 0; i < 3; i++)
            {
                var character = StartCanvas[row, i];
                characters[i] = character;
            }

            return characters;
        }

        //pobiera znaki z podanej w parametrze kolumny
        private static char[] GetCharactersFromColumn(int column)
        {
            var characters = new char[3];

            for (var i = 0; i < 3; i++)
            {
                var character = StartCanvas[i, column];
                characters[i] = character;
            }

            return characters;
        }

        /// <summary>
        /// pobiera znaki z skosów => default skos lewy, podajac parametr true skos prawy
        /// </summary>
        /// <param name="rightCross">Prawy skos</param>
        /// <returns></returns>
        private static char[] GetCharactersFromCross(bool rightCross = false)
        {
            var characters = new char[3];

            var reverseIndex = 2;

            for (var i = 0; i < 3; i++)
            {
                var character = StartCanvas[i, rightCross ? reverseIndex : i];
                characters[i] = character;
                reverseIndex--;
            }

            return characters;
        }
    }
}