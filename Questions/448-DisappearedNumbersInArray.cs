﻿using System;
using System.Collections.Generic;

namespace questions
{
    // Question URL: 
    //https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/description/
    //Given an array of integers where 1 ≤ a[i] ≤ n(n = size of array), 
    //some elements appear twice and others appear once.
    //Find all the elements of [1, n] inclusive that do not appear in this array.
    //Could you do it without extra space and in O(n) runtime? 
    //You may assume the returned list does not count as extra space.
    //Example:
    //Input:
    //[4,3,2,7,8,2,3,1]
    //Output:
    //[5,6]
    public class DisappearedNumbersInArray
    {
        // INTERESTING
        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            IList<int> missingNumbers = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]) - 1;
                if (nums[index] > 0)
                {
                    nums[index] = -nums[index];
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    missingNumbers.Add(i + 1);
                }
            }

            return missingNumbers;
        }
    }
}
