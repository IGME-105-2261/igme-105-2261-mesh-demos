using Abstraction_Polymorphism_Demo.Shapes;
using Abstraction_Polymorphism_Demo.MenuItems;
using Abstraction_Polymorphism_Demo.Pets;
using Abstraction_Polymorphism_Demo.Vehicles;

namespace Abstraction_Polymorphism_Demo
{
    class Program
    {
        //~~~~ MAIN ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            // Uncomment the demo you want to run
            //ShapesDemo();
            //PetsDemo();
            //VehiclesDemo();
            MenuItemDemo();
        }

        //~~~~ Public Input Helpers ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        #region InputHelpers
        // Input helper written by Prof. Mesh
        public static double GetPromptedPositiveDouble(string prompt)
        {
            double result = 0;
            while (!double.TryParse(GetPromptedInput(prompt), out result) || result < 0)
            {
                Console.WriteLine("\tPlease enter a positive number.");
            }
            return result;
        }

        // Input helper written by Prof. Mesh
        public static string GetPromptedInput(string prompt)
        {
            // Always print in white
            Console.ForegroundColor = ConsoleColor.White;

            // Print the prompt
            Console.Write(prompt + " ");

            // Switch color and get user input (trim too)
            Console.ForegroundColor = ConsoleColor.Cyan;
            string response = Console.ReadLine().Trim();

            // Switch back to white and then return response.
            Console.ForegroundColor = ConsoleColor.White;
            return response;
        }
        #endregion

        //~~~~ Private helpers to run sections of the demo ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Run the shapes demo code
        private static void ShapesDemo()
        {
            // Create some shapes...
            Circle c = new Circle(7.2);
            Console.WriteLine(c);

            Square sq = new Square(4);
            Console.WriteLine(sq);

            // Cannot instantiate an abstract class!
            // Shape s = new Shape("generic shape");

            // But we can create a Circle and treat it like a Shape
            Shape circle = new Circle(5);
            Console.WriteLine(circle);

            // And we can have a whole list of different kinds of shapes!
            List<Shape> shapes = new List<Shape>();

            string choice = "";

            // Keep asking for shapes and print them all out when done.
            do
            {
                choice = GetPromptedInput("What type of shape do you want (circle, square, or Q to quit)?").ToUpper();
                switch (choice)
                {
                    // Get the radius for a new circle and add it to the list
                    case "CIRCLE":
                        double radius = GetPromptedPositiveDouble("What is the radius?");
                        Circle newCircle = new Circle(radius);
                        shapes.Add(newCircle);
                        break;

                    // Get the side length for a new square and add it to the list
                    case "SQUARE":
                        // This one line gets the user input, uses it to create a new shape, and adds that
                        // to the list in the same way at the 3 lines for the circle case - just without
                        // the temporary variables
                        shapes.Add(new Square(GetPromptedPositiveDouble("What is the side length?")));
                        break;

                    // Print out all the shapes and say goodbye
                    case "Q":
                        Console.WriteLine("Your created {0} shapes:", shapes.Count);
                        foreach (Shape s in shapes)
                        {
                            Console.WriteLine(s);
                        }
                        Console.WriteLine("Goodbye!");
                        break;

                    // Ignore everything else
                    default:
                        Console.WriteLine("\tThat wasn't an option.");
                        break;
                }
            }
            while (choice != "Q");


        }

