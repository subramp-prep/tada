using System;
using System.Text;

namespace Misc
{
    public class AddSub
    {
        // add(add(4, 5), sub(2, add(1,1)))

        public int output;

        public static int Evaluate(string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var c in input)
            {
                if (c == ' ')
                {
                    continue;
                }

                sb.Append(c);
            }

            return Parse(sb.ToString());
        }

        private static int Parse(string input)
        {

            string op = input.Substring(0, 3);

            int a = GetNumBetween(input, '(', ',');
            int b = GetNumBetween(input, ',', ')');

            return Evaluate(op, a, b);
        }

        private static int GetNumBetween(string input, char startC, char endC)
        {
            int start = 0, end = 0;

            while (input[start] != startC)
            {
                start++;
            }

            end = start++;
            while (input[end] != endC)
            {
                end++;
            }

            string num = input.Substring(start, end - start).Trim();

            return int.Parse(num);
        }

        private static int Evaluate(string op, int a, int b)
        {
            if (op == "add")
            {
                return a + b;
            }
            else if (op == "sub")
            {
                return a - b;
            }

            return -1;
        }
    }
}
