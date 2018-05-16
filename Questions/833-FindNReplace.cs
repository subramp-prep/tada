using System;
using System.Collections.Generic;
using System.Text;

namespace questions
{
    // https://leetcode.com/problems/find-and-replace-in-string/description/

    //To some string S, we will perform some replacement operations that replace 
    //groups of letters with new ones(not necessarily the same size).
    //Each replacement operation has 3 parameters: a starting index i, a source word 
    //x and a target word y.The rule is that if x starts at position i in the 
    //original string S, then we will replace that occurrence of x with y.  If not, we do nothing.

    //For example, if we have S = "abcd" and we have some replacement operation 
    //i = 2, x = "cd", y = "ffff", then because "cd" starts at position 2 in the 
    //original string S, we will replace it with "ffff".

    //Using another example on S = "abcd", if we have both the replacement operation 
    //i = 0, x = "ab", y = "eee", as well as another replacement operation i = 2, 
    //x = "ec", y = "ffff", this second operation does nothing because in the 
    //original string S[2] = 'c', which doesn't match x[0] = 'e'.

    //All these operations occur simultaneously.It's guaranteed that there won't be 
    //any overlap in replacement: for example, S = "abc", indexes = [0, 1], 
    //sources = ["ab", "bc"] is not a valid test case.


    //Example 1:
    //Input: S = "abcd", indexes = [0, 2], sources = ["a", "cd"], targets = ["eee", "ffff"]
    //Output: "eeebffff"
    //Explanation: "a" starts at index 0 in S, so it's replaced by "eee".
    //"cd" starts at index 2 in S, so it's replaced by "ffff".

    //Example 2:
    //Input: S = "abcd", indexes = [0, 2], sources = ["ab", "ec"], targets = ["eee", "ffff"]
    //Output: "eeecd"
    //Explanation: "ab" starts at index 0 in S, so it's replaced by "eee". 
    //"ec" doesn't starts at index 2 in the original S, so we do nothing.

    //Notes:
    //0 <= indexes.length = sources.length = targets.length <= 100
    //0 < indexes[i] < S.length <= 1000
    //All characters in given inputs are lowercase letters.
    public class FindNReplace
    {
        public static string FindReplaceString(string S, int[] indexes, string[] sources, string[] targets)
        {
            List<Tuple<int, int>> sorted = new List<Tuple<int, int>>();
            for (int i = 0; i < indexes.Length; i++)
            {
                sorted.Add(new Tuple<int, int>(indexes[i], i));
            }

            // Sort list in descending order
            sorted.Sort((a,b) => -1*a.Item1.CompareTo(b.Item1)); // <-- key to solution

            for (int i = 0; i < sorted.Count; i++)
            {
                int startIndex = sorted[i].Item1;
                string source = sources[sorted[i].Item2];
                string target = targets[sorted[i].Item2];

                if (S.Substring(startIndex, source.Length) == source)
                {
                    S = S.Substring(0, startIndex) + target + S.Substring(startIndex + source.Length);
                }
            }

            return S;
        }

        // abandonded logic below
        public static string FindReplaceString_Obs(string S, int[] indexes, string[] sources, string[] targets)
        {
            StringBuilder output = new StringBuilder();
            for (int i = indexes.Length - 1; i > 0; i--)
            {
                int startIndex = indexes[i];
                string source = sources[i];
                string target = targets[i];

                if (S.Substring(startIndex, source.Length) == source)
                {
                    if (startIndex > 0)
                    {
                        string prev = S.Substring(0, startIndex - 1);
                        string after = S.Substring(startIndex + source.Length);

                        S.Remove(startIndex, source.Length);

                        S = prev + targets[i] + after;
                    }
                    else
                    {
                        string after = S.Substring(source.Length);

                        S.Remove(0, source.Length);
                        S = targets[i] + after;
                    }
                }
            }

            return output.ToString();
        }
    }
}
