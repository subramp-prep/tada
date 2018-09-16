using System;
using System.Collections.Generic;

namespace questions
{
    // https://leetcode.com/problems/sort-array-by-parity/description/

    //Given an array A of non-negative integers, return an array consisting 
    //of all the even elements of A, followed by all the odd elements of A.
    //You may return any answer array that satisfies this condition

    //Example 1:

    //Input: [3,1,2,4]
    //Output: [2,4,3,1]
    //The outputs [4,2,3,1], [2,4,1,3], and[4, 2, 1, 3] would also be accepted.

    //Note:

    //1 <= A.length <= 5000
    //0 <= A[i] <= 5000

    public class SortArray
    {
        // saw the answer after a couple attempts
        // similar to Q26
        public static int[] SortArrayByParity(int[] A)
        {
            for (int i = 0, j = 0; i < A.Length; i++)
            {
                if (A[i]%2 == 0)
                {
                    Utils.swap(ref A[j++], ref A[i]);
                }
            }

            return A;
        }

        //public static int[] SortArrayByParity(int[] A)
        //{
        //    Queue<int> s = new Queue<int>();

        //    for (int index = 0; index < A.Length; index++)
        //    {
        //        if (A[index]%2 != 0)
        //        {
        //            s.Enqueue(index);
        //        }
        //        else if (A[index] %2 == 0 && s.Count > 0)
        //        {
        //            Utils.swap(ref A[index], ref A[s.Dequeue()] );
        //        }
        //    }

        //    return A;
        //}
    }
}
