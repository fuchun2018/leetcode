using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.ZigzagConversion
{
    public class ZigzagConversionSolution
    {
        public string Convert(string s, int numRows)
        {
            if ((numRows == 1) || (s.Length < numRows)) return s;
            if (string.IsNullOrEmpty(s)) return string.Empty;
            var rows = new string[numRows];
            var pointer = 0;
            bool godown = true;
            foreach (var c in s)
            {
                rows[godown ? pointer++ : pointer--] += c;
                if (pointer == 0)
                    godown = true;
                else if (pointer == numRows - 1)
                    godown = false;
            }

            return string.Join("", rows);
        }
    }
}
