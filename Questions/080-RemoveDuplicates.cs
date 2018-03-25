using System;
namespace questions
{
    public class RemoveDuplicatesII
    {
        // Question URL: https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/description/
        //Follow up for "Remove Duplicates":
        //What if duplicates are allowed at most twice?
        //For example,
        //Given sorted array nums = [1,1,1,2,2,3],
        //Your function should return length = 5, with the first five elements of nums 
        //being 1, 1, 2, 2 and 3. It doesn't matter what you leave beyond the new length.

        public static int RemoveDuplicates(int[] nums)
        {
            int count = 0;
            for (int i = 2; i < nums.Length; i++)
            {
                if(nums[i] == nums[i - 2 - count])
                {
                    count++;
                }
                else
                {
                    nums[i - count] = nums[i];
                }
            }

            return nums.Length - count;

            //for (int i = 0, j = 1; j < nums.Length; i++, j++)
            //{
            //    if (nums[i] == nums [j] && !duplicate)
            //    {
            //        nums[index++] = nums[i];
            //        duplicate = true;
            //    }
            //    else if (nums[i] != nums[j])
            //    {
            //        nums[index++] = nums[i];
            //        duplicate = false;
            //    }
            //    else if(nums[i] == nums[j] && duplicate)
            //    {
            //        nums[index++] = nums[i];
            //        i++;
            //        j++;
            //    }
            //}
            //return index;
        }
    }
}
