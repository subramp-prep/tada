using System;
using System.Collections.Generic;
using System.Linq;

namespace questions
{
    // Question URL https://leetcode.com/problems/count-and-say/description/
    //The count-and-say sequence is the sequence of integers with the first five terms as following:
    //1.     1
    //2.     11
    //3.     21
    //4.     1211
    //5.     111221
    //1 is read off as "one 1" or 11.
    //11 is read off as "two 1s" or 21.
    //21 is read off as "one 2, then one 1" or 1211.
    //Given an integer n, generate the nth term of the count-and-say sequence.

    //Note: Each term of the sequence of integers will be represented as a string.

    //Example 1:

    //Input: 1
    //Output: "1"
    //Example 2:

    //Input: 4
    //Output: "1211"
    public class CountAndSay
    {
        public static string Perform(int n)
        {
            int[] counter = new int[10];
            while (n > 0)
            {
                int mod = n % 10;
                counter[mod] += 1;

                n /= 10;
            }

            string output = string.Empty;
            for (int index = 9; index >= 0; index--)
            {
                if (counter[index] > 0)
                {
                    output += string.Format("{0}{1}", counter[index], index);
                }
            }

            return output;
        }

        // Implementation from EPI
        public static string LookAnSay_EPI(int n)
        {
            string s = "1";
            for (int index = 1; index < n; index++)
            {
                s = NextNumber(s);
            }

            return s;
        }

        private static string NextNumber(string s)
        {
            string output = string.Empty;
            for (int index = 0; index < s.Length; index++)
            {
                int count = 1;
                while (index + 1 < s.Length && s[index] == s[index + 1])
                {
                    ++index; ++count;
                }

                output += count.ToString() + s[index];
            }

            Console.WriteLine(output);
            return output;
        }
    }
}
