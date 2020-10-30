using System;

namespace ch05_prj03_guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Guess the Number Game" +
                              "++++++++++++++++++++++++++++++++++++");

            bool loop = true;
            int target;
            int guesses;
            bool win;
            Random rand = new Random();

            while (loop)
            {
                Console.WriteLine("\nI'm thinking of a number from 1 to 100. \nTry to guess it.");
                target = rand.Next(1, 100);
                guesses = 0;
                win = false;

                while(!win)
                {
                    Console.Write("Enter number: ");
                    int guess = int.Parse(Console.ReadLine());
                    guesses++;
                    win = checkGuess(guess, target);
                }

            }

        }

        private static bool checkGuess(int guess, int target)
        {
            if (guess == target)
                return true;
            else if ()
        }
    }
}
