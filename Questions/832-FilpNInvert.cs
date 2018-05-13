using System;
namespace questions
{
    public class FilpNInvert
    {
        public static int[][] FlipAndInvertImage(int[][] A)
        {
            int rows = A.GetLength(0);
            
            for (int i = 0; i < rows; i++)
            {
                Flip(A[i]);
                Invert(A[i]);
            }

            return A;
        }

        private static void Flip(int[] nums)
        {
            int low = 0;
            int high = nums.Length - 1;
            while (low < high)
            {
                Utils.swap(ref nums[low++], ref nums[high--]);
            }
        }

        private static void Invert(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] ^= 1;
            }
        }
    }
}
