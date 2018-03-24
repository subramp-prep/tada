using System;
namespace questions
{
    public class Power
    {
        // Question URL: https://leetcode.com/problems/powx-n/description/
        //Implement pow(x, n).
        //Example 1:

        //Input: 2.00000, 10
        //Output: 1024.00000
        //Example 2:

        //Input: 2.10000, 3
        //Output: 9.26100

        public static double MyPow(double x, int n)
        {
            if (n == 0)
                return 1;

            if (n == 1)
                return x;

            if (n == 2)
                return x * x;

            if (n < 0)
            {
                n = -n;
                x = 1 /x;
            }

            if (n%2 == 0)
            {
                return MyPow(x*x, n / 2);
            }
            else
            {
                return x * MyPow(x*x, n / 2);
            }
        }

        // Efficient algo from EPI
        public static double MyPow_EPI(double x, int y)
        {
            long power = y;
            double result = 1.0;

            if(y < 0)
            {
                x = 1 / x;
                power = -power;
            }

            while (power > 0)
            {
                if ((power & 1) == 1)
                {
                    result *= x;
                }

                x *= x;
                power >>= 1;
            }

            return result;
        }
    }
}
