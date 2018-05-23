using System;
using System.Collections.Generic;
using System.Linq;

namespace questions
{
    // Question URL: https://leetcode.com/problems/combination-sum/description/
    //Given a set of candidate numbers(C) (without duplicates) and a target number(T), 
    //find all unique combinations in C where the candidate numbers sums to T.
    //The same repeated number may be chosen from C unlimited number of times.
    //Note:
    //All numbers (including target) will be positive integers.
    //The solution set must not contain duplicate combinations.
    //For example, given candidate set[2, 3, 6, 7] and target 7,
    //A solution set is: 
    //[
    //  [7],
    //[2, 2, 3]
    //]
    partial class CombinationSum
    {
        public static IList<IList<int>> CombinationSumI(int[] candidates, int target)
        {
            IList<IList<int>> output = new List<IList<int>>();

            if (candidates.Length > 0 && target > 0)
            {
                //List<int> source = new List<int>(candidates);
                Array.Sort(candidates);

                CombinationSumHelperI(output, new List<int>(), candidates, target, 0);
            }

            return output;
        }

        private static void CombinationSumHelperI(IList<IList<int>> output, 
                                                  IList<int> chosen, 
                                                  int[] nums, int remain, int start)
        {
            if (remain < 0)
            {
                return;
            }
            else if(remain == 0)
            {
                output.Add( new List<int>(chosen));
            }
            else
            {
                for (int i = start; i < nums.Length; i++)
                {
                    chosen.Add(nums[i]);
                    CombinationSumHelperI(output, chosen, nums, remain - nums[i], i);
                    chosen.RemoveAt(chosen.Count - 1);
                }
            }
        }


        // TODO need to remove duplicates
        private static void CombinationSumHelperI_Gut(List<int> source, 
                                                  List<int> sourceImmutable, int sum, 
                                                  List<int> chosen, IList<IList<int>> output)
        {
            if (source.Count <= 0)
            {
                if (chosen.Sum() == sum)
                {
                    if (!output.Contains(chosen))
                        output.Add(new List<int>(chosen));
                }
                else if (sourceImmutable.Contains(sum - chosen.Sum()))
                {
                    var temp = new List<int>(chosen);
                    temp.Add(sum - chosen.Sum());
                    if(!output.Contains(temp))
                        output.Add(temp);
                }
            }
            else
            {
                int c = source[0];
                source.RemoveAt(0);

                CombinationSumHelperI_Gut(source, sourceImmutable, sum, chosen, output);

                chosen.Add(c);
                CombinationSumHelperI_Gut(source, sourceImmutable, sum, chosen, output);

                chosen.RemoveAt(chosen.Count() - 1);
                source.Insert(0, c);
            }
        }
    }
}
