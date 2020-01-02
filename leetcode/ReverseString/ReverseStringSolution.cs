using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// https://leetcode.com/problems/reverse-string/
namespace leetcode.ReverseString
{
    public class ReverseStringSolution
    {
        public void ReverseString(char[] s)
        {
            if (s.Length < 2) return;
            int middle = s.Length / 2;
            for (var (i, j) = (0, s.Length - 1); i < j; ++i, --j) (s[i], s[j]) = (s[j], s[i]);
        }
    }
}
