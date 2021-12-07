using System;

namespace Piglet
{
    class Program
    {
        private static int _totalScore = 0;
        private static bool _gameLost = false;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Piglet!");
            RollDice();
            while (_gameLost == false && ContinueGame()) 
            {
                RollDice();
            }
            Console.WriteLine("You got {0} points.", _totalScore);
        }

        public static void RollDice()
        {
            Random random = new Random();
            var randomDie =  random.Next(1, 7);
            if (randomDie == 1)
            {
                _totalScore = 0;
                _gameLost = true;
            }
            else
            {
                _totalScore += randomDie;
            }
            Console.WriteLine("You rolled a {0}!, total score is {1}", randomDie, _totalScore);
        }

        public static bool ContinueGame()
        {
            Console.WriteLine("Roll again? Press y if you want to stop press n");
            var userChoice = Console.ReadKey(true).KeyChar.ToString().ToLower();
            return userChoice == "y";
        }
    }
}
