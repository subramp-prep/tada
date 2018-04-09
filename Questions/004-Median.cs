using System;
namespace questions
{
    // Question URL: https://leetcode.com/problems/median-of-two-sorted-arrays/description/
    //There are two sorted arrays nums1 and nums2 of size m and n respectively.
    //Find the median of the two sorted arrays.The overall run time complexity should be O(log (m+n)).
    //Example 1:
    //nums1 = [1, 3]
    //nums2 = [2]
    //The median is 2.0
    //Example 2:
    //nums1 = [1, 2]
    //nums2 = [3, 4]
    //The median is (2 + 3)/2 = 2.5

    public class Median
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] nums3 = new int[nums1.Length + nums2.Length];

            int i1 = 0;
            int i2 = 0;
            int index = 0;
            while (i1 < nums1.Length && i2 < nums2.Length)
            {
                if (nums1[i1] < nums2[i2])
                {
                    nums3[index++] = nums1[i1++];
                }
                else
                {
                    nums3[index++] = nums2[i2++];
                }
            }

            while (i1 < nums1.Length)
                nums3[index++] = nums1[i1++];

            while (i2 < nums2.Length)
                nums3[index++] = nums2[i2++];

            int length = nums3.Length;
            if (length % 2 == 0)
            {
                return ((double)nums3[length / 2] + (double)nums3[length / 2 - 1]) / 2;
            }
            else
            {
                return Convert.ToDouble(nums3[length / 2]);
            }
            
        }
    }
}
