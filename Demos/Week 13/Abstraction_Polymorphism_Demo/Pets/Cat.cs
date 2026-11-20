using System;

namespace Abstraction_Polymorphism_Demo.Pets
{
    /// <summary>
    /// Cats are Pets that say Meow
    /// </summary>
    public class Cat : Pet
    {
        // The parameterized Cat constructor just needs to
        // pass the parameters plus it's fixed type to the 
        // parent constructor
        public Cat(string name, DateTime birthday)
            : base(name, birthday, "cat")
        {
        }

        // We also want to override Speak so that this Cat can talk!
        public override void Speak()
        {
            Console.WriteLine(this.Name + " says MEOW.");
        }
    }
}
