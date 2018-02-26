using System;
namespace questions
{
    public class ValidPalindrome
    {
        /// <summary>
        /// https://leetcode.com/problems/valid-palindrome/description/
        /// Perform was not accepted, since the time complexity was too high for 475th of 476 input
        /// </summary>
        /// <returns>The peform.</returns>
        /// <param name="content">Content.</param>

        public static bool Peform(string content)
        {
            string filteredString = FilteredString(content);
            for (int lIndex = 0, hIndex = filteredString.Length - 1; lIndex < filteredString.Length / 2; 
                 lIndex++, hIndex--)
            {
                if (filteredString[lIndex] != filteredString[hIndex])
                    return false;
            }

            return true;
        }

        public static string FilteredString(string s)
        {
            string filteredString = "";

            for (int index = 0; index < s.Length; index++)
            {
                if (char.IsLetterOrDigit(s[index]))
                {
                    filteredString += s[index];
                }
            }
            return filteredString.ToLower();
        }


        /// <summary>
        /// This is an optimal solution. The submission was accepted!
        /// </summary>
        /// <returns><c>true</c>, if optimal was performed, <c>false</c> otherwise.</returns>
        /// <param name="content">Content.</param>
        public bool PerformOptimal(string content)
        {
            int lIndex = 0;
            int hIndex = content.Length - 1;

			//better comparison than checking for half
			while (lIndex < hIndex) 
            {
                if (!char.IsLetterOrDigit(content[lIndex]))
                {
                    lIndex++;
                }
                else if (!char.IsLetterOrDigit(content[hIndex]))
                {
                    hIndex--;
                }
                else
                {
                    if (char.ToLower(content[lIndex]) != char.ToLower(content[hIndex]))
                    {
                        return false;
                    }

                    lIndex++;
                    hIndex--;
                }
            }

            return true;
        }
    }
}
