using System;
using System.Collections.Generic;
using System.Text;

namespace Lists
{
    class Pet
    {
        // Save basic info about each pet
        private String name;
        private String type;
        private DateTime birthday;

        // Read only property to calculate the age in years
        public double AgeInYears
        {
            get
            {
                // Age in days
                double ageDays = (DateTime.Today - this.birthday).TotalDays;

                // Return in years
                return Math.Round(ageDays / 365, 2);
            }
        }

        // Constructor to initialize with real info
        // (Because "default" pets are creepy)
        public Pet(string name, string type, DateTime birthday)
        {
            this.name = name;
            this.type = type;
            this.birthday = birthday;
        }

        // Print out info about this pet
        public override string ToString()
        {
            return String.Format("{0} is a {1} that is {2} years old.",
                this.name,
                this.type,
                this.AgeInYears);
        }
    }
}
