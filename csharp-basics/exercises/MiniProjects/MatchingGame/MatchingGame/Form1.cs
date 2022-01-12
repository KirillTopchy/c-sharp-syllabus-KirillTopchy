using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class Form1 : Form
    {
        // firstClicked points to the first Label control 
        // that the player clicks, but it will be null 
        // if the player hasn't clicked a label yet
        private Label _firstClicked = null;

        // secondClicked points to the second Label control 
        // that the player clicks
        private Label _secondClicked = null;

        // Use this Random object to choose random icons for the squares
        private readonly Random _random = new();

        // Each of these letters is an interesting icon
        // in the Webdings font,
        // and each icon appears twice in this list
        private readonly List<string> _icons = new()
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };

        private double _totalTime;

        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }

        private void AssignIconsToSquares()
        {
            // The TableLayoutPanel has 16 labels,
            // and the icon list has 16 icons,
            // so an icon is pulled at random from the list
            // and added to each label
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Label iconLabel)
                {
                    var randomNumber = _random.Next(_icons.Count);
                    iconLabel.Text = _icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    _icons.RemoveAt(randomNumber);
                }
            }
        }

        /// <summary>
        /// Every label's Click event is handled by this event handler
        /// </summary>
        /// <param name="sender">The label that was clicked</param>
        /// <param name="e"></param>
        private void label_Click(object sender, EventArgs e)
        {
            if (sender is Label clickedLabel)
            {
                // The timer is only on after two non-matching 
                // icons have been shown to the player, 
                // so ignore any clicks if the timer is running
                if (timer1.Enabled)
                {
                    return;
                }

                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (clickedLabel.ForeColor == Color.Black)
                {
                    return;
                }

                // If firstClicked is null, this is the first icon 
                // in the pair that the player clicked,
                // so set firstClicked to the label that the player 
                // clicked, change its color to black, and return
                if (_firstClicked == null)
                {
                    _firstClicked = clickedLabel;
                    _firstClicked.ForeColor = Color.Black;
                }

                // If the player gets this far, the timer isn't
                // running and firstClicked isn't null,
                // so this must be the second icon the player clicked
                // Set its color to black
                else if (_secondClicked == null)
                {
                    _secondClicked = clickedLabel;
                    _secondClicked.ForeColor = Color.Black;

                    // If the player gets this far, the player 

                    // Check to see if the player won
                    if (CheckWinner())
                    {
                        // If the loop didn’t return, it didn't find
                        // any unmatched icons
                        // That means the user won. Show a message and close the form
                        timer2.Stop();
                        MessageBox.Show(@$"You WIN! Tour time: " + Math.Round(_totalTime, 2) + @" seconds.", @"Congratulations");
                        Close();
                    }

                    // clicked two different icons, so start the 
                    // timer (which will wait three quarters of 
                    // a second, and then hide the icons)
                    timer1.Start();
                }
            }
        }

        /// <summary>
        /// This timer is started when the player clicks 
        /// two icons that don't match,
        /// so it counts three quarters of a second 
        /// and then turns itself off and hides both icons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            timer1.Stop();

            if (_firstClicked.Text != _secondClicked.Text)
            {
                // Hide both icons
                _firstClicked.ForeColor = _firstClicked.BackColor;
                _secondClicked.ForeColor = _secondClicked.BackColor;
            }

            // Reset firstClicked and secondClicked 
            // so the next time a label is
            // clicked, the program knows it's the first click
            _firstClicked = null;
            _secondClicked = null;
        }

        /// <summary>
        /// Check every icon to see if it is matched, by 
        /// comparing its foreground color to its background color. 
        /// If all of the icons are matched, the player wins
        /// </summary>
        private bool CheckWinner()
        {
            // Go through all of the labels in the TableLayoutPanel, 
            // checking each one to see if its icon is matched
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Label iconLabel)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return false;
                }
            }

            return true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            _totalTime += 0.1;
        }
    }
}
