using System;
using System.Collections.Generic;

namespace Misc
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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

            int[][] arrary2d = new int [][] 
            { 
                new int[] {1,2},
                new int[] {3},
                new int[] {4,5,6}
            };
                
            Vector2D i = new Vector2D(vec2d);
            while (i.HasNext()) 
            {
                Console.WriteLine(i.Next());   
            }
        }
    }
}
