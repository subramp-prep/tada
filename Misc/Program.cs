using System;
using System.Collections.Generic;

namespace Misc
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Test_GridTraversal();
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
                
            Vector2D i = new Vector2D(vec2d);
            while (i.HasNext()) 
            {
                Console.WriteLine(i.Next());   
            }
        }
    }
}
