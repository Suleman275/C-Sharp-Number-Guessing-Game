using System;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);
            string userInput = "";
            bool convertion = false;
            int count = 0;

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            // Keep track of the number of guesses and the current user guess
            while (userInput != "-1") {
                userInput = Console.ReadLine();
                convertion = Int32.TryParse(userInput, out int userNum);

                if (!convertion) {
                    Console.WriteLine("That's not a number");
                    continue;
                }

                count++;

                if (userInput == "-1") {
                    Console.WriteLine("See you!");
                }
                else if (userNum == theNumber) {
                    Console.WriteLine("There you go!");
                    Console.WriteLine("You guessed correctly in {0} tries", count);
                    break;
                }
                else if (userNum > theNumber) {
                    Console.WriteLine("You guesed higher");
                }
                else {
                    Console.WriteLine("You guesed lower");
                }
            }

            // Start the game and run until user quits or guesses correctly
            // HINT: You'll need a way to convert the user's input to an integer
        }
    }
}
