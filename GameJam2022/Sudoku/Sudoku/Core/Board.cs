using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku.Core
{
    public class Board
    {
        public Sudoku Sudoku { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int CellsOpened { get; set; }

        public Cell[,] Cells { get; set; }

        public Random Random = new Random();

        public int TempValue;

        public int TempXLoc;

        public int TempYLoc;


        public Board(Sudoku sudoku, int width, int height, int cellsOpened)
        {
            Sudoku = sudoku;
            Sudoku.AutoSize = true;
            Width = width;
            Height = height;
            CellsOpened = cellsOpened;
            Cells = new Cell[width, height];
        }

        //public Board(MenuButtons sudoku, int width, int height, int cellsOpened)
        //{
        //    Sudoku = sudoku;
        //    Sudoku.AutoSize = true;
        //    Width = width;
        //    Height = height;
        //    CellsOpened = cellsOpened;
        //    Cells = new Cell[width, height];
        //}

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

        public void ChangeCellColor(Cell cell)
        {
            cell.BackColor = Color.Aqua;
        }

        // Change cell color based on its position.
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

        // Allows to enter numbers 1-9 in cell.
        private void CellKeyPressed(object sender, KeyPressEventArgs e)
        {
            var cell = sender as Cell;

            // Do nothing if the cell is locked
            if (cell.CellType == CellType.Locked)
            {
                return;
            }

            // Add the pressed key value in the cell only if it is a number
            if (int.TryParse(e.KeyChar.ToString(), out var value))
            {
                // Clear the cell value if pressed key is zero
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

        public void GenerateValues()
        {
            // Clear the values in each cells
            foreach (var cell in Cells)
            {
                cell.CellValue = 0;
                cell.Clear();
            }

            // Recursive method call until suitable values found for each cells
            FindValueForAllCells(0, -1);
        }

        private bool FindValueForAllCells(int x, int y)
        {
            // Increment the X and Y values to move to the next cell
            // if the columns ends move to the next row

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
            // and check if it can be allocated with another random and valid number

            do
            {
                // If there is not numbers left in the list to try next, 
                // return to the previous cell and allocate it with a different number
                if (possibleNumbers.Count < 1)
                {
                    Cells[x, y].CellValue = 0;
                    return false;
                }

                // Take a random number from the numbers left in the list
                value = possibleNumbers[Random.Next(0, possibleNumbers.Count)];
                Cells[x, y].CellValue = value;


                //TempValue = value;
                //TempXLoc = x;
                //TempYLoc = y;

                // Remove the used value from list
                possibleNumbers.Remove(value);
            } while (!CheckValidNumber(value, x, y)|| !FindValueForAllCells(x, y));

            // Remove this line after testing
            Cells[x, y].Text = value.ToString();
            //Cells[x, y].Text = $"{x},{y}";
            return true;
        }

        // Checks if randomly generated number can be used.
        private bool CheckValidNumber(int value, int x, int y)
        {
            //return CheckRow(TempValue, TempXLoc, TempYLoc) && CheckColumn(TempValue, TempXLoc, TempYLoc) 
            // && CheckBlock(TempValue, TempXLoc, TempYLoc);

            // Check cells in row.
            for (int i = 0; i < 9; i++)
            {
                if (i != y && Cells[i, y].CellValue == value)
                {
                    return false;
                }
            }

            // Check cells in column.
            for (int i = 0; i < 9; i++)
            {
                if (i != x && Cells[x, i].CellValue == value)
                {
                    return false;
                }
            }

            // Check cells in a block
            var blockNumber = FindBlock(x, y);

            if (blockNumber == 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (Cells[i, j].CellValue == value)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (blockNumber == 1)
            {
                for (int i = 3; i < 6; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (Cells[i, j].CellValue == value)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (blockNumber == 2)
            {
                for (int i = 6; i < 9; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (Cells[i, j].CellValue == value)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (blockNumber == 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 3; j < 6; j++)
                    {
                        if (Cells[i, j].CellValue == value)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (blockNumber == 4)
            {
                for (int i = 3; i < 6; i++)
                {
                    for (int j = 3; j < 6; j++)
                    {
                        if (Cells[i, j].CellValue == value)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (blockNumber == 5)
            {
                for (int i = 6; i < 9; i++)
                {
                    for (int j = 3; j < 6; j++)
                    {
                        if (Cells[i, j].CellValue == value)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (blockNumber == 6)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 6; j < 9; j++)
                    {
                        if (Cells[i, j].CellValue == value)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (blockNumber == 7)
            {
                for (int i = 3; i < 6; i++)
                {
                    for (int j = 6; j < 9; j++)
                    {
                        if (Cells[i, j].CellValue == value)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (blockNumber == 8)
            {
                for (int i = 6; i < 9; i++)
                {
                    for (int j = 6; j < 9; j++)
                    {
                        if (Cells[i, j].CellValue == value)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        private bool CheckRow(int value, int x, int y)
        {
            // Check cells in row.
            for (int i = 0; i < 9; i++)
            {
                if (i != y && Cells[i, y].CellValue == value)
                {
                    return false;
                }
            }

            return true;
        }

        private bool CheckColumn(int value, int x, int y)
        {
            // Check cells in column.
            for (int i = 0; i < 9; i++)
            {
                if (i != x && Cells[x, i].CellValue == value)
                {
                    return false;
                }
            }

            return true;
        }

        private bool CheckBlock(int value, int x, int y)
        {
            // Check cells in a block
            var blockNumber = FindBlock(x, y);

            if (blockNumber == 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (Cells[i, j].CellValue == value)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (blockNumber == 1)
            {
                for (int i = 3; i < 6; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (Cells[i, j].CellValue == value)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (blockNumber == 2)
            {
                for (int i = 6; i < 9; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (Cells[i, j].CellValue == value)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (blockNumber == 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 3; j < 6; j++)
                    {
                        if (Cells[i, j].CellValue == value)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (blockNumber == 4)
            {
                for (int i = 3; i < 6; i++)
                {
                    for (int j = 3; j < 6; j++)
                    {
                        if (Cells[i, j].CellValue == value)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (blockNumber == 5)
            {
                for (int i = 6; i < 9; i++)
                {
                    for (int j = 3; j < 6; j++)
                    {
                        if (Cells[i, j].CellValue == value)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (blockNumber == 6)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 6; j < 9; j++)
                    {
                        if (Cells[i, j].CellValue == value)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (blockNumber == 7)
            {
                for (int i = 3; i < 6; i++)
                {
                    for (int j = 6; j < 9; j++)
                    {
                        if (Cells[i, j].CellValue == value)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (blockNumber == 8)
            {
                for (int i = 6; i < 9; i++)
                {
                    for (int j = 6; j < 9; j++)
                    {
                        if (Cells[i, j].CellValue == value)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        private int FindBlock(int x, int y)
        {
            var block = x switch
            {
                < 3 when y < 3 => 0,
                < 6 when y < 3 => 1,
                < 9 when y < 3 => 2,
                < 3 when y < 6 => 3,
                < 6 when y < 6 => 4,
                < 9 when y < 6 => 5,
                < 3 when y < 9 => 6,
                < 6 when y < 9 => 7,
                < 9 when y < 9 => 8,
                _ => 0
            };

            return block;
        }
    }
}
