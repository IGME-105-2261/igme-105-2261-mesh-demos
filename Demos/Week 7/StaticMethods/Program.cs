namespace StaticMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Full code to get 1 player's name and format it nicely...
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            DoStuff();
            int number = 42;
            // First name
            /*
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Player 1 first name? ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string firstName = Console.ReadLine().Trim();
            */
            string firstName = GetUserInput("Player 1 first name? ");

            // Last name
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Player 1 last name? ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string lastName = Console.ReadLine().Trim();

            // Say hello without formatting
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello " + firstName + " " + lastName);

            // Use String.Format that puts the pieces together nicely
            string p1FullName = String.Format("{0}{1} {2}{3}",
                firstName[0].ToString().ToUpper(),
                firstName.Substring(1, firstName.Length - 1).ToLower(),
                lastName[0].ToString().ToUpper(),
                lastName.Substring(1, lastName.Length - 1).ToLower()
            );

            // Say hello
            Console.WriteLine("Hello " + p1FullName);
        }

        public static void DoStuff()
        {
            Console.WriteLine("stuff");
        }


        // new method: GetUserInput
        // - needs: the prompt - string
        // - return: input - string
        public static string GetUserInput(string prompt)
        {
            // print a prompt
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Player 1 first name? ");

            // change color
            Console.ForegroundColor = ConsoleColor.Cyan;

            // get input
            string input = Console.ReadLine().Trim();

            // change color back
            Console.ForegroundColor = ConsoleColor.White;

            // return input
            return input;
        }

    }
}
