using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    internal class Carrot
    {
        // fields
        private double weight;

        // properties
        public double Weight
        {
            get { return weight; }

            set
            {
                if (value >= 0)
                {
                    weight = value;
                }
            }
        }

        public bool IsGone
        {
            get
            {
                return weight == 0;
            }
        }

        // constructors

        public Carrot()
           : this(0)
        {
            //weight = 0;
            Console.WriteLine("Default carrot");
        }

        public Carrot(int weight)
        {
            this.weight = weight;
            Console.WriteLine("Parameterized carrot");
        }

        // methods
    }
}
