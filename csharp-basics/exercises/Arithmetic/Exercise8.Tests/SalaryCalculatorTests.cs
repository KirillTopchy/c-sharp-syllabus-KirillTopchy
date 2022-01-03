using Exercise_8;
using Xunit;

namespace Exercise8.Tests
{
    public class SalaryCalculatorTests
    {
        [Fact]
        public void CalculateSalary_7Point5_35_ShouldReturnSalary280()
        {
            //Arrange
            const decimal basePay = 7.5m;
            const double hoursWorked = 35;
            var expected = 280.00m;

            //Act
            var actual = SalaryCalculator.CalculateSalary(basePay, hoursWorked);


            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateSalary_8Point2_47_ShouldReturnSalary414Point10()
        {
            //Arrange
            const decimal basePay = 8.2m;
            const double hoursWorked = 47;
            var expected = 414.10m;

            //Act
            var actual = SalaryCalculator.CalculateSalary(basePay, hoursWorked);


            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateSalary_8Point2_25_ShouldReturnSalary205()
        {
            //Arrange
            const decimal basePay = 8.2m;
            const double hoursWorked = 25;
            var expected = 205.00m;

            //Act
            var actual = SalaryCalculator.CalculateSalary(basePay, hoursWorked);


            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateSalary_8Point2_65_ShouldReturnSalary0()
        {
            //Arrange
            const decimal basePay = 8.2m;
            const double hoursWorked = 65;
            var expected = 0.00m;

            //Act
            var actual = SalaryCalculator.CalculateSalary(basePay, hoursWorked);


            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact] public void DisplayMessage_280_7Point5_35_ShouldDisplaySalaryInfo()
        {
            //Arrange
            const decimal salary = 280.00m;
            const decimal basePay = 7.5m;
            const double hoursWorked = 35;
            var expected = "Employee base pay: 7.5, hours worked: 35, salary: $280.00$.";

            //Act
            var actual = SalaryCalculator.DisplayMessage(salary, basePay, hoursWorked);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DisplayMessage_280_7Point5_70_ShouldDisplayMessageAboutMaximalAllowedWorkHoursPerWeek()
        {
            //Arrange
            const decimal salary = 280.00m;
            const decimal basePay = 7.5m;
            const double hoursWorked = 70;
            var expected = "Foo Corp requires that an employee does not work more than 60 hours in a week.";

            //Act
            var actual = SalaryCalculator.DisplayMessage(salary, basePay, hoursWorked);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
