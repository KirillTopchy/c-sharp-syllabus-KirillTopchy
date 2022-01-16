using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku.Core
{
    public enum CellState
    {
        Changed, Unchanged
    }

    public enum CellType
    {
        Locked, Unlocked
    }

    class Cell : Button
    {
        public int XLoc { get; set; }

        public int YLoc { get; set; }

        public int CellSize { get; set; }

        public CellState CellState { get; set; }

        public CellType CellType { get; set; }

        public Board Board { get; set; }


        public void SetupDesign()
        {
            Location = new Point(XLoc * CellSize, YLoc * CellSize);
            Size = new Size(CellSize, CellSize);
            //UseVisualStyleBackColor = false;
        }


    }
}
