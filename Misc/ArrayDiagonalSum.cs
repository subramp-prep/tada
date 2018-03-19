using System;
namespace Misc
{
    // For a 2D array, identify the diagonal sum
    public class ArrayDiagonalSum
    {
        public static int DiagSum(int[,] nums, int arrayInOneDimension)
        {
            int sum = 0;
            for (int i = 0; i < arrayInOneDimension; i++)
            {
                sum += nums[i,i];
            }
            return sum;
        }
    }
}
