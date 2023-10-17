using System;

namespace example3_213036
{
    class Program
    {
        static void Main()
        {
            //Declare single array
            int[] array1 = new int[5];
            //Declare and set array
            int[] array2 = new int [] {2, 3, 4};
            //Declare 2D array
            int[,] array2D = new int[2, 3];
            // Declare and set 2D array
            int[,] array2d = { { 1, 2, 3 }, { 4, 5, 6 } };
            // Declare jagged Array 
            int[][] jaggedArray = new int[3][];
            //declare and set jagged array
            jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
        }
    }
}
