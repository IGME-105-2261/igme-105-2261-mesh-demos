namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Let's make a "default" car, see its stats, 
            // drive, and see the final stats
            Vehicle myCar = new Vehicle();
            myCar.Print();
            myCar.Drive(10);
            myCar.Print();

            // That was boring. Let's make a "real" car
            Vehicle hybrid = new Vehicle("Ford", "CMAX", 5);
            hybrid.Print();
            hybrid.Drive(10);
            hybrid.Print();

            // myCar.mileage = 0; // BAD
        }
    }
}
