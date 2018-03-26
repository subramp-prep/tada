using System;
using System.Collections.Generic;

namespace questions
{
    // Problem URL: https://leetcode.com/problems/3sum/description/
    //Given an array S of n integers, are there elements a, b, c in S such that a + b + c = 0? 
    //Find all unique triplets in the array which gives the sum of zero.
    //Note: The solution set must not contain duplicate triplets.
    //For example, given array S = [-1, 0, 1, 2, -1, -4],
    //A solution set is:
    //[
    //  [-1, 0, 1],
    //  [-1, -1, 2]
    //]

    public class Sum
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            HashSet<int> hashInt = new HashSet<int>(nums);
            int sum = 0;

            IList<IList<int>> result = new List<IList<int>>();

            Array.Sort(nums);

            for (int index1 = 0, index2 = 1; index2 < nums.Length; index1++, index2++)
            {
                if (index1 > 0 && nums[index2] == nums[index1])
                {
                    continue;
                }

                int missing = sum - (nums[index1] + nums[index2]);
                if (hashInt.Contains(missing))
                {
                    IList<int> threeSum = new List<int>();

                    threeSum.Add(nums[index1]);
                    threeSum.Add(nums[index2]);
                    threeSum.Add(missing);

                    result.Add(threeSum);
                }
            }
            return result;
        }

        // TODO
        public static IList<IList<int>> ThreeSum_Works(int[] nums)
        {
            IList<IList<int>> combinations = new List<IList<int>>();
            Array.Sort(nums);

            for (int i = 0, j = 1; j < nums.Length; i++, j++)
            {
                int delta = 0 - (nums[i] + nums[j]);
                for (int k = j + 1; k < nums.Length; k++)
                {
                    if (nums[k] == delta)
                    {
                        List<int> combo = new List<int>();
                        combo.Add(nums[i]);
                        combo.Add(nums[j]);
                        combo.Add(nums[k]);

                        combinations.Add(combo);
                    }
                }
            }

            return combinations;
        }

        /// <summary>
        /// Froms the wiki: https://en.wikipedia.org/wiki/3SUM
        /// </summary>
        public static IList<IList<int>> ThreeSum_Optimum(int[] nums)
        {
            IList<IList<int>> combinations = new List<IList<int>>();

            Array.Sort(nums);

            for (int i = 0; i < nums.Length -2; i++)
            {
                int a = nums[i];
                int start = i + 1;
                int end = nums.Length - 1;

                while (start < end)
                {
                    int b = nums[start];
                    int c = nums[end];

                    if (a+b+c == 0)
                    {
                        List<int> combo = new List<int>();
                        combo.Add(a);;
                        combo.Add(b);
                        combo.Add(c);

                        combinations.Add(combo);
                    }
                    else if (a+b+c > 0)
                    {
                        end = end - 1;
                    }
                    else
                    {
                        start = start + 1;
                    }
                }
            }


            return combinations;
        }
    }
}
