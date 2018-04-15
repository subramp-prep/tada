using System;
using System.Collections.Generic;
using System.Linq;

namespace questions
{
    // Question URL: https://leetcode.com/problems/generate-parentheses/description/
    //Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.
    //For example, given n = 3, a solution set is:
    //[
    //  "((()))",
    //  "(()())",
    //  "(())()",
    //  "()(())",
    //  "()()()"
    //]
    public class GenerateCombination
    {
        private static string _paranthesis = "()";

        public static IList<string> GenerateParenthesis(int n)
        {
            string paranthesis = string.Empty;
            for (int index = 0; index < n; index++)
            {
                paranthesis += _paranthesis;
            }

            HashSet<string> combinations = new HashSet<string>();

            //Permute(paranthesis, "", combinations);

            backtrack(combinations, "", 0, 0, n);

            return combinations.ToList();
        }


        private static void Permute(string paranthesis, string chosen, HashSet<string> combinations)
        {
            #region My Implementaton
            if (paranthesis.Length == 0)
            {
                if (!combinations.Contains(chosen) && Utils.ValidParanthesisCombination(chosen))
                {
                    combinations.Add(chosen);
                }
            }
            else
            {
                for (int index = 0; index < paranthesis.Length; index++)
                {
                    char c = paranthesis[index];
                    chosen += c;
                    paranthesis = paranthesis.Remove(index, 1);

                    if (chosen.StartsWith(')'))
                        continue;

                    Permute(paranthesis, chosen, combinations);

                    chosen = chosen.Remove(chosen.Length - 1);
                    paranthesis = paranthesis.Insert(index, c.ToString());
                }
            }
            #endregion
        }


        /// <summary>
        /// Backtrack the specified ans, cur, open, close and max. From Leetcode
        /// </summary>
        /// <returns>The backtrack.</returns>
        /// <param name="ans">Ans.</param>
        /// <param name="cur">Current.</param>
        /// <param name="open">Open.</param>
        /// <param name="close">Close.</param>
        /// <param name="max">Max.</param>
        public static void backtrack(HashSet<string> ans, string cur, int open, int close, int max)
        {
            if (cur.Length == max * 2)
            {
                ans.Add(cur);
            }
            else
            {
                if (open < max)
                    backtrack(ans, cur + "(", open + 1, close, max);

                if (close < open)
                    backtrack(ans, cur + ")", open, close + 1, max);
            }
        }
    }
}