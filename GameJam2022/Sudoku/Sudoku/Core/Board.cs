using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace Sudoku.Core
{
    public class Board
    {
        public Sudoku Sudoku { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public Cell[,] Cells { get; set; }

        public Random Random = new();

        public int IMin;
        public int IMax;
        public int JMin;
        public int JMax;

        public Board(Sudoku sudoku, int width, int height)
        {
            Sudoku = sudoku;
            Sudoku.AutoSize = true;
            Width = width;
            Height = height;
            Cells = new Cell[width, height];
        }

        // Sets up Sudoku board.
        public void SetupBoard()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    var cell = new Cell
                    {
                        XLoc = j,
                        YLoc = i,
                        CellType = CellType.Unlocked,
                        CellSize = 50,
                    };

                    if (CheckIfCellColorShouldBeChanged(i, j))
                    {
                        ChangeCellColor(cell);
                    }
                    else
                    {
                        cell.BackColor = Color.Beige;
                    }

                    cell.SetupDesign();
                    Cells[i, j] = cell;
                    Cells[i, j].KeyPress += CellKeyPressed;
                    Sudoku.Controls.Add(cell);
                } 
            }
        }

        // Checks if cell color should be changed according to cells position.
        public bool CheckIfCellColorShouldBeChanged(int i, int j)
        {
            switch (i)
            {
                case 0 when j is > 2 and < 6:
                case 1 when j is > 2 and < 6:
                case 2 when j is > 2 and < 6:
                case 3 when j is >= 0 and < 3:
                case 3 when j is > 5 and < 9:
                case 4 when j is >= 0 and < 3:
                case 4 when j is > 5 and < 9:
                case 5 when j is >= 0 and < 3:
                case 5 when j is > 5 and < 9:
                case 6 when j is > 2 and < 6:
                case 7 when j is > 2 and < 6:
                case 8 when j is > 2 and < 6:
                    return true;
            }

            return false;
        }

        // Changes cells color.
        public void ChangeCellColor(Cell cell)
        {
            cell.BackColor = Color.Aqua;
        }

        // Allows to enter numbers 1-9 in cell.
        public void CellKeyPressed(object sender, KeyPressEventArgs e)
        {
            var cell = sender as Cell;

            // Do nothing if the cell is locked.
            if (cell.CellType == CellType.Locked)
            {
                return;
            }

            // Add the pressed key value in the cell only if it is a number.
            if (int.TryParse(e.KeyChar.ToString(), out var value))
            {
                // Clear the cell value if pressed key is zero.
                if (value == 0)
                {
                    cell.Clear();
                }
                else
                {
                    cell.Text = value.ToString();
                    cell.ForeColor = SystemColors.ControlDarkDark;
                }
            }
        }

        // Generates random numbers and fills them in cells.
        public void GenerateValues()
        {
            // Clear the values in each cells
            foreach (var cell in Cells)
            {
                cell.CellValue = 0;
                cell.Clear();
            }

            // Sudoku generation timer.
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            // Recursive method call until suitable values found for each cells
            FindValueForAllCells(0, -1);

            stopwatch.Stop();
            Sudoku.label1.Text = $@"Sudoku Generation Time = {stopwatch.Elapsed}";
        }

        // Find values for cells.
        public bool FindValueForAllCells(int x, int y)
        {
            // Increment the x and y values to move to the next cell.
            // If the columns ends move to the next row.
            if (++y > 8)
            {
                y = 0;

                // Exit if the line ends
                if (++x > 8)
                {
                    return true;
                }
            }

            int value;
            var possibleNumbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};

      
            // Find a random and valid number for the cell and go to the next cell 
            // and check if it can be allocated with another random and valid number.
            do
            {
                // If there is not numbers left in the list to try next, 
                // return to the previous cell and allocate it with a different number.
                if (possibleNumbers.Count < 1)
                {
                    Cells[x, y].CellValue = 0;
                    return false;
                }

                // Take a random number from the numbers left in the list.
                value = possibleNumbers[Random.Next(0, possibleNumbers.Count)];
                Cells[x, y].CellValue = value;

                // Remove the used value from list
                possibleNumbers.Remove(value);
            } while (!CheckValidNumber(value, x, y)|| !FindValueForAllCells(x, y));
            

            // Sudoku value and cells position tests.
            //Cells[x, y].Text = value.ToString();
            //Cells[x, y].Text = $"{x},{y}";
            return true;
        }

        // Checks if randomly generated number is valid and can be used.
        public bool CheckValidNumber(int value, int x, int y)
        {
            // Check cells in row.
            for (int i = 0; i < 9; i++)
            {
                if (i != x && Cells[i, y].CellValue == value)
                {
                    return false;
                }
            }

            // Check cells in column.
            for (int i = 0; i < 9; i++)
            {
                if (i != y && Cells[x, i].CellValue == value)
                {
                    return false;
                }
            }

            // Find the block where particular cell is located.
            FindBlock(x, y);

            //Check all cells in a block
            if (!CheckCell(value, x, y))
            {
                return false;
            }

            return true;
        }

        //Check all cells in a block
        public bool CheckCell(int value, int x, int y)
        {
            for (int i = IMin; i < IMax; i++)
            {
                for (int j = JMin; j < JMax; j++)
                {
                    if (i != x && j != y && Cells[i, j].CellValue == value)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        // Sets i,j min and max values used in CheckCell method, depending on cells position (in which block it is located).
        public void FindBlock(int x, int y)
        {
            switch (x)
            {
                case < 3 when y < 3:
                    IMin = 0;
                    IMax = 3;
                    JMin = 0;
                    JMax = 3;
                    break;
                case < 6 when y < 3:
                    IMin = 3;
                    IMax = 6;
                    JMin = 0;
                    JMax = 3;
                    break;
                case < 9 when y < 3:
                    IMin = 6;
                    IMax = 9;
                    JMin = 0;
                    JMax = 3;
                    break;
                case < 3 when y < 6:
                    IMin = 0;
                    IMax = 3;
                    JMin = 3;
                    JMax = 6;
                    break;
                case < 6 when y < 6:
                    IMin = 3;
                    IMax = 6;
                    JMin = 3;
                    JMax = 6;
                    break;
                case < 9 when y < 6:
                    IMin = 6;
                    IMax = 9;
                    JMin = 3;
                    JMax = 6;
                    break;
                case < 3 when y < 9:
                    IMin = 0;
                    IMax = 3;
                    JMin = 6;
                    JMax = 9;
                    break;
                case < 6 when y < 9:
                    IMin = 3;
                    IMax = 6;
                    JMin = 6;
                    JMax = 9;
                    break;
                case < 9 when y < 9:
                    IMin = 6;
                    IMax = 9;
                    JMin = 6;
                    JMax = 9;
                    break;
            }
        }

        // Displays starting cells values to user.
        public void ShowHints(int hintsNumber)
        {
            var hintsPlaced = 0;

            while (hintsPlaced != hintsNumber)
            {
                var x = Random.Next(0, 9);
                var y = Random.Next(0, 9);
                if (Cells[x, y].CellType == CellType.Unlocked)
                {
                    Cells[x, y].CellType = CellType.Locked;
                    Cells[x, y].ForeColor = Color.DarkViolet;
                    hintsPlaced++;
                }
            }

            foreach (var cell in Cells)
            {
                if (cell.CellType == CellType.Locked)
                {
                    cell.Text = cell.CellValue.ToString();
                }
            }
        }

        // Clears all players entered values from board.
        public void ClearCells()
        {
            foreach (var cell in Cells)
            {
                // Clear the cell only if it is not locked
                if (cell.CellType == CellType.Unlocked)
                {
                    cell.Clear();
                }
            }
        }

        // Check if player entered values are equal to cell value, if ton changes text color.
        public void CheckResult()
        {
            if (CheckWin())
            {
                
                MessageBox.Show(@"YOU WIN!!!", @"Congrats!!!");
            }

            foreach (var cell in Cells)
            {
                if (cell.CellValue.ToString() != cell.Text)
                {
                    cell.ForeColor = Color.Red;
                }
            }
        }

        // Checks if player has won the game.
        public bool CheckWin()
        {
            return Cells.Cast<Cell>().All(cell => cell.CellValue.ToString() == cell.Text);
        }

        // Starts new game.
        public void StartNewGame()
        {
            GenerateValues();
        }
    }
}