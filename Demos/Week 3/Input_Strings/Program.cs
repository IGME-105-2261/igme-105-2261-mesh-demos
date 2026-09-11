namespace Input_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int num;

            Console.WriteLine("Hello, World!");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.Write("Enter your name: ");
            name = Console.ReadLine().Trim();
            Console.WriteLine(name + "!!!!!");
            Console.WriteLine("3");
            Console.WriteLine("4");

            // can't work without parsing
            //Console.Write("Enter a number: ");
            //num = Console.ReadLine();

            name.ToUpper(); // throws it on the floor
            Console.WriteLine(name.ToUpper()+" said:\n\t\"MEOW\"");
            name = name.ToUpper(); // replace with UC version
            Console.WriteLine(name);

            // Note that the starting index of the letters in the string is 0
            // [#] gives quick access to a specific character by index
            // Use Substring to get more than one at once
            Console.WriteLine("The first letter of " + name + " is " + name[0]);
            Console.WriteLine("The first 2 letters of " + name + " are " + name.Substring(0, 2));
            Console.WriteLine();

            // Can get pretty complicated (although we shouldn’t overdo it)
            // This calls PadLeft on the result of Remove which is on the result of Replace ...
            // (and on, and on)
            name = name.ToLower().Replace('s', 'x').Remove(1, 1).PadLeft(20, '@');
            Console.WriteLine(name);


        }
    }
}
