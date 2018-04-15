using System;
using System.Collections.Generic;
using System.Linq;

namespace questions
{
    // Question URL: https://leetcode.com/problems/group-anagrams
    //Given an array of strings, group anagrams together.
    //Example:
    //Input: ["eat", "tea", "tan", "ate", "nat", "bat"],
    //Output:
    //[
    //  ["ate","eat","tea"],
    //  ["nat","tan"],
    //  ["bat"]
    //]
    //Note:
    //All inputs will be in lowercase.
    //The order of your output does not matter.
    public class GroupAnagrams
    {
        public static IList<IList<string>> groupAnagrams(string[] strs)
        {
            IList<IList<string>> output = new List<IList<string>>();
            IDictionary<string, List<string>> combinations = new Dictionary<string, List<string>>();
            foreach (var str in strs)
            {
                char[] strArray = str.ToCharArray();
                Array.Sort(strArray); // TODO implement custom sort

                string buildKey = string.Empty;
                foreach (var item in strArray)
                {
                    buildKey += item;
                }

                List<string> values = null;
                if (!combinations.TryGetValue(buildKey, out values))
                {
                    values = new List<string>();
                    combinations.Add(buildKey, values);
                }
                values.Add(str);
            }

            foreach (var combination in combinations)
            {
                output.Add(combination.Value);
            }

            return output;
        }
    }
}
