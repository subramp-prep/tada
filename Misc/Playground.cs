using System;
using System.Collections.Generic;
using System.Linq;

namespace Misc
{
    public class Playground
    {
        public static int RemoveDuplicatesII(int[] nums)
        {
            int count = 0;
            for (int i = 2; i < nums.Length; i++)
            {
                if(nums[i] == nums[i - count - 2])
                {
                    count++;
                }
                else
                {
                    nums[i - count] = nums[i];
                }
            }

            return nums.Length - count;
        }

        public static int HammingDistance(int a, int b)
        {
            int distance = 0;
            int c = a ^ b;

            while (c > 0)
            {
                c = (c - 1) & c;
                distance++;
            }

            return distance;
        }
        
        public static int Fibonacci_DP(int n, int[] nums)
        {
            if (n < 2)
            {
                return n;
            }

            if (nums[n] != 0)
            {
                return nums[n];
            }

            nums[n] = Fibonacci_DP(n - 1, nums) + Fibonacci_DP(n - 2, nums);

            return nums[n];
        }

        public static IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> output = new List<IList<int>>();

            if (nums.Length > 0)
            {
                IList<int> chosen = new List<int>();
                PermuteHelper(nums.ToList(), chosen, output);
            }

            return output;
        }

        private static void PermuteHelper(IList<int> nums, IList<int> chosen, IList<IList<int>> output)
        {
            if (nums.Count == 0)
            {
                output.Add(new List<int>(chosen));
            }
            else
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    int c = nums[i];
                    chosen.Add(c);
                    nums.Remove(nums[i]);

                    PermuteHelper(nums, chosen, output);

                    chosen.RemoveAt(chosen.Count - 1);
                    nums.Insert(i, c);
                }
            }
        }

        public static void TowerOfHanoi(int num, char from, char to, char aux)
        {
            if(num == 1)
            {
                Console.WriteLine("Move disk 1 from rod {0} to rod {1}", from, to);
                return;
            }

            TowerOfHanoi(num - 1, from, aux, to);
            Console.WriteLine("Move disk {0} from rod {1} to rod {2}", num, from, to);

            TowerOfHanoi(num - 1, aux, to, from);
        }
    }
}
