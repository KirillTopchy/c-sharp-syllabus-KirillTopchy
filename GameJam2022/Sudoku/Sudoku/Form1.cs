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


        private void ButtonClick(object sender, EventArgs e)
        {
            var button = sender as Cell;
            

            if (isClicked == false)
            {

                if (count != 10)
                {
                    if (button != null) button.Text = count.ToString();
                    count++;
                    return;
                }

                if (count == 10)
                {
                    count = 1;
                }
            }
            else
            {
                var localCounter = int.Parse(button.Text);
                if (button.Text != "10")
                {
                    button.Text = localCounter.ToString();
                    localCounter++;
                }

                if (localCounter == 10)
                {
                    localCounter = 1;
                }
            }

            if(count != 10)
            {
                button.Text = count.ToString();
                count++;
            }

            if (count == 10)
            {
                count = 1;
            }
        }

        public bool isClicke()
        {
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
