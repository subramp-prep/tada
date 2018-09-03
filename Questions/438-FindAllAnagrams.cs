using System;
using System.Collections.Generic;
using System.Linq;

namespace questions
{
    
    // Question URL: https://leetcode.com/problems/find-all-anagrams-in-a-string/description/
    // 
    // Given a string s and a non-empty string p, find all the start indices of p's anagrams in s.
    //  Strings consists of lowercase English letters only and the length of both strings s and p will not be larger than 20,100.
    // The order of output does not matter.
    //Example 1:

    //Input:
    //s: "cbaebabacd" p: "abc"

    //Output:
    //[0, 6]

    //Explanation:
    //The substring with start index = 0 is "cba", which is an anagram of "abc".
    //The substring with start index = 6 is "bac", which is an anagram of "abc".
    //Example 2:

    //Input:
    //s: "abab" p: "ab"

    //Output:
    //[0, 1, 2]

    //    Explanation:
    //The substring with start index = 0 is "ab", which is an anagram of "ab".
    //The substring with start index = 1 is "ba", which is an anagram of "ab".
    //The substring with start index = 2 is "ab", which is an anagram of "ab".

    public class FindAllAnagrams
    {
        // similar to 
        // Q76 https://leetcode.com/problems/minimum-window-substring/description/
        // Sliding window problem

        public static IList<int> FindAnagrams(string s, string p)
        {
            IList<int> indices = new List<int>();

            Dictionary<char, int> map = new Dictionary<char, int>();

            foreach (char c in p.ToCharArray())
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

                    //if (end - begin < len)
                    if(end - begin == p.Length)
                    {
                        indices.Add(begin);
                    }
                    begin++;
                }

            }

            return indices;
        }

        //public static IList<int> FindAnagrams(string s, string p)
        //{
        //    IList<int> indices = new List<int>();

        //    if (s == null || s.Length <= 0)
        //    {
        //        return indices;
        //    }

        //    if (p.Length > s.Length)
        //    {
        //        return indices;
        //    }

        //    Dictionary<char, int> pElements = new Dictionary<char, int>();
        //    foreach (var element in p)
        //    {
        //        int count = 0;
        //        if (!pElements.TryGetValue(element, out count))
        //        {
        //            pElements.Add(element, 1);
        //        }
        //        else
        //        {
        //            pElements[element] += 1;
        //        }
        //    }

        //    for (int index = 0; index <= s.Length - p.Length; index++)
        //    {
        //        string substring = s.Substring(index, p.Length);

        //        bool identical = true;
        //        Dictionary<char, int> subElements = new Dictionary<char, int>(pElements);
        //        foreach (var subelement in substring)
        //        {
        //            int foundElement;
        //            if (!subElements.TryGetValue(subelement, out foundElement))
        //            {
        //                identical = false;
        //                break;
        //            }

        //            subElements[subelement] -= 1;
        //            if (subElements[subelement] <= 0)
        //            {
        //                subElements.Remove(subelement);
        //            }
        //        }

        //        if (identical && subElements.Count <= 0)
        //        {
        //            indices.Add(index);
        //        }

        //    }

        //    return indices;

        //    #region Initial approach in the above for loop
        //    //char[] temp_sorted = temp.ToCharArray();
        //    //Array.Sort(temp_sorted);

        //    //bool identical = true;
        //    //for (int verifyIndex = 0; verifyIndex < p.Length; verifyIndex++)
        //    //{
        //    //    if (temp_sorted[verifyIndex] != p_sorted[verifyIndex])
        //    //    {
        //    //        identical = false;
        //    //    }
        //    //}

        //    //if (identical)
        //    //{
        //    //    indices.Add(index);
        //    //}
        //    #endregion
        //}

        //public static IList<int> FindAnagramsOptimum(string s, string p)
        //{
        //    IList<int> indices = new List<int>();

        //    if (s == null || s.Length <= 0)
        //    {
        //        return indices;
        //    }

        //    if (p.Length > s.Length)
        //    {
        //        return indices;
        //    }

        //    int[] pArray = new int[p.Length];
        //    int[] sArray = new int[p.Length];
        //    for (int index = 0; index < p.Length; index++)
        //    {
        //        pArray[p[index]-'a'] += 1;
        //    }

        //    for (int index = 0; index <= s.Length - p.Length; index++)
        //    {
        //        sArray[s[index] - 'a'] += 1;
        //    }

        //    return indices;
        //}

        //public static IList<int> FindAangramsOnline(string input, string pattern)
        //{
        //    IList<int> list = new List<int>();
        //    if (input == null || pattern == null || input.Length < pattern.Length) return list;
        //    int[] chars = new int[256];
        //    foreach (char c in pattern)
        //    {
        //        chars[c]++;
        //    }
        //    int start = 0; int end = 0; int count = pattern.Length;
        //    while (end < input.Length)
        //    {
        //        //move right everytime, if the character exists in p's hash, decrease the count
        //        //current hash value >= 1 means the character is existing in p
        //        if (chars[input.ElementAt(end)] >= 1)
        //        {
        //            count--;
        //        }
        //        chars[input.ElementAt(end)]--;
        //        end++;
        //        //when the count is down to 0, means we found the right anagram
        //        //then add window's left to result list
        //        if (count == 0)
        //        {
        //            list.Add(start);
        //        }
        //        //if we find the window's size equals to p, then we have to move left (narrow the window) to find the new match window
        //        //++ to reset the hash because we kicked out the left
        //        //only increase the count if the character is in p
        //        //the count >= 0 indicate it was original in the hash, cuz it won't go below 0
        //        if (end - start == pattern.Length)
        //        {
        //            if (chars[input.ElementAt(start)] >= 0)
        //            {
        //                count++;
        //            }
        //            chars[input.ElementAt(start)]++;
        //            start++;
        //        }
        //    }
        //    return list;
        //}
    }
}
