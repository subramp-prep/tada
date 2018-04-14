using System;
namespace questions
{
    //Question URL:https://leetcode.com/problems/rotate-string/description/
    //We are given two strings, A and B.
    //A shift on A consists of taking string A and moving the leftmost character to the rightmost position.
    //For example, if A = 'abcde', then it will be 'bcdea' after one shift on A.
    //Return True if and only if A can become B after some number of shifts on A.

    //Example 1:
    //Input: A = 'abcde', B = 'cdeab'
    //Output: true

    //Example 2:
    //Input: A = 'abcde', B = 'abced'
    //Output: false
    //Note:

    //A and B will have length at most 100.
    public class Rotate
    {
        public static bool String(string A, string B)
        {
            if (A.Length != B.Length)
            {
                // no rotation possible
                return false;
            }

            if (string.Compare(A, B) == 0)
            {
                return true;
            }

            int count = 0;
            while (count < A.Length)
            {
                char c = A[0];
                A = A.Remove(0, 1);
                A = A + c.ToString();

                if (string.Compare(A, B) == 0)
                {
                    return true;
                }

                count++;
            }

            return false;
        }
    }
}
