using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.HappyNumber
{
    public class HappyNumberSolution
    {
        public bool IsHappy(int n)
        {
            HashSet<int> hashset = new HashSet<int>();
            var value = n;
            do
            {
                value = cal(value);
                if (hashset.Contains(value)) return false;
                hashset.Add(value);
            } while (value != 1);
            return true;
        }

        private int cal(int n)
        {
            int calculateBase = (int)Math.Pow(10, n.ToString().Length - 1);
            var result = 0;
            while (calculateBase > 1)
            {
                var _ = n / calculateBase;
                result += (int)Math.Pow(_, 2);
                if(_>0)
                    n = n > 0 ? n % (_ * calculateBase) : 0;
                calculateBase /= 10;
            }
            result += (int)Math.Pow((n % 10), 2);
            return result;
        }
    }
}
