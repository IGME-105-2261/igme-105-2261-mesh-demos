using System;
using System.Collections.Generic;

namespace Abstraction_Polymorphism_Demo.MenuItems
{
    class AddGameItem : MenuItem
    {
        // ~~~ FIELDS ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private List<MenuItem> menuItems;
        private Random rng;

        // ~~~ AUTO-PROPERTIES ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // None specific to this child class

        // ~~~ PROPERTIES ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // None specific to this child class

        // ~~~ CONSTRUCTORS ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public AddGameItem(List<MenuItem> menuItems, Random rng)
            : base("NEW GAME",
                  "Add a new guessing game choice to the menu",
                  "")
        {
            this.menuItems = menuItems;
            this.rng = rng;
        }

        // ~~~ OVERRIDES from Object ~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // None specific to this child class

        // ~~~ METHODS ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        // The child class can do as much as it likes when overriding!

        // Run an entire game, print the results, and then
        // return true to keep the program running
        public override bool Run()
        {
            // Get the difficulty description & number of attempts
            string difficulty = Program.GetPromptedInput("What is the difficulty level?");
            int attempts = 0;
            while (!int.TryParse(Program.GetPromptedInput("How many guesses will the player get?"), out attempts) || attempts < 1)
            {
                Console.WriteLine("Please input a whole number greater than 1.");
            }

            // Insert the new game menu item before the last element (which should always be quit).
            menuItems.Insert(
                menuItems.Count - 1,
                new GameItem(attempts, difficulty, rng)
                );

            return true;

        }
    }
}
