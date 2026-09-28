namespace CompoundConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fish = "Gluppy";
            string day;
            const string StartWeek = "MONDAY";

            Console.Write("What day is it? ");
            day = Console.ReadLine().Trim();

            if (day.ToUpper() == StartWeek)
            {
                Console.WriteLine(
                    "{0} is always hungry on {1}!\n" +
                    "Let's feed them!",
                    fish,
                    day);
            }
            else
            {
                bool elseRan = true;
                if (day.ToUpper() == "SUNDAY")
                {
                    int tmp = 5;
                    Console.WriteLine("{0} will be hungry again tomorrow.", fish);
                }
                else
                {
                    double tmp = 3.4;
                    Console.WriteLine("{0} is happy. :)", fish);
                    Console.WriteLine("Don't feed them again");
                }
            }

            Console.WriteLine("\nHave a nice day!");
            //Console.WriteLine("elseRan: " + elseRan);


            bool isAlive = true;
            /*
            if(isAlive)
            {
                isAlive = false;
            }
            else
            {
                isAlive = true;
            }
            */
            isAlive = !isAlive;

            string state = "pa";
            int age = 13;
            // More compound if statements
            if ((state == "pa" && age >= 16) ||
                (state == "vt" && age >= 15) ||
                (state == "ny" && age >= 16))
            {
                Console.WriteLine("You can drive!");
            }
            else
            {
                Console.WriteLine("No driving, sorry");
            }


        }
    }
}
