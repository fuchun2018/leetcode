using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.ReverseInteger
{
    public class ReverseIntegerSolution
    {
        public int Reverse(int x)
        {
            if (x == 0) return x;
            var sign = x > 0;
            var result = 0;
            while (x != 0)
            {
                var remainder = x % 10;
                result = result * 10 + remainder;
                x /= 10;
            }
            return sign ? result : result * -1;
        }
    }
}
