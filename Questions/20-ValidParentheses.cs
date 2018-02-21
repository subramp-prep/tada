using System;
using System.Collections.Generic;

namespace questions
{
    public class ValidParentheses
    {
        /// <summary>
        /// Question URL: https://leetcode.com/problems/valid-parentheses/description/
        /// </summary>
        /// <returns><c>true</c>, if valid was ised, <c>false</c> otherwise.</returns>
        /// <param name="s">S.</param>

        public static bool IsValid(string s)
        {
            Dictionary<char, char> bracesLookup = new Dictionary<char, char>();
            bracesLookup.Add('(', ')');
            bracesLookup.Add('{', '}');
            bracesLookup.Add('[', ']');

            Stack<char> validationStack = new Stack<char>();

            foreach (var element in s)
            {
                if (bracesLookup.ContainsKey(element))
                {
                    validationStack.Push(element);
                }
                else if (bracesLookup.ContainsValue(element))
                {
                    if (validationStack.Count <= 0)
                    {
                        return false;
                    }

                    char checkOpening = validationStack.Peek();
                    char checkClosing;
                    if (bracesLookup.TryGetValue(checkOpening, out checkClosing))
                    {
                        if (checkClosing == element)
                        {
                            validationStack.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            return validationStack.Count <= 0;
        }
    }
}
