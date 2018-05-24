using System;
namespace questions
{
    //https://leetcode.com/problems/unique-paths-ii/description/

    //A robot is located at the top-left corner of a m x n grid
    //(marked 'Start' in the diagram below).
    //The robot can only move either down or right at any point in time.
    //The robot is trying to reach the bottom-right corner of the grid
    //(marked 'Finish' in the diagram below).
    //Now consider if some obstacles are added to the grids.
    //How many unique paths would there be?
    //An obstacle and empty space is marked as 1 and 0 respectively in the grid.

    //Note: m and n will be at most 100.


    //Example 1:
    //Input:
    // [
    //   [0,0,0],
    //  [0,1,0],
    //  [0,0,0]
    // ]
    //Output: 2
    //Explanation:
    //There is one obstacle in the middle of the 3x3 grid above.
    //There are two ways to reach the bottom-right corner:
    //1. Right -> Right -> Down -> Down
    //2. Down -> Down -> Right -> Right

    public class UniquePathsII
    {
        public static int UniquePathsWithObstacles(int[,] obstacleGrid)
        {
            int rows = obstacleGrid.GetLength(0);
            int columns = obstacleGrid.GetLength(1);

            obstacleGrid[0, 0] ^= 1;

            for (int i = 1; i < rows; i++)
            {
                obstacleGrid[i, 0] = (obstacleGrid[i, 0] == 1) ? 0 : obstacleGrid[i - 1, 0];
            }

            for (int i = 1; i < columns; i++)
            {
                obstacleGrid[0, i] = (obstacleGrid[0, i] == 1) ? 0 : obstacleGrid[0, i-1];
            }

            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j < columns; j++)
                {
                    obstacleGrid[i, j] = (obstacleGrid[0, i] == 1) ? 0 : obstacleGrid[i - 1, j] + obstacleGrid[i, j - 1];
                }
            }

            return obstacleGrid[rows-1, columns-1];
        }
    }
}
