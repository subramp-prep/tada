using System;
using System.Collections.Generic;
using System.Linq;

namespace questions
{
    //Question URL: https://leetcode.com/problems/binary-trees-with-factors/description/
    //Given an array of unique integers, each integer is strictly greater than 1.
    //We make a binary tree using these integers and each number may be used for any number of times.
    //Each non-leaf node's value should be equal to the product of the values of it's children.
    //How many binary trees can we make? Return the answer modulo 10 ** 9 + 7.

    //Example 1:
    //Input: A = [2, 4]
    //Output: 3
    //Explanation: We can make these trees: [2], [4], [4, 2, 2]
    //Example 2:

    //Input: A = [2, 4, 5, 10]
    //Output: 7
    //Explanation: We can make these trees: [2], [4], [5], [10], [4, 2, 2], [10, 2, 5], [10, 5, 2].

    //Note:
    //1 <= A.length <= 1000.
    //2 <= A[i] <= 10 ^ 9.
    public class BTFactors
    {
        // TODO not complete
        public static int NumFactoredBinaryTrees(int[] A)
        {
            int count = 0;
            IList<int> chosen = new List<int>();
            NumFactoredBinaryTrees(new List<int>(A), chosen, ref count);

            return count;
        }    

        private static void NumFactoredBinaryTrees(IList<int> input, IList<int> chosen, ref int count)
        {
            if (input.Count <= 0)
            {
                foreach (var item in chosen)
                {
                    Console.Write("{0} ",item);
                }

                Console.WriteLine();
            }
            else
            {
                int c = input[0];
                input.RemoveAt(0);

                NumFactoredBinaryTrees(input, chosen, ref count);

                chosen.Add(c);

                NumFactoredBinaryTrees(input, chosen, ref count);

                input.Insert(0, c);
                chosen.RemoveAt(chosen.Count - 1);
            }
        }
    }
}
