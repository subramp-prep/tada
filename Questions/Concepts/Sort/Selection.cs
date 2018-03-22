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
                    if (nums[smallestIndex] > nums[j])
                    {
                        smallestIndex = j;
                    }
                }

                Utils.swap(ref nums[i], ref nums[smallestIndex]);
            }
        }
    }
}
