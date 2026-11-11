using System.Collections.Generic;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pet[] myPets = new Pet[3];
            List<Pet> petList = new List<Pet>();

            myPets[0] = new Pet("Shiro", "cat", new DateTime(2017, 3, 1));
            myPets[1] = new Pet("Pax", "dog", new DateTime(2018, 11, 1));
            myPets[2] = new Pet("Aiden", "horse", new DateTime(2004, 4, 1));


            List<string> names = new List<string>();
            names.Add("Shiro");
            names.Add("Odin");
            names.Add("Lacy");
            names.Add("Daisy");
            names.Add("Daisy");
            names.Add("Daisy");
            names.Add("Daisy");
            names.Add("Daisy");
            names.Add("Daisy");
            names.Add("Daisy");
            names.Add("Donald");
            names.Add("Indy");

            names.Remove("Daisy");

            //names.Insert(12, "TEST"); // ERROR

            // Let's actually remove all names w/ 4 letters
            // MUST do this with a for loop because the underlying
            // list is going to change!
            for (int i = 0; i < names.Count; i++)
            {
                // Determine if the current name has 4 letters
                if (names[i].Length == 4)
                {
                    // Time to get rid of this name
                    names.RemoveAt(i);

                    // Make sure we recheck the same spot because data has 
                    // moved when we made the list smaller!
                    i--;
                }
            }


        }
    }
}
