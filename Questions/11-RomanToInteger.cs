namespace questions
{
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
    }
}
