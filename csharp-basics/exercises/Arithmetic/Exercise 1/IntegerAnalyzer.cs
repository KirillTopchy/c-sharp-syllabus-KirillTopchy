namespace Exercise_1
{
    public class IntegerAnalyzer
    {
        public static bool CompareIntegers(int a, int b)
        {
            return a == 15 || b == 15 || a + b == 15 ||
                   a - b == 15 || b - a == 15;
        }
    }
}

