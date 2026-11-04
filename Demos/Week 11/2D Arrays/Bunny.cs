using System;
using System.Collections.Generic;
using System.Text;

namespace _2D_Arrays
{
    internal class Bunny
    {
        // fields
        // ALL object data is in the heap!
        private string name;
        private int numBananas;

        // constructor
        public Bunny(string name)
        {
            this.name = name;
            numBananas = 0;
        }

        // methods
        public void StealBanana()
        {
            numBananas++;
        }
    }
}
