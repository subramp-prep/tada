using System;
using System.Collections.Generic;

namespace questions
{
    // https://leetcode.com/problems/making-a-large-island/description/
    //In a 2D grid of 0s and 1s, we change at most one 0 to a 1.

    //After, what is the size of the largest island? 
    //(An island is a 4-directionally connected group of 1s).

    //Example 1:

    //Input: [[1, 0], [0, 1]]
    //Output: 3
    //Explanation: Change one 0 to 1 and connect two 1s, then we get an island with area = 3.
    //Example 2:

    //Input: [[1, 1], [1, 0]]
    //Output: 4
    //Explanation: Change the 0 to 1 and make the island bigger, only one island with area = 1.
    //Example 3:

    //Input: [[1, 1], [1, 1]]
    //Output: 4
    //Explanation: Can't change any 0 to 1, only one island with area = 1.

    //Notes:

    //1 <= grid.length = grid[0].length <= 50.
    //0 <= grid[i][j] <= 1.
    public class MakingIsland
    {
        // TODO more work involved in identifying the largest island
        public static int LargestIsland(int[][] grid)
        {
            int rows = grid.GetLength(0);
            int columns = grid[0].Length;
            int result = 0;
            List<int> sizes = new List<int>();

            // identify individual islands with differnt color code
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        var res = DFSFloodFill(grid, rows, grid[i].Length, i, j, sizes.Count + 2);
                        result = Math.Max(res, result);

                        sizes.Add(res);
                    }
                }
            }

            // idenitfy how to merge islands by flipping a 0
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        List<int> cn = new List<int>();
                        cn.Add(GetColor(grid, i, grid[i].Length, i + 1, j));
                        cn.Add(GetColor(grid, i, grid[i].Length, i, j + 1));
                        cn.Add(GetColor(grid, i, grid[i].Length, i - 1, j));
                        cn.Add(GetColor(grid, i, grid[i].Length, i, j - 1));

                        // TODO identify how to implement 
                        int newResult = 0;
                        for (int c = 0; c < cn.Count; c++)
                            newResult += cn[c] == 0 ? 0 : sizes[cn[c] - 2];

                        newResult = Math.Max(result, newResult + 1);
                    }
                }
            }

            return sizes.Count <= 0 ? 1 : result;
        }

        private static int DFSFloodFill(int[][] grid, int rows, int columns, int tRow, int tColumn, int colorIndex)
        {
            if (tRow < 0 || tColumn < 0 || tRow >= rows || tColumn >= columns || grid[tRow][tColumn] != 1)
            {
                return 0;
            }

            grid[tRow][tColumn] = colorIndex;

            return  1 + DFSFloodFill(grid, rows, columns, tRow + 1, tColumn, colorIndex) +
                        DFSFloodFill(grid, rows, columns, tRow, tColumn + 1, colorIndex) +
                        DFSFloodFill(grid, rows, columns, tRow - 1, tColumn, colorIndex) +
                        DFSFloodFill(grid, rows, columns, tRow, tColumn - 1, colorIndex);
        }

        private static int GetColor(int[][] grid, int rows, int columns, int tRow, int tColumn)
        {
            if (tRow < 0 || tColumn < 0 || tRow >= rows || tColumn >= columns)
                return 0;

            return grid[tRow][tColumn];
        }
    }
}
