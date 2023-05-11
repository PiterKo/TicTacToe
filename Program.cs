using TicTacToe;

const int columns = 3;
const int rows = 3;

string playerOneName;
string playerTwoName;

var startArray = Canvas.StartCanvas;
var greetings = new Greetings();
var game = new Game();

greetings.StartGame();

playerOneName = greetings.GetName();
playerTwoName = greetings.GetName();

game.Main(startArray, columns, rows, playerOneName, playerTwoName);