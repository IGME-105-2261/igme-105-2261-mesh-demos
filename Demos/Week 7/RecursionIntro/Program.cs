namespace RecursionIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(DoStuff(5));
            Console.WriteLine(Factorial(4)); // 4 * 3 * 2 * 1
        }

        private static int DoStuff(int num)
        {
            return DoStuff(num + 1);
        }

        public static int Factorial(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            return num * Factorial(num - 1);
        }

    }
}
