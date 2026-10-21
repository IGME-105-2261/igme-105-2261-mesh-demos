namespace Exam2Review
{
    internal class Program
    {
        // RECURSION

        // ARRAYS
        // How do you create larger arrays and how do you iterate them?
        // What is array syntax and what does each part do?
        // What is the difference between null and void?

        // MISC
        // Review String.Format?

        // METHODS
        // What is the difference between null and void?

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        /// <summary>
        /// Main -- always created for us -- called first when the program launches
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string[] words;
            words = new string[4];
            words = new string[] { "Orange", "Yellow", "Red" };

           // int words = 3;
            MergeWords(words);

            Console.WriteLine("Power_I(2,4) = " + Power_I(2, 4));
            Console.WriteLine("Power_R(2,4) = " + Power_R(2, 4));

            int[] powers = FillPowers(2, 5);


            // Define text we may use a lot up front with our variables.
            // (or even eventually read the dialog in from a file!)
            const string IntroTextTemplate = "Welcome {0}! How are you this fine {1}?";
            string name;

            // Get the values to plug in later via user input...
            Console.Write("What is your name?");
            name = Console.ReadLine().Trim();

            // or other System methods...
            // (DayOfWeek is a System defined type that formatting can
            //  auto-convert to a string)
            DayOfWeek today = DateTime.Today.DayOfWeek;

            // Build the full test as we print to the console
            Console.WriteLine("Welcome {1}! How are you this fine {0}?", name, today);

            // or build the full text as a string to use later 
            // (e.g. to save to a file)
            string text = String.Format(IntroTextTemplate, name, today);

            // We also don't have to only put variables in for the substitute values
            // Expressions, property lookups, or other method calls are fine too
            Console.WriteLine(IntroTextTemplate, name, DateTime.Today.DayOfWeek);


        }

        static int[] FillPowers(int num, int numPowers)
        {
            // define an array to fill
            int[] results;

            // create it
            results = new int[numPowers];

            for(int i = 0; i < results.Length; i++)
            {
                results[i] = Power_I(num, i+1);
            }

            return results;
        }



        /*
         * Method SIGNATURE:
         * - access modifiers (static)
         * - return type
         * - identifier
         * - parameters
         */

        // doesn't return anything
        // format a string
        // what is void?
        // Are there any scenarios so far where the exact same variable could be present in both a static method and the main code?
        static void MergeWords(string[] stuff)
        {
            string result = "";
            int words = stuff.Length;
            for (int i = 0; i < stuff.Length; i++)
            {
                result += stuff[i];
                result += stuff[i].Length / stuff.Length;
            }
            Console.WriteLine(result);
        }

        // iterative power X to Nth
        static int Power_I(int x, int n)
        {
            int result = 1;
            for (int i = 0; i < n; i++)
            {
                result *= x;
            }
            return result;
        }

        // what is the easiest way to understand recursion?
        // when do you use recursion over iteration?
        // Can you a walk us through a recursive algorithm so we can determine the output
        // What are the benefits of recursion versus iteration?

        // recursive power
        static int Power_R(int x, int n)
        {
            // Base case -- n == 0 (n <=0 )
            if(n <= 0)
            {
                return 1;
            }

            // Recursive case -- n > 0
            // state change -- n-1
            else
            {
                return x * Power_R(x, n - 1);
            }

        }



    }
}
