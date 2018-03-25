using System;
namespace questions
{
    public class DecodeWays
    {
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
