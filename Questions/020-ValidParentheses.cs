using System;
using System.Collections.Generic;

namespace questions
{
    //Question URL: https://leetcode.com/problems/valid-parentheses/description/
    //Given a string containing just the characters '(', ')', '{', '}', '[' and ']', 
    //determine if the input string is valid.
    //An input string is valid if:
    //Open brackets must be closed by the same type of brackets.
    //Open brackets must be closed in the correct order.
    //Note that an empty string is also considered valid.

    //Example 1:

    //Input: "()"
    //Output: true
    //Example 2:

    //Input: "()[]{}"
    //Output: true
    //Example 3:

    //Input: "(]"
    //Output: false
    //Example 4:

    //Input: "([)]"
    //Output: false
    //Example 5:

    //Input: "{[]}"
    //Output: true
    public class ValidParentheses
    {
        public static bool IsValid_Optimum(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var c in s)
            {
                switch (c)
                {
                    case '(':
                        stack.Push(')');
                        break;

                    case '[':
                        stack.Push(']');
                        break;

                    case '{':
                        stack.Push('}');
                        break;

                    default:

                        // NOTE: the order of the if block
                        // matters to get the count and return
                        if (stack.Count == 0)
                            return false;
                        else if (stack.Pop() != c)
                            return false;
                        break;
                }
            }

            return stack.Count == 0;
        }

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
