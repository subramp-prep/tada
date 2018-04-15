using System;
namespace questions
{
    // Question URL: https://leetcode.com/problems/decode-ways/description/
    //A message containing letters from A-Z is being encoded to numbers using the following mapping:
    //'A' -> 1
    //'B' -> 2
    //...
    //'Z' -> 26
    //Given an encoded message containing digits, determine the total number of ways to decode it.

    //For example,
    //Given encoded message "12", it could be decoded as "AB" (1 2) or "L" (12).

    //The number of ways decoding "12" is 2.
    public class DecodeWays
    {
        // TODO submission failed
        public static int NumDecodings(string s)
        {
            if (s.Length <= 0 || s[0] == '0' || s is null)
            {
                return 0;
            }

            int input = 0;
            int multiplier = 1;
            for (int index = s.Length - 1; index >= 0; index--)
            {
                int c = (s[index] - '0');
                input += c * multiplier;

                multiplier *= 10;
            }

            if (input <= 0)
            {
                return 0;
            }
            else if (input > 26 || input <= 10)
            {
                return 1;
            }

            return 2;
        }
    }
}
