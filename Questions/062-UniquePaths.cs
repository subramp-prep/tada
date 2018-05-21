using System;
namespace questions
{
    // https://leetcode.com/problems/unique-paths/description/
    //A robot is located at the top-left corner of a m x n grid
    //(marked 'Start' in the diagram below).

    //The robot can only move either down or right at any point in time.
    //The robot is trying to reach the bottom-right corner of the grid
    //(marked 'Finish' in the diagram below).

    //How many possible unique paths are there?


    //Above is a 7 x 3 grid.How many possible unique paths are there?

    //Note: m and n will be at most 100.

    //Example 1:
    //Input: m = 3, n = 2
    //Output: 3

    //Explanation:
    //From the top-left corner, there are a total of 3 ways to reach the bottom-right corner:
    //1. Right -> Right -> Down
    //2. Right -> Down -> Right
    //3. Down -> Right -> Right

    //Example 2:
    //Input: m = 7, n = 3
    //Output: 28
    public class TraversePaths
    {
        public static int UniquePaths(int m, int n)
        {
            int[,] grid = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                grid[i, 0] = 1;
            }

            for (int i = 0; i < n; i++)
            {
                grid[0, i] = 1;
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    grid[i, j] = grid[i - 1, j] + grid[i, j - 1];
                }
            }

            //TraverseGridSquares(grid, m-1, n-1, 0, 0);

            return grid[m-1, n-1];
        }

        private int TraverseGridSquares(int[,] grid, int row, int column, int cRow, int cColumn)
        {
            if (cRow == row && cColumn == column)
            {
                return 1;
            }

            if (cRow > row || cColumn > column)
            {
                return 0;
            }

            if (grid[cRow, cColumn] == 0)
            {
                grid[cRow, cColumn] = TraverseGridSquares(grid, row, column, cRow + 1, cColumn) +
                                      TraverseGridSquares(grid, row, column, cRow, cColumn + 1);
            }

            return grid[row, column];
        }
    }
}
