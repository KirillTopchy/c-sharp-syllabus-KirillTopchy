using System;

namespace Exercise_5
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] courses =
            {
                "English III", "Precalculus", "Music Theory", "Biotechnology", "Principles of Technology I", "Latin II",
                "AP US History", "Business Computer Infomation Systems"
            };
            string[] teachers =
            {
                "Ms. Lapan", "Mrs. Gideon", "Mr. Davis", "Ms. Palmer", "Ms. Garcia", "Mrs. Barnett", "Ms. Johannessen",
                "Mr. James"
            };
            Console.WriteLine("+------------------------------------------------------------+");
            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine("| {0} | {1} | {2} |", i+1,courses[i], teachers[i] );
            }
            Console.WriteLine("+------------------------------------------------------------+");
        }
    }
}
