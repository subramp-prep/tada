using System;
using System.Collections.Generic;

namespace questions
{
    // Question URL: https://leetcode.com/problems/longest-substring-without-repeating-characters/description/
    //Given a string, find the length of the longest substring without repeating characters.
    //Examples:
    //Given "abcabcbb", the answer is "abc", which the length is 3.
    //Given "bbbbb", the answer is "b", with the length of 1.
    //Given "pwwkew", the answer is "wke", with the length of 3. Note 
    //that the answer must be a substring, "pwke" is a subsequence and not a substring.
    public class SubstringWithoutRepeating
    {
        public static int LengthOfLongestSubstring(string s)
        {
            IList<int> substrings = new List<int>();
            string temp = string.Empty;

            for (int index = 0; index < s.Length; index++)
            {
                if (!temp.Contains(s[index].ToString()))
                {
                    temp += s[index];
                }
                else
                {
                    substrings.Add(temp.Length);

                    int foundIndex = temp.IndexOf(s[index]);
                    if (foundIndex >= temp.Length)
                    {
                        temp = string.Empty;
                    }
                    else
                    {
                        temp = temp.Substring(foundIndex + 1);
                        temp += s[index];
                    }
                }
            }

            substrings.Add(temp.Length);

            int longest = 0;
            foreach (var substring in substrings)
            {
                if (longest < substring)
                {
                    longest = substring;
                }
            }

            return longest;
        }
    }
}
