using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.Core
{
    public class Board
    {
        public Sudoku Sudoku { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int CellsOpened { get; set; }

        public Cell[,] Cells { get; set; }

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
                        CellState = CellState.Unchanged,
                        CellType = CellType.Locked,
                        CellSize = 50,
                        Board = this
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
                    Sudoku.Controls.Add(cell);
                } 
            }
        }

        public void ChangeCellColor(Cell cell)
        {
            cell.BackColor = Color.Aqua;
        }

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
    }
}
