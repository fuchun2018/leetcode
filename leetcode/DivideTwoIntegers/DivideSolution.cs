using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.DivideTwoIntegers
{
    public class DivideSolution
    {
        public int Divide(int dividend, int divisor)
        {
            if (dividend == divisor) return 1;
            if (dividend == int.MinValue && divisor == -1) return int.MaxValue;
            uint result = 0;
            bool sign = (dividend > 0) ^ (divisor > 0);
            var absDividend = (uint)(dividend >= 0 ? dividend : -dividend);
            var absDivisor = (uint)(divisor >= 0 ? divisor : -divisor);
            while (absDividend >= absDivisor)
            {
                var baseDiv = absDivisor;
                for (int i = 0; (baseDiv << i) <= absDividend; i++)
                {
                    var tmp = baseDiv << i;
                    absDividend -= tmp;
                    result += (uint) 1 << i;
                }
            }

            return sign ? (int)-result : (int)result;
        }
    }
}
