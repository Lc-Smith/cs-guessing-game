// Author: LcSmith
// References: https://www.w3schools.com/cs

class GuessingGame {
    static void Main(string[] args) {
        bool gameOn = true; // Enable game
        Random rnd = new Random();
        // Initial Output
        Console.WriteLine("The Guessing Game!");
        Console.WriteLine("Please only input when and what is requested.");

        while(gameOn) {
            int userGuess = 0;
            int i = 1;

            Console.WriteLine("Let the game begin...");
            Console.WriteLine("Please choose the upper number for the answer:");
            int answerLimit = Convert.ToInt32(Console.ReadLine()); // Store input
            int answer = rnd.Next(1, answerLimit + 1); // Generate (pseudo) random answer

            // Guessing
            while(userGuess != answer) {
                Console.WriteLine("Please input guess number " + i + " from 1 to " + answerLimit + ":");
                userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == answer) {
                    Console.WriteLine("You got it right on attempt " + i + ". Would you like to play again? (y/n)");
                    string playAgain = Console.ReadLine();

                    if (playAgain == "y") {
                        Console.WriteLine("You've opted to play again.");
                    } else {
                        Console.WriteLine("Thank you for playing.");
                        gameOn = false;
                    }
                } else if (userGuess > answer) {
                    Console.WriteLine("Your guess is too high. Try again!");
                } else if (userGuess < answer) {
                    Console.WriteLine("Your guess is too low. Try again!");
                }
                i++;
            }
        }
    }
}