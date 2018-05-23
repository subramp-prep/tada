using System;
using System.Collections.Generic;
using System.Linq;

namespace questions
{
    // Question URL: https://leetcode.com/problems/subsets/description/
    //Given a set of distinct integers, nums, return all possible subsets(the power set).
    //Note: The solution set must not contain duplicate subsets.
    //For example,
    //If nums = [1, 2, 3], a solution is:
    //[
    //  [3],
    //  [1],
    //  [2],
    //  [1,2,3],
    //  [1,3],
    //  [2,3],
    //  [1,2],
    //  []
    //]
    public class Subsets
    {
        public static IList<IList<int>> Perform(int[] nums)
        {
            IList<IList<int>> output = new List<IList<int>>();

            Array.Sort(nums);
            List<int> chosen = new List<int>();
            SubsetHelper(nums, chosen, output, 0);

            return output;
        }

        private static void SubsetHelper(int[] nums, List<int> chosen, IList<IList<int>> output, int start)
        {
            output.Add(new List<int>(chosen));

            for (int i = start; i < nums.Length; i++)
            {
                chosen.Add(nums[i]);
                SubsetHelper(nums, chosen, output, i + 1);
                chosen.RemoveAt(chosen.Count - 1);
            }
        }

        private static void SubsetHelper_gut(List<int> input, List<int> chosen, IList<IList<int>> output)
        {
            if (input.Count <= 0)
            {
                foreach (var element in chosen)
                {
                    Console.Write("{0}\t", element);
                }
                Console.WriteLine();

                output.Add(new List<int>(chosen));
            }
            else
            {
                int c = input[0];
                input.RemoveAt(0);

                SubsetHelper_gut(input, chosen, output);

                chosen.Add(c);
                SubsetHelper_gut(input, chosen, output);

                chosen.RemoveAt(chosen.Count() - 1);
                input.Insert(0, c);
            }
        }
    }
}
