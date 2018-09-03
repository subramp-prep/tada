using System;
using System.Collections.Generic;

namespace questions
{
    // https://leetcode.com/problems/minimum-window-substring/description/

    //Given a string S and a string T, find the minimum window in S 
    //which will contain all the characters in T in complexity O(n).

    //Example:
    //Input: S = "ADOBECODEBANC", T = "ABC"
    //Output: "BANC"
    //Note:

    //If there is no such window in S that covers all characters in T, return the empty string "".
    //If there is such window, you are guaranteed that there will always be only one unique minimum window in S.
    public class MinWindowSubstring
    {
        // Sliding window problem

        public static string MinWindow(string s, string t)
        {
            if (t.Length > s.Length) 
                return "";

            Dictionary<char, int> map = new Dictionary<char, int>();

            foreach (char c in t.ToCharArray())
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
            int head = 0;
            int len = int.MaxValue;

            while (end < s.Length)
            {
                char c = s[end];
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
                    char tempc = s[begin];
                    if (map.ContainsKey(tempc))
                    {
                        map[tempc] += 1;
                        if (map[tempc] > 0)
                        {
                            counter++;
                        }
                    }
                    if (end - begin < len)
                    {
                        len = end - begin;
                        head = begin;
                    }
                    begin++;
                }

            }
            if (len == int.MaxValue) return "";
            return s.Substring(head, len);
        }
    }
}
