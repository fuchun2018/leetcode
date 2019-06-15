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
            if (matrix.Length == 0) return matrix.Length;
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
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        private int GetPathCount(int x, int y, int[][] matrix)
        {
            int max = 1;
            if (dictionary.ContainsKey(string.Concat(x, "_", y)))
                return dictionary[string.Concat(x, "_", y)];
            if ((y < matrix[0].Length - 1) && (matrix[x][y] < matrix[x][y + 1]))
                max = Math.Max(max, 1 + GetPathCount(x, y + 1, matrix));
            if ((y > 0) && (matrix[x][y] < matrix[x][y - 1]))
                max = Math.Max(max, 1 + GetPathCount(x, y - 1, matrix));
            if ((x < matrix.Length - 1) && (matrix[x][y] < matrix[x + 1][y]))
                max = Math.Max(max, 1 + GetPathCount(x + 1, y, matrix));
            if ((x > 0) && (matrix[x][y] < matrix[x - 1][y]))
                max = Math.Max(max, 1 + GetPathCount(x - 1, y, matrix));

            if (dictionary.ContainsKey(string.Concat(x, "_", y)) != true) dictionary.Add(string.Concat(x, "_", y), max);
            return max;
        }
    }
}
