using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Histogram
{
    class Program
    {
        static readonly string currentDir = Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "");
        static readonly string Path = (currentDir+"\\midtermscores.txt");
        
        private static void Main(string[] args)
        {
            DisplayHistogram(SortInputGrades());
            Console.ReadKey();
        }

        private static List<int> SortInputGrades()
        {
            var readText = File.ReadAllLines(Path);
            var scoreList = new List<int>();
            foreach (var s in readText)
            {
                var splited = s.Split(' ');
                scoreList.AddRange(splited.Select(score => Convert.ToInt32(score)));
                scoreList.Sort();
            }
            return scoreList;
        }

        private static void DisplayHistogram(List<int> scores)
        {
            for (int i = 0; i <= 9; i++)
            {
                Console.Write(i + "0-" + i + "9: ");
                foreach (var score in scores)
                {
                    if (score >= Convert.ToInt32(i + "0") && score < Convert.ToInt32(i + "9"))
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }

            Console.Write("  100: ");
            foreach (var score in scores.Where(score => score == 100))
            {
                Console.Write("*");
            }
        }
    }
}