using System;
using System.Collections.Generic;
using System.Text;

namespace questions
{
    public class PhoneCombo
    {
        /// <summary>
        /// Question URL: https://leetcode.com/problems/letter-combinations-of-a-phone-number/description/
        /// </summary>

        private static string[] keyboard = {
            "",     //0
            "",     //1 
            "abc",  //2
            "def",  //3 
            "ghi",  //4
            "jkl",  //5
            "mno",  //6
            "pqrs", //7
            "tuv",  //8
            "wxyz"  //9
        };

        public static IList<string> LetterCombinations(string digits)
        {
            IList<string> combinations = new List<string>();

            var builder = new StringBuilder();
            Perform(digits, 0, builder, combinations);

            return combinations;
        }

        private static void Perform(string input, int scanIndex, StringBuilder chosen, IList<string> combinations)
        {
            if (chosen.Length == input.Length)
            {
                if (chosen.Length > 0)
                    combinations.Add(chosen.ToString());
            }
            else
            {
                var keyboardIndex = input[scanIndex] - '0';
                var letters = keyboard[keyboardIndex];

                // choose -> explore -> unchoose
                for (int index = 0; index < letters.Length; index++)
                {
                    char c = letters[index];
                    chosen.Append(c);

                    Perform(input, scanIndex + 1, chosen, combinations);

                    chosen.Remove(chosen.Length - 1, 1);
                }
            }
        }
    }
}
