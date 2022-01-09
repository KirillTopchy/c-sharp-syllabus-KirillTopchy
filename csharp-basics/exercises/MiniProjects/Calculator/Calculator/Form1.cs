using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        internal static decimal _labelResult = 0;
        internal static decimal _secondLabelValue = 0;
        public static string OperationPerformed = "";
        private bool _isOperationPerformed = false;
        private bool _isSameOperationPerformed = false;
        private bool _firstValueEntered = false;
        public static int Counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0" || _isOperationPerformed)
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
                if (_firstValueEntered == false)
                {
                    textBoxResult.Text += button.Text;
                    _labelResult = decimal.Parse(textBoxResult.Text);
                }
                else
                {
                    textBoxResult.Text += button.Text;
                    _secondLabelValue = decimal.Parse(textBoxResult.Text);
                }
            }
        }

        private void OperatorClick(object sender, EventArgs e)
        {
            Counter = 0;
            var button = (Button)sender;
            if (_isOperationPerformed == false)
            {
                _isOperationPerformed = true;
                _firstValueEntered = true;
                OperationPerformed = button.Text;
                labelOperations.Text = textBoxResult.Text + " " + OperationPerformed + " ";
            }
            else
            {
                if (_labelResult != 0)
                {
                    _isOperationPerformed = true;
                    _firstValueEntered = true;
                    new CalculateResult().Calculation();
                    OperationPerformed = button.Text;
                    labelOperations.Text += textBoxResult.Text + " " + OperationPerformed + " ";
                }
                else
                {
                    OperationPerformed = button.Text;
                    _labelResult = decimal.Parse(textBoxResult.Text);
                    labelOperations.Text += _labelResult + " " + OperationPerformed + " ";
                    _isOperationPerformed = true;
                    _firstValueEntered = true;
                }
            }
        }

        private void ClearClick(object sender, EventArgs e)
        { 
            textBoxResult.Text = "0";
            labelOperations.Text = "";
            _labelResult = 0;
            _secondLabelValue = 0;
            Counter = 0;
            _isOperationPerformed = false;
            _firstValueEntered = false;
        }

        private void ClearEntryClick(object sender, EventArgs e)
        {
            _secondLabelValue = 0;
            textBoxResult.Text = "0";
            Counter = 0;
        }

        private void EqualClicked(object sender, EventArgs e)
        {
            if (Form1.textBoxResult.Text == "Division by zero")
            {
                return;
            }

            new CalculateResult().Calculation();

            if (textBoxResult.Text != "Division by zero" && labelOperations.Text.Contains("="))
            {
                _labelResult = decimal.Parse(textBoxResult.Text);
                switch (OperationPerformed)
                {
                    case "+":
                        labelOperations.Text = (_labelResult - _secondLabelValue + " " + OperationPerformed + " " + _secondLabelValue + @" =");
                        break;
                    case "-":
                        labelOperations.Text = (_labelResult + _secondLabelValue + " " + OperationPerformed + " " + _secondLabelValue + @" =");
                        break;
                    case "*":
                        labelOperations.Text = (_labelResult / _secondLabelValue + " " + OperationPerformed + " " + _secondLabelValue + @" =");
                        break;
                    case "/":
                        labelOperations.Text = (_labelResult * _secondLabelValue + " " + OperationPerformed + " " + _secondLabelValue + @" =");
                        break;
                }
            }
            
            else if (textBoxResult.Text != "Division by zero")
            {
                if (Counter == 0)
                {
                    _labelResult = decimal.Parse(textBoxResult.Text);
                    labelOperations.Text += (_secondLabelValue + @" =");
                }
                else
                {
                    _labelResult = decimal.Parse(textBoxResult.Text);
                    labelOperations.Text = (_labelResult - _secondLabelValue + @" =");
                }
            }
            Counter++;
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
