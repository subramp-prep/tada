using System;
using System.Collections.Generic;
using System.Text;

namespace questions
{
    public class FindNReplace
    {
        public static string FindReplaceString(string S, int[] indexes, string[] sources, string[] targets)
        {
            List<Tuple<int, int>> sorted = new List<Tuple<int, int>>();
            for (int i = 0; i < indexes.Length; i++)
            {
                sorted.Add(new Tuple<int, int>(indexes[i], i));
            }

            // Sort list in descending order
            sorted.Sort((a,b) => -1*a.Item1.CompareTo(b.Item1)); // <-- key to solution

            for (int i = 0; i < sorted.Count; i++)
            {
                int startIndex = sorted[i].Item1;
                string source = sources[sorted[i].Item2];
                string target = targets[sorted[i].Item2];

                if (S.Substring(startIndex, source.Length) == source)
                {
                    S = S.Substring(0, startIndex) + target + S.Substring(startIndex + source.Length);
                }
            }

            return S;
        }

        // abandonded logic below
        public static string FindReplaceString_Obs(string S, int[] indexes, string[] sources, string[] targets)
        {
            StringBuilder output = new StringBuilder();
            for (int i = indexes.Length - 1; i > 0; i--)
            {
                int startIndex = indexes[i];
                string source = sources[i];
                string target = targets[i];

                if (S.Substring(startIndex, source.Length) == source)
                {
                    if (startIndex > 0)
                    {
                        string prev = S.Substring(0, startIndex - 1);
                        string after = S.Substring(startIndex + source.Length);

                        S.Remove(startIndex, source.Length);

                        S = prev + targets[i] + after;
                    }
                    else
                    {
                        string after = S.Substring(source.Length);

                        S.Remove(0, source.Length);
                        S = targets[i] + after;
                    }
                }
            }

            return output.ToString();
        }
    }
}
