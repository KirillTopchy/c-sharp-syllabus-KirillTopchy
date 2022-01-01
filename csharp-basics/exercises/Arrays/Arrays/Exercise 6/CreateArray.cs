using System;

namespace Exercise_6
{
    public class CreateArray
    {
        private static readonly int _min = 1;
        private static readonly int _max = 101;

        public static int[] CreateRandomNumberArray(int length)
        {
            int[] firstRandomNumbersArray = new int[length];

            for (int i = 0; i < firstRandomNumbersArray.Length; i++)
            {
                var random = new Random();
                firstRandomNumbersArray[i] = random.Next(_min, _max);
            }

            return firstRandomNumbersArray;
        }

        public static int [] CopyArray(int[] firstArray)
        {
            var secondRandomNumbersArray = new int[firstArray.Length];
            Array.Copy(firstArray, secondRandomNumbersArray, firstArray.Length);
            return secondRandomNumbersArray;
        }

        public static void ReplacLastElementOfArrayWith7(int[] firstArray)
        {
            firstArray[^1] = -7;
        }

        public static void PrintArray(int[] array)
        {
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
