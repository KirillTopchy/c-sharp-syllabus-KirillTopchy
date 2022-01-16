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
        public int count = 1;

        public bool isClicked;

        public Sudoku()
        {
            InitializeComponent();
        }


        private void DifficultyButtonClick(object sender, EventArgs e)
        {
            var button = sender as Button;

            switch (button.Text)
            {
                case "Easy":
                    {
                        var board = new Board(this, 9, 9, 50);
                        board.SetupBoard();
                        break;
                    }
                case "Medium":
                    {
                        var board = new Board(this, 9, 9, 40);
                        board.SetupBoard();
                        break;
                    }
                case "Hard":
                    {
                        var board = new Board(this, 9, 9, 30);
                        board.SetupBoard();
                        break;
                    }
            }
        }
    }
}
