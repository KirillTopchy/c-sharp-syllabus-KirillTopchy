using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.Core
{
    class Board
    {
        public Sudoku Sudoku { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public Cell[,] Cells { get; set; }

        public Board(Sudoku sudoku, int width, int height)
        {
            Sudoku = sudoku;
            Width = width;
            Height = height;
            Cells = new Cell[width, height];
        }

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
                        CellSize = 30,
                        Board = this
                    };
                    cell.SetupDesign();
                    Cells[i, j] = cell;
                    Sudoku.Controls.Add(cell);
                } 
            }
        }


    }
}
