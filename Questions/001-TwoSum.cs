using System;
using System.Collections.Generic;

namespace questions
{
    //https://leetcode.com/problems/two-sum/description/
    //Given an array of integers, return indices of the two numbers such that 
    //they add up to a specific target.

    //You may assume that each input would have exactly one solution, 
    //and you may not use the same element twice.

    //Example:

    //Given nums = [2, 7, 11, 15], target = 9,

    //Because nums[0] + nums[1] = 2 + 7 = 9,
    //return [0, 1].
    public class TwoSum
    {
        public static int[] TwoSumPerform(int[] nums, int target)
        {
            IDictionary<int, int> elements = new Dictionary<int, int>();
            int[] output = null;

            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];

                if (elements.ContainsKey(diff))
                {
                    output = new int[2];
                    output[0] = elements[diff];
                    output[1] = i;

                    break;
                }
                else
                {
                    if (!elements.ContainsKey(nums[i]))
                        elements.Add(nums[i], i);
                }
            }

            return output;
        }
    }
}
