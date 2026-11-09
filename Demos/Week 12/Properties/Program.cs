namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carrot red = new Carrot();
            //Bunny shiro = new Bunny();

            Bunny carrot = new Bunny("Carrot");
            carrot.StealBananas(2);
            carrot.StealBananas("42");
            carrot.Print();

            red.Weight = 10;
            Console.WriteLine(red.Weight);

            red.Weight = -5;
            Console.WriteLine(red.Weight);
        }
    }
}
