using System;
using System.Text;

namespace Hangman
{
    class Program
    {
        public static string randomWord = RandomWord();
        public static string hiddenWord = HiddenWord(randomWord);
        public static string guessedLetters = "";
        public static char guess = ' ';
        public static int lives = 0;
        static void Main()
        {
            SetDifficultyLevel();
            while (lives != 0 && randomWord != hiddenWord)
            {
                GameDisplay();
                var usersGuess = Guess();
                guess = usersGuess;
                guessedLetters += usersGuess;
                GuessCheck(usersGuess);
            }

            if (lives != 0)
            {
                WinDisplay();
            }
            else
            {
                LoseDisplay();
            }

            while (GameRestart())
            {
                Main();
            }
        }

        public static string RandomWord()
        {
            // chose random word from array
            string[] words =
            {
                "visitor", "division", "join", "crime", "coal", "stretch", "river",
                "uncle", "boundary", "sleet", "request", "match", "middle", "office",
                "guide", "soap", "ice", "walk", "harbor", "pin"
            };
            var random = new Random();
            var randomNumber = random.Next(0, words.Length);
            return words[randomNumber];
        }

        public static string HiddenWord(string word)
        {
            // makes hidden word
            return new string('*', word.Length);
        }

        public static void GameDisplay()
        {
            // displays game interface
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine();
            Console.WriteLine("You have {0} guesses left", lives);
            Console.WriteLine();
            Console.WriteLine("Word: {0}", hiddenWord);
            Console.WriteLine();
            Console.WriteLine("Misses: {0}", guessedLetters);
            Console.WriteLine();
            Console.WriteLine("Guess: {0}", guess);
            Console.WriteLine();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-");
        }

        public static void WinDisplay()
        {
            // displays win screen
            Console.WriteLine();
            Console.WriteLine("Word: {0}", hiddenWord);
            Console.WriteLine();
            Console.WriteLine("Misses: {0}", guessedLetters);
            Console.WriteLine();
            Console.WriteLine("YOU GOT IT!");
            Console.WriteLine();
        }

        public static void LoseDisplay()
        {
            // displays lose screen
            Console.WriteLine();
            Console.WriteLine("Hidden word was: {0}", randomWord);
            Console.WriteLine();
            Console.WriteLine("Misses: {0}", guessedLetters);
            Console.WriteLine();
            Console.WriteLine("YOU LOSE!");
            Console.WriteLine();
        }

        public static char Guess()
        {
            // reads user guess
            var guessedChar = Console.ReadKey(true).KeyChar;
            var notCaseSensitiveGuess = guessedChar.ToString().ToLower();
            notCaseSensitiveGuess.ToCharArray();
            return notCaseSensitiveGuess[0];
        }

        public static string GuessCheck(char userGuess)
        {
            // checks if hidden word contains user guess
            if (randomWord.Contains(userGuess))
            {
                for (int i = 0; i < randomWord.Length; i++)
                {
                    if (randomWord[i] == userGuess)
                    {
                        var sb = new StringBuilder(hiddenWord);
                        sb[i] = userGuess;
                        hiddenWord = sb.ToString();
                    }
                }
                return hiddenWord;
            }
            else
            {
                lives--;
                return hiddenWord;
            }
        }

        public static void SetDifficultyLevel()
        {
            // selects difficulty level
            Console.WriteLine("WELCOME TO HANGMAN GAME");
            Console.WriteLine();
            Console.WriteLine("PLEASE SELECT THE LEVEL OF DIFFICULTY");
            Console.WriteLine("TYPE E - EASY, M - MEDIUM, H - HARD");
            var difficultyLevel = Console.ReadKey(true).KeyChar;
            lives = difficultyLevel switch
            {
                'e' or 'E' => 15,
                'm' or 'M' => 10,
                'h' or 'H' => 5,
                _ => 15
            };
        }

        public static bool GameRestart()
        {
            // Ask user if application restart needed
            Console.WriteLine("Type \"again\" if you wanna play again or type \"quit?\" to quit.");
            var decision = Console.ReadLine().ToLower();
            guess = ' ';
            guessedLetters = "";
            randomWord = RandomWord();
            hiddenWord = HiddenWord(randomWord);
            return decision == "again";
        }
    }
}
