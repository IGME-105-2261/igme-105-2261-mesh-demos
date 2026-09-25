namespace BoolsAndIfs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fish;
          //  bool isHungry;
            string day;

            Console.Write("What is your fishy's name? ");
            fish = Console.ReadLine().Trim();

            Console.Write("What day is it? ");
            day = Console.ReadLine().Trim();

            //isHungry = day == "Monday";

            if (day.ToUpper() == "MONDAY")
            {
                Console.WriteLine(
                    "{0} is always hungry on {1}!\n" +
                    "Let's feed them!",
                    fish,
                    day);
            }
            else
            {
                Console.WriteLine("{0} is happy. :)", fish);
                Console.WriteLine("Don't feed them again");
            }

            Console.WriteLine("Have a nice day!");

            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());
            if (number < 10)
            {
                Console.WriteLine("Less than 10");
            }
            if (number == 10)
            {
                Console.WriteLine("Exactly 10");
            }
            if (number == 11)
            {
                Console.WriteLine("Exactly 11");
            }
            else
            {
                Console.WriteLine("Greater than 11");
            }


        }
    }
}
