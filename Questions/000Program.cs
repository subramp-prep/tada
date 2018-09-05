using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace questions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Test_ValidParentheses();
        }

        public static void Test_ValidParentheses()
        {
            ValidParentheses.IsValid_Optimum("()");
        }

        public static void Test_FindAllAnagrams()
        {
            var result_1 = FindAllAnagrams.FindAnagrams("cbaebabacd", "abc");
            var result_2 = FindAllAnagrams.FindAnagrams("abab", "ab");
        }

        public static void Test_MinWindowSubstring()
        {
            Console.WriteLine(MinWindowSubstring.MinWindow("arab", "aba"));
            Console.WriteLine(MinWindowSubstring.MinWindow("ADOBECODEBANC", "ABC"));
        }

        public static void Test_OrderlyQ()
        {
            Console.WriteLine(OrderlyQ.OrderlyQueue("cba", 1));
            Console.WriteLine(OrderlyQ.OrderlyQueue("baaca", 3));
        }

        public static void Test_IncreasingST()
        {
            int?[] nums = { 5, 3, 6, 2, 4, null, 8, 1, null, null, null, 7, 9};

            TreeNode root = TreeNode.BuildNullableTree(nums);

            var result = IncreasingST.IncreasingBST(root);
        }

        public static void Test_BitwiseSubarray()
        {
            int[] nums = { 1, 1, 2 };
            Console.WriteLine(BitwiseSubarray.SubarrayBitwiseORs(nums));

            int[] nums1 = {1,2,4};
            Console.WriteLine(BitwiseSubarray.SubarrayBitwiseORs(nums1));
        }

        public static void Test_ArrayMontone()
        {
            int[] nums1 = { 1, 2, 2, 3};
            Console.WriteLine(MonotonicArray.IsMonotonic(nums1));

            int[] nums2 = { 6, 5, 4, 4 };
            Console.WriteLine(MonotonicArray.IsMonotonic(nums2));

            int[] nums3 = { 1, 3, 2 };
            Console.WriteLine(MonotonicArray.IsMonotonic(nums3));

            int[] nums4 = { 1, 2, 4, 5 };
            Console.WriteLine(MonotonicArray.IsMonotonic(nums4));

            int[] nums5 = { 1, 1, 1 };
            Console.WriteLine(MonotonicArray.IsMonotonic(nums5));
        }

        public static void Test_RemoveDupFromSortedLLII()
        {
            ListNode node = new ListNode(1)
            {
                next = new ListNode(1)
                {
                    next = new ListNode(1)
                    {
                        next = new ListNode(2)
                        {
                            next = new ListNode(3)
                            {
                                next = null
                            }
                        }
                    }
                }
            };

            RemoveDuplicateII.DeleteDuplicates(node);
        }

        public static void Test_RemoveDupFromSortedLL()
        {
            ListNode node1 = new ListNode(1)
            {
                next = new ListNode(1)
                {
                    next = new ListNode(2)
                    {
                        next = new ListNode(2)
                        {
                            next = new ListNode(3)
                            {
                                next = new ListNode(56)
                                {
                                    next = new ListNode(56)
                                }
                            }
                        }
                    }
                }
            };

            var resultLL = RemoveDup.DeleteDuplicates(node1);
        }

        public static void Test_ReorderdPower2()
        {
            ReorderPower.ReorderedPowerOf2(3);
        }

        public static void Test_Transpose()
        {
            int[][] nums = { 
                new int[]{1,2,3},
                new int[]{4,5,6}
                //new int[]{7,8,9},
            };

            var matrix = TransposeMatrix.Transpose(nums);
        }

        public static void Test_ShiftingLetters()
        {
            int[] nums = { 3, 5, 9 };
            Shifting.ShiftingLetters("abc", nums);
        }

        public static void Test_BackspaceComp()
        {
            Console.WriteLine(BackspaceStringCompare.BackspaceCompare("ab#c", "ad#c"));
            Console.WriteLine(BackspaceStringCompare.BackspaceCompare("ab##", "c#d#"));
            Console.WriteLine(BackspaceStringCompare.BackspaceCompare("a##c", "#a#c"));
            Console.WriteLine(BackspaceStringCompare.BackspaceCompare("a#c", "b"));
        }

        public static void Test_Toeplitz()
        {
            int[,] matrix = {
                {1,2,3,4},
                {5,1,2,3},
                {9,5,1,2}
            };
            Console.WriteLine(Toeplitz.IsToeplitzMatrix(matrix));

            int[,] matrix1 = {
                {1,2},
                {2,2}
            };
            Console.WriteLine(Toeplitz.IsToeplitzMatrix(matrix1));
        }

        public static void Test_Permutation()
        {
            int[] nums = { 1, 2, 3 };
            var combo = Permutations.Permute(nums);
        }

        public static void Test_PermutationsII()
        {
            int[] nums = { 1, 1, 2 };
            PermutationsII.PermuteUnique(nums);
        }

        public static void Test_SubsetsII()
        {
            int[] nums = { 1, 2, 2};
            SubsetsII.SubsetsWithDup(nums);
        }

        public static void Test_Palindromic()
        {
            var o1 = Palindromic.Partition("aab");
            var o2 = Palindromic.Partition("02024451881");
        }

        public static void Test_UniquePaths()
        {
            Console.WriteLine(TraversePaths.UniquePaths(3, 2));

            Console.WriteLine(TraversePaths.UniquePaths(7,3));
        }

        public static void Test_FistUnique()
        {
            Console.WriteLine(FirstUnique.FirstUniqChar("leetcode"));
            Console.WriteLine(FirstUnique.FirstUniqChar("loveleetcode"));
        }

        public static void Test_CountBits()
        {
            var o1 = CountingBits.CountBits(2);
            var o2 = CountingBits.CountBits(4);
            var o3 = CountingBits.CountBits(6);
            var o4 = CountingBits.CountBits(10);
        }

        public static void Test_MostCommonWord()
        {
            string[] banned = { "hit" };
            MostCommonWord.MostWords("Bob hit a ball, the hit BALL flew far after it was hit.", banned);
        }

        public static void Test_MinimumDiffBST()
        {
            int?[] nums1 = { 5, 4, 7 };
            var root1 = TreeNode.BuildNullableTree(nums1);
            Console.WriteLine(MinAbsDiffBST.GetMinimumDifference(root1));
            
            int?[] nums = {1, null, 3, null, null, 2};
            var root = TreeNode.BuildNullableTree(nums);
            Console.WriteLine(MinAbsDiffBST.GetMinimumDifference(root));
        }

        public static void Test_CustomSortString()
        {
            string S = "cba";
            string T = "dabc";

            Console.WriteLine(CustomSort.CustomSortString(S, T));
        }

        public static void Test_KDiffPair()
        {
            int[] nums = { 3, 1, 4, 1, 5 };
            Console.WriteLine(KDiffPairs.FindPairs(nums, 2));

            int[] nums1 = { 1, 2, 3, 4, 5 };
            Console.WriteLine(KDiffPairs.FindPairs(nums1, 1));
        }

        public static void Test_LengthOfSubstringWithoutRepeat()
        {
            Console.WriteLine(SubstringWithoutRepeating.LengthOfLongestSubstring("abcabcbb"));
            Console.WriteLine(SubstringWithoutRepeating.LengthOfLongestSubstring("bbbbb"));
            Console.WriteLine(SubstringWithoutRepeating.LengthOfLongestSubstring("pwwkew"));
            Console.WriteLine(SubstringWithoutRepeating.LengthOfLongestSubstring("dvdf"));
        }

        public static void Test_RotateSum()
        {
            int[] nums = { 4, 3, 2, 6};
            Console.WriteLine(RotateFunction.MaxRotateFunction(nums));
        }

        public static void Test_FindNReplace()
        {
            int[] indexes = { 0, 2 };
            string[] sources = {"a", "cd" };
            string[] targets = { "eee", "ffff" };
            Console.WriteLine(FindNReplace.FindReplaceString("abcd", indexes, sources, targets));
        }

        public static void Test_FlipNInvert()
        {
            int[][] nums = { 
                new int[] {1, 1, 0},
                new int[] {1, 0, 1},
                new int[] {0, 0, 0},
            };
            var result = FilpNInvert.FlipAndInvertImage(nums);
        }

        public static void Test_TwoSumII()
        {
            int[] nums = {2, 7, 11, 15 };
            var result = TwoSumI.TwoSumII(nums, 9);
        }

        public static void Test_LongestPalindrome()
        {
            Console.WriteLine(Longest.LongestPalindrome_DP("madam"));
            Console.WriteLine(Longest.LongestPalindrome_DP("banana"));
        }

        public static void Test_MergeBT()
        {
            int?[] nums1 = { 1, 3, 2, 5 };
            var root1 = TreeNode.BuildNullableTree(nums1);

            int?[] nums2 = { 2, 1, 3, null, 4, null, 7 };
            var root2 = TreeNode.BuildNullableTree(nums2);

            var mergedTree = MergeBT.MergeTrees(root1, root2);
        }

        public static void Test_LargestTriangle()
        {
            int[][] points = {
                new int[]{0,0},
                new int[]{0,1},
                new int[]{1,0},
                new int[]{0,2},
                new int[]{2,0},
            };

            Console.WriteLine(LargestTriangle.LargestTriangleArea(points));
        }

        public static void Test_MaskPersonalInfo()
        {
            Console.WriteLine(MaskingPersonalInfo.MaskPII("+86(88)1513-7-74"));
            Console.WriteLine(MaskingPersonalInfo.MaskPII("1(234)567-890"));
            Console.WriteLine(MaskingPersonalInfo.MaskPII("LeetCode@LeetCode.com"));
            Console.WriteLine(MaskingPersonalInfo.MaskPII("AB@qq.com"));
        }

        public static void Test_PascalTriangle()
        {
            var output1 = PascalsTriangle.Generate(1);
            var output2 = PascalsTriangle.Generate(2);
            var output3 = PascalsTriangle.Generate(3);
            var output4 = PascalsTriangle.Generate(4);
            var output5 = PascalsTriangle.Generate(5);
            var output6 = PascalsTriangle.Generate(6);
        }

        public static void Test_LargeGroups()
        {
            var output0 = LargerGroups.LargeGroupPositions("abbxxxxzyy");
            var output1 = LargerGroups.LargeGroupPositions("abc");
            var output2 = LargerGroups.LargeGroupPositions("abcdddeeeeaabbbcd");
        }

        public static void Test_ConvertBST()
        {
            int[] nums = { -10, -3, 0, 5, 9 };
            TreeNode root = SortedArrayToBinaryST.SortedArrayToBST(nums);
        }

        public static void Test_TreeToString()
        {
            int[] nums = { 1, 2, 3, 4 };
            var root = TreeNode.BuildTree(nums);

            Console.WriteLine(TreeToString.Tree2str(root));
        }

        public static void Test_FindDupSubtrees()
        {
            int?[] nums = {1,2,3,4,null, 2,4,null, null, null, null, 4};
            var root = TreeNode.BuildNullableTree(nums);

            var dups = DuplicateSubtrees.FindDuplicateSubtrees(root);
        }

        public static void Test_LargestIsland()
        {
            int[][] grid1 = {
                new int[] {1, 0},
                new int[] {0, 1}
            };

            MakingIsland.LargestIsland(grid1);

            int[][] grid2 = {
                new int[] {1, 1, 1, 0},
                new int[] {1, 1, 0, 0},
                new int[] {0, 0, 1, 0},
                new int[] {0, 0, 0, 0},
                new int[] {0, 1, 1, 1}
            };

            MakingIsland.LargestIsland(grid2);
        }

        public static void Test_LLCycleII()
        {
            ListNode l1 = new ListNode(1);
            ListNode l2 = new ListNode(2);
            ListNode l3 = new ListNode(3);
            ListNode l4 = new ListNode(4);
            ListNode l5 = new ListNode(5);

            l1.next = l2;
            l2.next = l3;
            l3.next = l4;
            l4.next = l5;
            l5.next = l2;

            var val = LLCycleII.DetectCycle(l1);
        }

        public static void Test_LLCycle()
        {
            ListNode ll1 = new ListNode(1);
            ListNode ll2 = new ListNode(2);

            ll1.next = ll2;

            Console.WriteLine(LLCycle.HasCycle(ll1));

            ListNode l1 = new ListNode(1);
            ListNode l2 = new ListNode(2);
            ListNode l3 = new ListNode(3);
            ListNode l4 = new ListNode(4);
            ListNode l5 = new ListNode(5);

            l1.next = l2;
            l2.next = l3;
            l3.next = l4;
            l4.next = l5;
            l5.next = l2;

            Console.WriteLine(LLCycle.HasCycle(l1));
        }

        public static void Test_GoatLatin()
        {
            Console.WriteLine(GoatLatin.ToGoatLatin("I speak Goat Latin"));
        }

        public static void Test_MaxAreaIsland()
        {
            int[,] grid = { 
                {1,1,0,0,0},
                {1,1,0,0,0},
                {0,0,0,1,1},
                {0,0,0,1,1},
            };

            Console.WriteLine(MaxAreaIsland.MaxAreaOfIsland(grid));
        }

        public static void Test_NumberOfIslands()
        {
            char[,] grid3 = {
                {'1','1','1','1','1','0','1','1','1','1','1','1','1','1','1','0','1','0','1','1'},
                {'0','1','1','1','1','1','1','1','1','1','1','1','1','0','1','1','1','1','1','0'},
                {'1','0','1','1','1','0','0','1','1','0','1','1','1','1','1','1','1','1','1','1'},
                {'1','1','1','1','0','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1'},
                {'1','0','0','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1'},
                {'1','0','1','1','1','1','1','1','0','1','1','1','0','1','1','1','0','1','1','1'},
                {'0','1','1','1','1','1','1','1','1','1','1','1','0','1','1','0','1','1','1','1'},
                {'1','1','1','1','1','1','1','1','1','1','1','1','0','1','1','1','1','0','1','1'},
                {'1','1','1','1','1','1','1','1','1','1','0','1','1','1','1','1','1','1','1','1'},
                {'1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1'},
                {'0','1','1','1','1','1','1','1','0','1','1','1','1','1','1','1','1','1','1','1'},
                {'1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1'},
                {'1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1'},
                {'1','1','1','1','1','0','1','1','1','1','1','1','1','0','1','1','1','1','1','1'},
                {'1','0','1','1','1','1','1','0','1','1','1','0','1','1','1','1','0','1','1','1'},
                {'1','1','1','1','1','1','1','1','1','1','1','1','0','1','1','1','1','1','1','0'},
                {'1','1','1','1','1','1','1','1','1','1','1','1','1','0','1','1','1','1','0','0'},
                {'1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1'},
                {'1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1'},
                {'1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1'}
            };
            Console.WriteLine(NumberOfIslands.NumIslands_BFS(grid3));

            char[,] grid2 = {
                {'1', '1', '1'},
                {'0', '1', '0'},
                {'1', '1', '1'}
            };
            Console.WriteLine(NumberOfIslands.NumIslands_BFS(grid2));
            
            char[,] grid1 = { 
                {'1', '1', '0', '0', '0'},
                {'1', '1', '0', '0', '0'},
                {'0', '0', '1', '0', '0'},
                {'0', '0', '0', '1', '1'}
            };
            Console.WriteLine(NumberOfIslands.NumIslands_BFS(grid1));
            
            char[,] grid = { 
                {'1', '1', '1', '1', '0'},
                {'1', '1', '0', '1', '0'},
                {'1', '1', '0', '0', '0'},
                {'0', '0', '0', '0', '0'}
            };

            Console.WriteLine(NumberOfIslands.NumIslands(grid));
        }

        public static void Test_WallNGate()
        {
            int[,] matrix = new int[,]
            {
                {int.MaxValue, -1, 0, int.MaxValue},
                {int.MaxValue, int.MaxValue, int.MaxValue, -1},
                {int.MaxValue, -1, int.MaxValue, -1},
                {0, -1, int.MaxValue, int.MaxValue}
            };

            WallNGates.WallsAndGates(matrix);
        }

        public static void Test_BTFactors()
        {
            int[] nums = {2, 4, 5, 10 };
            BTFactors.NumFactoredBinaryTrees(nums);
        }

        public static void Test_TwosumBST()
        {
            int?[] nums = { 5,3,6,2,4,null,7};
            var root = TreeNode.BuildNullableTree(nums);

            Console.WriteLine(TwoSumBST.FindTarget(root, 9));
            Console.WriteLine(TwoSumBST.FindTarget(root, 28));

            int[] nums1 = { 1 };
            var root1 = TreeNode.BuildTree(nums1);
            Console.WriteLine(TwoSumBST.FindTarget(root1, 2));
        }

        public static void Test_LargestAtLeastTwice()
        {
            int[] nums = {71,62,60,32,67,37,62,44,0,9,52,22,65,69,13,50,93,17,27,
                77,99,15,65,19,83,80,55,39,36,81,52,44,42,95,66,26,11,53,97,18,
                46,76,18,32,71,16,86,1,66,28 };
            
            Console.WriteLine(LargestIndexTwice.Perform_Optimum(nums));
        }

        public static void Test_MergeInterval()
        {
            IList<int[]> input2 = new List<int[]>();
            input2.Add(new int[] { 1, 4 });
            input2.Add(new int[] { 0, 4 });

            var intervals2 = Interval.CreateMany(input2);
            MergeIntervals.Merge(intervals2);

            IList<int[]> input1 = new List<int[]>();
            input1.Add(new int[] { 1, 4 });
            input1.Add(new int[] { 5, 6 });

            var intervals1 = Interval.CreateMany(input1);

            MergeIntervals.Merge(intervals1);

            IList<int[]> input = new List<int[]>();
            input.Add(new int[] { 1, 3 });
            input.Add(new int[] { 2, 6 });
            input.Add(new int[] { 8, 10 });
            input.Add(new int[] { 15, 18 });

            var intervals = Interval.CreateMany(input);

            MergeIntervals.Merge(intervals);
        }

        public static void Test_BuildBST()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var root = TreeNode.BuildBST(nums);
        }

        public static void Test_TreeHeight()
        {
            int[] nums = {1,2,3,4,5,6,7,8,9,10 };

            var root = TreeNode.BuildTree(nums);
            Console.WriteLine(TreeNode.GetTreeHeight(root));

            int[] nums1 = { 1};

            var root1 = TreeNode.BuildTree(nums1);
            Console.WriteLine(TreeNode.GetTreeHeight(root1));
        }

        public static void Test_RotateString()
        {
            Console.WriteLine(Rotate.String("abcde", "cdeab"));
            Console.WriteLine(Rotate.String("abcde", "abced"));
        }

        public static void Test_RotateList()
        {
            ListNode head = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                        }
                    }
                }
            };

            var rotatedHead = RotateList.RotateRight(head, 2);
        }

        public static void Test_RotateArray()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            RotateArray.Rotate(nums, 3);

            int[] nums1 = { -1 };
            RotateArray.Rotate(nums1, 2);
        }

        public static void Test_CombinationSumI()
        {
            int[] nums = { 2, 3, 6, 7 };
            var output = CombinationSum.CombinationSumI(nums, 7);
        }

        public static void Test_BSTIterator()
        {
            int?[] nums = { 1, null, 2 };
            var root = TreeNode.BuildNullableTree(nums);

            BSTIterator i = new BSTIterator(root);

            while (i.HasNext())
            {
                Console.WriteLine(i.Next());
            }
        }

        public static void Test_CombinationSum()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            CombinationSum.CombinationSum3(45, 9);
            stopwatch.Stop();

            Console.WriteLine("Time taken: {0}s", stopwatch.ElapsedMilliseconds);

            CombinationSum.CombinationSum3(7, 2);
            CombinationSum.CombinationSum3(9, 3);
        }

        public static void Test_AddBinaryString()
        {
            Console.WriteLine(AddBinaryString.AddBinary("11", "1"));
        }

        public static void Test_MissingRanges()
        {
            int[] nums2 = { };
            var output2 = MissingRanges.FindMissingRanges(nums2, -3, -1);

            int[] nums1 = {  };
            var output1 = MissingRanges.FindMissingRanges(nums1, 1, 1);
            
            int[] nums = { 0, 1, 3, 50, 75 };
            var output = MissingRanges.FindMissingRanges(nums,0, 99);
        }

        public static void Test_FindMedianSortedArrays()
        {
            int[] nums1 = { };
            int[] nums2 = { 2};
            Console.WriteLine(Median.FindMedianSortedArrays(nums1, nums2));
        }

        public static void Test_LCABT()
        {
            int?[] nums = {3, 5,1,6,2,0,8,null,null,7,4};

            TreeNode root = TreeNode.BuildNullableTree(nums);
            TreeNode commonAncestor = LCABT.LowestCommonAncestor_EPI(root, 6,8);
        }

        public static void Test_SumIII()
        {
            int[] nums = {-2, 0, 1, 3 };
            Console.WriteLine(SumIII.ThreeSumSmaller(nums, 2));

            int[] nums1 = { 3,1,0,-2 };
            Console.WriteLine(SumIII.ThreeSumSmaller(nums1, 4));
        }

        public static void Test_Sum()
        {
            int[] nums = { -1, 0, 1, 2, -1, -4 };
            var sum = Sum.ThreeSum_Optimum(nums);
        }

        public static void Test_BTLevelTraversalII()
        {
            int?[] nums = { 3, 9, 20, null, null, 15, 7 };
            TreeNode root = TreeNode.BuildNullableTree(nums);

            var output = BTTraversalII.LevelOrderBottom(root);
        }

        public static void Test_BTLevelTraversal()
        {
            int?[] nums = { 3, 9, 20, null, null, 15, 7 };
            TreeNode root = TreeNode.BuildNullableTree(nums);

            var output = BTLevelTraversal.LevelOrder(root);
        }

        public static void Test_AverageBTLevel()
        {
            int?[] nums = { 3, 9, 20, null, null, 15, 7 };
            TreeNode root = TreeNode.BuildNullableTree(nums);

            var output = AverageBTLevel.AverageOfLevels(root);
        }

        public static void Test_MeetingRoomsII()
        {
            IList<int[]> nums = new List<int[]>(){
                new int []{4,9},
                new int []{4,9},
                new int []{9,15},
                new int []{15,16},
                new int []{10,14},
                new int []{4,17}
            };

            var meetingTimes = Interval.CreateMany(nums);
            Console.WriteLine(MeetingRoomsII.MinMeetingRooms(meetingTimes));

            IList<int[]> nums1 = new List<int[]>(){
                new int []{0,30},
                new int []{45,50},
                new int []{51,60}
            };

            var meetingTimes1 = Interval.CreateMany(nums1);
            Console.WriteLine(MeetingRoomsII.MinMeetingRooms(meetingTimes1));
        }


        public static void Test_MeetingRooms()
        {
            IList<int[]> nums = new List<int[]>(){ 
                new int []{0,30},
                new int []{5,10},
                new int []{15,20}
            };

            var meetingTimes = Interval.CreateMany(nums);
            Console.WriteLine(MeetingRooms.CanAttendMeetings(meetingTimes));

            IList<int[]> nums1 = new List<int[]>(){
                new int []{0,30},
                new int []{45,50},
                new int []{51,60}
            };

            var meetingTimes1 = Interval.CreateMany(nums1);
            Console.WriteLine(MeetingRooms.CanAttendMeetings(meetingTimes1));
        }

        public static void Test_QuickSort()
        {
            int[] nums = {3,4,1,7 };

            Quick.Sort(nums);
        }

        public static void Test_TotalHamming()
        {
            int[] nums = { 4, 14, 2};
            Console.WriteLine(TotalHamming.TotalHammingDistance(nums));
        }

        public static void Test_HammingDistance()
        {
            Console.WriteLine(Hamming.Distance(4, 1));
            Console.WriteLine(Hamming.Distance(5, 2));


            Console.WriteLine(Hamming.Distance(10, 3));
        }

        public static void Test_RemoveDuplicatesII()
        {
            int[] nums = { 1,1,1,2,2,3};
            RemoveDuplicatesII.RemoveDuplicates(nums);
        }

        public static void Test_PathSumIII()
        {
            int?[] nums = { 10, 5, -3, 3, 2, null, 11, 3, -2, null, 1 };
            //int?[] nums = { 0, 1, 1 };
            TreeNode root = TreeNode.BuildNullableTree(nums);
            
            Console.WriteLine(PathSumIII.PathSum(root, 8));
        }

        public static void Test_Power()
        {
            Console.WriteLine(Power.MyPow_EPI(2.10000, 3));

            Console.WriteLine(Power.MyPow_EPI(34.00515, -3));
        }

        public static void Test_PathSumII()
        {
            int?[] nums = { 5,4,8,11,null, 13,4,7,2,null,null, null, null ,5,1};

            TreeNode root = TreeNode.BuildNullableTree(nums);

            PathSumII.PathSum(root, 22);

            int?[] nums1 = {  };

            TreeNode root1 = TreeNode.BuildNullableTree(nums1);
            PathSumII.PathSum(root1, 1);
        }

        public static void Test_BinaryTreePath()
        {
            int[] nums = { 1,2,3,4,5,6 };
            TreeNode root = TreeNode.BuildTree(nums);

            BinaryTreePath.BinaryTreePaths(root);
        }

        public static void Test_AddStrings()
        {
            Console.WriteLine(AddString.AddStrings("0", "0"));
        }

        public static void Test_KthLargestElement()
        {
            int?[] nums = {19,7,43,3,11,23,47,2,5,null,17,37,null, 53,null, 
                null, null, null,null, null, null, null,null, null, null, 
                null,null, null, null, null  };
            
            TreeNode tree = TreeNode.BuildNullableTree(nums);

            var elements = KthLargestElement1.FindElements(tree, 3);
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

        public static void Test_RemoveDuplicates()
        {
            int[] nums = { 1,1,2 };
            Console.WriteLine(RemoveDuplicates.RemoveDuplicates_Perform(nums));

            int[] nums1 = { 1, 2, 2 };
            Console.WriteLine(RemoveDuplicates.RemoveDuplicates_Perform(nums1));
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
            int[] num3 = { 0 };
            int[] num4 = { 1 };
            MergeSortedArray.Merge(num3, 0, num4, 1);

            int[] num1 = { 1, 2, 3, 0, 0, 0 };
            int[] num2 = { 2, 5, 6 };
            MergeSortedArray.Merge(num1, 3, num2, 3);
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
            MaximumSizeSubarray.MaxSubArrayLen(nums, 1);
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