using System;
using System.Collections.Generic;

namespace questions
{
    public class Backtracking_StringPermutations
    {
        /// <summary>
        /// Ref: https://www.youtube.com/watch?v=78t_yHuGg-0
        /// </summary>
        /// <returns>The permute.</returns>
        /// <param name="s">S.</param>

        public static void Permute(string s)
        {
            HashSet<string> set = new HashSet<string>();

            PermuteHelper(s, "", set);
        }

        private static void PermuteHelper(string s, string chosen)
        {
            if (s.Length == 0)
            {
                Console.WriteLine(chosen);
            }
            else
            {
                // Step1 Choose
                // Step2 Explore
                // Step3 Unchoose
                for (int index = 0; index < s.Length; index++)
                {
                    // chooose
                    char c = s[index];
                    chosen += c;
                    s = s.Remove(index, 1);

                    // explore
                    PermuteHelper(s, chosen);

                    //unchoose
                    s = s.Insert(index, c.ToString());
                    chosen = chosen.Remove(chosen.Length - 1);
                }
            }
        }

        private static void PermuteHelper(string s, string chosen, HashSet<string> set)
        {
            if (s.Length == 0)
            {
                if (!set.Contains(chosen))
                {
                    set.Add(chosen);
                    Console.WriteLine(chosen);
                }
            }
            else
            {
                // Step1 Choose
                // Step2 Explore
                // Step3 Unchoose
                for (int index = 0; index < s.Length; index++)
                {
                    // chooose
                    char c = s[index];
                    chosen += c;
                    s = s.Remove(index, 1);

                    // explore
                    PermuteHelper(s, chosen);

                    //unchoose
                    s = s.Insert(index, c.ToString());
                    chosen = chosen.Remove(chosen.Length - 1);
                }
            }
        }
    }
}
