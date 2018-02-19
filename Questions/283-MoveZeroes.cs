using System;
using System.Collections.Generic;

namespace questions
{
    /// <summary>
    /// Question URL: https://leetcode.com/problems/move-zeroes/description/
    /// </summary>
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
