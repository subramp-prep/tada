using System;
namespace questions
{
    // Question URL: https://leetcode.com/problems/add-binary/description/
    //Given two binary strings, return their sum(also a binary string).
    //For example,
    //a = "11"
    //b = "1"
    //Return "100".
    public class AddBinaryString
    {
        //TODO
        // Does not handle large numbers
        // More work required
        public static string AddBinary(string a, string b)
        {
            int num1 = Convert.ToInt32(a, 2);
            int num2 = Convert.ToInt32(b, 2);

            return IntToBinaryString(num1 + num2);
        }

        private static int BinaryStringToInt(string s)
        {
            int output = 0;
            if (s.Length < 1)
            {
                return output;
            }

            int length = s.Length - 1;
            output = s[length--] - '0';

            int multiplier = 2;
            while (length >= 0)
            {
                output += (s[length--] - '0') * multiplier;
                multiplier *= 2;
            }

            return output;
        }

        private static string IntToBinaryString(int i)
        {
            return Convert.ToString(i, 2);
        }
    }
}
