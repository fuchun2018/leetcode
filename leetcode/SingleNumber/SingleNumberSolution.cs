using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.SingleNumber
{
    public class SingleNumberSolution
    {
        public int SingleNumber(int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++) result ^= nums[i];
            return result;
        }
    }
}
