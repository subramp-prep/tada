using System;
namespace questions
{
    // Question URL: https://leetcode.com/problems/maximum-subarray/description/

    //Find the contiguous subarray within an array(containing at least one number) which has the largest sum.
    //For example, given the array[-2, 1, -3, 4, -1, 2, 1, -5, 4],
    //the contiguous subarray[4, -1, 2, 1] has the largest sum = 6.
    //click to show more practice.
    //More practice:
    //If you have figured out the O(n) solution, try coding another solution using the divide and conquer approach, 
    //which is more subtle.

    public class MaximumSubarray
    {
        // WARNING: inefficient for larger arrays!
        public static int MaxSubArray(int[] nums)
        {
            int maxSum = nums[0];

            for (int index = 0; index < nums.Length; index++)
            {
                int tempIndex = index;
                int tempSum = 0;

                while (tempIndex < nums.Length)
                {
                    tempSum += nums[tempIndex];
                    tempIndex++;

                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                    }
                }
            }

            return maxSum;
        }

        // TODO
        // Kadane's algorithm is best used to solve this question
        // https://en.wikipedia.org/wiki/Maximum_subarray_problem
        public static int MaxSubArray_Optimum(int[] nums)
        {
            int maxSum = int.MinValue;
            int tempSum = 0;

            for (int index = 0; index < nums.Length; index++)
            {
                tempSum = tempSum + nums[index];

                maxSum = Math.Max(maxSum, tempSum);

                tempSum = Math.Max(0, tempSum);
            }

            return maxSum;
        }
    }
}
