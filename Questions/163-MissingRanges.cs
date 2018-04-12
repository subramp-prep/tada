using System;
using System.Collections.Generic;

namespace questions
{
    // Question URL: https://leetcode.com/problems/missing-ranges/description/
    //Given a sorted integer array where the range of elements are in 
    //the inclusive range[lower, upper], return its missing ranges.
    //For example, given[0, 1, 3, 50, 75], lower = 0 and upper = 99, return ["2", "4->49", "51->74", "76->99"].
    public class MissingRanges
    {
        // TODO
        // Not complete for -ve integers
        public static IList<string> FindMissingRanges(int[] nums, int lower, int upper)
        {
            IList<string> output = new List<string>();

            if (nums.Length > 1)
            {
                AddRange(nums[0], lower, output);

                for (int i = 0, j = 1; j < nums.Length; i++, j++)
                {
                    AddRange(nums[i], nums[j], output);
                }

                AddRange(nums[nums.Length - 1], upper + 1, output);
            }
            else
            {
                AddRange(lower, upper, output);
            }

            return output;
        }

        private static void AddRange(int low, int high, IList<string> output)
        {
            int difference = 0;
            difference = high - low;
            if (difference > 2)
            {
                output.Add(string.Format("{0}->{1}", low+1, high-1));
            }
            else if (difference == 2)
            {
                int miss = low + 1;
                output.Add(miss.ToString());
            }
            else if(difference == 0)
            {
                output.Add(high.ToString());
            }
        }
    }
}
