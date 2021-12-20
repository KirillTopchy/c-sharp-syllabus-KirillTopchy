using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student(8.2, "Kirill", "Topchy", "Kalku 228", 1);
            var employee = new Employee("Civil Engineer", "Andrey", "Agapov", "Rostokas 322", 2);
            student.Display();
            Console.WriteLine();
            employee.Display();
        }
    }
}
