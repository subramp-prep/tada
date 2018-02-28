using System;
using System.Collections.Generic;

namespace questions
{
    /// <summary>
    /// Question URL: https://leetcode.com/problems/palindrome-permutation/description/
    /// Given a string, determine if a permutation of the string could form a palindrome.
    /// For example,
    //  "code" -> False, "aab" -> True, "carerac" -> True.
    /// </summary>

    public class PalindromePermutation
    {
        public static bool CanPermutePalindrome(string s)
        {
            bool isOddLength = (s.Length % 2 == 1);
            bool isEvenLength = (s.Length % 2 == 0);

            HashSet<char> checker = new HashSet<char>();
            foreach (var c in s)
            {
                if (checker.Contains(c))
                {
                    checker.Remove(c);
                }
                else
                {
                    checker.Add(c);
                }
            }

            if (isOddLength && checker.Count == 1 ||
                isEvenLength && checker.Count == 0)
            {
                return true;
            }

            return false;
        }
    }
}
