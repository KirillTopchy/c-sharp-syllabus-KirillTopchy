using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private decimal _labelResult = 0;
        private decimal _secondLabelValue = 0;
        private string _operationPerformed = "";
        private bool _isOperationPerformed = false;
        private string _lastClick = "";
        private bool _resultShown = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if ((textBoxResult.Text == "0") || (_isOperationPerformed) || _lastClick == "operator")
            {
                textBoxResult.Clear();
            }

            _isOperationPerformed = false;
            var button = (Button) sender;
            if (button.Text == ".")
            {
                if (!textBoxResult.Text.Contains("."))
                {
                    textBoxResult.Text += button.Text;
                }
            }
            else
            {
                textBoxResult.Text += button.Text;
                _secondLabelValue = decimal.Parse(textBoxResult.Text);
            }

            _lastClick = "button";
        }

        private void OperatorClick(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (_lastClick == "operator")
            {
                _isOperationPerformed = false;
                _operationPerformed = button.Text;
                labelOperations.Text = _labelResult + " " + _operationPerformed + " ";
            }
            else
            {
                if (_labelResult != 0)
                {
                    buttonEquals.PerformClick();
                    _operationPerformed = button.Text;
                    labelOperations.Text += _labelResult + " " + _operationPerformed + " ";
                    _isOperationPerformed = true;
                }
                else
                {
                    _operationPerformed = button.Text;
                    _labelResult = decimal.Parse(textBoxResult.Text);
                    labelOperations.Text += _labelResult + " " + _operationPerformed + " ";
                    _isOperationPerformed = true;
                }
            }
            _lastClick = "operator";
        }

        private void ClearClick(object sender, EventArgs e)
        { 
            textBoxResult.Text = "0";
            labelOperations.Text = "";
            _labelResult = 0;
        }

        private void ClearEntryClick(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0")
            {
                _labelResult = 0;
                labelOperations.Text = "";
            }
            else
            {
                textBoxResult.Text = "0";
            }
        }

        private void EqualClicked(object sender, EventArgs e)
        {
            switch (_operationPerformed)
            {
                case "+":
                    textBoxResult.Text =
                        Math.Round(_labelResult + (decimal.Parse(textBoxResult.Text)), 10).ToString(CultureInfo.InvariantCulture);
                    break;
                case "-":
                    textBoxResult.Text =
                        Math.Round(_labelResult - (decimal.Parse(textBoxResult.Text)), 10).ToString(CultureInfo.InvariantCulture);
                    break;
                case "*":
                    textBoxResult.Text =
                        Math.Round(_labelResult * (decimal.Parse(textBoxResult.Text)), 10).ToString(CultureInfo.InvariantCulture);
                    break;
                case "/":
                    textBoxResult.Text = decimal.Parse(textBoxResult.Text) == 0m
                        ? "Division by zero"
                        : Math.Round(_labelResult / (decimal.Parse(textBoxResult.Text)), 10).ToString(CultureInfo.InvariantCulture);
                    break;
                default:
                    textBoxResult.Text = textBoxResult.Text;
                    break;
            }

            if (textBoxResult.Text != "Division by zero" && _resultShown == false)
            {
                _labelResult = decimal.Parse(textBoxResult.Text);
                labelOperations.Text += (_secondLabelValue + @" =");
                _resultShown = true;
            } else if (textBoxResult.Text != "Division by zero" && _resultShown)
            {
                _labelResult = decimal.Parse(textBoxResult.Text);
                _resultShown = false;
            }
        }

        private new void KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                    buttonZero.PerformClick();
                    break;
                case Keys.NumPad1:
                    buttonOne.PerformClick();
                    break;
                case Keys.NumPad2:
                    buttonTwo.PerformClick();
                    break;
                case Keys.NumPad3:
                    buttonThree.PerformClick();
                    break;
                case Keys.NumPad4:
                    buttonFour.PerformClick();
                    break;
                case Keys.NumPad5:
                    buttonFive.PerformClick();
                    break;
                case Keys.NumPad6:
                    buttonSix.PerformClick();
                    break;
                case Keys.NumPad7:
                    buttonSeven.PerformClick();
                    break;
                case Keys.NumPad8:
                    buttonEight.PerformClick();
                    break;
                case Keys.NumPad9:
                    buttonNine.PerformClick();
                    break;
                case Keys.Add:
                    buttonPlus.PerformClick();
                    break;
                case Keys.Subtract:
                    buttonMinus.PerformClick();
                    break;
                case Keys.Multiply:
                    buttonMult.PerformClick();
                    break;
                case Keys.Divide:
                    buttonDivide.PerformClick();
                    break;
                case Keys.Decimal:
                    buttonPoint.PerformClick();
                    break;
            }
        }
    }
}
