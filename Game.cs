using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Game
    {
        public void Main(char[,] startArray, int columns, int rows, string playerOneName, string playerTwoName)
        {
            var lvl = 1;
            char playerOne = (playerOneName.ToLower())[0];
            char playerTwo = (playerTwoName.ToLower())[0];

            var endGame = new EndGame();


            ShowCanvas.Execute(startArray, columns, rows);

        Start:
            Console.WriteLine($"{lvl} level!");

            var move = new Move();

        //pierwszy ruch w lvl
        FirstMove:

            DoMove(move, playerOneName, playerOne, lvl, startArray);

        //drugi ruch w lvl
        SecondMove:

            DoMove(move, playerTwoName, playerTwo, lvl, startArray);

            //Dodaje kolejny lvl i warca do początku
            lvl++;
            goto Start;

            //end of program
            endGame.End();
        }

        private void DoMove(Move move, string playerName, char playerChar, int lvl, char[,] startArray)
        {
        FirstMove:
            var response = move.Run($"Enter first move {playerName} column,row : ", playerChar);

            var endGame = new EndGame();

            //Kontrolka czy pole jest juz zajęte
            if (!response)
            {
                goto FirstMove;
            }

            //kontrolka sprawdza wygraną
            if (Canvas.CheckWin() && lvl > 2)
                endGame.Win(playerName);

            //Kontrolka sprawdza czy tablica nie została w całości wypełniona znakami
            if (Canvas.IsEnd())
            {
                return;
            }

            //Fuckcja pokazuje aktualną tablice / canvas
            ShowCanvas.Execute(startArray);
        }
    }
}