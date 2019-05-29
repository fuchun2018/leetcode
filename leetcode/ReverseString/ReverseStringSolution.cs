using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.ReverseString
{
    public class ReverseStringSolution
    {
        public void ReverseString(char[] s)
        {
            if (s.Length < 2) return;
            int middle = s.Length / 2;
            for (int i = 0; i < middle; i++)
            {
                var temp = s[i];
                s[i] = s[s.Length - 1 - i];
                s[s.Length - 1 - i] = temp;
            }
        }
    }
}
