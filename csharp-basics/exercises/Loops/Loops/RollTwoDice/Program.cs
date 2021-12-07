using System;

namespace RollTwoDice
{
    class Program
    {
        private static int _firstDice = 0;
        private static int _secondDice = 0;
        private static int _sum = 0;
        private static int _desiredSum = 0;
        private static int _counter = 0;

        public static void Main(string[] args)
        {
            UserInput();
            while (DiceRoll() != _desiredSum)
            {
                DiceRollMessage();
            }
            DiceRollMessage();
            EndGameMessage();
        }

        public static void UserInput()
        {
            Console.WriteLine("Enter desired sum of two dices (2-12)");
            Console.Write("Desired sum: ");
            int.TryParse(Console.ReadLine(), out _desiredSum);

            while (_desiredSum is < 2 or > 12)
            {
                Console.WriteLine("Wrong input please chose number from 2 to 12");
                Console.Write("Desired sum: ");
                int.TryParse(Console.ReadLine(), out _desiredSum);
            }
        }

        public static int DiceRoll()
        {
            var random = new Random();
            _firstDice = random.Next(1, 7);
            _secondDice = random.Next(1, 7);
            _sum = _firstDice + _secondDice;
            _counter++;
            return _sum;
        }

        public static void DiceRollMessage()
        {
            Console.WriteLine("{0} + {1} = {2}", _firstDice, _secondDice, _sum);
        }

        public static void EndGameMessage()
        {
            Console.WriteLine("You rolled dices {0} times to get your desired sum:{1}",_counter,_desiredSum);
        }
    }
}
