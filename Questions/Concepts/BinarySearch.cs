using System;
namespace questions
{
    // from S Skiena
    public class BinarySearch
    {
        public static int BinarySearchImpl(int[] nums, int low, int high, int key)
        {
            if (low > high)
                return -1;

            int mid = (low + high) / 2;

            if (nums[mid] == key)
                return mid;

            if (nums[mid] > key)
            {
                return BinarySearchImpl(nums, low, mid - 1, key);
            }
            else
            {
                return BinarySearchImpl(nums, mid + 1, high, key);
            }
        }
    }
}
