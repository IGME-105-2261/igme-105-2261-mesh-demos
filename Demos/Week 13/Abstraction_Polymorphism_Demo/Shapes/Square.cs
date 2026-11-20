using System;

namespace Abstraction_Polymorphism_Demo.Shapes
{
    /// <summary>
    /// Squares are Shapes with 4 equal sides
    /// </summary>
    class Square : Shape
    {
        // Squares all have the same length sides
        private double sideLength;

        // Create a new circle using the base constructor to save the type
        public Square(double sideLength) : base("square")
        {
            this.sideLength = sideLength;
        }

        // Implement CalculateArea correctly for a square
        public override double CalculateArea()
        {
            return sideLength * sideLength;
        }

        // Implement the Area property as well
        public override double Area
        {
            get
            {
                return sideLength * sideLength;
            }
        }
    }
}
