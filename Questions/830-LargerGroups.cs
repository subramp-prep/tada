using System;
using System.Collections.Generic;

namespace questions
{
    // https://leetcode.com/problems/positions-of-large-groups/description/
    //In a string S of lowercase letters, these letters form consecutive groups of the same character.
    //For example, a string like S = "abbxxxxzyy" has the groups "a", "bb", "xxxx", "z" and "yy".
    //Call a group large if it has 3 or more characters.We would like the starting 
    //and ending positions of every large group.

    //The final answer should be in lexicographic order.
    //Example 1:

    //Input: "abbxxxxzzy"
    //Output: [[3,6]]
    //Explanation: "xxxx" is the single large group with starting  3 and ending positions 6.
    //Example 2:

    //Input: "abc"
    //Output: []
    //    Explanation: We have "a","b" and "c" but no large group.
    //    Example 3:
    //Input: "abcdddeeeeaabbbcd"
    //Output: [[3,5], [6,9], [12,14]]
     
    //Note:  1 <= S.length <= 1000
    public class LargerGroups
    {
        public static IList<IList<int>> LargeGroupPositions(string S)
        {
            IList<IList<int>> output = new List<IList<int>>();

            for (int i = 0; i < S.Length; )
            {
                int j = i + 1;
                int count = 1;
                while (j < S.Length && S[j] == S[i])
                {
                    ++j;
                    ++count;
                }

                if (count >= 3)
                {
                    IList<int> combination = new List<int>();
                    combination.Add(i);
                    combination.Add(i + count - 1);

                    output.Add(combination);
                }

                i = j;
            }

            return output;
        }
    }
}
