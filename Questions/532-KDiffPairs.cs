using System;
using System.Collections.Generic;

namespace questions
{
    // https://leetcode.com/problems/k-diff-pairs-in-an-array/description/

    //Given an array of integers and an integer k, you need to find the number of 
    //unique k-diff pairs in the array.Here a k-diff pair is defined as an integer 
    //pair (i, j), where i and j are both numbers in the array and their absolute difference is k.

    //Example 1:
    //Input: [3, 1, 4, 1, 5], k = 2
    //Output: 2
    //Explanation: There are two 2-diff pairs in the array, (1, 3) and(3, 5).
    //Although we have two 1s in the input, we should only return the number of unique pairs.

    //Example 2:
    //Input:[1, 2, 3, 4, 5], k = 1
    //Output: 4
    //Explanation: There are four 1-diff pairs in the array, (1, 2), (2, 3), (3, 4) and(4, 5).

    //Example 3:
    //Input: [1, 3, 1, 5, 4], k = 0
    //Output: 1
    //Explanation: There is one 0-diff pair in the array, (1, 1).

    //Note:
    //The pairs(i, j) and(j, i) count as the same pair.
    //The length of the array won't exceed 10,000.
    //All the integers in the given input belong to the range: [-1e7, 1e7].

    public class KDiffPairs
    {
        public static int FindPairs(int[] nums, int k)
        {
            if (k < 0)
            {
                return 0;
            }

            HashSet<int> starters = new HashSet<int>();
            HashSet<int> uniqs = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (uniqs.Contains(nums[i] - k))
                {
                    starters.Add(nums[i] - k);
                }

                if (uniqs.Contains(nums[i] + k))
                {
                    starters.Add(nums[i]);
                }

                uniqs.Add(nums[i]);
            }

            return starters.Count;
        }

        // Tried and Failed
        public static int FindPairs_gut_1(int[] nums, int k)
        {
            Dictionary<int, int> elements = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!elements.ContainsKey(nums[i]))
                {
                    elements.Add(nums[i], 1);
                }
                else
                {
                    elements[nums[i]] += 1;
                }
            }

            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int diff = Math.Abs(k - nums[i]);
                if (elements.ContainsKey(diff) && elements[diff] > 0)
                {
                    count++;
                    elements[diff] -= 1;
                }
            }

            return count;
        }
        
        public static int FindPairs_gut(int[] nums, int k)
        {
            HashSet<string> lookup = new HashSet<string>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    int diff = Math.Abs(nums[i] - nums[j]);

                    if (diff == k && 
                        !(lookup.Contains(nums[i].ToString() + ":" + nums[j].ToString()) ||
                          lookup.Contains(nums[j].ToString() + ":" + nums[i].ToString())))
                    {
                        lookup.Add(nums[i].ToString()+":"+nums[j].ToString());
                    }
                }
            }

            return lookup.Count;
        }
    }
}
