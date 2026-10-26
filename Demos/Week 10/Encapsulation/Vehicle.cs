using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    /// <summary>
    /// 
    /// </summary>
    public class Vehicle
    {
        // Let’s start with the basic fields
        private String make;
        private String model;
        private int doors;
        private double mileage;

        // A DEFAULT constructor - it has NO parameters
        // Useful if we want to make a "default" car
        // C# makes one of these for us, but gives the fields
        // default values.
        public Vehicle()
        {
            make = "Make?";
            model = "Model?";
            doors = 4;
            mileage = 0.0;
        }

        // A PARAMETERIZED constructor - meaning it takes
        // some extra data when we make a car
        public Vehicle(string make, string model, int doors)
        {
            // Use the "this" keyword to ensure
            // that the variable on the left is 
            // actually the FIELD in which we want
            // to save the data
            this.make = make;
            this.model = model;

            // Also save the number of doors
            this.doors = doors;
        }


        /// <summary>
        /// This prints out the car's info
        /// </summary>
        public void Print()
        {
            Console.WriteLine(
               "The {0} {1} with {2} doors has {3:F2} miles on it.",
               make, model, doors, mileage);
        }

        // This causes the car to drive forward
        public void Drive(double distance)
        {
            // Update the field
            mileage += distance;
        }


    }
}
