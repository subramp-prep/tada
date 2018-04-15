using System;
using System.Collections.Generic;

namespace questions
{
    // Question URL: https://leetcode.com/problems/move-zeroes/description/
    //Given an array nums, write a function to move all 0's to the 
    //end of it while maintaining the relative order of the non-zero elements.
    //For example, given nums = [0, 1, 0, 3, 12], after calling your function, nums should be[1, 3, 12, 0, 0].

    //Note:
    //You must do this in-place without making a copy of the array.
    //Minimize the total number of operations.

    public class MoveZeroes
    {
        public static void Perform1(int[] nums)
        {
            Queue<int> numQ = new Queue<int>(nums);
            int index = 0;

            while (numQ.Count > 0)
            {
                if (numQ.Peek() != 0)
                {
                    nums[index] = numQ.Peek();
                    index++;
                }
                numQ.Dequeue();
            }

            while (index < nums.Length)
            {
                nums[index] = 0;
                index++;
            }
        }

        public static void Perform2(int[] nums)
        {
            for (int current = 0, lastKnownNonZero = 0; current < nums.Length; current++)
            {
                if (nums[current] != 0)
                {
                    Utils.swap(ref nums[lastKnownNonZero++], ref nums[current]);
                }
            }
        }
    }
}
