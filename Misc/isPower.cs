using System;
namespace Misc
{
    //Given a positive integer which fits in a 32 bit signed integer, 
    //find if it can be expressed as A^P where P > 1 and A > 0. A and P 
    // both should be integers.
    //
    // Input : 4
    // Output : True  
    // as 2^2 = 4. 
    public class isPower
    {
        public static bool IsPower(int A)
        {
            if (A == 1) return true;

            for (int power = 2; power < A && power < int.MaxValue / power; power++)
            {
                int tempPower = power;

                while (tempPower < A && tempPower < int.MaxValue / power)
                {
                    tempPower *= power;
                    if (tempPower == A)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
