using System;
namespace questions
{
    public class RemoveDuplicates
    {
        // Question URL: https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/
        //Given a sorted array, remove the duplicates in-place such that each 
        //element appear only once and return the new length.
        //Do not allocate extra space for another array, you must do this 
        //by modifying the input array in-place with O(1) extra memory.
        //Example:
        //Given nums = [1, 1, 2],
        //Your function should return length = 2, with the first two elements of nums being 1 and 2 respectively.
        //It doesn't matter what you leave beyond the new length.

        public static int RemoveDuplicates_Perform(int[] nums)
        {
            int index = 0;

            int i = 0, j= i+1;
            for (; j < nums.Length; i++, j++)
            {
                if (nums[j] != nums[i])
                {
                    nums[index++] = nums[i];
                }
            }
            nums[index] = nums[i];

            return index+1;
        }

    }
}
