using System;
using System.Collections.Generic;

namespace questions
{
    // Question URL: https://leetcode.com/problems/number-of-islands/description/
    //Given a 2d grid map of '1's(land) and '0's(water), count the number of islands.
    //An island is surrounded by water and is formed by connecting adjacent lands horizontally 
    //or vertically.You may assume all four edges of the grid are all surrounded by water.

    //Example 1:
    //11110
    //11010
    //11000
    //00000
    //Answer: 1

    //Example 2:
    //11000
    //11000
    //00100
    //00011
    //Answer: 3

    // HINT: DFS, https://en.wikipedia.org/wiki/Flood_fill
    public class NumberOfIslands
    {
        public static int NumIslands(char[,] grid)
        {
            int count = 0;

            int rows = grid.GetLength(0);
            int columns = grid.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (grid[r, c] == '1')
                    {
                        DFSFloodFill(grid, rows -1 , columns - 1, r, c);
                        count++;
                    }
                }
            }

            return count;
        }

        private static void DFSFloodFill(char[,] grid, int row, int column, int tRow, int tColumn)
        {
            if (tRow < 0 || tColumn < 0 || tRow > row || tColumn > column || grid[tRow, tColumn] == '0')
                return;

            grid[tRow, tColumn] = '0';

            DFSFloodFill(grid, row, column, tRow + 1, tColumn);
            DFSFloodFill(grid, row, column, tRow, tColumn + 1);
            DFSFloodFill(grid, row, column, tRow - 1, tColumn);
            DFSFloodFill(grid, row, column, tRow, tColumn - 1);
        }

        public static int NumIslands_BFS(char[,] grid)
        {
            int count = 0;
            
            int rows = grid.GetLength(0);
            int columns = grid.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (grid[r, c] == '1')
                    {
                        BFSFloodFill(grid, rows, columns, r, c);
                        count++;
                    }
                }
            }

            return count;
        }

        private static void BFSFloodFill(char[,] grid, int row, int column, int tRow, int tColumn)
        {
            Queue<Tuple<int, int>> visited = new Queue<Tuple<int, int>>();
            visited.Enqueue(new Tuple<int, int>(tRow, tColumn));

            while (visited.Count > 0)
            {
                var recent = visited.Dequeue();

                if (recent.Item1 + 1 < row && grid[recent.Item1+1, recent.Item2] == '1') 
                {
                    grid[recent.Item1 + 1, recent.Item2] = '0';
                    visited.Enqueue(new Tuple<int, int>(recent.Item1 + 1, recent.Item2));
                }

                if (recent.Item2 + 1 < column && grid[recent.Item1, recent.Item2 + 1] == '1')
                {
                    grid[recent.Item1, recent.Item2 + 1] = '0';
                    visited.Enqueue(new Tuple<int, int>(recent.Item1, recent.Item2 + 1));
                }

                if (recent.Item1 - 1 >= 0  && grid[recent.Item1 -1 , recent.Item2] == '1')
                {
                    grid[recent.Item1 - 1, recent.Item2] = '0';
                    visited.Enqueue(new Tuple<int, int>(recent.Item1 - 1, recent.Item2));
                }

                if (recent.Item2 - 1 >= 0 && grid[recent.Item1, recent.Item2 - 1] == '1')
                {
                    grid[recent.Item1, recent.Item2-1] = '0';
                    visited.Enqueue(new Tuple<int, int>(recent.Item1, recent.Item2 -1));
                }
            }
        }
    }
}
