using System;
using System.Collections.Generic;
using System.Linq;

namespace questions
{
	/// <summary>
	/// Question URL https://leetcode.com/problems/count-and-say/description/
	/// </summary>
	public class CountAndSay
    {
        /// <summary>
        /// Note: Didnt go well!!! 
        /// Question was not really understandable
        /// </summary>
        /// <returns>The perform.</returns>
        /// <param name="n">N.</param>

        public static string  Perform(int n)
		{
            int[] counter = new int[10];
            while (n > 0)
            {
                int mod = n % 10;
                counter[mod] += 1;

                n /= 10;
            }

            string output = string.Empty;
            for (int index = 9; index >=0; index--)
            {
                if (counter[index] > 0)
                {
                    output += string.Format("{0}{1}", counter[index], index);
                }
            }

            return output;
		}
    }
}
