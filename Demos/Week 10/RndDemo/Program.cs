namespace RndDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generate a random object
            // Only need 1 per project!
            Random rng = new Random();
            Random rng2 = new Random();

            Console.WriteLine(rng.Next());
            Console.WriteLine(rng2.Next());


            int count = 0;
            while (count < 10)
            {
                // This code runs really fast
                // Creates more Random objects all with the same seed
                // even though we’re using time as a seed
                Random anotherRng = new Random(DateTime.Today.Millisecond);

                // Each new object will print the
                // exact same number here!
                Console.WriteLine(anotherRng.Next(50));
                count++;
            }


            // Use a method to generate a non-negative
            // number up to the max number of an int
            int randNum = rng.Next();

            // Generate a non-negative number up to 
            // (but NOT including) a specified maximum
            int smallNum = rng.Next(10); // [0,10) == 0 to 9

            // Generate a number in a specified range
            //  - The minimum is inclusive
            //  - The maximum is exclusive
            int randNumInRange = rng.Next(10, 25); // 10 – 24

            // Generate a double between 0.0 and 0.999999999999
            //  - This is the only option for doubles
            //  - Again, there is an exclusive upper bound
            double zeroToOne = rng.NextDouble();

            double zeroToTen = rng.NextDouble() * 10;
            double fiveToTen = rng.NextDouble() * 5 + 5;

        }


        static void DoStuff()
        {
            // stuff
        }
    }
}
