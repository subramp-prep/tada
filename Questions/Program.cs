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
            int[] nums = {4,5,6,7,0,1,2 };

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

            MergeSort.Sort(nums);
        }

        public static void Test_FindBadVersion()
        {
            FirstBadVersion.Initialize();

            Console.WriteLine(FirstBadVersion.FindBadVersion(10));
        }

        public static int Test_RomanToInteger(string input)
        {
            return RomanToInteger.Perform_Optimum(input);
        }
    }
}
