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
            int result = 0;
            bool sign = (dividend > 0) ^ (divisor > 0);
            var absDividend = (uint) Math.Abs(dividend);
            var absDivisor = (uint) Math.Abs(divisor);
            while(absDividend > absDivisor)
            {
                var baseDiv = absDivisor;
                for (int i = 0; (baseDiv<<i) < absDividend ; i++)
                {
                    var tmp = baseDiv << i;
                    absDividend -= tmp;
                    result += 1 << i;
                }
            }

            return sign ? -1 * result : result;
        }
    }
}
