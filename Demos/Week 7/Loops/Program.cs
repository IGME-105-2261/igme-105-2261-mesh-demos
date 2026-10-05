namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

        }
    }
}
