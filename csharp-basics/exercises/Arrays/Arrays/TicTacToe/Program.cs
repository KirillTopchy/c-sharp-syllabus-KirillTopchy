using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];

        private static void Main(string[] args)
        {
            InitBoard();
            DisplayBoard();

            var turn = true;
            var isWin = false;

            while (!GameIsFinished())
            {
                Turn(turn);
                DisplayBoard();

                if (IsWin())
                {
                    WinMessage();
                    isWin = true;
                    break;
                }
                turn = !turn;
            }

            if (!isWin)
            {
                TieMessage();
            }
            Console.ReadKey();
        }

        private static void InitBoard()
        {
            // fills up the board with blanks
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
        }

        public static void Turn(bool turn)
        {
            // makes turn
            if (turn)
            {
                Console.Write("'X', choose your location (row, column): ");
                var input = Console.ReadLine();
                var inputArray = input.Split(' ');

                var inputArrayAsIntegers = Array.ConvertAll(inputArray, int.Parse);
                if (board[inputArrayAsIntegers[0], inputArrayAsIntegers[1]] == ' ')
                {
                    board[inputArrayAsIntegers[0], inputArrayAsIntegers[1]] = 'X';
                }
                else
                {
                    Console.WriteLine("This cell is taken, please chose other");
                    Turn(false);
                }
            }
            else
            {
                Console.Write("'0', choose your location (row, column): ");
                var input = Console.ReadLine();
                var inputArray = input.Split(' ');

                var inputArrayAsIntegers = Array.ConvertAll(inputArray, int.Parse);
                if (board[inputArrayAsIntegers[0], inputArrayAsIntegers[1]] == ' ')
                {
                    board[inputArrayAsIntegers[0], inputArrayAsIntegers[1]] = '0';
                }
                else
                {
                    Console.WriteLine("This cell is taken, please chose other");
                    Turn(false);
                }
            }
        }

        public static bool GameIsFinished()
        {
            // checks if game is finished.
            var counter = 0;
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    if (board[r, c] == ' ')
                    {
                        counter++;
                    }
            }
            return counter == 0;
        }

        public static bool IsWin()
        {
            // check if is winner.
            // row win
            if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2] && board[0, 0] != ' ')
            {
                return true;
            }
            if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] && board[1, 0] != ' ')
            {
                return true;
            }
            if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2] && board[2, 0] != ' ')
            {
                return true;
            }
            // column win
            if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0] && board[0, 0] != ' ')
            {
                return true;
            }
            if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1] && board[0, 1] != ' ')
            {
                return true;
            }
            if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2] && board[0, 2] != ' ')
            {
                return true;
            }
            // diagonal win
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != ' ')
            {
                return true;
            }
            if (board[2, 0] == board[1, 1] && board[1, 1] == board[0, 2] && board[2, 0] != ' ')
            {
                return true;
            }
            return false;
        }

        public static bool WinMessage()
        {
            // Displays win message
            if (board[0, 0] == 'X' || board[1, 1] == 'X' || board[2, 2] == 'X')
            {
                Console.WriteLine("X WON");
                return true;
            }
            Console.WriteLine("0 WON");
            return true;
        }

        public static void TieMessage()
        {
            Console.WriteLine("TIE");
        }
    }
}
