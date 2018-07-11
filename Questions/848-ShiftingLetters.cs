using System;
namespace questions
{
    // https://leetcode.com/contest/weekly-contest-88/problems/shifting-letters/
    public class Shifting
    {
        // TODO
        public static string ShiftingLetters(string S, int[] shifts)
        {
            int sum = 0;
            for (int i = shifts.Length - 1; i >= 0 ; i--)
            {
                sum += shifts[i];
                shifts[i] = sum;
            }

            string O = string.Empty;
            for (int i = 0; i < S.Length && i < shifts.Length; i++)
            {
                int a = S[i] + shifts[i];
                if (a > 'a' + 25)
                {
                    // TODO
                }

            }

            return O;
        }
    }
}
