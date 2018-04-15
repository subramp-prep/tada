using System;
using System.Collections.Generic;

namespace questions
{
    //Question URL:https://leetcode.com/problems/intersection-of-two-arrays-ii/description/
    //Given two arrays, write a function to compute their intersection.

    //Example:
    //Given nums1 = [1, 2, 2, 1], nums2 = [2, 2], return [2, 2].

    //Note:
    //Each element in the result should appear as many times as it shows in both arrays.
    //The result can be in any order.
    //Follow up:
    //What if the given array is already sorted? How would you optimize your algorithm?
    //What if nums1's size is small compared to nums2's size? Which algorithm is better?
    //What if elements of nums2 are stored on disk, and the memory is limited such that 
    //you cannot load all elements into the memory at once?
    public class ArrayIntersection2
    {
        public static int[] Perform(int[] nums1, int[] nums2)
        {
            List<int> numsList1 = new List<int>(nums1);
            List<int> numsList2 = new List<int>(nums2);

            List<int> results = new List<int>();

            foreach (var element in numsList1)
            {
                if (numsList2.Count < 0)
                {
                    break;
                }

                if (numsList2.Contains(element))
                {
                    results.Add(element);
                    numsList2.Remove(element);
                }
            }

            return results.ToArray();
        }
    }
}
