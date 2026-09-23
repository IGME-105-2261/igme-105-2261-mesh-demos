namespace StringFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String literals
            /*
            Console.WriteLine("Shiro");
            Console.WriteLine("Shiro says \n\"hi!\""); // quoted - I'll use these
            Console.WriteLine(@"Shiro says 
                        ""Hi!"""); // verbatim
            Console.WriteLine(
                """
                Shiro says
                "Hi!"
                """); // raw
            */

            // Data to work with
            double value = 1000000.0 / 3;
            int number = (int)value;
            Console.WriteLine("Double: " + value);
            Console.WriteLine("Int: " + number);

            int apples = 3;
            double price = 10.0/3;
            Console.WriteLine(
                "Apples cost {1:C3} each. {0} of them cost {2:C}", // template string
                3, // 0
                price, // 1
                apples * price); // 2


            double tax = .08; // 8%
            Console.WriteLine("Tax: {0:P0}", tax); // req'd to understand this way
            Console.WriteLine($"Tax: {tax:P0}"); // this is allowed

            /*
            string output = string.Format(
                "Apples cost {1} each. {0} of them cost {2}", // template string
                apples, // 0
                price, // 1
                apples * price); // 2
            Console.WriteLine(output);
            */

            Console.WriteLine("Let's test console colors\n");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("This is a different color");

            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("This has a background color");

            Console.Write("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hi!");

            Console.WriteLine(
                "{0} \t- Unformatted\n" +
                "{0:C} \t- Currency, default of 2 places\n" +
                "{0:C1} \t- Currency, 1 place\n" +
                "{0:F} \t- Round to 2 places by default\n" +
                "{0:F0} \t\t- Round to 0 places\n" +
                "{0:N} \t- Add grouping symbols\n" +
                "{0:P} \t- Show as a % (*'s by 100!)\n" +
                "{1:D7} \t- Show an **int** value with 7 digits (0 pad left)\n",
                value,
                (int)value);

        }
    }
}
