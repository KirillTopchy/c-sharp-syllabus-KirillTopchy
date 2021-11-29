using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            var input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the 2nd number: ");
            var input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the 3rd number: ");
            var input3 = Convert.ToInt32(Console.ReadLine());

            int[] inputArray = {input1, input2, input3};

            Array.Sort(inputArray);

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] % 1 == 0)
                {
                    Console.WriteLine($"Input the {i+1}" + DisplaySuffix(i+1) +
                                      $" number: {inputArray[i]}");
                }
            }
            Console.ReadKey();
        }

        public static string DisplaySuffix(int num)
        {
            var number = num.ToString();
            if (number.EndsWith("11")) return "th";
            if (number.EndsWith("12")) return "th";
            if (number.EndsWith("13")) return "th";
            if (number.EndsWith("1")) return "st";
            if (number.EndsWith("2")) return "nd";
            if (number.EndsWith("3")) return "rd";
            return "th";
        }
    }
}
