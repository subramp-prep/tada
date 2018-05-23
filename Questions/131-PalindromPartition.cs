using System;
using System.Collections.Generic;

namespace questions
{
    // https://leetcode.com/problems/palindrome-partitioning/description/
    //Given a string s, partition s such that every substring 
    //of the partition is a palindrome.
    //Return all possible palindrome partitioning of s.

    //Example:
    //Input: "aab"
    //Output:
    //[
    //  ["aa","b"],
    //  ["a","a","b"]
    //]

    // Compute all palindromic decompositions of a given string. For example
    // if s is "02024451881", then the decomposition 
    //"020"
    //"44"
    //"5"
    //"1881"
    // is palindromic, as is 
    // "020"
     //"44"
     //"5"
     //"1"
     //"88"
     //"1"
     //However,, "02044", "5","1881" is not a palindromic decomposition
    public class Palindromic
    {
        public static IList<IList<string>> Partition(string s)
        {
            IList<IList<string>> output = new List<IList<string>>();

            List<string> path = new List<string>();
            dfs(0, s, path, output);

            return output;
        }

        private static void dfs(int index, string s, List<string> path, IList<IList<string>> output)
        {
            if (index == s.Length)
            {
                output.Add(path.ToArray());
            }
            else
            {
                for (int i = index; i < s.Length; i++)
                {
                    if (IsPalindrome(s, index, i))
                    {
                        path.Add(s.Substring(index, i - index + 1));
                        dfs(i+1, s, path, output);
                        path.RemoveAt(path.Count-1);
                    }
                }
            }
        }

        private static bool IsPalindrome(string s, int low, int high)
        {
            while (low < high)
            {
                if (s[low++] != s[high--])
                {
                    return false;
                }
            }

            return true;
        }

        //private static void DecompositionHelper(string s, int begin, string chosen, IList<IList<string>> output)
        //{
        //    if (s.Length == begin)
        //    {
        //        Console.WriteLine(chosen);
        //    }
        //    else
        //    {
        //        for (int index = begin + 1; index <= s.Length; index++)
        //        {
        //            // chooose
        //            string prefix = s.Substring(begin, index - begin);

        //            if (IsPalindrome(prefix))
        //            {
        //                Console.WriteLine(prefix);

        //                // explore
        //                DecompositionHelper(s, index, chosen, output);
        //            }

        //            //unchoose
        //            //s = s.Insert(index, c.ToString());
        //            //chosen = chosen.Remove(chosen.Length - 1);
        //        }
        //    }
        //}


    }
}
