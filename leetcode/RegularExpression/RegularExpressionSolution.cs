using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.RegularExpression
{
    public class RegularExpressionSolution
    {
        public bool IsMatch(string s, string p)
        {
            var dp = new bool[s.Length + 1, p.Length + 1];
            dp[0, 0] = true;
            for (int i = 0; i < p.Length; i++) dp[0, i + 1] = (p[i] == '*' && dp[0, i - 1]);

            for (int i = 1; i < dp.GetLength(0); i++)
            {
                for (int j = 1; j < dp.GetLongLength(1); j++)
                {
                    if (p[j - 1] == '*')
                    {
                        dp[i, j] = dp[i, j - 2];
                        if (s[i - 1] == p[j - 2] || p[j - 2] == '.')
                            dp[i, j] |= dp[i - 1, j] || dp[i, j - 1];
                    }
                    else if ((p[j - 1] == '.') || (p[j - 1] == s[i - 1])) dp[i, j] = dp[i - 1, j - 1];
                }
            }
            return dp[s.Length, p.Length];
        }
    }
}
