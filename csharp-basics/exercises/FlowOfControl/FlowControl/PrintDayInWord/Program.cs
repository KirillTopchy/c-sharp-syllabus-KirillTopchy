using System;

namespace PrintDayInWord
{
    class Program
    {
        enum Days
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter day number");
            var info = Console.ReadKey();

            if (int.TryParse(info.KeyChar.ToString(), out var dayNumber))
            {
                switch (dayNumber)
                {
                    case 0:
                        Console.WriteLine("-" + Days.Sunday);
                        break;
                    case 1:
                        Console.WriteLine("-" + Days.Monday);
                        break;
                    case 2:
                        Console.WriteLine("-" + Days.Tuesday);
                        break;
                    case 3:
                        Console.WriteLine("-" + Days.Wednesday);
                        break;
                    case 4:
                        Console.WriteLine("-" + Days.Thursday);
                        break;
                    case 5:
                        Console.WriteLine("-" + Days.Friday);
                        break;
                    case 6:
                        Console.WriteLine("-" + Days.Sunday);
                        break;
                    default:
                        Console.WriteLine("Not a valid day");
                        break;
                }
            }
            else
            {
                Console.WriteLine(" YOUR INPUT IS NO A NUMBER");
            }
            Console.ReadKey();
        }
    }
}
