using System;
namespace questions
{
    // Question URL: https://leetcode.com/problems/range-sum-query-immutable/description/
    //Given an integer array nums, find the sum of the elements 
    //between indices i and j(i ≤ j), inclusive.

    //Example:
    //Given nums = [-2, 0, 3, -5, 2, -1]

    //sumRange(0, 2) -> 1
    //sumRange(2, 5) -> -1
    //sumRange(0, 5) -> -3
    //Note:
    //You may assume that the array does not change.
    //There are many calls to sumRange function.
    public class NumArray
    {
        // Concept Dynamic programming
        
        int[] _nums;
        int[] _sumNum;

        public NumArray(int[] nums)
        {
            _nums = nums;
            _sumNum = new int[nums.Length + 1];
            _sumNum[0] = 0;
            for (int i = 1; i < _sumNum.Length; i++)
            {
                _sumNum[i] = _sumNum[i - 1] + nums[i - 1];
            }
        }

        public int sumRange(int i, int j)
        {
            if (i < 0 || j >= _nums.Length)
            {
                return 0;
            }

            return _sumNum[j + 1] - _sumNum[i];
        }
    }
}
