using System;
using System.Collections.Generic;

namespace questions
{
    public class MinSizeSubarray
    {
        // Question URL: https://leetcode.com/problems/minimum-size-subarray-sum/description/
        //Given an array of n positive integers and a positive integer s, 
        //find the minimal length of a contiguous subarray of which the sum ≥ s.
        //If there isn't one, return 0 instead.

        //For example, given the array[2, 3, 1, 2, 4, 3] and s = 7,
        //the subarray[4, 3] has the minimal length under the problem constraint.

        //click to show more practice.

        //More practice:
        //If you have figured out the O(n) solution, 
        //try coding another solution of which the time complexity is O(n log n).

        // TODO time exceeded on submission
        public static int MinSubArrayLen(int s, int[] nums)
        {
            int ?minSize = null;

            for (int i = 0; i < nums.Length; i++)
            {
                int sum = nums[i];
                int count = 1;
                if (sum >= s)
                {
                    minSize = minSize.HasValue ?
                                     Math.Min(minSize.Value, count) :
                                     count;
                }

                for (int j = i + 1; j < nums.Length; j++)
                {
                    sum += nums[j]; count++;
                    if (sum >= s)
                    {
                        minSize = minSize.HasValue ? 
                                         Math.Min(minSize.Value, count) : 
                                         count;
                    }
                }
            }

            return minSize.HasValue ? minSize.Value : 0;
        }
    }
}
