using System;
using System.Collections.Generic;
using System.Text;

namespace ConstChaining_Overloading
{
    internal class Carrot
    {
        private double weight;

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
    }
}
