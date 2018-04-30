using System;
using System.Collections.Generic;

namespace questions
{
    public class ContiguousArray
    {
        // Question URL: https://leetcode.com/problems/contiguous-array/description/
        //Given a binary array, find the maximum length of a contiguous subarray with equal number of 0 and 1
        //Example 1:
        //Input: [0,1]
        //        Output: 2
        //Explanation: [0, 1] is the longest contiguous subarray with equal number of 0 and 1.
        //Example 2:
        //Input: [0,1,0]
        //        Output: 2
        //Explanation: [0, 1] (or[1, 0]) is a longest contiguous subarray with equal number of 0 and 1.

        // WARNING Wrong solution.... didnt understand it right
        public static int FindMaxLength(int[] nums)
        {
            int maxLength = 0;
            Stack<int> stack = new Stack<int>();

            for (int index = 0; index < nums.Length; index++)
            {
                if (stack.Count > 0)
                {
                    var ops = stack.Peek() ^ nums[index];
                    if(ops == 0)
                    {
                        stack.Push(nums[index]);
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    stack.Push(nums[index]);
                }
            }

            return maxLength;
        }

        // TODO learn from the below soltuion
        // GREAT solution from Discussions section
        // INTERESTING
        public static int FindMaxLength_Correect(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            map.Add(0, -1);

            int zeroCount = 0;
            int oneCount = 0;
            int len = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zeroCount++;
                }
                else
                {
                    oneCount++;
                }

                int tempValue;
                if (map.TryGetValue(zeroCount - oneCount, out tempValue))
                {
                    len = Math.Max(len, i - map[zeroCount - oneCount]);
                }
                else
                {
                    map.Add(zeroCount - oneCount, i);
                }
            }

            return len;
        }
    }
}
