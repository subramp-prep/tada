using System;
namespace questions
{
    //Starting with a positive integer N, we reorder the digits 
    //in any order(including the original order) such that the leading digit is not zero.

    //Return true if and only if we can do this in a way such 
    // that the resulting number is a power of 2.
     
    //Example 1:
    //Input: 1
    //Output: true

    //Example 2:
    //Input: 10
    //Output: false

    //Example 3:
    //Input: 16
    //Output: true

    //Example 4:
    //Input: 24
    //Output: false

    //Example 5:
    //Input: 46
    //Output: true

    //Note:
    //1 <= N <= 10^9
    public class ReorderPower
    {
        public static bool ReorderedPowerOf2(int N)
        {
            Console.WriteLine("3: {0}", IsPower2(3));
            Console.WriteLine("4: {0}", IsPower2(4));
            Console.WriteLine("5: {0}", IsPower2(5));
            Console.WriteLine("10: {0}", IsPower2(10));
            Console.WriteLine("8: {0}", IsPower2(8));
            Console.WriteLine("50: {0}", IsPower2(50));
            
            return false;
        }

        private static bool IsPower2(int n)
        {
            while (n > 1)
            {
                if (n > 1 && (n & 1) == 1)
                {
                    return false;
                }
                else
                {
                    n = n >> 1;
                }
            }

            return true;
        }
    }
}
