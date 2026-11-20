using System;

namespace Abstraction_Polymorphism_Demo.Pets
{
    /// <summary>
    /// Ducks are Pets that say quack
    /// </summary>
    public class Duck : Pet
    {
        // The parameterized Duck constructor just needs to
        // pass the parameters plus it's fixed type to the 
        // parent constructor
        public Duck(string name, DateTime birthday)
            : base(name, birthday, "duck")
        {
        }

        // We also want to override Speak so that this Duck can talk!
        public override void Speak()
        {
            Console.WriteLine(this.Name + " says QUACK.");
        }
    }
}
