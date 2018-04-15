using System;
using System.Collections.Generic;

namespace questions
{
    // Question URL: https://leetcode.com/problems/integer-to-roman/description/
    //Given an integer, convert it to a roman numeral.
    //Input is guaranteed to be within the range from 1 to 3999.
    class IntegerToRoman
    {
        Dictionary<int, string> _lookups = new Dictionary<int, string>();

        public void Intialize()
        {
            _lookups.Add(1, "I");
            _lookups.Add(4, "IV");
            _lookups.Add(5, "V");
            _lookups.Add(9, "IX");
            _lookups.Add(10, "X");
            _lookups.Add(40, "XL");
            _lookups.Add(50, "L");
        }

        public string GetRoman_Brute(int num)
        {
            if (num == 0)
                return "";

            string final = "";

            int carry = 0;
            int remainder = 0;

            //while(carry > 0)
            {
                carry = num / 50;
                remainder = num % 50;
            }

            for (int index = 0; index < carry; index++)
            {
                final += _lookups[10];
            }

            if (remainder >= 1 && remainder < 4)
            {
                // between 1 - 3 
                for (int index = 1; index <= remainder; index++)
                {
                    final += _lookups[1];
                }
            }
            else if (remainder == 4)
            {
                final += _lookups[4];
            }
            else if (remainder == 5)
            {
                final += _lookups[5];
            }

            else if (remainder > 5 && remainder < 9)
            {
                final += _lookups[5];

                // between 6 - 8 
                for (int index = 6; index < remainder; index++)
                {
                    final += _lookups[1];
                }
            }
            else if (remainder == 9)
            {
                final += _lookups[9];
            }

            return final;
        }

        public static string GetRoman_Optimum(int num)
        {
            string[] M = { "", "M", "MM", "MMM" };
            string[] C = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] L = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "LC" };
            string[] X = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            return M[num / 1000] + C[(num % 1000) / 100] + L[(num % 1000) % 100 / 10] + X[(num % 1000) % 100 % 10];
        }
    }
}