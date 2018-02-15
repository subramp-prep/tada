using System;
using System.Collections.Generic;

namespace Questions
{
    /// <summary>
    /// Question URL: https://leetcode.com/problems/intersection-of-two-arrays/description/
    /// </summary>
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
