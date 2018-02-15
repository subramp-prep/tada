using System;
using System.Collections.Generic;

namespace questions
{
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
