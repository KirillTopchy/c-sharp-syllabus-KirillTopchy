using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstRandomNumberArray = CreateArray.CreateRandomNumberArray(10);
            var secondRandomNumberArray = CreateArray.CopyArray(firstRandomNumberArray);
            CreateArray.PrintArray(firstRandomNumberArray);
            CreateArray.PrintArray(secondRandomNumberArray);
            CreateArray.ReplaceLastElementOfArrayWith7(secondRandomNumberArray);
            CreateArray.PrintArray(secondRandomNumberArray);
        }
    }
}
