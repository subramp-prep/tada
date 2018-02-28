using System;
using System.Collections.Generic;

namespace questions
{
    /// <summary>
    /// Question URL: https://leetcode.com/problems/valid-anagram/description/
    /// 
    /// Given two strings s and t, write a function to determine if t is an anagram of s.
    //    For example,
    //    s = "anagram", t = "nagaram", return true.
    //    s = "rat", t = "car", return false.
    //Note:
    //You may assume the string contains only lowercase alphabets.
    //Follow up:
    //What if the inputs contain unicode characters? How would you adapt your solution to such case?
    /// </summary>

    public class ValidAnagram
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            Dictionary<char, int> validator = new Dictionary<char, int>();
            foreach (var elem in s)
            {
                int counter;
                if(!validator.TryGetValue(elem, out counter))
                {
                    validator.Add(elem, 1);
                }
                else
                {
                    validator[elem] += 1;
                }
            }

            foreach (var elem in t)
            {
                int reducer;
                if(validator.TryGetValue(elem, out reducer))
                {
                    reducer--;

                    if (reducer <= 0)
                    {
                        validator.Remove(elem);
                    }
                    else
                    {
                        validator[elem] = reducer;
                    }
                }
            }

            return (validator.Count == 0);
        }
    }
}
