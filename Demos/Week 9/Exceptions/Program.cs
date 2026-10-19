namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4 };
            int number = 0;
            Console.Write("Enter a whole number: ");

            try
            {
                // format
                number = int.Parse(Console.ReadLine());

                // out of bounds or divide by zero
                Console.WriteLine(numbers[6] / number);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("That was 0");
            }
            catch (FormatException e)
            {
                Console.WriteLine("That wasn't a whole number.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("All done");

            // overflow
            //DoStuff();
        }

        static void DoStuff()
        {
            DoStuff();
        }
    }
}
