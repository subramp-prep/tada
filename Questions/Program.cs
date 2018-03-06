using System;
using System.Collections.Generic;

namespace questions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Test_PeakIndex();
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
    }
}
