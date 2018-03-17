using System;
using System.Collections.Generic;

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
    public class MaximumSizeSubarray
    {
        public static int MaxSubArrayLen(int[] nums, int k)
        {
            int maxLen = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int tempsum = nums[i];
                int count = 1;

                if (tempsum == k && count > maxLen)
                {
                    maxLen = count;
                }

                for (int j = i + 1; j < nums.Length; j++)
                {
                    tempsum += nums[j];
                    count++;

                    if (tempsum == k && count > maxLen)
                    {
                        maxLen = count;
                    }
                }
            }

            return maxLen;
        }

        // TODO
        //Below implementation beats 85% of submissions in leetcode
        public static int MaxSubArrayLen_Optimum(int[] nums, int k)
        {
            int maxLen = 0, sum = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (sum == k)
                {
                    maxLen = Math.Max(maxLen, i + 1);
                }

                int diff = sum - k;
                if (map.ContainsKey(diff))
                {
                    maxLen = Math.Max(maxLen, i - map[diff]);
                }

                if (!map.ContainsKey(sum))
                {
                    map[sum] = i;
                }

            }
            return maxLen;
        }
    }
}
