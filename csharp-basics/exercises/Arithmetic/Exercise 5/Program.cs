using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it.");
            var guessedNumber = Convert.ToInt32(Console.ReadLine());

            var random = new Random();
            var randomNumber = random.Next(1, 101);

            if (guessedNumber > randomNumber)
            {
                Console.WriteLine("Sorry, you are too high.  I was thinking of {0}.", randomNumber);
            } 
            else if (guessedNumber < randomNumber)
            {
                Console.WriteLine("Sorry, you are too low.  I was thinking of {0}.", randomNumber);
            }
            else
            {
                Console.WriteLine("You guessed it!  What are the odds?!?");
            }
        }
    }
}