        // Run the pets demo code
        private static void PetsDemo()
        {

            // Create an array of names
            string[] names = { "Shiro", "Odin", "Donald", "Samson", "Bucky", "Fido", "Spot" }; // The { , , } Creates a new array and gives it these initial values all at once.

            // Create an array of pets
            Pet[] pets = new Pet[names.Length];
            for (int i = 0; i < pets.Length; i++)
            {
                // We create pets in trios: Cat, Dog, then Duck -- over and over
                // until we're out of pet names
                // We're giving them all today as a birthday
                if (i % 3 == 0)
                {
                    pets[i] = new Cat(names[i], DateTime.Today);
                }
                else if (i % 3 == 1)
                {
                    pets[i] = new Dog(names[i], DateTime.Today);
                }
                else // i % 3 must be 2 in this case
                {
                    pets[i] = new Duck(names[i], DateTime.Today);
                }
                pets[i].Speak();
            }
            Console.WriteLine();

            // Loop through the array of PETS trying to call Dog specific methods
            for (int i = 0; i < pets.Length; i++)
            {
                // Make sure this Pet is also a Dog
                if (pets[i] is Dog)
                {
                    // This won't compile because ChaseTail() isn't a member of Pet
                    //pets[i].ChaseTail(); 

                    // But if we downcast to Dog first, it's fine (the ()'s are needed so that ChaseTail is called after the cast
                    ((Dog)pets[i]).ChaseTail(10);
                }

                // A downcast if it's not actually a Dog will cause a run time error
                //((Dog)pets[i]).ChaseTail(10);

                // Finally, if we really don't want to have to down cast, we could make ChaseTail have a default implementation in the
                // Parent. Not ever child class would have to override it.
                // pets[i].ChaseTail(10);
            }
            Console.WriteLine("\n");
        }

        // Run the vehicles demo code
        private static void VehiclesDemo()
        {
            // Test out the vehicle class
            Vehicle v = new Vehicle("Honda");
            v.Drive();
            v.Stop();
            Console.WriteLine(v + "\n"); // Print using  the vehicle's ToString()

            // Test out the car class, but using a 
            // vehicle variable!
            Vehicle car = new Car("VW");
            car.Drive();
            car.Stop();
            Console.WriteLine(car); // Another print using Car's ToString()


            // Try some other permutations
            Car okay = new Car("Ford");
            //Car nope = (Car)(new Vehicle("Nope"));  // Not all vehicles are cars!

            // Create a data structure that can hold any kind of vehicle
            Vehicle[] vehicles = new Vehicle[10];
            for (int i = 0; i < vehicles.Length; i++)
            {
                // If 'i' is an even number...
                if (i % 2 == 0)
                {
                    vehicles[i] = new Vehicle("Vehicle" + i);
                }
                else
                {
                    vehicles[i] = new Car("Car" + i);
                }
            }

            // Loop and try to open the sunroof of each car
            for (int i = 0; i < vehicles.Length; i++)
            {
                // If this vehicle is actually a car, then open the sunroof
                if (vehicles[i] is Car)
                {
                    // Cast the vehicle to a car
                    Car carVersion = (Car)vehicles[i];
                    carVersion.Sunroof();
                }
            }
        }

        // Run the dynamic menu items demo code
        private static void MenuItemDemo()
        {
            // Setup a List to hold menu items and add some defaults
            Random rng = new Random();
            List<MenuItem> menuItems = new List<MenuItem>();
            menuItems.Add(new MenuItem("Hello", "Say hello", "Hello GDAPS1!"));
            menuItems.Add(new GetTimeItem());
            menuItems.Add(new AddGameItem(menuItems, rng));
            menuItems.Add(new QuitOption());

            // Run the main menu
            bool keepRunning = true;

            do
            {
                // Print the menu
                Console.WriteLine("\nWhat would you like to do?");
                foreach (MenuItem item in menuItems)
                {
                    Console.WriteLine(item);
                }

                // Get the user's choice
                string choice = GetPromptedInput("> ");

                // Run the matching menu item (if we never find it, do nothing)
                foreach (MenuItem item in menuItems)
                {
                    if (choice.ToUpper() == item.Keyword)
                    {
                        keepRunning = item.Run();

                        // Once we find the menu item and run it, we can quit the loop early
                        // We actually MUST quit it early because if the "new game" option runs, 
                        // it's going to change the menuItems list and break the foreach loop anyway

                        // Break is a loop control statement I didn't explictly teach you. It's very
                        // useful in specific situations like this, but can be easily abused to avoid
                        // having to write good loop control conditions.
                        break;
                    }
                }

            }
            while (keepRunning);
        }

    }
}
