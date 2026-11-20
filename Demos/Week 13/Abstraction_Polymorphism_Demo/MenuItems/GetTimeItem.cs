using System;

namespace Abstraction_Polymorphism_Demo.MenuItems
{
    /// <summary>
    /// Inherits core information about the data to manage and behavior
    /// from MenuItem and customizes it to represent a menu choice
    /// to print out the current time.
    /// </summary>
    class GetTimeItem : MenuItem
   
    {
        // ~~~ FIELDS ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // None specific to this child class

        // ~~~ PROPERTIES ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // None specific to this child class

        // ~~~ CONSTRUCTORS ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        // Default constructor that leverages the base class' parameterized const.
        public GetTimeItem()
            : base("TIME", "Get the current time", "The current time is: ")
        {
        }

        // ~~~ OVERRIDES from Object ~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // None specific to this child class

        // ~~~ METHODS ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        // But a child class has the option to do override and implement
        // differently

        // Run the base version, get the current time
        // and return true to keep the program running
        public override bool Run()
        {
            base.Run();
            Console.WriteLine("\t" + DateTime.Now.ToString("hh:mm tt"));
            return true;
        }
        

    }
}
