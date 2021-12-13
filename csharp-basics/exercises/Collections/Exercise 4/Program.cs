using System;

namespace Exercise_4
{
    class Program
    {
        public static int Number;
        public static bool NumberIsHappy;
        static void Main(string[] args)
        {
            UserInput();
            Calculation(Number);
            IsHappy();
        }

        static void UserInput()
        {
            Console.Write("Enter a number: ");
            int.TryParse(Console.ReadLine(), out Number);
        }

        static void Calculation(int num)
        {
            var charArr = num.ToString().ToCharArray();
            var result = "";
            var sum = 0;
            
            while (charArr.Length !=1)
            {
                for (int i = 0; i < charArr.Length; i++)
                {
                    if (i < charArr.Length - 1)
                    {
                        sum += (int)Math.Pow(Convert.ToDouble(charArr[i].ToString()), 2);
                        result += charArr[i];
                        result += "^2 + ";
                    }
                    else
                    {
                        sum += (int)Math.Pow(Convert.ToDouble(charArr[i].ToString()), 2);
                        result += charArr[i];
                        result += "^2 = ";
                    }
                }

                if(sum == 1)
                {
                    NumberIsHappy = true;
                }
                Console.WriteLine(result+sum);
                charArr = sum.ToString().ToCharArray();
                sum = 0;
                result = "";
            }
        }

        public static void IsHappy ()
        {
            Console.WriteLine("Number {0} is Happy: {1}",Number, NumberIsHappy);
        }
    }
}
