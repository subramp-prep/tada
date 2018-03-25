using System;
namespace questions
{
    public class Quick
    {
        // ref Steven Skiena
        public static void Sort(int[] nums)
        {
            Sort(nums, 0, nums.Length - 1);
        }

        private static void Sort(int[] nums, int low, int high)
        {
            if (high - low > 0)
            {
                int partition = Partition(nums, low, high);

                Sort(nums, low, partition - 1);
                Sort(nums, partition + 1, high);
            }
        }

        private static int Partition(int[] nums, int low, int high)
        {
            int firstHigh = low;
            int pivot = high;

            for (int i = low; i < high; i++)
            {
                if (nums[i] < nums[pivot])
                {
                    Utils.swap(ref nums[i], ref nums[firstHigh]);
                    firstHigh++;
                }
            }

            Utils.swap(ref nums[pivot], ref nums[firstHigh]);

            return firstHigh;
        }
    }
}
