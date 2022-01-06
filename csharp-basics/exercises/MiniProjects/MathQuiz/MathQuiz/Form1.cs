using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class MathQuizWindow : Form
    {
        // Create a Random object called randomizer 
        // to generate random numbers.
        readonly Random _random = new Random();

        // These integer variables store the numbers 
        // for the addition problem. 
        private int _addend1;
        private int _addend2;

        // These integer variables store the numbers 
        // for the subtraction problem. 
        private int _minuend;
        private int _subtrahend;

        // These integer variables store the numbers 
        // for the multiplication problem. 
        private int _multiplicand;
        private int _multiplier;

        // These integer variables store the numbers 
        // for the division problem.
        private double _dividend;
        private int _divisor;


        // This integer variable keeps track of the 
        // remaining time.
        private int _timeLeft;

        public void StartTheQuiz()
        {
            // Board colors setup
            timeLabel.ForeColor = Color.Black;
            sum.BackColor = default;
            difference.BackColor = default;
            product.BackColor = default;
            quotient.BackColor = default;

            // Fill in the addition problem.
            // Generate two random numbers to add.
            // Store the values in the variables 'addend1' and 'addend2'.
            _addend1 = _random.Next(101);
            _addend2 = _random.Next(101);

            // Convert the two randomly generated numbers
            // into strings so that they can be displayed
            // in the label controls.
            plusLeftLabel.Text = _addend1.ToString();
            plusRightLabel.Text = _addend2.ToString();

            // 'sum' is the name of the NumericUpDown control.
            // This step makes sure its value is zero before
            // adding any values to it.
            sum.Value = 0;

            // Fill in the subtraction problem.
            _minuend = _random.Next(1, 101);
            _subtrahend = _random.Next(1, _minuend);
            minusLeftLabel.Text = _minuend.ToString();
            minusRightLabel.Text = _subtrahend.ToString();
            difference.Value = 0;

            // Fill in the multiplication problem.
            _multiplicand = _random.Next(1, 51);
            _multiplier = _random.Next(2, 21);
            timesLeftLabel.Text = _multiplicand.ToString();
            timesRightLabel.Text = _multiplier.ToString();
            product.Value = 0;

            // Fill in the division problem.
            while (_dividend % _divisor != 0)
            { 
                _dividend = _random.Next(1, 101);
                _divisor = _random.Next(2, 10);
                dividedLeftLabel.Text = _dividend.ToString();
                dividedRightLabel.Text = _divisor.ToString();
                quotient.Value = 0;
            }

            // Start the timer.
            _timeLeft = 30;
            timeLabel.Text = @"30 seconds";
            timer1.Start();
            
        }

        private bool CheckSum()
        {
            return _addend1 + _addend2 == sum.Value;
        }

        private bool CheckSubtract()
        {
            return _minuend - _subtrahend == difference.Value;
        }

        private bool CheckMultiply()
        {
            return _multiplicand * _multiplier == product.Value;
        }

        private bool CheckDivision()
        {
            return _dividend / _divisor == (double)quotient.Value;
        }

        private bool CheckAnswer()
        {
            return (CheckSum() && CheckSubtract()) 
                   && CheckMultiply() && CheckDivision();
        }

        private void PlayCorrectAnswerSound()
        {
            var player = new SoundPlayer(@"C:\Users\9er0j\Desktop\Programming\Codelex\C#\Lekcijas\c-sharp-syllabus-KirillTopchy\csharp-basics\exercises\MiniProjects\MathQuiz\correct.wav");
            player.Play();
        }

        public MathQuizWindow()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            _dividend = 0;
            _divisor = 0;
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void sum_ValueChanged(object sender, EventArgs e)
        {
            if (CheckSum())
            {
                sum.BackColor = Color.GreenYellow;
                PlayCorrectAnswerSound();
            }
        }

        private void difference_ValueChanged(object sender, EventArgs e)
        {
            if (CheckSubtract())
            {
                difference.BackColor = Color.GreenYellow;
                PlayCorrectAnswerSound();
            }
        }

        private void product_ValueChanged(object sender, EventArgs e)
        {
            if (CheckMultiply())
            {
                product.BackColor = Color.GreenYellow;
                PlayCorrectAnswerSound();
            }
        }

        private void quotient_ValueChanged(object sender, EventArgs e)
        {
            if (CheckDivision())
            {
                quotient.BackColor = Color.GreenYellow;
                PlayCorrectAnswerSound();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (CheckAnswer())
            {
                // If CheckTheAnswer() returns true, then the user 
                // got the answer right. Stop the timer  
                // and show a MessageBox.
                timer1.Stop();
                MessageBox.Show(@"You Win!");
                startButton.Enabled = true;
            }
            else if (_timeLeft <= 11 && _timeLeft > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                timeLabel.ForeColor = Color.Red;
                _timeLeft--;
                timeLabel.Text = _timeLeft + @" seconds";
            }
            else if (_timeLeft > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                _timeLeft--;
                timeLabel.Text = _timeLeft + @" seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                timeLabel.Text = @"Time's up!";
                MessageBox.Show(@"You Lost");

                if (!CheckSum())
                {
                    sum.Value = _addend1 + _addend2;
                    sum.BackColor = Color.Red;
                }

                if (!CheckSubtract())
                {
                    difference.Value = _minuend - _subtrahend;
                    difference.BackColor = Color.Red;
                }

                if (!CheckMultiply())
                {
                    product.Value = _multiplicand * _multiplier;
                    product.BackColor = Color.Red;
                }

                if (!CheckDivision())
                {
                    quotient.Value = (decimal)(_dividend / _divisor);
                    quotient.BackColor = Color.Red;
                }

                startButton.Enabled = true;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            var answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                var lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

    }
}
