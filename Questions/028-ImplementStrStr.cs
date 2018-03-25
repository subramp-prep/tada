using System;
namespace questions
{
    // Question URL: https://leetcode.com/problems/implement-strstr/description/
    //Implement strStr().
    //Return the index of the first occurrence of needle in haystack, 
    //or -1 if needle is not part of haystack.
    //Example 1:
    //Input: haystack = "hello", needle = "ll"
    //Output: 2
    //Example 2:
    //Input: haystack = "aaaaa", needle = "bba"
    //Output: -1
    public class ImplementStrStr
    {
        public static int strStr(string haystack, string needle)
        {
            if (needle.Length <= 0)
            {
                return 0;
            }

            if (haystack.Length < needle.Length)
            {
                return -1;
            }

            int needleIndex = 0;
            int matchCount = 0;
            int? matchStartIndex = null;

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[needleIndex] && 
                   (haystack.Length - i >= needle.Length)) // <-- Important step
                {
                    for (int j = i; j < haystack.Length; j++)
                    {
                        if (haystack[j] != needle[needleIndex])
                            break;
                            
                        if (matchStartIndex == null)
                        {
                            matchStartIndex = j;
                        }

                        matchCount++;
                        needleIndex++;
                        if (matchCount == needle.Length)
                        {
                            return matchStartIndex.Value;
                        }
                    }

                    matchStartIndex = null;
                    needleIndex = 0;
                    matchCount = 0;
                }
            }

            return -1;
        }
    }
}
