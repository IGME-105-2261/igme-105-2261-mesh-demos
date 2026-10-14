namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recursive Factorial(5): " + Factorial(5));
            Console.WriteLine("Iterative Factorial(5): " + FactorialIter(5));
        }

        // Iterative
        static int FactorialIter(int n)
        {
            int result = 1;
            for (int i = n; i > 0; i--)
            {
                result *= i;
            }
            return result;
        }

        // Recursive
        static int Factorial(int n)
        {
            if (n == 0) // base case
            { 
                return 1; 
            }
            else if (n > 0) // recursive case
            {
                return n * Factorial(n-1); // state change to move n towards 0: n-1
            }
            else // base case
            { 
                return -1; 
            }
        }


    }
}
