using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.LongestIncreasingPath
{
    public class LongestIncreasingPathSolution
    {
        public int LongestIncreasingPath(int[][] matrix)
        {
            var result = 1;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    result = Math.Max(result, GetPathCount(i, j, matrix));
                }
            }
            return result;
        }
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        private int GetPathCount(int x, int y, int[][] matrix)
        {
            int max = 1;
            if (dictionary.ContainsKey(x * matrix.Length + y)) return dictionary[x + y];
            if ((y < matrix[1].Length - 1) && (matrix[x][y] < matrix[x][y + 1]))
                max = Math.Max(max, 1 + GetPathCount(x, y + 1, matrix));
            if ((y > 0) && (matrix[x][y] < matrix[x][y - 1]))
                max = Math.Max(max, 1 + GetPathCount(x, y - 1, matrix));
            if ((x < matrix.Length - 1) && (matrix[x][y] < matrix[x + 1][y]))
                max = Math.Max(max, 1 + GetPathCount(x + 1, y, matrix));
            if ((x > 0) && (matrix[x][y] < matrix[x - 1][y]))
                max = Math.Max(max, 1 + GetPathCount(x - 1, y, matrix));

            if (dictionary.ContainsKey(x * matrix.Length + y) != true) dictionary.Add(x * matrix.Length + y, max);
            return max;
        }
    }
}
