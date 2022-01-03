namespace Exercise_8
{
    public class SalaryCalculator
    {
        public static decimal CalculateSalary(decimal basePay, double hoursWorked)
        {
            decimal salary = 0;
            double overtime = 0;

            var employee = new Employee {BasePay = basePay, HoursWorked = hoursWorked};

            if (employee.BasePay < (decimal)8.00)
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
                    break;

                case > 40 and < 60:
                    salary = (decimal)(((employee.HoursWorked - overtime) * (double)employee.BasePay) +
                                       (overtime * (double)employee.BasePay * 1.5));
                    break;

                default:
                    salary = (decimal)(employee.HoursWorked * (double)employee.BasePay);
                    break;
            }

            return salary;
        }

        public static string DisplayMessage(decimal salary, decimal basePay, double hoursWorked)
        {
            var message = "";
            switch (hoursWorked)
            {
                case > 60:
                    message += "Foo Corp requires that an employee does not work more than 60 hours in a week.";
                    break;

                default:
                    message += $"Employee base pay: {basePay}, hours worked: {hoursWorked}, salary: {salary:C2}$.";
                    break;
            }

            return message;
        }
    }
}
