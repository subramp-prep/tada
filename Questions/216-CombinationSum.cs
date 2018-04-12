using System;
using System.Collections.Generic;
using System.Linq;

namespace questions
{
    // Question URL: https://leetcode.com/problems/combination-sum-iii/description/
    //Find all possible combinations of k numbers that add up to a number n, 
    //given that only numbers from 1 to 9 can be used and each combination
    //should be a unique set of numbers.

    //Example 1:
    //Input: k = 3, n = 7
    //Output:
    //[[1,2,4]]

    //Example 2:
    //Input: k = 3, n = 9
    //Output:
    //[[1,2,6], [1,3,5], [2,3,4]]

    partial class CombinationSum
    {
        public static IList<IList<int>> CombinationSum3(int k, int n)
        {
            IList<IList<int>> output = new List<IList<int>>();

            if (k > 0 && n > 0)
            {
                List<int> chosen = new List<int>();
                int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                IList<int> numbers = new List<int>(nums);

                IList<string> interOutput = new List<string>();
                CombinationHelper(n, k, nums.ToList(), chosen, interOutput);

                foreach (var inter in interOutput)
                {
                    IList<int> permutation = new List<int>();
                    foreach (var c in inter)
                    {
                        permutation.Add(int.Parse(c.ToString()));
                    }

                    output.Add(permutation);
                }
            }

            return output;
        }

        private static void CombinationHelper(int count, int sum, 
                                              IList<int> nums, 
                                              List<int> chosen, 
                                              IList<string> output)
        {
            if (chosen.Count() > count)
            {
                return;
            }

            if (count == chosen.Count && chosen.Sum() == sum)
            {
                chosen.Sort();

                string s = string.Empty;
                foreach (var item in chosen)
                {
                    s += item.ToString();
                }

                if(!output.Contains(s))
                    output.Add(s);
            }
            else
            {
                //choose -> explore -> unchoose
                for (int i = 0; i < nums.Count; i++)
                {
                    int num = nums[i];
                    chosen.Add(num);
                    nums.RemoveAt(i);

                    CombinationHelper(count, sum, nums, chosen, output);

                    nums.Insert(i, num);
                    chosen.Remove(num);
                }
            }
        }
    }
}
