using System;
namespace questions
{
    // Question URL: https://leetcode.com/problems/rotate-array/description/
    //Rotate an array of n elements to the right by k steps.
    //For example, with n = 7 and k = 3, 
    //the array [1,2,3,4,5,6,7] is rotated to [5,6,7,1,2,3,4].

    //Note:
    //Try to come up as many solutions as you can, 
    //there are at least 3 different ways to solve this problem.

    //Hint:
    //Could you do it in-place with O(1) extra space?
    public class RotateArray
    {
        public static void Rotate(int[] nums, int k)
        {
            k %= nums.Length;
            
            Reverse(nums, 0, nums.Length-1);
            Reverse(nums, 0, k-1);
            Reverse(nums, k, nums.Length-1);
        }

        public static void Reverse(int[] nums, int low, int high)
        {
            while (low < high)
            {
                Utils.swap(ref nums[low++], ref nums[high--]);
            }
        }
    }
}
