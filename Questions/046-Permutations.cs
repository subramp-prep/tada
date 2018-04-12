using System.Collections.Generic;
using System.Linq;

namespace questions
{
	// Question URL https://leetcode.com/problems/permutations
    // Given a collection of distinct numbers, return all possible permutations.
    // For example,
    // [1, 2, 3] have the following permutations:
    //  [
    //    [1,2,3],
    //    [1,3,2],
    //    [2,1,3],
    //    [2,3,1],
    //    [3,1,2],
    //    [3,2,1]
    //  ]
	public class Permutations
    {
        public static IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> output = new List<IList<int>>();

            List<int> chosen = new List<int>();
            PermuteHelper(nums.ToList(), chosen, output);
            return output;
        }

        private static void PermuteHelper(List<int> input, List<int> chosen, IList<IList<int>> output)
        {
            if (input.Count == 0)
            {
                output.Add(chosen.ToArray());
            }
            else
            {
                for (int index = 0; index < input.Count(); index++)
                {
                    //choose
                    int c = input[index];
                    chosen.Add(c);
                    input.Remove(input[index]);

                    //explore
                    PermuteHelper(input, chosen, output);

                    //unchoose
                    chosen.RemoveAt(chosen.Count() - 1);
                    input.Insert(index, c);
                }
            }
        }
    }
}
