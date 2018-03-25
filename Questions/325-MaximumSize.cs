using System;
using System.Collections.Generic;
using System.Linq;

namespace questions
{
    // Question URL: https://leetcode.com/problems/maximum-size-subarray-sum-equals-k/description/
    //Given an array nums and a target value k, find the maximum length of a subarray that sums to k.
    //If there isn't one, return 0 instead.
    //Note:
    //The sum of the entire nums array is guaranteed to fit within the 32-bit signed integer range.
    //Example 1:
    //Given nums = [1, -1, 5, -2, 3], k = 3,
    //return 4. (because the subarray [1, -1, 5, -2] sums to 3 and is the longest)
    //Example 2:
    //Given nums = [-2, -1, 2, 1], k = 1,
    //return 2. (because the subarray[-1, 2] sums to 1 and is the longest)
    //Follow Up:
    //Can you do it in O(n) time?

    public class MaximumSize
    {
        // TODO 
        // not complete, since this implementation 
        // provides the non-contiguous elements sum as well
        // more than the contiguous array
        // Backtracking not the right solution!!!!
        public static void FindMaxSubarray(int[] nums, int sum)
        {
            IList<int> chosen = new List<int>();
            IList<int> count = new List<int>();

            MaximumSizeHelper(nums.ToList(), chosen, count, sum);

            Console.WriteLine(count.Max());
        }

        private static void MaximumSizeHelper(IList<int> nums, IList<int> chosen, IList<int> count, int sum)
        {
            if (nums.Count == 0)
            {
                if (chosen.Sum() == sum)
                    count.Add(chosen.Count);
            }
            else
            {
                int c = nums[0];
                nums.RemoveAt(0);

                MaximumSizeHelper(nums, chosen, count, sum);

                chosen.Add(c);
                MaximumSizeHelper(nums, chosen, count, sum);

                nums.Insert(0, c);
                chosen.RemoveAt(chosen.Count - 1);
            }
        }
    }
}
