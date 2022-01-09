using System;
using System.Globalization;

namespace Calculator
{
    public class CalculateResult
    {
        public void Calculation()
        {
            if (Form1.Counter == 0)
            {
                switch (Form1.OperationPerformed)
                {
                    case "+":
                        Form1.textBoxResult.Text =
                            Math.Round(Form1._labelResult + (decimal.Parse(Form1.textBoxResult.Text)), 10).ToString(CultureInfo.InvariantCulture);
                        break;
                    case "-":
                        Form1.textBoxResult.Text =
                            Math.Round(Form1._labelResult - (decimal.Parse(Form1.textBoxResult.Text)), 10).ToString(CultureInfo.InvariantCulture);
                        break;
                    case "*":
                        Form1.textBoxResult.Text =
                            Math.Round(Form1._labelResult * (decimal.Parse(Form1.textBoxResult.Text)), 10).ToString(CultureInfo.InvariantCulture);
                        break;
                    case "/":
                        Form1.textBoxResult.Text = decimal.Parse(Form1.textBoxResult.Text) == 0m
                            ? "Division by zero"
                            : Math.Round(Form1._labelResult / (decimal.Parse(Form1.textBoxResult.Text)), 10).ToString(CultureInfo.InvariantCulture);
                        break;
                }
            }
            else
            {
                switch (Form1.OperationPerformed)
                {
                    case "+":
                        Form1.textBoxResult.Text =
                            Math.Round(Form1._secondLabelValue + (decimal.Parse(Form1.textBoxResult.Text)), 10).ToString(CultureInfo.InvariantCulture);
                        break;
                    case "-":
                        Form1.textBoxResult.Text =
                            Math.Round((decimal.Parse(Form1.textBoxResult.Text)) - Form1._secondLabelValue, 10).ToString(CultureInfo.InvariantCulture);
                        break;
                    case "*":
                        Form1.textBoxResult.Text =
                            Math.Round(Form1._secondLabelValue * (decimal.Parse(Form1.textBoxResult.Text)), 10).ToString(CultureInfo.InvariantCulture);
                        break;
                    case "/":
                        Form1.textBoxResult.Text = decimal.Parse(Form1.textBoxResult.Text) == 0m
                            ? "Division by zero"
                            : Math.Round((decimal.Parse(Form1.textBoxResult.Text)) / Form1._secondLabelValue, 10).ToString(CultureInfo.InvariantCulture);
                        break;
                }
            }
        }
    }
}
