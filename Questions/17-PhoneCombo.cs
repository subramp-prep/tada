using System;
using System.Collections.Generic;

namespace questions
{
    public class PhoneCombo
    {
        /// <summary>
        /// Question URL: https://leetcode.com/problems/letter-combinations-of-a-phone-number/description/
        /// </summary>

        private static string[] representation = {
            "",
            "",
            "abc",
            "def",
            "ghi",
            "jkl",
            "mno",
            "pqrs",
            "tuv",
            "wxyz"
        };

        public static IList<string> LetterCombinations(string digits)
        {
            string[] digitRepresentation = new string[digits.Length];
            for (int index = 0; index < digits.Length; index++)
            {
                digitRepresentation[index] = representation[digits[index] - '0'];
            }

            return Perform(digitRepresentation);
        }

        private static IList<string> Perform(string[] digits)
        {
            List<string> combinations = new List<string>();

            PerformHelper(digits, "", combinations);

            return combinations;
        }

        private static void PerformHelper(string[] digits, string combo, List<string> combinations)
        {
            if (combo.Length == digits.Length)
            {
                combinations.Add(combo);
            }
            else
            {
                // choose -> explore -> unchoose
            }
        }
    }
}
