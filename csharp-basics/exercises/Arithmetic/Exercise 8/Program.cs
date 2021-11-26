using System;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            SalaryCalculator((decimal) 7.5, 35);
            SalaryCalculator((decimal)8.20, 47);
            SalaryCalculator((decimal)10.00, 73);
        }

        public static void SalaryCalculator(decimal basePay, double hoursWorked)
        {
            decimal salary = 0;
            double overtime = 0;
            var employee = new Employee
            {
                BasePay = basePay,
                HoursWorked = hoursWorked
            };

            if (employee.BasePay < (decimal) 8.00)
            {
                employee.BasePay = (decimal)8.00;
            }

            if (employee.HoursWorked > 40)
            {
                overtime = employee.HoursWorked - 40;
            }

            switch (employee.HoursWorked)
            {
                case > 60:
                    Console.WriteLine("Foo Corp requires that an employee does not work more than 60 hours in a week.");
                    break;

                case > 40 and < 60:
                    salary = (decimal) (((employee.HoursWorked - overtime) * (double) employee.BasePay) +
                                        (overtime * (double) employee.BasePay * 1.5));
                    Console.WriteLine("Employee base pay: {0}, hours worked:{1}, salary: {2}$",employee.BasePay, employee.HoursWorked,salary);
                    break;

                default:
                    salary = (decimal) (employee.HoursWorked * (double) employee.BasePay);
                    Console.WriteLine("Employee base pay: {0}, hours worked:{1}, salary: {2}$", employee.BasePay, employee.HoursWorked, salary);
                    break;
            }
        }
    }
}
