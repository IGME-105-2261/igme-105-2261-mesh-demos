using System;
using System.Collections.Generic;
using System.Text;

namespace ConstChaining_Overloading
{
    internal class Bunny
    {
        // fields
        // ALL object data is in the heap!
        private string name;
        private int numBananas;

        // constructor
        public Bunny(string name)
            : this(name, 0)
        {
            this.name = name;
            //numBananas = 0;
        }

        public Bunny(string name, int startingBananas)
        {
            this.name = name;
            numBananas = startingBananas;
        }

        // methods
        public void StealBananas(int numBananas)
        {
            this.numBananas += numBananas;
        }

        public void StealBananas(string numBananas)
        {
            this.numBananas += int.Parse(numBananas);
        }

        public void Print()
        {
            Console.WriteLine("{0} has stolen {1} bananas.", name, this.numBananas);
        }

    }
}
