using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper.Core
{
    public class MineCounter
    {
        public static int TotalMines = 0;
        public static int FlaggedMines = 0;
        public static int TotalNotMines = 0;
        public static int NotMinesOpened = 0;

        public static void CheckWin()
        {
            if (TotalMines == FlaggedMines && TotalNotMines == NotMinesOpened)
            {
                ResetCounter();
                MessageBox.Show("Congrats you WIN!");
                Application.Restart();
                //Environment.Exit(0);
            }
        }

        public static void ResetCounter()
        {
            TotalMines = 0;
            FlaggedMines = 0;
            TotalNotMines = 0;
            NotMinesOpened = 0;
        }
    }
}
