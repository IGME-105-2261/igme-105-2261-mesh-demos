namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user
            Console.WriteLine("Enter a positive integer.");

            // Try to get the response as an int
            int result = -1;
            bool success = int.TryParse(
                 Console.ReadLine(), out result);

            // If the parse fails or the value is negative,
            // keep asking
            while (!success || result < 0)
            {
                Console.WriteLine("Invalid. Try again. ");
                success = int.TryParse(
                     Console.ReadLine(), out result);
            }

        }
    }
}
