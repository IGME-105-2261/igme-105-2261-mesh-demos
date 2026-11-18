namespace DynamicMenus
{
    /// <summary>
    /// Inherits core information about the data to manage and behavior
    /// from MenuItem and customizes it to represent a menu choice
    /// to launch a guessing game with a custom difficulty level
    /// </summary>
    class GameItem : MenuItem
    {
        // ~~~ FIELDS ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private int attempts;
        private Random rng;

        // ~~~ PROPERTIES ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // None specific to this child class

        // ~~~ CONSTRUCTORS ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public GameItem(int attempts, string difficulty, Random rng)
            : base(difficulty.ToUpper(), 
                  "Play a " + difficulty.ToLower() + " game", 
                  "Guess the lucky number (0-100)!")
        {
            this.attempts = attempts;
            this.rng = rng;
        }

        // ~~~ OVERRIDES from Object ~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // None specific to this child class

        // ~~~ METHODS ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        // The child class can do as much as it likes when overriding!
        public override void Run()
        {
            // Setup
            Console.WriteLine(actionText);
            int triesLeft = attempts;
            int guess = 0;
            int number = rng.Next(101);
            Console.WriteLine("(" + number + ")");

            // Run the game
            do
            {
                Console.Write("\n" + triesLeft + " guesses left > ");

                // Make sure it was a valid guess
                while (!int.TryParse(Console.ReadLine(), out guess) || guess < 0 || guess > 100)
                {
                    Console.Write("\tGuess must be 0-100 > ");
                }

                // Decrement the number of tries
                triesLeft--;
            }
            // Keep asking for guesses until win or out of tries
            while (triesLeft > 0 && guess != number);

            // Print result
            if (guess == number)
            {
                Console.WriteLine("You WIN!");
            }
            else
            {
                Console.WriteLine("Better luck next time!");
            }
        }
    }
}
