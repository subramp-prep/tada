using System;
using System.Collections.Generic;

namespace questions
{
    // https://leetcode.com/problems/subsets-ii/description/
    //Given a collection of integers that might contain duplicates, 
    //nums, return all possible subsets(the power set).

    //Note: The solution set must not contain duplicate subsets.

    //Example:
    //Input: [1,2,2]
    //Output:
    //[
    //  [2],
    //  [1],
    //  [1,2,2],
    //  [2,2],
    //  [1,2],
    //  []
    //]
    public class SubsetsII
    {
        public static IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            IList<IList<int>> output = new List<IList<int>>();
            Array.Sort(nums);

            SubsetHelper(nums, new List<int>(), output, 0);

            return output;
        }

        private static void SubsetHelper(int[] nums, IList<int> chosen, IList<IList<int>> output, int start)
        {
            output.Add(new List<int>(chosen));

            for (int i = start; i < nums.Length; i++)
            {
                if (i > start && nums[i] == nums[i-1])
                {
                    continue;
                }

                chosen.Add(nums[i]);
                SubsetHelper(nums, chosen, output, i + 1);
                chosen.RemoveAt(chosen.Count - 1);
            }
        }
    }
}
