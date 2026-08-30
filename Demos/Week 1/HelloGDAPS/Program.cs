// Comment at the top about what this file/project is
namespace HelloGDAPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // single line comment
            Console.WriteLine("Hello GDAPS!"); // end of line
            Console.WriteLine("another line"); /* block at end of line */                                          

            /* Block comment
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            */

            // Write vs WriteLine
            Console.WriteLine("Prints text AND a new line character");
            Console.Write("Prints text");
            Console.Write(" but NOT a new line");

            Console.Clear();

            Console.WriteLine("new stuff");

            // Write some math expressions
            Console.WriteLine(6 + 3 * 8 - 4);
            Console.WriteLine(
                    3.14159 *
                    8.2 *
                    8.2);

            // Print a label and the result of an evaluated expression
            Console.WriteLine("Hours per week: " + 7 * 24);
            Console.WriteLine("5" + 5);

            Console.WriteLine("Numbers: " + 5 + 7 + 9);
            Console.WriteLine("Math: " + (5 + 7 + 9));

            Console.WriteLine("1111111111111111111111111111111111111111111111111111111111111111111111" +
                "111111111111111111111111111111111111111111111111111111111111111111111111111111111111" +
                "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111" +
                "111111111111111111111111111111111111111111");

        }
    }
}
