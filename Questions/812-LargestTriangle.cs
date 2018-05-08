using System;
namespace questions
{
    // https://leetcode.com/problems/largest-triangle-area/description/
    //You have a list of points in the plane.Return the area of the largest triangle 
    //that can be formed by any 3 of the points.

    //Example:
    //Input: points = [[0, 0], [0,1], [1,0], [0,2], [2,0]]
    //Output: 2
    //Explanation: 
    //The five points are show in the figure below.The red triangle is the largest.


    //Notes:
    //3 <= points.length <= 50.
    //No points will be duplicated.
    // -50 <= points[i][j] <= 50.
    //Answers within 10^-6 of the true value will be accepted as correct.

    public class LargestTriangle
    {
        // Shoelace algorithm
        // https://en.wikipedia.org/wiki/Shoelace_formula

        public static double LargestTriangleArea(int[][] points)
        {
            double largestArea = 0;
            int count = points.GetLength(0);

            for (int i = 0; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    for (int k = j + 1; k < count; k++)
                    {
                        largestArea = Math.Max(largestArea, 
                                   CalculateArea(points[i], points[j], points[k]));
                    }
                }
            }

            return largestArea;
        }

        private static double CalculateArea(int[]x, int[] y, int[]z)
        {
            var leftRight = x[0] * y[1] + y[0] * z[1] + z[0] * x[1];
            var RightLeft = x[1] * y[0] + y[1] * z[0] + z[1] * x[0];

            return 0.5 * Math.Abs(leftRight - RightLeft);
        }
    }
}
