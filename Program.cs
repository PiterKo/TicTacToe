// See https://aka.ms/new-console-template for more information
using TicTacToe;

Console.WriteLine("TicTacToe Game");

const int columns = 3;
const int rows = 3;

int lvl = 1;

char palyerOne = 'x';
char playerTwo = 'o';

string playerOneName = "Bob";
string playerTwoName = "Robert";

var startArray = Canvas.StartCanvas;
var endGame = new EndGame();



ShowCanvas.Execute(startArray, columns, rows);

Start:
Console.WriteLine($"{lvl} level!");

var move = new Move();

//pierwszy ruch w lvl
FirstMove:
var response = move.Run($"Enter first move {playerOneName} column,row : ", palyerOne);

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