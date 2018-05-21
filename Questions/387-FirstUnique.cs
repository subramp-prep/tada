using System;
using System.Collections.Generic;

namespace questions
{
    //https://leetcode.com/problems/first-unique-character-in-a-string/description/
    //Given a string, find the first non-repeating character in it and return 
    //it's index. If it doesn't exist, return -1.

    //Examples:
    //s = "leetcode"
    //return 0.

    //s = "loveleetcode",
    //return 2.
    //Note: You may assume the string contain only lowercase letters.
    public class FirstUnique
    {
        public static int FirstUniqChar(string s)
        {
            int[] chars = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                chars[s[i] - 'a'] += 1;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (chars[s[i] - 'a'] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
