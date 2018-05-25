using System;
namespace questions
{
    //Question URL: https://leetcode.com/problems/merge-sorted-array/description/
    //Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.
    //Note:
    //You may assume that nums1 has enough space(size that is greater or equal to m + n) 
    //to hold additional elements from nums2.The number of elements initialized in 
    //nums1 and nums2 are m and n respectively.

    //Example:
    //Input:
    //nums1 = [1,2,3,0,0,0], m = 3
    //nums2 = [2,5,6],       n = 3

    //Output: [1,2,2,3,5,6]

    public class MergeSortedArray
    {
        // FANTASTIC LOGIC!!!
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int p1 = m - 1;
            int p2 = n - 1;

            int index = m + n - 1;

            while (p1 >= 0 && p2 >= 0)
            {
                if (nums1[p1] > nums2[p2])
                {
                    nums1[index--] = nums1[p1--];
                }
                else
                {
                    nums1[index--] = nums2[p2--];
                }
            }

            while (p2 >= 0)
            {
                nums1[index--] = nums2[p2--];
            }
        }

        //Brute force
        public static void Merge_Brute(int[] nums1, int m, int[] nums2, int n)
        {
            int[] nums3 = new int[m + n];
            int n1 = 0, n2 = 0, n3 = 0;

            while (n1 < m && n2 < n)
            {
                if (nums1[n1] <= nums2[n2])
                {
                    nums3[n3++] = nums1[n1++];
                }
                else
                {
                    nums3[n3++] = nums2[n2++];
                }
            }

            while (n1 < m)
            {
                nums3[n3++] = nums1[n1++];
            }

            while (n2 < n)
            {
                nums3[n3++] = nums2[n2++];
            }

            for (int index = 0; index < nums3.Length; index++)
            {
                nums1[index] = nums3[index];
            }
        }
    }
}
