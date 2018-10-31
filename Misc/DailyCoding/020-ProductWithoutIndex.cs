using System;
namespace Misc
{
    public class ProductWithoutIndex
    {
        public static int[] Product(int[] nums)
        {
            int[] prefix = new int[nums.Length];
            int product = 1;
            for (int index = 0; index < nums.Length; index++)
            {
                product *= nums[index];
                prefix[index] = product;
            }

            int[] suffix = new int[nums.Length];
            product = 1;
            for (int index = nums.Length - 1; index >= 0; index--)
            {
                product *= nums[index];
                suffix[index] = product;
            }

            //Array.Reverse(suffix);

            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    result[i] = suffix[i];
                }
                else if (i == nums.Length - 1)
                {
                    result[i] = prefix[i - 1];
                }
                else
                {
                    result[i] = suffix[i + 1] * prefix[i - 1];
                }
            }

            return result;
        }
    }
}
