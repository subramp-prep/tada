using System;
namespace questions
{
    public class Selection
    {
        public static void Sort(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int smallestIndex = i;

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[smallestIndex])
                    {
                        smallestIndex = j;
                    }
                }

                // swap unneeded if both are the same
                if (i != smallestIndex)
                {
                    Utils.swap(ref nums[i], ref nums[smallestIndex]);
                }
            }
        }
    }
}
