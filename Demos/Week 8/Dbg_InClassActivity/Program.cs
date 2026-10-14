/***
 * GDAPS Debugging In Class Activity
 * 
 * With a partner, debug the 3 methods called by Main().
 * 
 * ONE person should "drive" (run, take notes in comments, etc) 
 *   while the other "navigates" (make suggestions, look up info needed, etc.).
 * 
 * Together, for each problem:
 * 1. Talk through the code together.
 * 2. Add comments explaining the parts you understand (this code is 
 *      intentionally UNDER commented!)
 * 3. Add comments with questions for parts you're unsure about
 * 4. Make a hypothesis about where the problem is
 * 5. Use the debugger to test your hypothesis (do NOT just hack at the code
 *      blindly until it works!!!)
 * 6. Take notes about what you look at in the debugger and how that helped
 *      narrow down the problem (also in comments)
 * 
 * Get as far as you can. The final problem is intentionally difficult. It's okay
 *      (and expected) if not everyone "gets" it. We'll spend 20-30 minutes on this
 *      and then regroup.
 * 
 */
namespace Dbg_InClassActivity
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Uncomment the method calls one at a time and debug them
            //FractionToDecimal();
            //Quadratic();
            //CipherText(); 
            //Console.WriteLine(Fibonaci(10)); // The result should be 55 (0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55)
        }

        /// <summary>
        /// Input helper written by Prof. Mesh
        /// Uses the given string to prompt the user for input and set
        /// the color to cyan while they type.
        /// </summary>
        /// <param name="prompt">What to print before waiting for input</param>
        /// <returns>A trimmed version of what the user entered</returns>
        public static string PromptForInput(string prompt)
        {
            // Always print in white
            Console.ForegroundColor = ConsoleColor.White;

            // Print the prompt
            Console.Write(prompt + " ");

            // Switch color and get user input (trim too)
            Console.ForegroundColor = ConsoleColor.Cyan;
            string response = Console.ReadLine().Trim();

            // Switch back to white and then return response.
            Console.ForegroundColor = ConsoleColor.White;

            return response;
        }

        /// <summary>
        /// Convert the numerator & denominator given to a decimal number.
        /// TODO: BUG - The result is always a whole number no matter what values are given.
        /// </summary>
        private static void FractionToDecimal()
        {
            Console.WriteLine("Enter a fraction...");
            Console.WriteLine("\n ---> " + 
                    ( int.Parse(PromptForInput("\tNumerator\t:")) 
                      / int.Parse(PromptForInput("\tDenominator\t:")) 
                    )
                );
        }


        /// <summary>
        /// Solve for x in a quadratic equation - https://en.wikipedia.org/wiki/Quadratic_formula
        /// TODO: BUG - Entering 5, 6, 1 for a, b, c should give X = -0.2, -1 (and clearly doesn't)
        /// </summary>
        private static void Quadratic()
        {
            /* Technically, it violates our coding standards to declare multiple variables at once.
                  I'm doing it anyway here because it really does make sense to declare sets of
                  variables for an algebraic equation together.
             */
            double a, b, c;
            double numTerm2;
            double x1, x2;

            // Get the coefficients
            Console.WriteLine("Enter the 3 coefficients for ax^2 + bx + c = 0...");
            a = double.Parse(PromptForInput("\ta:"));
            b = double.Parse(PromptForInput("\tb:"));
            c = double.Parse(PromptForInput("\tc:"));

            numTerm2 = Math.Sqrt(b * b - 4 * a * c);

            x1 = (0 - b + numTerm2) / 2 * a;
            x2 = (0 - b - numTerm2) / 2 * a;


            Console.WriteLine("\n ---> x = " + x1 + ", " + x2);
        }

        /// <summary>
        /// Recursive calculation of the nth Fibonaci number
        /// https://en.wikipedia.org/wiki/Fibonacci_sequence
        /// 
        /// TODO: BUG - It runs, but it never stops :(
        /// </summary>
        private static int Fibonaci(int n)
        {
            return Fibonaci(n - 1) + Fibonaci(n - 2);
        }

        /// <summary>
        /// Use a shift cipher to encrypt a word
        ///      - Get a key
        ///      - Get a word
        ///      - Use the key to encrypt the word using a (very very ugly) implementation of the shift cipher
        ///      - Output the ciphertext in all caps.
        ///
        /// TODO: BUG - It runs, but the ciphertext is always wrong.
        ///
        /// With a shift key of 9, "encryption" should result in "NWLAHYCRXW"
        /// 
        /// References:
        ///  - https://en.wikipedia.org/wiki/Caesar_cipher
        ///  - Encryption - E(x) = (x+n) mod 26
        ///  - Decryption - D(x) = (x-n) mod 26
        /// </summary>
        private static void CipherText()
        {
            // Setup
            const char MinSourceLetter = 'A';
            const char MinCipherLetter = 'A';
            const int NumLetters = 26;

            // Variables we'll need
            string text;
            string ciphertext;
            int shiftKey = 0;

            // Get the cipher info
            shiftKey = int.Parse(PromptForInput("Enter the shift key [0, 26]:"));

            // Get the word to encrypt
            text = PromptForInput("Enter the word to encrypt:").ToUpper();

            // Encrypt & print
            ciphertext = text;
            ciphertext = ciphertext.Replace((char)(MinSourceLetter + 0), (char)((0 + shiftKey) % NumLetters + MinCipherLetter));
            ciphertext = ciphertext.Replace((char)(MinSourceLetter + 1), (char)((1 + shiftKey) % NumLetters + MinCipherLetter));
            ciphertext = ciphertext.Replace((char)(MinSourceLetter + 2), (char)((2 + shiftKey) % NumLetters + MinCipherLetter));
            ciphertext = ciphertext.Replace((char)(MinSourceLetter + 3), (char)((3 + shiftKey) % NumLetters + MinCipherLetter));
            ciphertext = ciphertext.Replace((char)(MinSourceLetter + 4), (char)((4 + shiftKey) % NumLetters + MinCipherLetter));
            ciphertext = ciphertext.Replace((char)(MinSourceLetter + 5), (char)((5 + shiftKey) % NumLetters + MinCipherLetter));
            ciphertext = ciphertext.Replace((char)(MinSourceLetter + 6), (char)((6 + shiftKey) % NumLetters + MinCipherLetter));
            ciphertext = ciphertext.Replace((char)(MinSourceLetter + 7), (char)((7 + shiftKey) % NumLetters + MinCipherLetter));
            ciphertext = ciphertext.Replace((char)(MinSourceLetter + 8), (char)((8 + shiftKey) % NumLetters + MinCipherLetter));
            ciphertext = ciphertext.Replace((char)(MinSourceLetter + 9), (char)((9 + shiftKey) % NumLetters + MinCipherLetter));
            ciphertext = ciphertext.Replace((char)(MinSourceLetter + 10), (char)((10 + shiftKey) % NumLetters + MinCipherLetter));
            ciphertext = ciphertext.Replace((char)(MinSourceLetter + 11), (char)((11 + shiftKey) % NumLetters + MinCipherLetter));
            ciphertext = ciphertext.Replace((char)(MinSourceLetter + 12), (char)((12 + shiftKey) % NumLetters + MinCipherLetter));
            ciphertext = ciphertext.Replace((char)(MinSourceLetter + 13), (char)((13 + shiftKey) % NumLetters + MinCipherLetter));
            ciphertext = ciphertext.Replace((char)(MinSourceLetter + 14), (char)((14 + shiftKey) % NumLetters + MinCipherLetter));
            ciphertext = ciphertext.Replace((char)(MinSourceLetter + 15), (char)((15 + shiftKey) % NumLetters + MinCipherLetter));
            ciphertext = ciphertext.Replace((char)(MinSourceLetter + 16), (char)((16 + shiftKey) % NumLetters + MinCipherLetter));
            ciphertext = ciphertext.Replace((char)(MinSourceLetter + 17), (char)((17 + shiftKey) % NumLetters + MinCipherLetter));
            ciphertext = ciphertext.Replace((char)(MinSourceLetter + 18), (char)((18 + shiftKey) % NumLetters + MinCipherLetter));
            ciphertext = ciphertext.Replace((char)(MinSourceLetter + 19), (char)((19 + shiftKey) % NumLetters + MinCipherLetter));
            ciphertext = ciphertext.Replace((char)(MinSourceLetter + 20), (char)((20 + shiftKey) % NumLetters + MinCipherLetter));
            ciphertext = ciphertext.Replace((char)(MinSourceLetter + 21), (char)((21 + shiftKey) % NumLetters + MinCipherLetter));
            ciphertext = ciphertext.Replace((char)(MinSourceLetter + 22), (char)((22 + shiftKey) % NumLetters + MinCipherLetter));
            ciphertext = ciphertext.Replace((char)(MinSourceLetter + 23), (char)((23 + shiftKey) % NumLetters + MinCipherLetter));
            ciphertext = ciphertext.Replace((char)(MinSourceLetter + 24), (char)((24 + shiftKey) % NumLetters + MinCipherLetter));
            ciphertext = ciphertext.Replace((char)(MinSourceLetter + 25), (char)((25 + shiftKey) % NumLetters + MinCipherLetter));

            Console.WriteLine("\n ---> " + ciphertext);
        }
    }
}
