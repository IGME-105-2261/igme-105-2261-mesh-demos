using System;

namespace Abstraction_Polymorphism_Demo.MenuItems
{
    class QuitOption : MenuItem

    {
        // ~~~ FIELDS ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // None specific to this child class

        // ~~~ AUTO-PROPERTIES ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // None specific to this child class

        // ~~~ PROPERTIES ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // None specific to this child class

        // ~~~ CONSTRUCTORS ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public QuitOption()
            : base("Quit", "End the program", "Goodbye!")
        {
        }

        // ~~~ OVERRIDES from Object ~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // None specific to this child class

        // ~~~ METHODS ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        // But a child class has the option to do override and implement
        // differently

        // Run the base version but then return false
        public override bool Run()
        {
            base.Run();
            return false;
        }


    }
}
