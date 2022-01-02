using System;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var salary1 = SalaryCalculator.CalculateSalary(7.5m, 35);
            Console.WriteLine(SalaryCalculator.DisplayMessage(salary1, 7.5m, 35));

            var salary2 = SalaryCalculator.CalculateSalary(8.20m, 47);
            Console.WriteLine(SalaryCalculator.DisplayMessage(salary2, 8.20m, 47));

            var salary3 = SalaryCalculator.CalculateSalary(10.00m, 73);
            Console.WriteLine(SalaryCalculator.DisplayMessage(salary3, 10.00m, 73));
        }
    }
}
