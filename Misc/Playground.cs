using System;
using System.Collections.Generic;
using System.Linq;

namespace Misc
{
    public class Playground
    {
        public static void RandomizeArray(int[] nums)
        {
            Random random = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                int rand = random.Next(nums.Length-1);
                swap(ref nums[i], ref nums[rand]);
            }
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            IDictionary<int, int> elements = new Dictionary<int, int>();
            int[] output = null;

            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];

                if (elements.ContainsKey(diff))
                {
                    output = new int[2];
                    output[0] = elements[diff];
                    output[1] = i;

                    break;
                }
                else
                {
                    if(!elements.ContainsKey(nums[i]))
                        elements.Add(nums[i], i);
                }
            }

            return output;
        }

        public static void RotateArray(int[] nums, int k)
        {
            k %= nums.Length;

            Reverse(nums, 0, nums.Length-1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, nums.Length - 1);
        }

        private static void Reverse(int[] nums, int low, int high)
        {
            while (low < high)
            {
                swap(ref nums[low++], ref nums[high--]);
            }
        }

        public static void ReverseSentence(char[] s)
        {
            Reverse(s, 0, s.Length - 1);

            int ?startIndex = null;
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] != ' ' && startIndex == null)
                {
                    startIndex = i;
                }
                else if (s[i] == ' ' && startIndex.HasValue)
                {
                    Reverse(s, startIndex.Value, i - 1);
                    startIndex = null;
                }
                else if (i == s.Length -1 && s[i] != ' ')
                {
                    Reverse(s, startIndex.Value, i);
                }
            }
        }

        private static void Reverse(char[] s, int low, int high)
        {
            while (low < high)
            {
                swap(ref s[low++], ref s[high--]);
            }
        }

        private static void swap(ref char a, ref char b)
        {
            char temp = a;
            a = b;
            b = temp;
        }

        public static void RotateMatrix(int[,] nums)
        {
            int row = nums.GetLength(0);
            int column = nums.GetLength(1);

            for (int i = 0; i < row/2; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    swap(ref nums[i, j], ref nums[row - 1 - i, j]);
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = i; j < column; j++) // <-- Important assignment j=i
                {
                    swap(ref nums[i,j], ref nums[j,i]);
                }
            }
        }

        public static int FirstFactorial(int num)
        {
            int result = 1;
            for (int i = num; i > 1; i--)
            {
                result *= i;
            }

            return result;
        }

        public static int KthSmallest(int[,] matrix, int k)
        {
            int n = (int)Math.Sqrt(matrix.Length);

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine(matrix[j, i]);
                    if (++count == k)
                    {
                        return matrix[j, i];
                    }
                }
            }

            return 0;
        }

        public static IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> output = new List<IList<int>>();

            SubsetHelper(new List<int>(nums), new List<int>(), output);

            return output;
        }

        private static void SubsetHelper(List<int> input, List<int> chosen, IList<IList<int>> output)
        {
            if (input.Count == 0)
            {
                output.Add(new List<int>(chosen));
            }
            else
            {
                int c = input[0];
                input.RemoveAt(0);

                SubsetHelper(input, chosen, output);

                chosen.Add(c);

                SubsetHelper(input, chosen, output);

                chosen.RemoveAt(chosen.Count -1);
                input.Add(c);
            }
        }

        public static string CountAndSay(int n)
        {
            string s = "1";
            for (int i = 0; i < n; i++)
            {
                s = NextNumber(s);
            }

            return s;
        }

        private static string NextNumber(string s)
        {
            string output = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                int count = 1;

                while (i+1 < s.Length && s[i] == s[i+1])
                {
                    i++; count++;
                }

                output += count.ToString() + s[i];
            }
            return output;
        }

        public static void Rotate_Array(int[,] nums)
        {
            int rowElementCount = (int)Math.Sqrt(nums.Length);
            int mid =  rowElementCount/ 2;
            int n = rowElementCount;
            for (int i = 0; i < mid; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    swap(ref nums[i,j], ref nums[n-1-i,j]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    swap(ref nums[i,j], ref nums[j,i]);
                }
            }
        }

        public static void swap(ref int a, ref int b)
        {
            int temp = 0;

            temp = a;
            a = b;
            b = temp;
        }

        public static int Fib_DP(int n, int[] nums)
        {
            if (n < 2)
            {
                return n;
            }

            if (nums[n] == 0)
            {
                nums[n] = Fib_DP(n - 1, nums) + Fib_DP(n - 2, nums);
            }

            return nums[n];
        }

        public static int RemoveArrayElementOccurence(int[] nums, int k)
        {
            if (nums.Length < 1)
            {
                return -1;
            }

            int occurence = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == k)
                {
                    occurence++;
                }
                else
                {
                    nums[i - occurence] = nums[i];
                }
            }

            return nums.Length - occurence;
        }

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
