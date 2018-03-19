using System;
namespace Misc
{
    public class SecondLargesInArray
    {
        public static int? DetermineElement(int[] nums)
        {
            int ?largest = null;
            int ?secondLargest = null;

            for (int i = 0; i < nums.Length; i++)
            {
                if(largest == null)
                {
                    largest = nums[i];
                }
                else if (nums[i] > largest)
                {
                    secondLargest = largest;
                    largest = nums[i];
                }
                else if (secondLargest == null)
                {
                    secondLargest = nums[i];
                }
                else if (nums[i] > secondLargest)
                {
                    secondLargest = nums[i];
                }
            }

            return secondLargest;
        }
    }
}
