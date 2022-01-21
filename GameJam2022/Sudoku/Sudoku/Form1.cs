using System;
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
            _board.SetupBoard();
        }

        private void DifficultyButtonClick(object sender, EventArgs e)
        {
            var button = sender as Button;
            _board.StartNewGame();
            switch (button.Text)
            {
                case "Easy":
                    _board.ShowHints(45);
                    break;
                case "Medium":
                    _board.ShowHints(35);
                    break;
                case "Hard":
                    _board.ShowHints(25);
                    break;
            }
        }

        private void ClearButtonClick(object sender, EventArgs e)
        {
            _board.ClearCells();
        }

        private void CheckResultButtonClick(object sender, EventArgs e)
        {
            _board.CheckResult();
        }
    }
}
