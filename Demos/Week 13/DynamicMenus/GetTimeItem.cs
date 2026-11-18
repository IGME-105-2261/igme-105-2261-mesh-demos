namespace DynamicMenus
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
        public GetTimeItem()
            : base("TIME", "Get the current time", "The current time is: ")
        {
        }

        // ~~~ OVERRIDES from Object ~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // None specific to this child class

        // ~~~ METHODS ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        // But a child class has the option to do override and implement
        // differently
        public override void Run()
        {
            Console.WriteLine(actionText + DateTime.Now.ToString("hh:mm tt"));
        }
    }
}
