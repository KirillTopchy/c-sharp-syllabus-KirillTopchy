using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        private const string Path = @"C:\Users\9er0j\Desktop\Programming\Codelex\C#\Lekcijas\c-sharp-syllabus-KirillTopchy\csharp-basics\exercises\Collections\Histogram\midtermscores.txt";

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
