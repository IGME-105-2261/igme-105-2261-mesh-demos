namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region while & do-while
            /*
            int num = 0; // lcv
            string name = "shiro";
            while (num < 3) // while (condition)
            { // do stuff
                Console.WriteLine("Hello, World! - " + num + ": " + name[num]);
                num++;
            }
            Console.WriteLine("Final num: " + num);
            Console.WriteLine();

            int count = 1;
            while (count <= 3)
            {
                Console.WriteLine(":) - "+count);
                count++;
            }
            Console.WriteLine("Final count: " + count);

            double temperature = 0.00005;
            do
            {
                Console.WriteLine("Temp: " + temperature);
                temperature /= 2;
            }
            while (temperature > 1);
            */
            #endregion

            // setup
            int num1 = 0; // lcv - loop control variable
            int num2 = 0; // lcv - loop control variable
            const double N = 2;
            string name = "Shiro";

            // while
            Console.WriteLine("while");
            while(num1 < 4)
            {
                Console.WriteLine(num1);
                num1++;
            }

            // do-while
            Console.WriteLine("\ndo-while");
            do
            {
                Console.WriteLine(num2);
                num2++;
            }
            while (num2 < 4);

            //double num1 = 4.5;

            // for
            Console.WriteLine("\nfor");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nfor");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nfor");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nfor");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(i);
            }

            // Using a nested loop to print some values
            Console.WriteLine(
                "\nNested loop that goes NxN times with N={0}:", N);
            for (int col = 0; col < N; col++)
            {
                for (int row = 0; row < N; row++)
                {
                    // Print the next coordinate pair for this row
                    Console.Write(row + "," + col + " ");
                }
                // Move to a new line
                Console.WriteLine();
            }


            // letters
            for(int i=0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }


        }
    }
}
