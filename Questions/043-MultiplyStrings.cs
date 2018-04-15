using System;
using System.Collections.Generic;
using System.Numerics;

namespace questions
{
    // Question URL: https://leetcode.com/problems/multiply-strings/description/
    //Given two non-negative integers num1 and num2 represented as strings, 
    //return the product of num1 and num2, also represented as a string.

    //Example 1:

    //Input: num1 = "2", num2 = "3"
    //Output: "6"
    //Example 2:

    //Input: num1 = "123", num2 = "456"
    //Output: "56088"
    //Note:

    //The length of both num1 and num2 is < 110.
    //Both num1 and num2 contain only digits 0-9.
    //Both num1 and num2 do not contain any leading zero, except the number 0 itself.
    //You must not use any built-in BigInteger library or convert the inputs to integer directly.
    public class MultiplyStrings
    {
        public static string Multiply(string num1, string num2)
        {
            string output = string.Empty;
            List<BigInteger> productLines = new List<BigInteger>();

            ulong lineItem = 1;
            for (int index2 = num2.Length - 1; index2 >= 0; index2--)
            {
                BigInteger carry = 0;
                BigInteger tens = lineItem;
                BigInteger lineNumber = 0;

                for (int index1 = num1.Length - 1; index1 >= 0; index1--)
                {
                    BigInteger prodVal = ((BigInteger)num1[index1] - '0') * ((BigInteger)num2[index2] - '0');
                    BigInteger product = prodVal + carry;
                    carry = product / 10;

                    BigInteger remainder = 0;
                    remainder = product % 10;

                    lineNumber = (tens * remainder + lineNumber);
                    tens *= 10;
                }

                productLines.Add(tens * carry + lineNumber);
                lineItem *= 10;
            }

            BigInteger sumOfProductlines = 0;
            foreach (var line in productLines)
            {
                sumOfProductlines += line;
            }

            output = string.Format("{0}", sumOfProductlines);

            return output;
        }
    }
}
