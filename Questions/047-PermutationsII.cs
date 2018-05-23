using System;
using System.Collections.Generic;

namespace questions
{
    // https://leetcode.com/problems/permutations-ii/description/

    //Given a collection of numbers that might contain duplicates, 
    //return all possible unique permutations.

    //Example:
    //Input: [1,1,2]
    //Output:
    //[
    //  [1,1,2],
    //  [1,2,1],
    //  [2,1,1]
    //]
    public class PermutationsII
    {
        public static IList<IList<int>> PermuteUnique(int[] nums)
        {
            IList<IList<int>> output = new List<IList<int>>();
            Array.Sort(nums);

            PermutationHelper(nums, new List<int>(), output, new bool[nums.Length]);

            return output;
        }

        private static void PermutationHelper(int[] nums, IList<int> chosen, 
                                              IList<IList<int>> output,
                                              bool[] used)
        {
            if (chosen.Count == nums.Length)
            {
                output.Add(new List<int>(chosen));
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (used[i] || i > 0 && nums[i] == nums[i-1] && !used[i-1])
                    {
                        continue;
                    }

                    used[i] = true;
                    chosen.Add(nums[i]);

                    PermutationHelper(nums, chosen, output, used);

                    used[i] = false;
                    chosen.RemoveAt(chosen.Count - 1);
                }
            }
        }
    }
}
