using System.Runtime.InteropServices;

namespace StackHeap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 3;
            string food = "banana";
            //DoStuff();


            int a = 10;
            int b = a;
            b += 5;


            int[] nums = new int[5];
            int[] moreNums = nums;  // moreNums now refers to the same 
                                    // underlying array as nums
            moreNums[2] = 100; // changes the 3rd element 
                               // referred to by BOTH variables

            DoStuff(nums);
        }

        static void DoStuff(int[] nums)
        {
            int things = 12;
            double x;
            double y;
            double a;
            //double[] nums = new double[10];
            string stuff = "Shiro";
            nums[1] = 10;
            // DoStuff();
        }
    }
}
