using System;

namespace Abstraction_Polymorphism_Demo.Pets
{
    /// <summary>
    /// A EVEN better implementation for Pet using properties, inheritance, and abstraction
    /// </summary>
    public abstract class Pet
    {
        // Save basic info about each pet
        protected String name;
        protected String type;
        protected DateTime birthday;

        // Properties

        // Let clients of this class access and even
        // change the pet's name
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Let clients of this class access the pet's type
        public string Type
        {
            get { return this.type; }
        }

        // Supply an Age property by calculating 
        // how old the pet is TODAY
        public double Age
        {
            get
            {
                // Age in days
                double ageDays = (DateTime.Today - this.birthday).TotalDays;

                // Return in years
                return Math.Round(ageDays / 365, 2);
            }

            // Set not allowed
        }


        // Default Pets are creepy so make this protected
        // so that the only way to create a Pet is if it's
        // via creation of a child class
        protected Pet(string name, DateTime birthday, string type)
        {
            // This never gets called by Main()
            this.name = name;
            this.birthday = birthday;
            this.type = type;
        }

        // Print out info about this pet
        public override string ToString()
        {
            return String.Format("{0} is a {1} that is {2} years old.",
                this.Name,
                this.Type,
                this.Age);
        }

        // Make this Pet speak
        public abstract void Speak();

        // By default, most pets won't chase their tails
        // Uncomment this to try having a default behavior that not all
        // child classes override
        /*
        public virtual void ChaseTail(int loops)
        {
            Console.WriteLine(this.Name + " looks at their tail and then at you as if to say 'Seriously?'");
        }
        */
    }
}
