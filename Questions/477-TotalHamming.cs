using System;
using System.Collections.Generic;

namespace questions
{
    public class TotalHamming
    {
        //Question URL: https://leetcode.com/problems/total-hamming-distance/description/
        //The Hamming distance between two integers is the number of 
        //positions at which the corresponding bits are different.
        //Now your job is to find the total Hamming distance between all pairs of the given numbers.
        //Example:
        //Input: 4, 14, 2
        //Output: 6
        //Explanation: In binary representation, the 4 is 0100, 14 is 1110, and 2 is 0010 (just
        //showing the four bits relevant in this case). So the answer will be:
        //HammingDistance(4, 14) + HammingDistance(4, 2) + HammingDistance(14, 2) = 2 + 2 + 2 = 6.
        //Note:
        //Elements of the given array are in the range of 0 to 10^9
        //Length of the array will not exceed 10^4.

        // TODO time exceeded on submission
        public static int TotalHammingDistance(int[] nums)
        {
            int distance = 0;
            List<int[]> combinations = new List<int[]>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    combinations.Add(new int [] {nums[i], nums[j]});
                }
            }

            foreach (var combination in combinations)
            {
                distance += CalculateDistance(combination[0], combination[1]);
            }

            return distance;
        }

        private static int CalculateDistance(int x, int y)
        {
            int distance = 0;
            int n = x ^ y;

            while (n > 0)
            {
                distance++;
                n &= n - 1;
            }

            return distance;
        }
    }
}
