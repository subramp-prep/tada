using System;
namespace questions
{
    // Question URL: https://leetcode.com/problems/number-of-1-bits/description/
    //Write a function that takes an unsigned integer and returns the number 
    //of ’1' bits it has (also known as the Hamming weight).

    //For example, the 32-bit integer ’11' has binary representation 
    //00000000000000000000000000001011, so the function should return 3.
    public class NumberOfBits
    {
        public static int HammingWeight(uint n)
        {
            uint count = 0;

            while (n > 0)
            {
                count = count + (n & 1);
                n = n >> 1;
            }

            return (int)count;
        }
    }
}
