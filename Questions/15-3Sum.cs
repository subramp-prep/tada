using System;
using System.Collections.Generic;
using System.Linq;

namespace questions
{
    /// <summary>
    /// Problem URL: https://leetcode.com/problems/3sum/description/
    /// </summary>
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

        /// <summary>
        /// Froms the wiki: https://en.wikipedia.org/wiki/3SUM
        /// </summary>
        public static void fromWiki()
        { }
    }



}
