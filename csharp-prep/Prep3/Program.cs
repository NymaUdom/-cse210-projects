using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;

        while (playAgain)
        {
            // Generate a random magic number between 1 and 100
            Random random = new Random();
            int magicNumber = random.Next(1, 101);

            int guess;
            int attempts = 0;

            Console.WriteLine("Guess My Number Game!");
            Console.WriteLine("I'm thinking of a number between 1 and 100.");

            do
            {
                // Ask the user for a guess
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                // Check if the guess is correct, higher, or lower
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }

                attempts++;

            } while (guess != magicNumber);

            // Inform the user of the number of attempts
            Console.WriteLine($"It took you {attempts} attempts to guess the number.");

            // Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no): ");
            string playAgainInput = Console.ReadLine().ToLower();
            playAgain = (playAgainInput == "yes");
        }

        Console.WriteLine("Thanks for playing!");
    }
}