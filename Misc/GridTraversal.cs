using System;
namespace Misc
{
    public class GridTraversal
    {
        private bool[,] _grid;
        private int _row;
        private int _column;

        public GridTraversal()
        {
            _row = 8;
            _column = 8;

            _grid = new bool[,] {
                {true,  true,  true,  true,  true,  true,  true,  true},
                {true,  true,  false, true,  true,  true,  false, true},
                {true,  true,  true,  true,  false, true,  true,  true},
                {false, true,  false, true,  true,  false, true,  true},
                {true,  true,  false, true,  true,  true,  true,  true},
                {true,  true,  true,  false, false, true,  false, true},
                {true,  false, true,  true,  true,  false, true,  true},
                {true,  true,  true,  true,  true,  true,  true,  true},
            };
        }

        public bool validSquare(int row, int column)
        {
            if (row < _row && column < _column)
            {
                return _grid[row, column];
            }

            return false;
        }

        public bool isAtEnd(int row, int column)
        {
            if (row == 7 && column == 7)
                return true;

            return false;
        }

        // Recursive approach
        // Complexity O(2 (pow(n)pow(2)))
        public int CountPaths_Recursive(int row, int column)
        {
            if (!validSquare(row, column))
                return 0;

            if (!isAtEnd(row, column))
                return 1;

            return CountPaths_Recursive(row + 1, column) +
                CountPaths_Recursive(row, column + 1);
        }

        //private int[][] _paths;
        // Dynamic programming 
        // Complexity O(n pow(2))
        public int CountPaths_DP(int row, int column, int[,] paths)
        {
            if (!validSquare(row, column))
                return 0;

            if (isAtEnd(row, column))
                return 1;

            if (paths[row, column] == 0)
            {
                paths[row, column] = CountPaths_DP(row, column + 1, paths) +
                    CountPaths_DP(row + 1, column, paths);
            }

            return paths[row, column];
        }
    }
}
