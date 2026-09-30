namespace Switches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // What is the output?
            bool isWed = "Wed".ToLower()[0] == "wednesday"[0];
            if(!isWed)
            {
                Console.WriteLine("Hello!");
            }
            else
            {
                Console.WriteLine("Gluppy");
            }

            int number;
            Console.Write("Enter an integer: ");
            number = int.Parse(Console.ReadLine());
            switch (number)
            {
                // Each case defines a single condition to check against the SAME variable
                case 10:
                    Console.WriteLine("Ten!");
                    break; // Each case must purposefully exit the case (e.g. via a break; statement)

                case 5:
                    Console.WriteLine("Five!");
                    break;

                // Range checking works, but ONLY against the same variable!
                // CANNOT overlap with another case!
                case <= 0:
                    Console.WriteLine("Negative");
                    break;

                case 1: // Empty cases don't need a break
                case 2:
                    Console.WriteLine("Two");
                    break;

                default:
                    Console.WriteLine("Other");
                    break;
            }

        }
    }
}
