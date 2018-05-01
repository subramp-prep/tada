using System;
namespace questions
{
    // https://leetcode.com/problems/max-area-of-island/description/
    //Given a non-empty 2D array grid of 0's and 1's, an island is a group of 1's 
    //(representing land) connected 4-directionally (horizontal or vertical.) 
    //You may assume all four edges of the grid are surrounded by water.

    //Find the maximum area of an island in the given 2D array. (If there is no island, the maximum area is 0.)

    //Example 1:
    //[[0,0,1,0,0,0,0,1,0,0,0,0,0],
    // [0,0,0,0,0,0,0,1,1,1,0,0,0],
    // [0,1,1,0,1,0,0,0,0,0,0,0,0],
    // [0,1,0,0,1,1,0,0,1,0,1,0,0],
    // [0,1,0,0,1,1,0,0,1,1,1,0,0],
    // [0,0,0,0,0,0,0,0,0,0,1,0,0],
    // [0,0,0,0,0,0,0,1,1,1,0,0,0],
    // [0,0,0,0,0,0,0,1,1,0,0,0,0]]
    //Given the above grid, return 6. Note the answer is not 11, because the island must be connected 4-directionally.
    //Example 2:
    //[[0,0,0,0,0,0,0,0]]
    //Given the above grid, return 0.
    //Note: The length of each dimension in the given grid does not exceed 50.
    
    public class MaxAreaIsland
    {
        public static int MaxAreaOfIsland(int[,] grid)
        {
            int rows = grid.GetLength(0);
            int columns = grid.GetLength(1);
            int max = 0;
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (grid[r, c] == 1)
                    {
                        max = Math.Max(max, DFSFloodFill(grid, rows - 1, columns - 1, r, c));
                    }
                }
            }

            return max;
        }

        private static int DFSFloodFill(int[,] grid, int row, int column, int tRow, int tColumn)
        {
            if (tRow < 0 || tColumn < 0 || tRow > row || tColumn > column || grid[tRow, tColumn] == 0)
                return 0;

            grid[tRow, tColumn] = 0;

            return
            DFSFloodFill(grid, row, column, tRow + 1, tColumn) +
            DFSFloodFill(grid, row, column, tRow, tColumn + 1) +
            DFSFloodFill(grid, row, column, tRow - 1, tColumn) +
            DFSFloodFill(grid, row, column, tRow, tColumn - 1) + 1;
        }
    }
}
