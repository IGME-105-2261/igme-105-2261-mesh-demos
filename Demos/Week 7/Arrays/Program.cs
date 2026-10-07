namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare AND init
            string[] names = new string[3];
            string name = "Shiro";

            // declare
            int num;
            int[] numbers;

            // initialize
            num = 3;
            numbers = new int[5];

            // access
            Console.WriteLine(num);
            Console.WriteLine(name);
            Console.WriteLine(name[2]);
            Console.WriteLine(numbers[2]);


            // modify
            Console.WriteLine();
            num += 42;
            numbers[2] = 42;
            Console.WriteLine(numbers[2]);
            names[0] = "Lacy";
            string tmp = names[0];
            //Console.WriteLine(names[2].ToUpper());
            //Console.WriteLine(tmp.ToUpper());


            // Make the array
            int[] nums = new int[5];

            // Fill the array
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i + 1;
            }

            // TODO: Run the rest of the demo code in the slides before starting the PE!

        }
    }
}
