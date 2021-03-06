﻿using System;
namespace questions
{
    // Question URL: https://leetcode.com/problems/3sum-smaller/description/
    //Given an array of n integers nums and a target, find the number of index 
    //triplets i, j, k with 0 <= i<j<k<n that satisfy the 
    //condition nums[i] + nums[j] + nums[k] < target.
    //For example, given nums = [-2, 0, 1, 3], and target = 2.
    //Return 2. Because there are two triplets which sums are less than 2:
    //[-2, 0, 1]
    //[-2, 0, 3]
    //Follow up:
    //Could you solve it in O(n2) runtime?
    public class SumIII
    {
        // TODO tends to miss the extreme ends of the array
        public static int ThreeSumSmaller(int[] nums, int target)
        {
            int count = 0;
            for (int i = 0, j = i + 1; j < nums.Length; i++, j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[j] + nums[k] < target)
                    {
                        Console.WriteLine("{0} {1} {2}", nums[i], nums[j], nums[k]);
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
