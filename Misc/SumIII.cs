using System;
namespace Misc
{
    // Design an algorithm to determine if given an array A
    // A3 elements add up to number k
    public class SumIII
    {
        public static bool Has3Sum(int[] nums, int k)
        {
            foreach (var num in nums)
            {
                if (Has2Sum(nums, k - num))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool Has2Sum(int[] nums, int t)
        {
            int low = 0;
            int high = nums.Length - 1;

            while (low < high)
            {
                int sum = nums[low] + nums[high];
                if ( sum == t)
                {
                    return true;
                }
                else if (sum > t)
                {
                    high--;
                }
                else
                {
                    low++;
                }
            }

            return false;
        }
    }
}
