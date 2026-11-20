using System;

namespace Abstraction_Polymorphism_Demo.Pets
{
    /// <summary>
    /// Dogs are Pets that say woof and chase their tails
    /// </summary>
    public class Dog : Pet
    {
        // The parameterized Dog constructor just needs to
        // pass the parameters plus it's fixed type to the 
        // parent constructor
        public Dog(string name, DateTime birthday)
            : base(name, birthday, "dog")
        {
        }

        // We also want to override Speak so that this Dog can talk!
        public override void Speak()
        {
            Console.WriteLine(this.Name + " says WOOF.");
        }

        // Dogs sometimes like to chase their tails
        // If Pet has a virtual ChaseTail, this one will need to override
        // in order for polymorphism to work
        //public override void ChaseTail(int loops)
        public void ChaseTail(int loops)
        {
            for (int i = 0; i<loops;i++)
            {
                Console.Write("WOOF! ");
            }
            Console.WriteLine();
        }
    }
}
