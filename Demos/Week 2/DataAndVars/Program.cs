namespace DataAndVars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int num = 10.75; // won't compile
            double bigNum = 10;

            const int MaxHealth = 100;

            string shiro;
            int x = 3;
            int y = 4;
            int z;

            //MaxHealth = 10;

            shiro = "my cat too?";
            Console.WriteLine(shiro);
            Console.WriteLine(x + y);
            z = x + y;
            Console.WriteLine(z);

            //            z = z + 1;
            // z += 1;
            z++;
            Console.WriteLine(z);
            Console.WriteLine(MaxHealth);

            // shiro = z; // BAD
        }
    }
}
