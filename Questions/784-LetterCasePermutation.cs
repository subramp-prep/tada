using System;
using System.Collections.Generic;
using System.Text;

namespace questions
{
    // Question URL: https://leetcode.com/problems/letter-case-permutation/description/
    //Given a string S, we can transform every letter individually to be lowercase or uppercase to create another string.  
    //Return a list of all possible strings we could create.
    //Examples:
    //Input: S = "a1b2"
    //Output: ["a1b2", "a1B2", "A1b2", "A1B2"]
    //Input: S = "3z4"
    //Output: ["3z4", "3Z4"]
    //Input: S = "12345"
    //Output: ["12345"]
    //Note:
    //S will be a string with length at most 12.
    //S will consist only of letters or digits.

    public class LetterCasePermutation
    {
        public static IList<string> LetterPermutation(string S)
        {
            IList<string> output = new List<string>();
            var chosen = new StringBuilder();

            PermuteHelper(S, 0, chosen, output);

            return output;
        }

        private static void PermuteHelper(string input, int scanIndex, StringBuilder chosen, IList<string> output)
        {
            if (input.Length == chosen.Length)
            {
                output.Add(chosen.ToString());
            }
            else
            {
                char letter = input[scanIndex];
                string lu = letter.ToString();
                if (char.IsLetter(letter))
                {
                    lu = char.IsLower(letter) ?
                             letter.ToString() + char.ToUpper(letter) :
                             letter.ToString() + char.ToLower(letter);
                }

                for (int index = 0; index < lu.Length; index++)
                {
                    char c = lu[index];
                    chosen.Append(c);

                    PermuteHelper(input, scanIndex + 1, chosen, output);

                    chosen.Remove(chosen.Length - 1, 1);
                }
            }
        }
    }
}
