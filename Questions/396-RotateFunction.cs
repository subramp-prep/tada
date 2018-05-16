using System;
namespace questions
{
    //https://leetcode.com/problems/rotate-function/description/
    //Given an array of integers A and let n to be its length.
    //Assume Bk to be an array obtained by rotating the array A k 
    //positions clock-wise, we define a "rotation function" F on A as follow:

    //F(k) = 0 * Bk[0] + 1 * Bk[1] + ... + (n-1) * Bk[n - 1].

    //Calculate the maximum value of F(0), F(1), ..., F(n-1).

    //Note:
    //n is guaranteed to be less than 105.

    //Example:

    //A = [4, 3, 2, 6]

    //F(0) = (0 * 4) + (1 * 3) + (2 * 2) + (3 * 6) = 0 + 3 + 4 + 18 = 25
    //F(1) = (0 * 6) + (1 * 4) + (2 * 3) + (3 * 2) = 0 + 4 + 6 + 6 = 16
    //F(2) = (0 * 2) + (1 * 6) + (2 * 4) + (3 * 3) = 0 + 6 + 8 + 9 = 23
    //F(3) = (0 * 3) + (1 * 2) + (2 * 6) + (3 * 4) = 0 + 2 + 12 + 12 = 26

    //So the maximum value of F(0), F(1), F(2), F(3) is F(3) = 26.
    public class RotateFunction
    {
        // TODO optimization required 
        // Hint DP
        public static int MaxRotateFunction(int[] A)
        {
            if (A.Length < 1)
            {
                return 0;
            }

            int maxRotateSum = int.MinValue;

            for (int i = 0; i < A.Length; i++)
            {
                RotateArray(A, i);

                int sum = 0;
                for (int j = 0; j < A.Length; j++)
                {
                    sum += A[j] * j;
                }

                maxRotateSum = Math.Max(sum, maxRotateSum);
            }

            return maxRotateSum;
        }

        private static void RotateArray(int[] nums, int k)
        {
            k %= nums.Length;

            SwapElements(nums, 0, nums.Length - 1);
            SwapElements(nums, 0, k-1);
            SwapElements(nums, k, nums.Length - 1);
        }

        private static void SwapElements(int[] nums, int low, int high)
        {
            while (low < high)
            {
                Swap(ref nums[low++], ref nums[high--]);
            }
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
