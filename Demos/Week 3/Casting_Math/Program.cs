namespace Casting_Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variable type & data match
            int dollars = 45;
            int cents = 33;

            // implicit casting
            double price = 10; // 10 without .0 -- int "literal"
            price = dollars;
            price += cents / 100.0;

            // explicit
            dollars = (int)price; // force copying ONLY the int portion


            price += 1 / 3.0;
            Console.WriteLine(Math.Round(price, 2));

        }
    }
}
