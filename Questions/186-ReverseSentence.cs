using System;
namespace questions
{
    // https://leetcode.com/problems/reverse-words-in-a-string-ii/description/
    //Given an input string, reverse the string word by word.
    //A word is defined as a sequence of non-space characters.

    //The input string does not contain leading or trailing spaces 
    //and the words are always separated by a single space.

    //For example,
    //Given s = "the sky is blue",
    //return "blue is sky the".

    //Could you do it in-place without allocating extra space?
    public class ReverseSentence
    {
        public static void ReverseWords(char[] s)
        {
            ReverseWord(s, 0, s.Length - 1);

            int? startIndex = null;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ' && startIndex == null)
                {
                    startIndex = i;
                }
                else if (s[i] == ' ' && startIndex.HasValue)
                {
                    ReverseWord(s, startIndex.Value, i - 1);
                    startIndex = null;
                }
                else if (i == s.Length - 1 && s[i] != ' ')
                {
                    ReverseWord(s, startIndex.Value, i);
                }
            }
        }

        private static void ReverseWord(char[] s, int low, int high)
        {
            while (low < high)
            {
                swap(ref s[low++], ref s[high--]);
            }
        }

        private static void swap(ref char a, ref char b)
        {
            char temp = a;
            a = b;
            b = temp;
        }
    }
}
