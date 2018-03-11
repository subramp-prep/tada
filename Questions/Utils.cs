using System;
using System.Collections.Generic;

namespace questions
{
    public class Utils
    {
        public static void swap(ref int a, ref int b)
        {
            int temp = 0;

            temp = a;
            a = b;
            b = temp;
        }

        public static bool ValidParanthesisCombination(string paranthesis)
		{
			if (paranthesis.EndsWith('(') || paranthesis.StartsWith(')'))
			{
				return false;
			}

			Stack<char> validateParanthesis = new Stack<char>();
			foreach (var element in paranthesis)
			{
				if (element == '(')
				{
					validateParanthesis.Push(element);
				}
				else
				{
					if (validateParanthesis.Count > 0)
					{
						validateParanthesis.Pop();
					}
				}
			}

			return validateParanthesis.Count <= 0;
		}

        public static int countSetBits(int n)
        {
            int count = 0;
            while (n > 0)
            {
                count += n & 1;
                n >>= 1;
            }
            return count;
        }
	}
}
