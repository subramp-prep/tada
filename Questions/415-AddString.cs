using System;
namespace questions
{
    public class AddString
    {
        // Question URL: https://leetcode.com/problems/add-strings/description/
        //Given two non-negative integers num1 and num2 represented as string, 
        //return the sum of num1 and num2.
        //Note:
        //The length of both num1 and num2 is < 5100.
        //Both num1 and num2 contains only digits 0-9.
        //Both num1 and num2 does not contain any leading zero.
        //You must not use any built-in BigInteger library or convert the inputs to integer directly.

        public static string AddStrings(string num1, string num2)
        {
            int a = num1.Length;
            int b = num2.Length;
            int c = Math.Min(a, b);

            int carry = 0;
            string output = string.Empty;
            int i = a - 1, j = b - 1;
            for (int k = c; k > 0; k--, i--, j--)
            {
                int sum = (num1[i] - '0') + (num2[j] - '0') + carry;
                int reminder = sum % 10;
                carry = sum / 10;

                output = reminder + output;
            }

            while (i >= 0)
            {
                int sum = (num1[i] - '0') + carry;
                int reminder = sum % 10;
                carry = sum / 10;

                output = reminder + output;
                i--;
            }

            while (j >= 0)
            {
                int sum = (num2[j] - '0') + carry;
                int reminder = sum % 10;
                carry = sum / 10;

                output = reminder + output;
                j--;
            }

            if(carry > 0)
                output = carry + output;

            return output;
        }
    }
}
