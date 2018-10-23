using System;
using System.Collections.Generic;

namespace questions
{
    public class SubarraySum
    {
        // https://leetcode.com/problems/subarray-sum-equals-k/\
        //Given an array of integers and an integer k, you need to find the total 
        //number of continuous subarrays whose sum equals to k.

        //Example 1:
        //Input:nums = [1,1,1], k = 2
        //Output: 2
        //Note:
        //The length of the array is in range[1, 20, 000].
        //The range of numbers in the array is [-1000, 1000] and the range of the integer k is [-1e7, 1e7].

        public static int Count(int[] nums, int k)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int result = 0;
            int sum = 0;

            map.Add(0, 1);

            for (int index = 0; index < nums.Length; index++)
            {
                sum += nums[index];

                if (map.ContainsKey(sum - k))
                {
                    result += map[sum - k];
                }

                if (!map.ContainsKey(sum))
                {
                    map.Add(sum, 1);
                }
                else
                {
                    map[sum] ++;
                }
            }

            return result;
        }
    }
}
