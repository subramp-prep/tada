using System;
namespace questions
{
    public class LargestIndexTwice
    {
        /// <summary>
        /// Question URL: https://leetcode.com/problems/largest-number-at-least-twice-of-others/description/
        /// </summary>
        /// <returns>The perform.</returns>
        /// <param name="nums">Nums.</param>
        public static int Perform(int[] nums)
        {
            if (nums.Length < 1 || nums.Length > 50)
                return -1;

            if (nums.Length <= 1)
                return 0;

            int largeIndex = 0;

            for (int index = 0; index < nums.Length; index++)
            {
                if (nums[index] >= nums[largeIndex])
                {
                    largeIndex = index;
                }
            }

            for (int dIndex = 0; dIndex < nums.Length; dIndex++)
            {
                if (dIndex != largeIndex && nums[dIndex]*2 > nums[largeIndex])
                {
                    return -1;
                }
            }

            return largeIndex;
        }
    }
}
