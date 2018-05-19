using System;
using System.Text;

namespace questions
{
    //https://leetcode.com/problems/custom-sort-string/description/
    //S and T are strings composed of lowercase letters.In S, no letter occurs more than once.
    //S was sorted in some custom order previously.We want to permute the characters 
    //of T so that they match the order that S was sorted.More specifically, if x occurs 
    //before y in S, then x should occur before y in the returned string.

    //Return any permutation of T (as a string) that satisfies this property.

    //Example :
    //Input: 
    //S = "cba"
    //T = "abcd"
    //Output: "cbad"
    //Explanation: 
    //"a", "b", "c" appear in S, so the order of "a", "b", "c" should be "c", "b", and "a". 
    //Since "d" does not appear in S, it can be at any position in T. "dcba", "cdba", "cbda" are also valid outputs.

    //Note:
    //S has length at most 26, and no character is repeated in S.
    //T has length at most 200.
    //S and T consist of lowercase letters only.

    public class CustomSort
    {
        public static string CustomSortString(string S, string T)
        {
            int[] count = new int[26];
            foreach(char c in T.ToCharArray()) 
            { 
                ++count[c - 'a']; 
            }  // count each char in T.

            StringBuilder sb = new StringBuilder();
            foreach (char c in S.ToCharArray())
            {
                while (count[c - 'a']-- > 0) 
                { 
                    sb.Append(c); 
                }    // sort chars both in T and S by the order of S.
            }
            for (char c = 'a'; c <= 'z'; ++c)
            {
                while (count[c - 'a']-- > 0) 
                { 
                    sb.Append(c); 
                }   // group chars in T but not in S.
            }
            return sb.ToString();
        }

        // Tried and Failed!!!!
        public static string CustomSortString_gut(string S, string T)
        {
            string output = string.Empty;
            CustomSortHelper(S, T, "", T.Length, ref output);

            return output;
        }

        private static void CustomSortHelper(string S, string T, string chosen, int comparerLength, ref string output)
        {
            if (chosen.Length == comparerLength && chosen.StartsWith(S, StringComparison.CurrentCulture))
            {
                output = chosen;
            }
            else
            {
                for (int i = 0; i < T.Length; i++)
                {
                    char c = T[i];
                    chosen += c;
                    T = T.Remove(i, 1);

                    CustomSortHelper(S, T, chosen, comparerLength, ref output);

                    T = T.Insert(i, c.ToString());
                    chosen = chosen.Remove(chosen.Length - 1);
                }
            }
        }
    }
}
