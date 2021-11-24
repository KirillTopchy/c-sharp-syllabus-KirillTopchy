using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight in pounds");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your height in inches");
            double height = Convert.ToDouble(Console.ReadLine());

            double bmi = Math.Round(weight * 703 / (height * height),2);

            if (bmi < 18.5)
            {
                Console.WriteLine("Your BMI is: {0} you have underweight", bmi);
            } 
            else if (bmi is >= 18.5 and < 25)
            {
                Console.WriteLine("Your BMI is: {0} your weight is optimal.", bmi);
            }
            else
            {
                Console.WriteLine("Your BMI is: {0} you have overweight", bmi);
            }
        }
    }
}
