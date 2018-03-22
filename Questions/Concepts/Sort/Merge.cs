using System;
using System.Collections.Generic;

namespace questions
{
    public class Merge
    {
        public static void Sort(int[] nums)
        {
            Sort(nums, 0, nums.Length - 1);
        }

        private static void Sort(int[] nums, int lo, int hi)
        {
            if (lo < hi)
            {
                int mid = (lo + hi) / 2;
                Sort(nums, lo,  mid);
                Sort(nums, mid + 1, hi);

                MergeSortHelper(nums, lo, mid, hi);
            }
        }

        private static void MergeSortHelper(int[] nums, int lo, int mid, int hi)
        {
            Queue<int> lowQ = new Queue<int>();
            for (int index = lo; index <= mid; index++)
            {
                lowQ.Enqueue(nums[index]);
            }

            Queue<int> highQ = new Queue<int>();
            for (int index = mid + 1; index <= hi; index++)
            {
                highQ.Enqueue(nums[index]);
            }

            int active = lo;
            while (lowQ.Count > 0 && highQ.Count > 0)
            {
                if (lowQ.Peek() >= highQ.Peek())
                {
                    nums[active++] = highQ.Dequeue();
                }
                else
                {
                    nums[active++] = lowQ.Dequeue();
                }
            }

            while (lowQ.Count > 0)
                nums[active++] = lowQ.Dequeue();
            

            while (highQ.Count > 0)
                nums[active++] = highQ.Dequeue();
        }
    }
}
