using System;
using System.Collections.Generic;

namespace questions
{
    // https://leetcode.com/problems/backspace-string-compare/description/

    //Given two strings S and T, return if they are equal when both are typed 
    //into empty text editors. # means a backspace character.

    //Example 1:
    //Input: S = "ab#c", T = "ad#c"
    //Output: true
    //Explanation: Both S and T become "ac".

    //Example 2:
    //Input: S = "ab##", T = "c#d#"
    //Output: true
    //Explanation: Both S and T become "".

    //Example 3:
    //Input: S = "a##c", T = "#a#c"
    //Output: true
    //Explanation: Both S and T become "c".

    //Example 4:
    //Input: S = "a#c", T = "b"
    //Output: false
    //Explanation: S becomes "c" while T becomes "b".
     

    //Note:
    //1 <= S.length <= 200
    //1 <= T.length <= 200
    //S and T only contain lowercase letters and '#' characters.
    public class BackspaceStringCompare
    {
        public static bool BackspaceCompare(string S, string T)
        {
            string s1 = Process(S);
            string s2 = Process(T);

            return s1 == s2;
        }

        private static string Process(string s)
        {
            Stack<char> c = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (c.Count > 0 && s[i] == '#')
                {
                    c.Pop();
                }
                else if(s[i] != '#')
                {
                    c.Push(s[i]);
                }
            }

            string output = string.Empty;
            while (c.Count > 0)
            {
                output = c.Pop() + output;
            }

            return output;
        }
    }
}
