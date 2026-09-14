namespace Parsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // What type of cast does this need?
            // int a = (int)10.5; // explicit

            // "12"
            // '1' '2'
            // 1*10 + 2*1
            // 12

            int num;
            //string input;
            Console.Write("Enter a whole number: ");
            //input = Console.ReadLine();
            num = int.Parse(Console.ReadLine());
            Console.WriteLine(num * 10);

        }
    }
}
