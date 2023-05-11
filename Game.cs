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
            var response = move.Run($"Enter first move {playerOneName} column,row : ", playerOne);

            //Kontrolka czy pole jest juz zajęte
            if (!response)
            {
                goto FirstMove;
            }

            //kontrolka sprawdza wygraną
            if (Canvas.CheckWin() && lvl > 2)
                endGame.Win(playerOneName);

            //Kontrolka sprawdza czy tablica nie została w całości wypełniona znakami
            if (Canvas.IsEnd())
            {
                goto End;
            }

            //Fuckcja pokazuje aktualną tablice / canvas
            ShowCanvas.Execute(startArray);

        //drugi ruch w lvl
        SecondMove:
            response = move.Run($"Enter second move {playerTwoName} column,row : ", playerTwo);

            //Kontrolka czy pole jest juz zajęte
            if (!response)
            {
                goto SecondMove;
            }

            //kontrolka sprawdza wygraną
            if (Canvas.CheckWin() && lvl > 2)
                endGame.Win(playerTwoName);

            //Kontrolka sprawdza czy tablica nie została w całości wypełniona znakami
            if (Canvas.IsEnd())
            {
                goto End;
            }

            ShowCanvas.Execute(startArray);

            //Dodaje kolejny lvl i warca do początku
            lvl++;
            goto Start;

        End:
            //end of program
            endGame.End();
        }
    }
}