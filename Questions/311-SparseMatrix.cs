using System;
namespace questions
{
    // Question URL: https://leetcode.com/problems/sparse-matrix-multiplication/description/
    //Given two sparse matrices A and B, return the result of AB.
    //You may assume that A's column number is equal to B's row number.

    //Example:

        //A = [
        //  [1, 0, 0],
        //  [-1, 0, 3]
        //]
        
        //B = [
        //  [ 7, 0, 0 ],
        //  [ 0, 0, 0 ],
        //  [ 0, 0, 1 ]
        //]
        
        
        //     |  1 0 0 |   | 7 0 0 |   |  7 0 0 |
        //AB = | -1 0 3 | x | 0 0 0 | = | -7 0 3 |
                          //| 0 0 1 |

    // hint: BFS
    public class SparseMatrix
    {
        // TODO
        public int[,] Multiply(int[,] A, int[,] B)
        {
            return null;
        }
    }
}
