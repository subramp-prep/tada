using System;
using System.Collections.Generic;

namespace questions
{
    //https://leetcode.com/problems/pascals-triangle/description/

    //Given a non-negative integer numRows, generate the first numRows of Pascal's triangle.
    //In Pascal's triangle, each number is the sum of the two numbers directly above it.
    //Example:

    //Input: 5
    //Output:
    //[
    //     [1],
    //    [1,1],
    //   [1,2,1],
    //  [1,3,3,1],
    // [1,4,6,4,1]
    //]
    public class PascalsTriangle
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> output = new List<IList<int>>();

            if (numRows > 0)
            {
                IList<int> first = new List<int>();
                first.Add(1);

                output.Add(first);
                for (int i = 1; i < numRows; i++)
                {
                    IList<int> row = new List<int>();

                    row.Add(1);

                    IList<int> prev = output[i - 1];
                    int j = 0;
                    int k = 1;
                    while (k < i)
                    {
                        row.Add(prev[j++] + prev[k++]);
                    }

                    row.Add(1);

                    output.Add(row);
                }
            }

            return output;
        }
    }
}
