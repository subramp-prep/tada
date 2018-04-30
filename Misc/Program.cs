using System;
using System.Collections.Generic;

namespace Misc
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Test_TwoSum();
        }

        public static void Test_TwoSum()
        {
            int[] nums = { 2, 7, 11, 15 };
            Playground.TwoSum(nums, 9);
        }

        public static void Test_RotateArray()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Playground.RotateArray(nums, 3);
        }

        public static void Test_ReverseWord()
        {
            char[] s = "the sky is blue".ToCharArray();
            Playground.ReverseSentence(s);

            char[] s1 = "Vande matram   ".ToCharArray();
            Playground.ReverseSentence(s1);
        }

        public static void Test_Codec()
        {
            string url = "https://leetcode.com/problems/design-tinyurl";

            Codec codec = new Codec();
            Console.WriteLine(codec.decode(codec.encode(url)));
        }

        public static void Test_Factorial()
        {
            Console.WriteLine(Playground.FirstFactorial(4));
            Console.WriteLine(Playground.FirstFactorial(8));
        }

        public static void Test_KthSmallestFromMatrix()
        {
            int[,] nums = { 
                {1,  5,  9},
                {10, 11, 13},
                {12, 13, 15}
            };

            Console.WriteLine(Playground.KthSmallest(nums, 8));
        }

        public static void Test_Subset()
        {
            int[] nums = { 1, 2, 3 };
            Playground.Subsets(nums);
        }

        public static void Test_CountnSay()
        {
            Playground.CountAndSay(4);
        }

        public static void Test_MatrixRotation()
        {
            int[,] nums = { 
                {1,2},
                {3,4}
            };
            Playground.RotateMatrix(nums);

            int[,] nums1 = {
                {1,2, 3},
                {4, 5,6},
                {7,8,9}
            };
            Playground.RotateMatrix(nums1);
        }

        public static void Test_FibDP()
        {
            Console.WriteLine(Playground.Fib_DP(30, new int[31]));
        }

        public static void Test_RemoveRedundantDir()
        {
            string[] dirs = { @"\abc\def\ghi", @"\abc\def", @"\abc\uvw", @"\xyz" };
            RmRedundantDir.RemoveRedundantFileDirs(dirs);

            string[] dirs1 = { @"\abc\ghi", @"\abc\def", @"\abc\uvw", @"\abc", @"bc\xyz\ghi" };
            RmRedundantDir.RemoveRedundantFileDirs(dirs1);

            string[] dirs2 = { @"\abc", @"\abc\ghi", @"\abc\ghi\uvw"};
            RmRedundantDir.RemoveRedundantFileDirs(dirs2);

            string[] dirs3 = { @"\", @"\abc", @"\abc\ghi", @"\abc\ghi\uvw" };
            RmRedundantDir.RemoveRedundantFileDirs(dirs3);
        }

        public static void Test_RemoveArrayElementOccurence()
        {
            int[] nums = { 5,3,7,11,2,3,13,5,7};
            Console.WriteLine(Playground.RemoveArrayElementOccurence(nums, 3));
        }

        public static void Test_Playground()
        {
            Test_TowerOfHanoi();

            int[] nums2 = { 1, 1, 1, 2, 2, 3 };
            Console.WriteLine("Remove duplicatesII length:{0}", Playground.RemoveDuplicatesII(nums2));

            Console.WriteLine(Playground.HammingDistance(1, 4));

            int[] nums1 = new int[10];
            Console.WriteLine(Playground.Fibonacci_DP(6, nums1));

            int[] nums = { 1, 2, 3 };
            Playground.Permute(nums);
        }

        public static void Test_TowerOfHanoi()
        {
            TowerOfHanoi.Perform(3, 'A', 'B', 'C');
        }

        public static void Test_SumIII()
        {
            int[] nums = { 5 ,3, 67, 75, 54, 8, 83};

            Console.WriteLine(SumIII.Has3Sum(nums, 83));
        }

        public static void Test_ArrayDiagonalSum()
        {
            int[,] nums = new int[,] {
                {1, 2, 3, 4},
                {1, 2, 3, 4},
                {1, 2, 3, 4},
                {1, 2, 3, 4}
            };
            
            Console.WriteLine(ArrayDiagonalSum.DiagSum(nums,4));    
        }

        public static void Test_SecondLargestArrayElement()
        {
            int[] nums = { 1, -2, 3, 4};
            Console.WriteLine(SecondLargesInArray.DetermineElement(nums));

            int[] nums1 = { 1, 3,4,5,0,2 };
            Console.WriteLine(SecondLargesInArray.DetermineElement(nums1));

            int[] nums2 = { -2, -1 };
            Console.WriteLine(SecondLargesInArray.DetermineElement(nums2));

            int[] nums5 = { 2, 2, 1 };
            Console.WriteLine(SecondLargesInArray.DetermineElement(nums5));

            int[] nums3 = { 2 };
            Console.WriteLine(SecondLargesInArray.DetermineElement(nums3));

            int[] nums4 = {  };
            Console.WriteLine(SecondLargesInArray.DetermineElement(nums4));
        }

        public static void Test_GridTraversal()
        {
            GridTraversal grid = new GridTraversal();

            int[,] path = new int[8,8];
            int count = grid.CountPaths_DP(0 ,0, path);
        }

        public static void Test_isPower()
        {
            isPower.IsPower(81);
        }

        public static void Test_Vector2D()
        {
            IList<IList<int>> vec2d = new List<IList<int>>();

            vec2d.Add(new List<int>(new int[] { 1, 2 }));
            vec2d.Add(new List<int>(new int[] { 3 }));
            vec2d.Add(new List<int>(new int[] { 4,5,6 }));
                
            //Vector2D i = new Vector2D(vec2d);
            //while (i.HasNext()) 
            //{
            //    Console.WriteLine(i.Next());   
            //}

            //[[],[],[-1]]
            IList<IList<int>> vec2d1 = new List<IList<int>>();

            vec2d1.Add(new List<int>(new int[] { }));
            vec2d1.Add(new List<int>(new int[] {  }));
            vec2d1.Add(new List<int>(new int[] { -1}));

            Vector2D j = new Vector2D(vec2d1);
            while (j.HasNext())
            {
                Console.WriteLine(j.Next());
            }
        }
    }
}
