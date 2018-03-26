using System;
using System.Diagnostics;

namespace questions
{
    public class Bubble
    {
        public static void Sort(int[] nums)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if(nums[j] < nums[j-1])
                    {
                        Utils.swap(ref nums[j], ref nums[j-1]);
                    }
                }
            }
            stopwatch.Stop();

            Console.WriteLine("Sort Time Taken: {0}", stopwatch.ElapsedTicks);
        }

        public static void Sort_Optimum(int[] nums)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            bool elementSwap = true;
            for (int i = 0; i < nums.Length && elementSwap; i++)
            {
                elementSwap = false;
                for (int j = 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[j - 1])
                    {
                        elementSwap = true;
                        Utils.swap(ref nums[j], ref nums[j - 1]);
                    }
                }
            }
            stopwatch.Stop();

            Console.WriteLine("Sort_Optimum Time Taken: {0}", stopwatch.ElapsedTicks);
        }
    }
}
