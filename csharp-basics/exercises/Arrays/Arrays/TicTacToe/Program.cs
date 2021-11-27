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

            while (!GameIsFinished() || IsWin() != true || IsTie() != true)
            {
                Turn(turn);
                DisplayBoard();

                if (IsWin())
                {
                    break;
                }

                if (IsTie() == false)
                {
                    break;
                }

                turn = !turn;
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
            if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2] && board[0,0] == 'X')
            {
                Console.WriteLine("X WON");
                return true;
            }
            if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2] && board[0, 0] == '0')
            {
                Console.WriteLine("0 WON");
                return true;
            }
            if(board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] && board[1, 0] == 'X')
            {
                Console.WriteLine("X WON");
                return true;
            }
            if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] && board[1, 0] == '0')
            {
                Console.WriteLine("0 WON");
                return true;
            }
            if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2] && board[2, 0] == 'X')
            {
                Console.WriteLine("X WON");
                return true;
            }
            if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2] && board[2, 0] == '0')
            {
                Console.WriteLine("0 WON");
                return true;
            }
            // column win
            if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0] && board[0, 0] == 'X')
            {
                Console.WriteLine("X WON");
                return true;
            }
            if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0] && board[0, 0] == '0')
            {
                Console.WriteLine("0 WON");
                return true;
            }
            if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1] && board[0, 1] == 'X')
            {
                Console.WriteLine("X WON");
                return true;
            }
            if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1] && board[0, 1] == '0')
            {
                Console.WriteLine("0 WON");
                return true;
            }
            if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2] && board[0, 2] == 'X')
            {
                Console.WriteLine("X WON");
                return true;
            }
            if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2] && board[0, 2] == '0')
            {
                Console.WriteLine("0 WON");
                return true;
            }
            // diagonal win
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] == 'X')
            {
                Console.WriteLine("X WON");
                return true;
            }
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] == '0')
            {
                Console.WriteLine("0 WON");
                return true;
            }
            if (board[2, 0] == board[1, 1] && board[1, 1] == board[0, 2] && board[2, 0] == 'X')
            {
                Console.WriteLine("X WON");
                return true;
            }
            if (board[2, 0] == board[1, 1] && board[1, 1] == board[0, 2] && board[2, 0] == '0')
            {
                Console.WriteLine("0 WON");
                return true;
            }
            return false;
        }

        public static bool IsTie()
        {
            // checks if its tie
            if (GameIsFinished() && IsWin() == false)
            {
                Console.WriteLine("TIE");
                return false;
            }
            return true;
        }
    }
}
