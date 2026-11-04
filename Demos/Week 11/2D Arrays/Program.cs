namespace _2D_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Attendance question
            // Does this code result in ints created in the
            // STACK, HEAP, or NOT AT ALL?
            int[] nums = new int[5]; // variable in the STACK, data in the HEAP

            int num; // 0 -- STACK - value type AND defined in a method
            Bunny jeff; // variable: STACK
                        // actual Bunny object: NOT AT ALL (yet)

            jeff = new Bunny("Jeff"); // object goes on the HEAP

            Bunny[] bunnies = new Bunny[5]; // array in the HEAP; NO bunnies yet
            bunnies[0] = new Bunny("Lacy");

            // ~~~~~~~~~~~~~~~~
            // 2D array with 3 rows, 6 columns
            double[,] gradesA = new double[3, 6];

            // Master Chief's exam scores
            gradesA[0, 0] = 95;
            gradesA[1, 0] = 94;
            gradesA[2, 0] = 76;

            // Samus Aran's exam scores
            gradesA[0, 1] = 100;
            gradesA[1, 1] = 75;
            gradesA[2, 1] = 89;

            // Commander Shepherd's exam scores
            gradesA[0, 2] = 68;
            gradesA[1, 2] = 99;
            gradesA[2, 2] = 83;

            int elements = gradesA.Length;		// 18 total elements
            int rows = gradesA.GetLength(0);        // First size, or 3
            int cols = gradesA.GetLength(1);        // Second size, or 6


            // ~~~~~~~~~~~~~~~~~
            // 2D array with 6 rows, 3 columns
            double[,] gradesB = new double[6, 3];

            // Master Chief's exam scores
            gradesB[0, 0] = 95;
            gradesB[0, 1] = 94;
            gradesB[0, 2] = 76;

            // Samus Aran's exam scores
            gradesB[1, 0] = 100;
            gradesB[1, 1] = 75;
            gradesB[1, 2] = 89;

            // Commander Shepherd's exam scores
            gradesB[2, 0] = 68;
            gradesB[2, 1] = 99;
            gradesB[2, 2] = 83;


            // ~~~~~~~~~~~~~~~~~~
            // Declaration uses 2 sets of square brackets.
            int[][] jaggedArray = new int[3][];

            // Initialize each "inner" array inside the "outer" array
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[5];
            jaggedArray[2] = new int[3];

            // Place data in each inner array
            jaggedArray[0][0] = 1;
            jaggedArray[0][1] = 3;
            jaggedArray[0][2] = 5;
            jaggedArray[0][3] = 7;
            jaggedArray[0][4] = 9;
            jaggedArray[1][0] = 0;
            jaggedArray[1][1] = 2;
            jaggedArray[1][2] = 4;
            jaggedArray[1][3] = 6;
            jaggedArray[1][4] = 8;
            jaggedArray[2][0] = 11;
            jaggedArray[2][1] = 22;
            jaggedArray[2][2] = 33;



        }
    }
}
