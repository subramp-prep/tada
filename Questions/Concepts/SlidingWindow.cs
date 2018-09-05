using System;
using System.Collections.Generic;

namespace questions
{
    public class SlidingWindow
    {
        public List<int> slidingWindowTemplateByHarryChaoyangHe(string s, string t)
        {
            //init a collection or int value to save the result according the question.
            List<int> result = new List<int>();
            if (t.Length > s.Length) 
                return result;

            //create a hashmap to save the Characters of the target substring.
            //(K, V) = (Character, Frequence of the Characters)
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (char c in t.ToCharArray())
            {
                map.Add(c, map.GetValueOrDefault(c, 0) + 1);
            }
            //maintain a counter to check whether match the target string.
            int counter = map.Count;//must be the map size, NOT the string size because the char may be duplicate.

            //Two Pointers: begin - left pointer of the window; end - right pointer of the window
            int begin = 0, end = 0;

            //the length of the substring which match the target string.
            // int len = int.MaxValue;

            //loop at the begining of the source string
            while (end < s.Length)
            {

                char c = s[end];//get a character

                if (map.ContainsKey(c))
                {
                    map.Add(c, map[c] - 1);// plus or minus one
                    if (map[c] == 0) counter--;//modify the counter according the requirement(different condition).
                }
                end++;

                //increase begin pointer to make it invalid/valid again
                while (counter == 0) /* counter condition. different question may have different condition */
                {

                    char tempc = s[begin];//***be careful here: choose the char at begin pointer, NOT the end pointer
                    if (map.ContainsKey(tempc))
                    {
                        map.Add(tempc, map[tempc] + 1);//plus or minus one
                        if (map[tempc] > 0) counter++;//modify the counter according the requirement(different condition).
                    }

                    /* save / update(min/max) the result if find a target*/
                    // result collections or result int value

                    begin++;
                }
            }
            return result;
        }
    }
}
