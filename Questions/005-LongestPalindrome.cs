using System;
namespace questions
{
    // https://leetcode.com/problems/longest-palindromic-substring/description/
    //Given a string s, find the longest palindromic substring in s.
    //You may assume that the maximum length of s is 1000.

    //Example 1:

    //Input: "babad"
    //Output: "bab"
    //Note: "aba" is also a valid answer.
    //Example 2:

    //Input: "cbbd"
    //Output: "bb"
    public class Longest
    {
        // O(pow(n, 2)
        // TODO time limit exceeded on submission
        public static string LongestPalindrome(string s)
        {
            string longestPalindrome = string.Empty;
            int longestLength = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j <= s.Length; j++)
                {
                    string substr = s.Substring(i, j - i);
                    Console.WriteLine("String: {0} Result: {1}", substr, IsPalindrome(substr));

                    if (IsPalindrome(substr) && longestLength < Math.Max(longestLength, substr.Length))
                    {
                        longestLength = Math.Max(longestLength, substr.Length);
                        Console.WriteLine("Longest string is {0} Length {1}", substr, substr.Length);
                        longestPalindrome = substr;
                    }
                }
            }

            return longestPalindrome;
        }

        public static bool IsPalindrome(string s)
        {
            if (s.Length <= 1)
            {
                return false;
            }

            int low = 0;
            int high = s.Length - 1;

            while (low < high)
            {
                if (char.ToLower(s[low++]) != char.ToLower(s[high--]))
                {
                    return false;
                }
            }

            return true;
        }


        public static string LongestPalindrome_DP(string s)
        {
            bool[,] table = new bool[s.Length, s.Length];
            int n = s.Length;
            int maxBegin = 0;
            int maxLen = 1;

            for (int i = 0; i < s.Length; i++)
            {
                table[i, i] = true;
            }

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i+1])
                {
                    table[i, i + 1] = true;
                    maxBegin = i;
                    maxLen = 2;
                }
            }

            for (int len = 3; len <= n; len++)
            {
                for (int i = 0; i < n - len + 1; i++)
                {
                    int j = i + len - 1;
                    if (s[i] == s[j] && table[i + 1,j - 1])
                    {
                        table[i,j] = true;
                        maxBegin = i;
                        maxLen = len;
                    }
                }
            }

            return s.Substring(maxBegin, maxLen);
        }
    }
}
