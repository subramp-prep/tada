using System;
using System.Collections.Generic;

namespace questions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void Test_KthLargestElement()
        {
            int?[] nums = {19,7,43,3,11,23,47,2,5,null,17,37,null, 53,null, 
                null, null, null,null, null, null, null,null, null, null, 
                null,null, null, null, null  };
            
            TreeNode tree = TreeNode.BuildNullableTree(nums);

            var elements = KthLargestElement.FindElements(tree, 3);
        }

        public static void Test_BubbleSortOptimum()
        {
            int[] nums = { 5, 1, 4, 89, 2, 3, 44, 100, 98, 67, 45, 99, 56, 43, 12, 67 };

            Bubble.Sort_Optimum(nums);
        }

        public static void Test_BubbleSort()
        {
            int[] nums = { 5, 1, 4, 89, 2, 3, 44, 100, 98, 67, 45, 99, 56, 43, 12, 67 };

            Bubble.Sort(nums);
        }

        public static void Test_SelectionSort()
        {
            int[] nums = { 5, 1, 4, 89, 2, 3, 44};

            Selection.Sort(nums);
        }

        public static void Test_ValidateBST()
        {
            int[] nums = { 1,1 };
            TreeNode root = TreeNode.BuildTree(nums);

            Console.WriteLine(ValidateBST.IsValidBST(root));
        }

        public static void Test_TreeSumLeft()
        {
            int[] nums = {1, 2, 3, 4, 5};
            TreeNode root = TreeNode.BuildTree(nums);

            Console.WriteLine(TreeSumLeft.SumOfLeftLeaves(root));
        }

        public static void Test_TreeTraversal()
        {
            TreeNode root = TreeNode.BuildSampleTree();
            
            Console.WriteLine("***InOrder***");
            TreeNode.InOrder(root);

            Console.WriteLine("***PreOrder***");
            TreeNode.PreOrder(root);

            Console.WriteLine("***PostOrder***");
            TreeNode.PostOrder(root);
        }

        public static void Test_MinSizeSubarray()
        {
            int[] nums = { 2, 3, 1, 2, 4, 3};
            Console.WriteLine(MinSizeSubarray.MinSubArrayLen( 7, nums));

            int[] nums1 = { 1,4,4 };
            Console.WriteLine(MinSizeSubarray.MinSubArrayLen(4, nums1));

            int[] nums3 = { 1,2,3,4,5};
            Console.WriteLine(MinSizeSubarray.MinSubArrayLen(15, nums3));
        }

        public static void Test_ImplementStrStr()
        {
            Console.WriteLine(ImplementStrStr.strStr("mississippi", "issip"));
        }

        public static void Test_RemoveLLElement()
        {
            ListNode node1 = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(6)
                    {
                        next = new ListNode(3)
                        {
                            next = new ListNode(4)
                            {
                                next = new ListNode(5)
                                {
                                    next = new ListNode(6)
                                }
                            }
                        }
                    }
                }
            };

            ListNode final = RemoveLLElement.RemoveElements(node1, 6);
        }

        public static void Test_RemoveArrayElement()
        {
            int[] nums = { 3, 2, 2, 3 };
            Console.WriteLine(RemoveArrayElement.RemoveElement(nums, 3));
        }

        public static void Test_ReverseLL()
        {
            ListNode node1 = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(4)
                    {
                        next = new ListNode(10)
                        {
                            
                        }
                    }
                }
            };

            var reversedNode = ReverseLL.ReverseList(node1);
        }

        public static void Test_NumArray()
        {
            int[] nums = { -2, 0, 3, -5, 2, -1};
            NumArray obj = new NumArray(nums);
            int param = obj.sumRange(2, 5);

            int[] nums1 = { 2, -2, 4, 3, 10,-20 };
            NumArray obj1 = new NumArray(nums1);
            int param1 = obj1.sumRange(2, 5);
        }

        //TODO
        public static void Test_RemoveDuplicates()
        {
            int[] nums = { 1,1,2 };
            Console.WriteLine(RemoveDuplicates.RemoveDuplicates_Perform(nums));
        }

        public static void Test_DisappearedNumbersInArray()
        {
            int[] nums = {4, 3, 2, 7, 8, 2, 3, 1};
            var test = DisappearedNumbersInArray.FindDisappearedNumbers(nums);
        }

        public static void Test_MaximumSizeSubarray()
        {
            //int[] nums = { 1, -1, 5, -2, 3 };
            //Console.WriteLine(MaximumSizeSubarray.MaxSubArrayLen_Optimum(nums, 3));

            //int[] nums1 = { -2, -1, 2, 1 };
            //Console.WriteLine(MaximumSizeSubarray.MaxSubArrayLen_Optimum(nums1, 1));

            //int[] nums2 = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            //Console.WriteLine(MaximumSizeSubarray.MaxSubArrayLen_Optimum(nums2, 1));

            int[] nums3 = { 3, 4, 7, 2, -3, 1, 4, 2 };
            Console.WriteLine(MaximumSizeSubarray.MaxSubArrayLen_Optimum(nums3, 7));
        }

        public static void Test_Backtracking_SubLists()
        {
            IList<string> input = new List<string>();
            input.Add("Jane");
            input.Add("Bob");
            input.Add("Matt");
            input.Add("Sara");

            Backtracking_SubLists.Sublists(input);
        }

        public static void Test_PeakIndex()
        {
            int[] nums = { 1, 2, 3, 1 };
            FindPeak.FindPeakElement(nums);
        }

        public static void Test_MergeSortedArray()
        {
            int[] num1 = { 0, 0 };
            int[] num2 = { 1 };


            MergeSortedArray.Merge(num1, 1, num2, num2.Length);
        }

        public static void Test_SearcRotatedSortArray()
        {
            int[] nums = { 4, 5, 6, 7, 0, 1, 2 };

            SearchInSorted.search(nums, 2);
        }

        public static void Test_MergeList()
        {
            ListNode node1 = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(4)
                    {
                    }
                }
            };

            ListNode node2 = new ListNode(1)
            {
                next = new ListNode(3)
                {
                    next = new ListNode(4)
                    {
                    }
                }
            };

            MergeSortedLists.MergeTwoLists(node1, node2);
        }

        public static void Test_MergeSort()
        {
            int[] nums = { 25, 7, 3, 23, 15, 60, 63, 52, 49 };

            Merge.Sort(nums);
        }

        public static void Test_FindBadVersion()
        {
            FirstBadVersion.Initialize();

            Console.WriteLine(FirstBadVersion.FindBadVersion(10));
        }

        public static int Test_RomanToInteger(string input)
        {
            return RomanToInteger.Perform_EPI(input);
        }

        public static void Test_ContiguousArray()
        {
            int[] nums = { 0, 0, 0, 1, 1, 1, 0, 0 };
            Console.WriteLine(ContiguousArray.FindMaxLength_Correect(nums));
        }

        public static void Test_MaxSizeSubarray()
        {
            int[] nums = { -2, -1, 2, 1 };
            MaximumSize.FindMaxSubarray(nums, 1);
        }

        public static void Test_MaximumSubarray()
        {
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Console.WriteLine(MaximumSubarray.MaxSubArray_Optimum(nums));
        }

        public static void Test_BuySellStock()
        {
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine("Trial1: {0}", BuySellStock.MaxProfit_Optimum(prices));


            int[] noSell = {7, 6, 4, 3, 1};
            Console.WriteLine("Trial2: {0}", BuySellStock.MaxProfit_Optimum(noSell));
        }

        public static void Test_LetterCasePermutation()
        {
            var output = LetterCasePermutation.LetterPermutation("a1b2");
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }

        public static void Test_Subsets()
        {
            int[] nums = {1, 2, 3};
            Subsets.Perform(nums);
        }

        public static void Test_BinaryWatch()
        {
            BinaryWatch.ReadBinaryWatch_Optimum(3);
        }

        public static void Test_NumberOfBits()
        {
            NumberOfBits.HammingWeight(5);
            NumberOfBits.HammingWeight(4294967295);    
        }

        public static void Test_CountAndSay()
        {
            CountAndSay.LookAnSay_EPI(5);
        }

        public static void Test_StringCompression()
        {
            char[] input = { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
            Console.WriteLine(StringCompression.Compress(input));
        }
    }
}
