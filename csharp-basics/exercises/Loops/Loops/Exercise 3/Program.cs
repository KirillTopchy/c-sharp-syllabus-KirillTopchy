using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var array =  GenerateRandomNumbersArray();
            Print(array);
            Console.Write("Chose number: ");
            int.TryParse(Console.ReadLine(), out var chosenNumber);
            Console.WriteLine("Your numbers position in array is {0}",Array.IndexOf(array,chosenNumber));
        }

        static int[] GenerateRandomNumbersArray()
        {
            int[] randomNumbersArray = new int[20];

            var random = new Random();

            for (int i = 0; i < randomNumbersArray.Length; i++)
            {
                randomNumbersArray[i] = random.Next(1, 101);
            }

            return randomNumbersArray;
        }

        static void Print(int[] numbers)
        {
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }
}
