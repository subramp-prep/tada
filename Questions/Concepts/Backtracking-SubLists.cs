using System;
using System.Collections.Generic;

namespace questions
{
    // from an array of strings, we need to print all 
    // combinations unique in nature
    // {"Red", "Green"} => {}, {"Red" "Green"}, {"Red"}, {"Greeen"}
    //
    // video URL: https://www.youtube.com/watch?v=WshpHyZIWRE
    public class Backtracking_SubLists
    {
        public static void Sublists(IList<string> input)
        {
            IList<string> chosen = new List<string>();
            SubListsHelper(input, chosen);
        }

        private static void SubListsHelper(IList<string> input, IList<string> chosen)
        {
            if (input.Count <= 0)
            {
                // base case
                foreach (var element in chosen)
                {
                    Console.Write("{0}\t", element);
                }
                Console.WriteLine();
            }
            else
            {
                // recursive case
                string s = input[0];
                input.RemoveAt(0);

                // choose/explore without s
                SubListsHelper(input, chosen);

                // choose/explore with s
                chosen.Add(s);
                SubListsHelper(input, chosen);

                // unchoose
                input.Insert(0, s);
                chosen.RemoveAt(chosen.Count - 1);
            }
        }
    }
}
