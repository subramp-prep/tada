using System;
using System.Collections.Generic;

namespace questions
{
    // Question URL: https://leetcode.com/problems/intersection-of-two-arrays/description/
    //Given two arrays, write a function to compute their intersection.
    //Example:
    //Given nums1 = [1, 2, 2, 1], nums2 = [2, 2], return [2].
    //Note:
    //Each element in the result must be unique.
    //The result can be in any order.

    public class ArrayIntersection
    {
        public static int[] Perform(int[] nums1, int[] nums2)
        {
            HashSet<int> hashSet1 = new HashSet<int>(nums1);
            HashSet<int> hashSet2 = new HashSet<int>(nums2);

            List<int> intersects = new List<int>();

            foreach (var element in hashSet1)
            {
                if (hashSet2.Contains(element))
                {
                    intersects.Add(element);
                }
            }

            return intersects.ToArray();
        }
    }
}
