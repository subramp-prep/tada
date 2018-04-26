using System;
using System.Collections.Generic;

namespace questions
{
    // Question URL: https://leetcode.com/problems/walls-and-gates/description/
    //    You are given a m x n 2D grid initialized with these three possible values.

    //-1 - A wall or an obstacle.
    //0 - A gate.
    //INF - Infinity means an empty room.We use the value 231 - 1 = 2147483647 
    //to represent INF as you may assume that the distance to a gate is less than 2147483647.
    //Fill each empty room with the distance to its nearest gate.
    //If it is impossible to reach a gate, it should be filled with INF.

    //For example, given the 2D grid:
    //INF  -1  0  INF
    //INF INF INF  -1
    //INF  -1 INF  -1
    //  0  -1 INF INF
    //After running your function, the 2D grid should be:
    // 3  -1   0   1
    // 2   2   1  -1
    // 1  -1   2  -1
    // 0  -1   3   4

    // Hint: BFS
    public class WallNGates
    {
        public static void WallsAndGates(int[,] rooms)
        {
            int row = rooms.GetLength(0);
            int column = rooms.GetLength(1);
            
            Queue<Tuple<int, int>> reachable = new Queue<Tuple<int, int>>();
            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < column; y++)
                {
                    if (rooms[x,y] == 0)
                    {
                        reachable.Enqueue(new Tuple<int, int>(x, y));
                    }
                }
            }

            List<Tuple<int, int>> dirs = new List<Tuple<int, int>>();
            dirs.Add(new Tuple<int, int>(1, 0));
            dirs.Add(new Tuple<int, int>(0, 1));
            dirs.Add(new Tuple<int, int>(-1, 0));
            dirs.Add(new Tuple<int, int>(0, -1));

            while (reachable.Count > 0)
            {
                var current = reachable.Dequeue();

                var currentX = current.Item1;
                var currentY = current.Item2;

                foreach (var dir in dirs)
                {
                    int x = currentX + dir.Item1;
                    int y = currentY + dir.Item2;
                    if (x < 0 || y < 0 || 
                        x >= row || y >= column ||
                        rooms[x,y] <= rooms[currentX, currentY] + 1)
                    {
                        continue;
                    }

                    rooms[x, y] = rooms[currentX, currentY] + 1;

                    reachable.Enqueue(new Tuple<int, int>(x, y));
                }
            }

            Console.WriteLine("Built new matrix");
        }
    }
}
