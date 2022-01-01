namespace Exercise_2
{
    public class CheckOddEven
    {
        public static int ParseInputToInteger(string input)
        {
            if (!int.TryParse(input, out var userEnteredInteger))
            {
                throw new NotAnIntegerException("Wrong input");
            }

            return userEnteredInteger;
        }

        public static string OddOrEven(int a)
        {
            return a % 2 == 0 ? "Even number" : "Odd number";
        }
    }
}
