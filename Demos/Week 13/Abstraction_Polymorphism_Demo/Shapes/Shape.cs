using System;

namespace Abstraction_Polymorphism_Demo.Shapes
{
    // Making the entire class abstract means it can't be instantiated!
    abstract class Shape
    {
        // Fields
        private string type;

        // public constructor, but since the class is abstract, 
        // we can't ever instantiate a "plain" Shape.
        public Shape(string type)
        {
            this.type = type;
        }

        // Define a method that MUST be overidden by the child classes
        public abstract double CalculateArea();

        // We can also define abstract properties
        public abstract double Area { get; }

        // abstract classes can still have "normal" methods
        public override string ToString()
        {
            // Even though CalculateArea isn't implemented in the parent, this
            // will work because polymorphism will cause the child's 
            // version of CalculateArea to be executed.
            return String.Format("This {0} has an area of {1:F2}.",
                type,
                CalculateArea());
        }
    }

}
