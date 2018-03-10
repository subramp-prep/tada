using System.Collections.Generic;

namespace questions
{
    // Question URL: https://leetcode.com/problems/roman-to-integer/description/
    //Given a roman numeral, convert it to an integer.
    //Input is guaranteed to be within the range from 1 to 3999.
    public class RomanToInteger
    {
        public static int Perform(string roman)
        {
            int number = 0;

            for (int index = roman.Length - 1; index >= 0; index--)
            {
                switch (roman[index])
                {
                    case 'I':
                        if (number >= 10)
                        {
                            number = 9;
                        }
                        else if (number >= 5)
                        {
                            number = 4;
                        }
                        else
                        {
                            number += 1;
                        }
                        break;

                    case 'V':
                        number += 5;
                        break;

                    case 'X':

                        if (number >= 100)
                        {
                            number -= 10;
                        }
                        else if (number >= 50)
                        {
                            number -= 10;
                        }
                        else
                        {
                            number += 10;
                        }
                        break;

                    case 'L':
                        number += 50;
                        break;

                    case 'C':
                        if (number >= 1000)
                        {
                            number -= 100;
                        }
                        else if (number >= 500)
                        {
                            number -= 100;
                        }
                        else
                        {
                            number += 100;
                        }
                        break;

                    case 'D':
                        number += 500;
                        break;

                    case 'M':
                        number += 1000;
                        break;

                    default:
                        return -1;
                }
            }

            return number;
        }


        /// <summary>
        /// The below code although looks a lot optimum, based on
        /// leetcode's submission, this is slower than the above logiv=c
        /// </summary>
        /// <returns>The optimum.</returns>
        /// <param name="roman">Roman.</param>
        public static int Perform_Optimum(string roman)
        {
            Dictionary<char, int> _lookup = new Dictionary<char, int>();
            _lookup.Add('I', 1);
            _lookup.Add('V', 5);
            _lookup.Add('X', 10);
            _lookup.Add('L', 50);
            _lookup.Add('C', 100);
            _lookup.Add('D', 500);
            _lookup.Add('M', 1000);


            if (roman.Length == 1)
            {
                return _lookup[roman[0]];
            }

            int number = 0;
            int prevNumber = 0;
            for (int index = roman.Length - 1; index >= 0; index--)
            {
                if (prevNumber > _lookup[roman[index]])
                {
                    number -= _lookup[roman[index]];
                }
                else
                {
                    number += _lookup[roman[index]];
                }
                prevNumber = _lookup[roman[index]]; // <--- AAHA moment
            } 

            return number;
        }
    }
}
