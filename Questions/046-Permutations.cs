using System.Collections.Generic;
using System.Linq;

namespace questions
{
	/// <summary>
	/// Question URL https://leetcode.com/problems/permutations
	/// </summary>
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
