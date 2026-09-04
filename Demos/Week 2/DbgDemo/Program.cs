namespace DbgDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 100;
            int denom = 0;
            double decNumber = 100.0;
            double okayIsh = decNumber / denom; // "Not a number" (infinity)
            //int probablyAnError = number / denom; // impossible

            Console.WriteLine(okayIsh);

            // Point 1
            int x1 = 0;
            int y1 = 0;

            // Point 2
            int x2 = 5;
            int y2 = 5;

            // subcalcs
            double xDiff = x2 - x1;
            double yDiff = y2 - y1;
            double sumSquares = xDiff * xDiff + yDiff * yDiff;

            //Console.WriteLine(xDiff);
            // ...

            // https://en.wikipedia.org/wiki/Euclidean_distance
            Console.WriteLine("Distance: " +
                    // square root of
                    Math.Sqrt(
                        (x2 - x1) * (x2 - x1)    // diff in x squared
                        + (y2 - y1) * (y2 - y1) // + diff in y squared
                     )
                );


        }
    }
}
