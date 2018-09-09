using System;
using System.Collections.Generic;

namespace questions
{
    // https://leetcode.com/problems/permutation-in-string/description/
    //Given two strings s1 and s2, write a function to return true if s2 contains 
    //the permutation of s1. In other words, one of the first string's permutations 
    // is the substring of the second string.

    //Example 1:
    //Input:s1 = "ab" s2 = "eidbaooo"
    //Output:True
    //Explanation: s2 contains one permutation of s1 ("ba").

    //Example 2:
    //Input:s1= "ab" s2 = "eidboaoo"
    //Output: False

    //Note:
    //The input strings only contain lower case letters.
    //The length of both given strings is in range[1, 10, 000].
    public class PermutationString
    {
        public static bool CheckInclusion(string s1, string s2)
        {
            if (s1.Length > s2.Length)
                return false;

            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (char c in s1.ToCharArray())
            {
                if (map.GetValueOrDefault(c, 0) == 0)
                {
                    map.Add(c, 1);
                }
                else
                {
                    map[c] += 1;
                }
            }
            int counter = map.Count;
            int begin = 0, end = 0;

            while (end < s2.Length)
            {
                char c = s2[end];
                if (map.ContainsKey(c))
                {
                    map[c] -= 1;
                    if (map[c] == 0)
                    {
                        counter--;
                    }
                }

                end++;

                while (counter == 0)
                {
                    char tempc = s2[begin];
                    if (map.ContainsKey(tempc))
                    {
                        map[tempc] += 1;
                        if (map[tempc] > 0)
                        {
                            counter++;
                        }
                    }
                    if (end - begin == s1.Length)
                    {
                        return true;
                    }
                    begin++;
                }

            }
            return false;
        }
    }
}
