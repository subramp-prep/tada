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

            List<int> chosen = new List<int>();
            SubsetHelper(nums.ToList(), chosen, output);

            return output;
        }

        private static void SubsetHelper(List<int> input, List<int> chosen, IList<IList<int>> output)
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

                SubsetHelper(input, chosen, output);

                chosen.Add(c);
                SubsetHelper(input, chosen, output);

                chosen.RemoveAt(chosen.Count() - 1);
                input.Insert(0, c);
            }
        }
    }
}
