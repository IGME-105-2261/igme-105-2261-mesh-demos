using System;

namespace Abstraction_Polymorphism_Demo.Shapes
{
    /// <summary>
    /// Circles are Shapes with a radius
    /// </summary>
    class Circle : Shape
    {
        // Circles need a radius
        private double radius;

        // Create a new circle using the base constructor to save the type
        public Circle(double radius) : base("circle")
        {
            this.radius = radius;
        }

        // Implement CalculateArea since we have a radius and can actually
        // do the math here
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        // Implement the Area property as well
        public override double Area
        {
            get
            {
                return Math.PI * radius * radius;
            }
        }
    }

}
