using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArray = new int[10];

            for (int i = 0; i < firstArray.Length; i++)
            {
                Random random = new Random();
                firstArray[i] = random.Next(1, 101);
            }

            var secondArray = new int[firstArray.Length];
            Array.Copy(firstArray, secondArray, firstArray.Length);

            firstArray[^1] = -7;

            Console.Write("Array 1: ");
            PrintArray(firstArray);
            Console.WriteLine();
            Console.Write("Array 2: ");
            PrintArray(secondArray);
        }
        public static void PrintArray(int[] array)
        {
            foreach (var element in array)
            {
                Console.Write(element+" ");
            }
        }
    }
}
