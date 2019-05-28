using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.WildcardMatch
{
    public class WildcardMatchSolution
    {
        public bool IsMatch(string s, string p)
        {
            bool[,] result = new bool[s.Length+1, p.Length+1];

            result[0, 0] = true;

            for (int i = 1; i <= p.Length; i++)
            {
                result[0, i] = p[i-1] == '*' && result[0, i - 1];
            }
            for (int i = 1; i < result.GetLength(0); i++)
            {
                for (int j = 1; j < result.GetLength(1); j++)
                {
                    if (p[j - 1] == '*') result[i, j] = result[i - 1, j] || result[i, j - 1];
                    else if ((p[j - 1] == '?') || (p[j - 1] == s[i - 1])) result[i, j] = result[i - 1, j - 1];
                }
            }
            return result[s.Length, p.Length];
        }
    }
}
