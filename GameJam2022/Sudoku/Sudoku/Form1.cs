using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sudoku.Core;

namespace Sudoku
{
    public partial class Sudoku : Form
    {
        private readonly Board _board;
        public Sudoku()
        {
            InitializeComponent();
            _board = new Board(this, 9, 9);
        }

        private void DifficultyButtonClick(object sender, EventArgs e)
        {
            var button = sender as Button;
            //var board = new Board(this, 9, 9);

            switch (button.Text)
            {
                case "Easy":
                    _board.SetupBoard();
                    _board.GenerateValues();
                    _board.ShowHints(45);
                    break;
                case "Medium":
                    _board.SetupBoard();
                    _board.GenerateValues();
                    _board.ShowHints(35);
                    break;
                case "Hard":
                    _board.SetupBoard();
                    _board.GenerateValues();
                    _board.ShowHints(25);
                    break;
            }
        }

        private void ClearButtonClick(object sender, EventArgs e)
        {
            _board.ClearCells();
        }
    }
}
